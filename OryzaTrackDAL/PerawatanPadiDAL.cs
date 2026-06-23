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

                //sp
                string query = "SELECT * FROM vw_PerawatanPadi";
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
        public DataRow GetById(int idPerawatan)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM vw_PerawatanPadi WHERE idPerawatan = @idPerawatan";
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

        /*==========================================================
  Metode Tambahan untuk Binding ComboBox (Tanpa Duplikat)
============================================================*/

        public DataTable GetHasilPerawatanUnik()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT DISTINCT hasilPerawatan FROM vw_PerawatanPadi WHERE hasilPerawatan IS NOT NULL";
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
                Search Perawatan 
        ==============================*/
        public DataTable Search(string keyword)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                //sp
                using (SqlCommand cmd = new SqlCommand("sp_SearchPerawatan", conn))
                {//sp
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
                Insert Perawatan 
        ==============================*/
        public string Insert(int idRiwayat, string jenisPerawatan, string jenisPestisida, DateTime tanggalPerawatan, string hasilPerawatan)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                //sp
                using (SqlCommand cmd = new SqlCommand("sp_InsertPerawatan", conn))
                {
                    //sp
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idRiwayat", idRiwayat);
                    cmd.Parameters.AddWithValue("@jenisPerawatan", jenisPerawatan);
                    cmd.Parameters.AddWithValue("@jenisPestisida", jenisPestisida);
                    cmd.Parameters.AddWithValue("@tanggalPerawatan", tanggalPerawatan);
                    cmd.Parameters.AddWithValue("@hasilPerawatan", hasilPerawatan);

                    SqlParameter outputMsg = new SqlParameter("@hasilMsg", SqlDbType.VarChar, 200);
                    outputMsg.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputMsg);

                    cmd.ExecuteNonQuery();
                    return outputMsg.Value.ToString();
                }
            }
        }

        /*=============================
               Update Perawatan 
        ==============================*/
        public string Update(int idPerawatan, int idRiwayat, string jenisPerawatan, string jenisPestisida, DateTime tanggalPerawatan, string hasilPerawatan)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                //sp
                using (SqlCommand cmd = new SqlCommand("sp_UpdatePerawatan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPerawatan", idPerawatan);
                    cmd.Parameters.AddWithValue("@idRiwayat", idRiwayat);
                    cmd.Parameters.AddWithValue("@jenisPerawatan", jenisPerawatan);
                    cmd.Parameters.AddWithValue("@jenisPestisida", jenisPestisida);
                    cmd.Parameters.AddWithValue("@tanggalPerawatan", tanggalPerawatan);
                    cmd.Parameters.AddWithValue("@hasilPerawatan", hasilPerawatan);


                    SqlParameter outputMsg = new SqlParameter("@hasilMsg", SqlDbType.VarChar, 200);
                    outputMsg.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputMsg);

                    cmd.ExecuteNonQuery();
                    return outputMsg.Value.ToString();
                }
            }
        }

        /*=============================
            Delete Perawatan 
        ==============================*/
        public string Delete(int idPerawatan)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                //sp
                using (SqlCommand cmd = new SqlCommand("sp_DeletePerawatan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPerawatan", idPerawatan);

                    SqlParameter outputMsg = new SqlParameter("@hasilMsg", SqlDbType.VarChar, 200);
                    outputMsg.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputMsg);

                    cmd.ExecuteNonQuery();
                    return outputMsg.Value.ToString();
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
                using (SqlCommand cmd = new SqlCommand("sp_CountPerawatan", conn))
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

        //perbaikan
        public DataTable GetLookupRiwayatPenyakit()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                // Menggabungkan info kasus agar user mudah memilih di UI Form
                // ✅ Sesuai, tinggal ubah query-nya
                string query = @"SELECT idRiwayat, 
                 namaPetani + ' | ' + jenisBibit + ' | ' + kategoriPenyakit + 
                 ' (ID: ' + CAST(idRiwayat AS VARCHAR) + ')' AS TeksTampilan
                 FROM vw_RiwayatPenyakit";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
