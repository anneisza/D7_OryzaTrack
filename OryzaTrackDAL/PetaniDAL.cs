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
                string query = "SELECT idPetani, namaPetani FROM petani WHERE statusAktif = 1";
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
                string query = "SELECT * FROM petani WHERE idPetani = @idPetani";
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
        public string Insert(string namaPetani, string nik, string alamat, string noTelepon)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_InsertPetani", conn))
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

                    // Return pesan dari SP ("OK" atau pesan error)
                    return outputMsg.Value.ToString();
                }
            }
        }

        /*=======================
               Update Petani 
        ========================*/
        public string Update(int idPetani, string namaPetani, string nik, string alamat, string noTelepon, bool statusAktif)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_UpdatePetani", conn))
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
                    return outputMsg.Value.ToString();
                }
            }
        }

        /*=======================
            Delete Petani 
        ========================*/
        public string Delete(int idPetani)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_DeletePetani", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPetani", idPetani);

                    SqlParameter outputMsg = new SqlParameter("@pesanHasil", SqlDbType.VarChar, 200);
                    outputMsg.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputMsg);

                    cmd.ExecuteNonQuery();
                    return outputMsg.Value.ToString();
                }
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
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string resetQuery = @"
            DELETE FROM petani;
            DBCC CHECKIDENT ('petani', RESEED, 0);
            INSERT INTO petani (namaPetani, NIK, alamat, noTelepon, statusAktif)
            SELECT namaPetani, NIK, alamat, noTelepon, statusAktif
            FROM petani_backup;";

                using (SqlCommand cmd = new SqlCommand(resetQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
    }
}
