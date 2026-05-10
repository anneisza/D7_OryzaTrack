using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OryzaTrackDAL
{
    public class PenyakitDAL
    {
        DatabaseConnection db = new DatabaseConnection();

        /*=============================
          View Penyakit | GetAll()
        ==============================*/
        public DataTable GetAll()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM penyakit";

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
        public DataRow GetById(int idPenyakit)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM penyakit WHERE idPenyakit = @idPenyakit";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPenyakit", idPenyakit);
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
                Search Penyakit 
        ==============================*/
        public DataTable Search(string keyword)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                // Mencari berdasarkan kategori, gejala
                string query = @"SELECT * FROM penyakit 
                                WHERE kategori LIKE @keyword 
                                OR gejalaPenyakit LIKE @keyword";

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
                Insert Penyakit 
        ==============================*/
        public bool Insert(string kategori, string gejalaPenyakit, string tingkatKerusakan, DateTime tanggalSerangan  )
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO penyakit 
                                (kategori, gejalaPenyakit, tingkatKerusakan, tanggalSerangan) 
                                VALUES 
                                (@kategori, @gejalaPenyakit, @tingkatKerusakan, @tanggalSerangan)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kategori", kategori);
                    cmd.Parameters.AddWithValue("@gejalaPenyakit", gejalaPenyakit);
                    cmd.Parameters.AddWithValue("@tingkatKerusakan", tingkatKerusakan);
                    cmd.Parameters.AddWithValue("@tanggalSerangan", tanggalSerangan );

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        /*=============================
               Update Penyakit 
        ==============================*/
        public bool Update(int idPenyakit, string kategori, string gejalaPenyakit, string tingkatKerusakan, DateTime tanggalSerangan)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE penyakit 
                                SET kategori = @kategori, 
                                    gejalaPenyakit = @gejalaPenyakit, 
                                    tingkatKerusakan = @tingkatKerusakan, 
                                    tanggalSerangan = @tanggalSerangan
                                WHERE idPenyakit = @idPenyakit";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPenyakit", idPenyakit);
                    cmd.Parameters.AddWithValue("@kategori", kategori);
                    cmd.Parameters.AddWithValue("@gejalaPenyakit", gejalaPenyakit);
                    cmd.Parameters.AddWithValue("@tingkatKerusakan", tingkatKerusakan);
                    cmd.Parameters.AddWithValue("@tanggalSerangan", tanggalSerangan);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        /*=============================
            Delete Penyakit 
        ==============================*/
        public bool Delete(int idPenyakit)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"DELETE FROM penyakit WHERE idPenyakit = @idPenyakit";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPenyakit", idPenyakit);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        /*=============================
                Count Penyakit 
        ==============================*/
        public int Count()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM penyakit";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
    }
}
