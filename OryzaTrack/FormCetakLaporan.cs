using OryzaTrackBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using OryzaTrackBLL;

namespace OryzaTrack
{
    public partial class FormCetakLaporan : Form
    {
        private LaporanBLL laporanBLL = new LaporanBLL();
        public FormCetakLaporan(DateTime tanggalAwal, DateTime tanggalAkhir,
                                 string jenisBibit, string kategori)
        {
            InitializeComponent();

            try
            {
                // Ambil data dari BLL
                DataTable dt = laporanBLL.GetLaporan(tanggalAwal, tanggalAkhir,
                                                      jenisBibit, kategori);

                // Konversi DataTable ke List<LaporanData>
                List<LaporanData> listData = new List<LaporanData>();

                foreach (DataRow row in dt.Rows)
                {
                    listData.Add(new LaporanData
                    {
                        NamaPetani = row["namaPetani"].ToString(),
                        JenisBibit = row["jenisBibit"].ToString(),
                        LokasiLahan = row["lokasiLahan"].ToString(),
                        KategoriPenyakit = row["kategoriPenyakit"].ToString(),
                        TingkatKerusakan = row["tingkatKerusakan"].ToString(),
                        TanggalTerdeteksi = Convert.ToDateTime(row["tanggalTerdeteksi"]),
                        TanggalSelesai = row["tanggalSelesai"].ToString(),
                        Keterangan = row["keterangan"].ToString(),
                        JenisPerawatan = row["jenisPerawatan"] == DBNull.Value
                                            ? "-" : row["jenisPerawatan"].ToString(),
                        JenisPestisida = row["jenisPestisida"] == DBNull.Value
                                            ? "-" : row["jenisPestisida"].ToString(),
                        HasilPerawatan = row["hasilPerawatan"] == DBNull.Value
                                            ? "-" : row["hasilPerawatan"].ToString()
                    });
                }

                // Set ke Crystal Report
                CrystalReport_LaporanCetak report = new CrystalReport_LaporanCetak();
                report.SetDataSource(listData);

                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load laporan: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
