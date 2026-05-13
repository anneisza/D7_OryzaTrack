using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OryzaTrackDAL
{

    public class LaporanDAL
    {
        DatabaseConnection db = new DatabaseConnection();

        // =====================
        // GetLaporan → pakai sp_GetLaporan
        // =====================
        public DataTable GetLaporan(DateTime tanggalAwal, DateTime tanggalAkhir,
                                     string jenisBibit, string kategori)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetLaporan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tanggalAwal", tanggalAwal.Date);
                    cmd.Parameters.AddWithValue("@tanggalAkhir", tanggalAkhir.Date);

                    // Kirim NULL ke SP jika "Semua"
                    cmd.Parameters.AddWithValue("@jenisBibit",
                        string.IsNullOrEmpty(jenisBibit) ? (object)DBNull.Value : jenisBibit);
                    cmd.Parameters.AddWithValue("@kategori",
                        string.IsNullOrEmpty(kategori) ? (object)DBNull.Value : kategori);

                    // Pakai DataAdapter + Fill() karena ini SELECT
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
