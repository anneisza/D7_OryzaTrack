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
        public DataTable GetAll()
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            // JOIN untuk laporan keseluruhan (sesuai requirement)
            string query = @"SELECT 
                                pp.idPerawatan,
                                a.namaAdmin,
                                rp.gejalaPenyakit,
                                h.namaHama,
                                pp.jenisPerawatan,
                                pp.jenisPestisida,
                                pp.tanggalPerawatan,
                                pp.hasilPerawatan
                             FROM perawatanPadi pp
                             JOIN admin a ON pp.idAdmin = a.idAdmin
                             JOIN riwayatPenyakit rp ON pp.idPenyakit = rp.idPenyakit
                             JOIN hama h ON pp.idHama = h.idHama
                             ORDER BY pp.idPerawatan DESC";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetAllRaw()
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = "SELECT * FROM perawatanPadi ORDER BY idPerawatan DESC";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Search(string keyword)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = @"SELECT 
                                pp.idPerawatan,
                                a.namaAdmin,
                                rp.gejalaPenyakit,
                                h.namaHama,
                                pp.jenisPerawatan,
                                pp.jenisPestisida,
                                pp.tanggalPerawatan,
                                pp.hasilPerawatan
                             FROM perawatanPadi pp
                             JOIN admin a ON pp.idAdmin = a.idAdmin
                             JOIN riwayatPenyakit rp ON pp.idPenyakit = rp.idPenyakit
                             JOIN hama h ON pp.idHama = h.idHama
                             WHERE pp.jenisPerawatan LIKE @k OR pp.jenisPestisida LIKE @k
                                   OR pp.hasilPerawatan LIKE @k OR h.namaHama LIKE @k
                             ORDER BY pp.idPerawatan DESC";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@k", "%" + keyword + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Insert(int idAdmin, int idPenyakit, int idHama, string jenisPerawatan,
                           string jenisPestisida, DateTime tanggalPerawatan, string hasilPerawatan)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = @"INSERT INTO perawatanPadi 
                             (idAdmin, idPenyakit, idHama, jenisPerawatan, jenisPestisida, tanggalPerawatan, hasilPerawatan)
                             VALUES (@idAdmin, @idPenyakit, @idHama, @jenisPerawatan, @jenisPestisida, @tanggal, @hasil)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idAdmin", idAdmin);
                cmd.Parameters.AddWithValue("@idPenyakit", idPenyakit);
                cmd.Parameters.AddWithValue("@idHama", idHama);
                cmd.Parameters.AddWithValue("@jenisPerawatan", jenisPerawatan);
                cmd.Parameters.AddWithValue("@jenisPestisida", jenisPestisida);
                cmd.Parameters.AddWithValue("@tanggal", tanggalPerawatan);
                cmd.Parameters.AddWithValue("@hasil", hasilPerawatan);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(int idPerawatan, int idPenyakit, int idHama, string jenisPerawatan,
                           string jenisPestisida, DateTime tanggalPerawatan, string hasilPerawatan)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = @"UPDATE perawatanPadi SET 
                             idPenyakit=@idPenyakit, idHama=@idHama,
                             jenisPerawatan=@jenisPerawatan, jenisPestisida=@jenisPestisida,
                             tanggalPerawatan=@tanggal, hasilPerawatan=@hasil
                             WHERE idPerawatan=@idPerawatan";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idPerawatan", idPerawatan);
                cmd.Parameters.AddWithValue("@idPenyakit", idPenyakit);
                cmd.Parameters.AddWithValue("@idHama", idHama);
                cmd.Parameters.AddWithValue("@jenisPerawatan", jenisPerawatan);
                cmd.Parameters.AddWithValue("@jenisPestisida", jenisPestisida);
                cmd.Parameters.AddWithValue("@tanggal", tanggalPerawatan);
                cmd.Parameters.AddWithValue("@hasil", hasilPerawatan);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int idPerawatan)
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = "DELETE FROM perawatanPadi WHERE idPerawatan=@idPerawatan";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idPerawatan", idPerawatan);
                cmd.ExecuteNonQuery();
            }
        }

        public int CountData()
        {
            SqlConnection conn = DatabaseConnection.GetConnection();
            string query = "SELECT COUNT(*) FROM perawatanPadi";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
