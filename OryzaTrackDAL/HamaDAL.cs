using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OryzaTrackDAL
{
    public class HamaDAL
    {
        public DataTable GetAll()
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = "SELECT * FROM hama ORDER BY idHama DESC";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Search(string keyword)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = @"SELECT * FROM hama 
                             WHERE namaHama LIKE @k OR jenisHama LIKE @k OR lokasiLahan LIKE @k
                             ORDER BY idHama DESC";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@k", "%" + keyword + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Insert(int idAdmin, string namaHama, string jenisHama,
                           string gejalaHama, string lokasiLahan, DateTime tanggalSerangan)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = @"INSERT INTO hama (idAdmin, namaHama, jenisHama, gejalaHama, lokasiLahan, tanggalSerangan)
                             VALUES (@idAdmin, @namaHama, @jenisHama, @gejalaHama, @lokasiLahan, @tanggal)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idAdmin", idAdmin);
                cmd.Parameters.AddWithValue("@namaHama", namaHama);
                cmd.Parameters.AddWithValue("@jenisHama", jenisHama);
                cmd.Parameters.AddWithValue("@gejalaHama", gejalaHama);
                cmd.Parameters.AddWithValue("@lokasiLahan", lokasiLahan);
                cmd.Parameters.AddWithValue("@tanggal", tanggalSerangan);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(int idHama, string namaHama, string jenisHama,
                           string gejalaHama, string lokasiLahan, DateTime tanggalSerangan)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = @"UPDATE hama SET namaHama=@namaHama, jenisHama=@jenisHama,
                             gejalaHama=@gejalaHama, lokasiLahan=@lokasiLahan,
                             tanggalSerangan=@tanggal WHERE idHama=@idHama";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idHama", idHama);
                cmd.Parameters.AddWithValue("@namaHama", namaHama);
                cmd.Parameters.AddWithValue("@jenisHama", jenisHama);
                cmd.Parameters.AddWithValue("@gejalaHama", gejalaHama);
                cmd.Parameters.AddWithValue("@lokasiLahan", lokasiLahan);
                cmd.Parameters.AddWithValue("@tanggal", tanggalSerangan);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int idHama)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = "DELETE FROM hama WHERE idHama=@idHama";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idHama", idHama);
                cmd.ExecuteNonQuery();
            }
        }

        // ExecuteScalar untuk hitung jumlah data (sesuai requirement)
        public int CountData()
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = "SELECT COUNT(*) FROM hama";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
