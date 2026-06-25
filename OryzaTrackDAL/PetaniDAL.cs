using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace OryzaTrackDAL
{
    public class PetaniDAL
    {
        DatabaseConnection db = new DatabaseConnection();

        /*=======================
          View Petani | GetAll()
        ========================*/
        public DataTable GetAll()
        {
            using (SqlConnection conn = db.GetConnection())
            {

                // Ganti "SELECT * FROM petani" → pakai VIEW
                string query = "SELECT * FROM vw_Petani";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        //=======================
        //filter petani aktif
        //=======================
        public DataTable GetAktif()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT idPetani, namaPetani FROM vw_PetaniAktif";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                  
                }
            }
        }

        /*=======================
                GetById 
         ========================*/
        public DataRow GetById(int idPetani)
        { 
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM vw_Petani WHERE idPetani = @idPetani";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPetani", idPetani);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);

                        //cek ada data nggak, kalau ada return baris pertama (karena idPetani unik, pasti cuma ada 1 baris), kalau nggak ada return null
                        if (dt.Rows.Count > 0)
                            return dt.Rows[0];
                        else
                            return null;
                    }
                }
            }
        }

        /*=======================
                Search Petani 
         ========================*/
        public DataTable Search(string keyword)
        {
            using (SqlConnection conn = db.GetConnection())
            {

                using (SqlCommand cmd = new SqlCommand("sp_SearchPetani", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@keyword", keyword);
                        
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }


        /*=======================
                Insert Petani 
         ========================*/
        public string Insert(string namaPetani, string nik, string alamat, string noTelepon, bool statusAktif)
        {
                SqlConnection conn = db.GetConnection();
            
                conn.Open();
                // buat transaction
                SqlTransaction trans = conn.BeginTransaction();

                //buat try catch buat transaksi
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertPetani", conn, trans))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@namaPetani", namaPetani);
                        cmd.Parameters.AddWithValue("@NIK", nik);
                        cmd.Parameters.AddWithValue("@alamat", alamat);
                        cmd.Parameters.AddWithValue("@noTelepon", noTelepon);

                        // Parameter OUTPUT untuk ambil pesan dari SP
                        SqlParameter outputMsg = new SqlParameter("@pesanHasil", SqlDbType.VarChar, 200);
                        outputMsg.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputMsg);

                        cmd.ExecuteNonQuery();

                    SqlCommand cmdLog = new SqlCommand(
                        "INSERT INTO LogAktivitas (aktivitas, tabel, waktu) VALUES (@aktivitas, @tabel, GETDATE())",
                        conn, trans);
                    cmdLog.Parameters.AddWithValue("@aktivitas", "INSERT Petani : " + namaPetani);
                    cmdLog.Parameters.AddWithValue("@tabel", "petani"); 
                    cmdLog.ExecuteNonQuery();

                    //transaksi nihh
                    trans.Commit();
                        // Return pesan dari SP ("OK" atau pesan error)
                        return outputMsg.Value.ToString();
                    }
                }
                catch (SqlException ex)
                {
                    trans.Rollback();
                    SimpanLog("Tabel Petani", "ROLLBACK INSERT : " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    SimpanLog("General System", "GENERAL ERROR : " + ex.Message);
                    throw;
                }
                finally
                {
                    conn.Close(); 
                }

        }

        /*=======================
               Update Petani 
        ========================*/
        public string Update(int idPetani, string namaPetani, string nik, string alamat, string noTelepon, bool statusAktif)
        {
            SqlConnection conn = db.GetConnection();
       
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdatePetani", conn, trans))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPetani", idPetani);
                    cmd.Parameters.AddWithValue("@namaPetani", namaPetani);
                    cmd.Parameters.AddWithValue("@NIK", nik);
                    cmd.Parameters.AddWithValue("@alamat", alamat);
                    cmd.Parameters.AddWithValue("@noTelepon", noTelepon);
                    cmd.Parameters.AddWithValue("@statusAktif", statusAktif);

                    SqlParameter outputMsg = new SqlParameter("@pesanHasil", SqlDbType.VarChar, 200);
                    outputMsg.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputMsg);

                    cmd.ExecuteNonQuery();

                    SqlCommand cmdLog = new SqlCommand(
                        "INSERT INTO LogAktivitas (aktivitas, tabel, waktu) VALUES (@aktivitas, @tabel, GETDATE())",
                        conn, trans);
                    cmdLog.Parameters.AddWithValue("@aktivitas", "UPDATE Petani : " + namaPetani);
                    cmdLog.Parameters.AddWithValue("@tabel", "petani");
                    cmdLog.ExecuteNonQuery();

                    trans.Commit();

                    return outputMsg.Value.ToString();
                }
            }
            catch (SqlException ex)
            {
                trans.Rollback();
                SimpanLog("Tabel Petani", "ROLLBACK UPDATE : " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                SimpanLog("General System", "GENERAL ERROR : " + ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        /*=======================
            Delete Petani 
        ========================*/
        public string Delete(int idPetani)
        {
            SqlConnection conn = db.GetConnection();
            
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_DeletePetani", conn, trans))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPetani", idPetani);

                    SqlParameter outputMsg = new SqlParameter("@pesanHasil", SqlDbType.VarChar, 200);
                    outputMsg.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputMsg);

                    cmd.ExecuteNonQuery();

                    SqlCommand cmdLog = new SqlCommand(
                        "INSERT INTO LogAktivitas (aktivitas, tabel, waktu) VALUES (@aktivitas, @tabel, GETDATE())",
                        conn, trans);
                    cmdLog.Parameters.AddWithValue("@aktivitas", "DELETE Petani ID : " + idPetani);
                    cmdLog.Parameters.AddWithValue("@tabel", "petani");
                    cmdLog.ExecuteNonQuery();

                    trans.Commit();

                    return outputMsg.Value.ToString();
                }
            }
            catch (SqlException ex)
            {
                trans.Rollback();
                SimpanLog("Tabel Petani", "ROLLBACK DELETE : " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                SimpanLog("General System", "GENERAL ERROR : " + ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }

        }

        /*=======================
                Count Petani 
         ========================*/
        //ExcecuteScalar buat ngejalanin query yang hasilnya cuma satu nilai (misalnya COUNT, SUM, dll)
        public int Count()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_CountPetani", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter outputTotal = new SqlParameter("@totalData", SqlDbType.Int);
                    outputTotal.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputTotal);

                    cmd.ExecuteNonQuery();
                    return (int)outputTotal.Value;
                }
            }
        }


        //
        public bool IsNoTeleponExist(string noTelepon, int idPetani = 0)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                // Jika idPetani > 0, berarti ini untuk pengecekan saat UPDATE (mengabaikan dirinya sendiri)
                string query = "SELECT COUNT(*) FROM petani WHERE noTelepon = @noTelepon AND idPetani != @idPetani";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@noTelepon", noTelepon);
                    cmd.Parameters.AddWithValue("@idPetani", idPetani);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        //injection
        public DataTable SearchRentan(string keyword)
        {
            // Method SENGAJA tidak aman untuk demo SQL Injection
            string queryRentan =
                "SELECT idPetani, namaPetani, NIK, alamat, noTelepon " +
                "FROM petani " +
                "WHERE namaPetani = '" + keyword + "'";

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(queryRentan, conn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public bool ResetData()
        {
            SqlConnection conn = db.GetConnection();

            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                string resetQuery = @"
            -- Matikan FK constraint dulu
            ALTER TABLE perawatanPadi NOCHECK CONSTRAINT ALL;
            ALTER TABLE riwayatPenyakit NOCHECK CONSTRAINT ALL;
            ALTER TABLE Padi NOCHECK CONSTRAINT ALL;
            ALTER TABLE petani NOCHECK CONSTRAINT ALL;

            DELETE FROM perawatanPadi;
            DELETE FROM riwayatPenyakit;
            DELETE FROM Padi;
            DELETE FROM petani;

            SET IDENTITY_INSERT petani ON;
            INSERT INTO petani (idPetani, namaPetani, NIK, alamat, noTelepon, statusAktif)
            SELECT idPetani, namaPetani, NIK, alamat, noTelepon, statusAktif
            FROM petani_backup;
            SET IDENTITY_INSERT petani OFF;

            SET IDENTITY_INSERT Padi ON;
            INSERT INTO Padi (idPadi, idPetani, jenisBibit, lokasiLahan, tanggalTanam)
            SELECT idPadi, idPetani, jenisBibit, lokasiLahan, tanggalTanam
            FROM padi_backup;
            SET IDENTITY_INSERT Padi OFF;

            SET IDENTITY_INSERT riwayatPenyakit ON;
            INSERT INTO riwayatPenyakit (idRiwayat, idPadi, idPenyakit, tanggalTerdeteksi, tanggalSelesai, keterangan)
            SELECT idRiwayat, idPadi, idPenyakit, tanggalTerdeteksi, tanggalSelesai, keterangan
            FROM riwayat_backup;
            SET IDENTITY_INSERT riwayatPenyakit OFF;

            SET IDENTITY_INSERT perawatanPadi ON;
            INSERT INTO perawatanPadi (idPerawatan, idRiwayat, jenisPerawatan, jenisPestisida, tanggalPerawatan, hasilPerawatan)
            SELECT idPerawatan, idRiwayat, jenisPerawatan, jenisPestisida, tanggalPerawatan, hasilPerawatan
            FROM perawatan_backup;
            SET IDENTITY_INSERT perawatanPadi OFF;

            -- Aktifkan kembali FK constraint TANPA validasi data lama
            ALTER TABLE Padi NOCHECK CONSTRAINT ALL;
            ALTER TABLE riwayatPenyakit NOCHECK CONSTRAINT ALL;
            ALTER TABLE perawatanPadi NOCHECK CONSTRAINT ALL;
            ALTER TABLE petani NOCHECK CONSTRAINT ALL;";

                using (SqlCommand cmd = new SqlCommand(resetQuery, conn, trans))
                {
                    cmd.ExecuteNonQuery();
                }

                SqlCommand cmdLog = new SqlCommand(
                    "INSERT INTO LogAktivitas (aktivitas, tabel, waktu) VALUES (@aktivitas, @tabel, GETDATE())",
                    conn, trans);
                cmdLog.Parameters.AddWithValue("@aktivitas", "RESET semua data ke kondisi awal");
                cmdLog.Parameters.AddWithValue("@tabel", "semua tabel");
                cmdLog.ExecuteNonQuery();

                trans.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                trans.Rollback();
                SimpanLog("Tabel Petani", "ROLLBACK RESET : " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                SimpanLog("General System", "GENERAL ERROR : " + ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        

        ///  buat injeksi
 
        /// <param name="input"></param>
        public void DeleteRentan(string input)
        {
            // SENGAJA tidak aman untuk demo
            string query = "DELETE FROM petani WHERE namaPetani = '" + input + "'";

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Membuat Method Logging 
        public void SimpanLog(string tabel, string pesan)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"INSERT INTO LogError VALUES(@tabel, @pesan, GETDATE())";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                { 
                    cmd.Parameters.AddWithValue("@tabel", tabel);
                    cmd.Parameters.AddWithValue("@pesan", pesan);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Massive Update | Sengaja rentan
        public void MassUpdateRentan()
        {
            string query = "UPDATE petani SET namaPetani = namaPetani WHERE 1=1";

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
