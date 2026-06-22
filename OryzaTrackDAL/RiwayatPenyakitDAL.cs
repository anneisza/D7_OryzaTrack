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
                // sp
                string query = "SELECT * FROM vw_RiwayatPenyakit";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;

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
                string query = "SELECT * FROM vw_RiwayatPenyakit WHERE idRiwayat = @idRiwayat";
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
                //sp
                using (SqlCommand cmd = new SqlCommand("sp_SearchRiwayat", conn))
                {
                    //sp
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@keyword", keyword);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;

                }
            }
        }

        /*=============================
                Insert Riwayat 
        ==============================*/
        public string Insert(int idPadi, int idPenyakit, DateTime tanggalTerdeteksi, DateTime? tanggalSelesai, string keterangan)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                //sp
                using (SqlCommand cmd = new SqlCommand("sp_InsertRiwayat", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPadi", idPadi);
                    cmd.Parameters.AddWithValue("@idPenyakit", idPenyakit);
                    cmd.Parameters.AddWithValue("@tanggalTerdeteksi", tanggalTerdeteksi.Date);

                    // Handle nullable DateTime
                    if (tanggalSelesai.HasValue)
                        cmd.Parameters.AddWithValue("@tanggalSelesai", tanggalSelesai.Value.Date);
                    else
                        cmd.Parameters.AddWithValue("@tanggalSelesai", DBNull.Value);

                    cmd.Parameters.AddWithValue("@keterangan", keterangan);

                    SqlParameter outputMsg = new SqlParameter("@hasilMsg", SqlDbType.VarChar, 200);
                    outputMsg.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputMsg);

                    cmd.ExecuteNonQuery();
                    return outputMsg.Value.ToString();
                }
            }
        }

        /*=============================
               Update Riwayat 
        ==============================*/
        public string Update(int idRiwayat, int idPadi, int idPenyakit, DateTime tanggalTerdeteksi, DateTime? tanggalSelesai, string keterangan)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                //sp
                using (SqlCommand cmd = new SqlCommand("sp_UpdateRiwayat", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idRiwayat", idRiwayat);
                    cmd.Parameters.AddWithValue("@idPadi", idPadi);
                    cmd.Parameters.AddWithValue("@idPenyakit", idPenyakit);
                    cmd.Parameters.AddWithValue("@tanggalTerdeteksi", tanggalTerdeteksi.Date);
                    
                    // Handle null untuk tanggalSelesai
                    if (tanggalSelesai.HasValue)
                        cmd.Parameters.AddWithValue("@tanggalSelesai", tanggalSelesai.Value.Date);
                    else
                        cmd.Parameters.AddWithValue("@tanggalSelesai", DBNull.Value);

                    cmd.Parameters.AddWithValue("@keterangan", keterangan);

                    SqlParameter outputMsg = new SqlParameter("@hasilMsg", SqlDbType.VarChar, 200);
                    outputMsg.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputMsg);

                    cmd.ExecuteNonQuery();
                    return outputMsg.Value.ToString();
                }
            }
        }

        /*=============================
            Delete Riwayat 
        ==============================*/
        public string Delete(int idRiwayat)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                //sp
                using (SqlCommand cmd = new SqlCommand("sp_DeleteRiwayat", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idRiwayat", idRiwayat);

                    SqlParameter outputMsg = new SqlParameter("@hasilMsg", SqlDbType.VarChar, 200);
                    outputMsg.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputMsg);

                    cmd.ExecuteNonQuery();
                    return outputMsg.Value.ToString();
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
                using (SqlCommand cmd = new SqlCommand("sp_CountRiwayat", conn))
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

        //*=============================
        // GetStatistikPenyakit
        //==============================*/
        public DataTable GetStatistikPenyakit() {
            DataTable dt = new DataTable();
            // Query ini menggabungkan tabel riwayat dengan tabel penyakit 
            // untuk menghitung berapa kali tiap penyakit muncul
            string query = "string query = \"SELECT * FROM vw_StatistikPenyakit\";";

            using (SqlConnection conn = db.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}
