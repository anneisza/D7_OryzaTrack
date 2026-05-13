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
                //pakai view
                string query = "SELECT * FROM vw_Penyakit";


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

                //pakai sp
                using (SqlCommand cmd = new SqlCommand("sp_SearchPenyakit", conn))
                {
                    // sp_SearchPenyakit menerima parameter @keyword
                    cmd.CommandType = CommandType.StoredProcedure;
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
        public string Insert(string kategori, string gejalaPenyakit, string tingkatKerusakan, DateTime tanggalSerangan  )
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                //sp
                using (SqlCommand cmd = new SqlCommand("sp_InsertPenyakit", conn))
                {
                    //sp_InsertPenyakit menerima parameter @kategori, @gejalaPenyakit, @tingkatKerusakan, @tanggalSerangan
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@kategori", kategori);
                    cmd.Parameters.AddWithValue("@gejalaPenyakit", gejalaPenyakit);
                    cmd.Parameters.AddWithValue("@tingkatKerusakan", tingkatKerusakan);
                    cmd.Parameters.AddWithValue("@tanggalSerangan", tanggalSerangan );

                    SqlParameter outputMsg = new SqlParameter("@hasilMsg", SqlDbType.VarChar, 200);
                    outputMsg.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputMsg);

                    cmd.ExecuteNonQuery();
                    return outputMsg.Value.ToString();
                }
            }
        }

        /*=============================
               Update Penyakit 
        ==============================*/
        public string Update(int idPenyakit, string kategori, string gejalaPenyakit, string tingkatKerusakan, DateTime tanggalSerangan)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                //sp
                using (SqlCommand cmd = new SqlCommand("sp_UpdatePenyakit", conn))
                {
                    //sp
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPenyakit", idPenyakit);
                    cmd.Parameters.AddWithValue("@kategori", kategori);
                    cmd.Parameters.AddWithValue("@gejalaPenyakit", gejalaPenyakit);
                    cmd.Parameters.AddWithValue("@tingkatKerusakan", tingkatKerusakan);
                    cmd.Parameters.AddWithValue("@tanggalSerangan", tanggalSerangan);

                    SqlParameter outputMsg = new SqlParameter("@hasilMsg", SqlDbType.VarChar, 200);
                    outputMsg.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputMsg);

                    cmd.ExecuteNonQuery();
                    return outputMsg.Value.ToString();
                }
            }
        }

        /*=============================
            Delete Penyakit 
        ==============================*/
        public string Delete(int idPenyakit)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                //sp
                using (SqlCommand cmd = new SqlCommand("sp_DeletePenyakit", conn))
                {   //sp_DeletePenyakit menerima parameter @idPenyakit
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPenyakit", idPenyakit);

                    SqlParameter outputMsg = new SqlParameter("@hasilMsg", SqlDbType.VarChar, 200);
                    outputMsg.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputMsg);

                    cmd.ExecuteNonQuery();
                    return outputMsg.Value.ToString();
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
