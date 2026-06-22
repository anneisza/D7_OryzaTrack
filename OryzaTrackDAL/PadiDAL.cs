using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OryzaTrackDAL
{
    public class PadiDAL
    {
        DatabaseConnection db = new DatabaseConnection();

        /*=======================
          View Padi | GetAll()
        ========================*/
        public DataTable GetAll()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                // Ganti JOIN query → pakai VIEW
                string query = "SELECT * FROM vw_Padi";
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
        public DataRow GetById(int idPadi)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM vw_Padi WHERE idPadi = @idPadi";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPadi", idPadi);
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
                Search Padi 
         ========================*/
        public DataTable Search(string keyword)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_SearchPadi", conn))
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
                Insert Padi
         ========================*/
        public string Insert(int idPetani, string jenisBibit, string lokasiLahan, DateTime tanggalTanam)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_InsertPadi", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPetani", idPetani);
                    cmd.Parameters.AddWithValue("@jenisBibit", jenisBibit);
                    cmd.Parameters.AddWithValue("@lokasiLahan", lokasiLahan);
                    cmd.Parameters.AddWithValue("@tanggalTanam", tanggalTanam.Date);

                    SqlParameter outputMsg = new SqlParameter("@pesanHasil", SqlDbType.VarChar, 200);
                    outputMsg.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputMsg);

                    cmd.ExecuteNonQuery();
                    return outputMsg.Value.ToString();
                }
            }
        }

        /*=======================
               Update Padi
        ========================*/
        public string Update(int idPadi, int idPetani,   string jenisBibit, string lokasiLahan, DateTime tanggalTanam)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_UpdatePadi", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPadi", idPadi);
                    cmd.Parameters.AddWithValue("@idPetani", idPetani);
                    cmd.Parameters.AddWithValue("@jenisBibit", jenisBibit);
                    cmd.Parameters.AddWithValue("@lokasiLahan", lokasiLahan);
                    cmd.Parameters.AddWithValue("@tanggalTanam", tanggalTanam.Date);

                    SqlParameter outputMsg = new SqlParameter("@pesanHasil", SqlDbType.VarChar, 200);
                    outputMsg.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputMsg);

                    cmd.ExecuteNonQuery();
                    return outputMsg.Value.ToString();
                }
            }
        }

        /*=======================
            Delete Padi
        ========================*/
        public string Delete(int idPadi)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_DeletePadi", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPadi", idPadi);

                    SqlParameter outputMsg = new SqlParameter("@pesanHasil", SqlDbType.VarChar, 200);
                    outputMsg.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputMsg);

                    cmd.ExecuteNonQuery();
                    return outputMsg.Value.ToString();
                }
            }
        }

        /*=======================
                Count Padi 
         ========================*/
        //ExcecuteScalar buat ngejalanin query yang hasilnya cuma satu nilai (misalnya COUNT, SUM, dll)
        public int Count()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("sp_CountPadi", conn))
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
    }
}
