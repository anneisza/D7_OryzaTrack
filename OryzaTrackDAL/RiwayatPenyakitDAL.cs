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
        public DataTable GetAll()
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = "SELECT * FROM riwayatPenyakit ORDER BY idPenyakit DESC";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Search(string keyword)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = @"SELECT * FROM riwayatPenyakit 
                             WHERE gejalaPenyakit LIKE @k OR tingkatKerusakan LIKE @k OR lokasiLahan LIKE @k
                             ORDER BY idPenyakit DESC";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@k", "%" + keyword + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Insert(int idAdmin, string gejalaPenyakit, string tingkatKerusakan,
                           string lokasiLahan, DateTime tanggalSerangan)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = @"INSERT INTO riwayatPenyakit (idAdmin, gejalaPenyakit, tingkatKerusakan, lokasiLahan, tanggalSerangan)
                             VALUES (@idAdmin, @gejala, @tingkat, @lokasi, @tanggal)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idAdmin", idAdmin);
                cmd.Parameters.AddWithValue("@gejala", gejalaPenyakit);
                cmd.Parameters.AddWithValue("@tingkat", tingkatKerusakan);
                cmd.Parameters.AddWithValue("@lokasi", lokasiLahan);
                cmd.Parameters.AddWithValue("@tanggal", tanggalSerangan);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(int idPenyakit, string gejalaPenyakit, string tingkatKerusakan,
                           string lokasiLahan, DateTime tanggalSerangan)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = @"UPDATE riwayatPenyakit SET gejalaPenyakit=@gejala, tingkatKerusakan=@tingkat,
                             lokasiLahan=@lokasi, tanggalSerangan=@tanggal
                             WHERE idPenyakit=@idPenyakit";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idPenyakit", idPenyakit);
                cmd.Parameters.AddWithValue("@gejala", gejalaPenyakit);
                cmd.Parameters.AddWithValue("@tingkat", tingkatKerusakan);
                cmd.Parameters.AddWithValue("@lokasi", lokasiLahan);
                cmd.Parameters.AddWithValue("@tanggal", tanggalSerangan);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int idPenyakit)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = "DELETE FROM riwayatPenyakit WHERE idPenyakit=@idPenyakit";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idPenyakit", idPenyakit);
                cmd.ExecuteNonQuery();
            }
        }

        public int CountData()
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = "SELECT COUNT(*) FROM riwayatPenyakit";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
