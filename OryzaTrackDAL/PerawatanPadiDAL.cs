using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OryzaTrackDAL
{
    public class PerawatanPadiDAL
    {
        DatabaseConnection db = new DatabaseConnection();

        /*=============================
          View Perawatan | GetAll()
        ==============================*/
        public DataTable GetAll()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM perawatanPadi";

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
        public DataRow GetById(int idPerawatan)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM perawatanPadi WHERE idPerawatan = @idPerawatan";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPerawatan", idPerawatan);
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
                Search Perawatan 
        ==============================*/
        public DataTable Search(string keyword)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"SELECT * FROM perawatanPadi 
                                WHERE jenisPerawatan LIKE @keyword 
                                OR jenisPestisida LIKE @keyword 
                                OR hasilPerawatan LIKE @keyword";

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
                Insert Perawatan 
        ==============================*/
        public bool Insert(int idPadi, int idPenyakit, string jenisPerawatan, string jenisPestisida, DateTime tanggalPerawatan, string hasilPerawatan)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO perawatanPadi 
                                (idPadi, idPenyakit, jenisPerawatan, jenisPestisida, tanggalPerawatan, hasilPerawatan) 
                                VALUES 
                                (@idPadi, @idPenyakit, @jenisPerawatan, @jenisPestisida, @tanggalPerawatan, @hasilPerawatan)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPadi", idPadi);
                    cmd.Parameters.AddWithValue("@idPenyakit", idPenyakit);
                    cmd.Parameters.AddWithValue("@jenisPerawatan", jenisPerawatan);
                    cmd.Parameters.AddWithValue("@jenisPestisida", jenisPestisida);
                    cmd.Parameters.AddWithValue("@tanggalPerawatan", tanggalPerawatan);
                    cmd.Parameters.AddWithValue("@hasilPerawatan", hasilPerawatan);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        /*=============================
               Update Perawatan 
        ==============================*/
        public bool Update(int idPerawatan, int idPadi, int idPenyakit, string jenisPerawatan, string jenisPestisida, DateTime tanggalPerawatan, string hasilPerawatan)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE perawatanPadi 
                                SET idPadi = @idPadi, 
                                    idPenyakit = @idPenyakit, 
                                    jenisPerawatan = @jenisPerawatan, 
                                    jenisPestisida = @jenisPestisida,
                                    tanggalPerawatan = @tanggalPerawatan,
                                    hasilPerawatan = @hasilPerawatan
                                WHERE idPerawatan = @idPerawatan";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPerawatan", idPerawatan);
                    cmd.Parameters.AddWithValue("@idPadi", idPadi);
                    cmd.Parameters.AddWithValue("@idPenyakit", idPenyakit);
                    cmd.Parameters.AddWithValue("@jenisPerawatan", jenisPerawatan);
                    cmd.Parameters.AddWithValue("@jenisPestisida", jenisPestisida);
                    cmd.Parameters.AddWithValue("@tanggalPerawatan", tanggalPerawatan);
                    cmd.Parameters.AddWithValue("@hasilPerawatan", hasilPerawatan);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        /*=============================
            Delete Perawatan 
        ==============================*/
        public bool Delete(int idPerawatan)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"DELETE FROM perawatanPadi WHERE idPerawatan = @idPerawatan";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPerawatan", idPerawatan);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        /*=============================
                Count Perawatan 
        ==============================*/
        public int Count()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM perawatanPadi";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
    }
}
