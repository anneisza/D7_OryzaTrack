using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OryzaTrackDAL
{
    public class RiwayatPenyakitDAL
    {
        DatabaseConnection db = new DatabaseConnection();

        /*=============================
          View Riwayat | GetAll()
        ==============================*/
        public DataTable GetAll()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                // Menggunakan JOIN agar tampilan di tabel lebih informatif
                string query = @"SELECT r.idRiwayat, p.jenisBibit, py.Kategori, 
                                r.tanggalTerdeteksi, r.tanggalSelesai, r.keterangan 
                                FROM riwayatPenyakit r
                                JOIN Padi p ON r.idPadi = p.idPadi
                                JOIN Penyakit py ON r.idPenyakit = py.idPenyakit";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        return dt;
                    }
                }
            }
        }

        /*=============================
                GetById 
        ==============================*/
        public DataRow GetById(int idRiwayat)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM riwayatPenyakit WHERE idRiwayat = @idRiwayat";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idRiwayat", idRiwayat);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);

                        if (dt.Rows.Count > 0)
                            return dt.Rows[0];
                        else
                            return null;
                    }
                }
            }
        }

        /*=============================
                Search Riwayat 
        ==============================*/
        public DataTable Search(string keyword)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"SELECT 
                                    r.idRiwayat, 
                                    p.jenisBibit, 
                                    py.Kategori, 
                                    r.tanggalTerdeteksi, 
                                    r.keterangan 
                                FROM riwayatPenyakit r
                                JOIN Padi p ON r.idPadi = p.idPadi
                                JOIN Penyakit py ON r.idPenyakit = py.idPenyakit
                                WHERE 
                                    p.jenisBibit LIKE @keyword 
                                    OR py.Kategori LIKE @keyword 
                                    OR r.keterangan LIKE @keyword
                                    OR CAST(r.idRiwayat AS VARCHAR) LIKE @keyword
                                    OR CAST(r.tanggalTerdeteksi AS VARCHAR) LIKE @keyword";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        return dt;
                    }
                }
            }
        }

        /*=============================
                Insert Riwayat 
        ==============================*/
        public bool Insert(int idPadi, int idPenyakit, DateTime tanggalTerdeteksi, DateTime? tanggalSelesai, string keterangan)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO riwayatPenyakit 
                                (idPadi, idPenyakit, tanggalTerdeteksi, tanggalSelesai, keterangan) 
                                VALUES 
                                (@idPadi, @idPenyakit, @tanggalTerdeteksi, @tanggalSelesai, @keterangan)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPadi", idPadi);
                    cmd.Parameters.AddWithValue("@idPenyakit", idPenyakit);
                    cmd.Parameters.AddWithValue("@tanggalTerdeteksi", tanggalTerdeteksi);
                    cmd.Parameters.AddWithValue("@tanggalSelesai", (object)tanggalSelesai ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@keterangan", keterangan);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        /*=============================
               Update Riwayat 
        ==============================*/
        public bool Update(int idRiwayat, int idPadi, int idPenyakit, DateTime tanggalTerdeteksi, DateTime? tanggalSelesai, string keterangan)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE riwayatPenyakit 
                                SET idPadi = @idPadi, 
                                    idPenyakit = @idPenyakit, 
                                    tanggalTerdeteksi = @tanggalTerdeteksi, 
                                    tanggalSelesai = @tanggalSelesai,
                                    keterangan = @keterangan
                                WHERE idRiwayat = @idRiwayat";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idRiwayat", idRiwayat);
                    cmd.Parameters.AddWithValue("@idPadi", idPadi);
                    cmd.Parameters.AddWithValue("@idPenyakit", idPenyakit);
                    cmd.Parameters.AddWithValue("@tanggalTerdeteksi", tanggalTerdeteksi);
                    // Handle null untuk tanggalSelesai
                    cmd.Parameters.AddWithValue("@tanggalSelesai", (object)tanggalSelesai ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@keterangan", keterangan);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        /*=============================
            Delete Riwayat 
        ==============================*/
        public bool Delete(int idRiwayat)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"DELETE FROM riwayatPenyakit WHERE idRiwayat = @idRiwayat";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idRiwayat", idRiwayat);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        /*=============================
                Count Riwayat 
        ==============================*/
        public int Count()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM riwayatPenyakit";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        //*=============================
        // GetStatistikPenyakit
        //==============================*/
        public DataTable GetStatistikPenyakit() {
            DataTable dt = new DataTable();
            // Query ini menggabungkan tabel riwayat dengan tabel penyakit 
            // untuk menghitung berapa kali tiap penyakit muncul
            string query = @"
        SELECT p.kategori, COUNT(r.idRiwayat) as Total 
        FROM riwayatPenyakit r
        JOIN penyakit p ON r.idPenyakit = p.idPenyakit
        GROUP BY p.kategori";

            using (SqlConnection conn = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
