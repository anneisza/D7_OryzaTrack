using OryzaTrackDAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace OryzaTrackBLL
{
    public class LaporanBLL
    {
        LaporanDAL dal = new LaporanDAL();

        public DataTable GetLaporan(DateTime tanggalAwal, DateTime tanggalAkhir,
                                     string jenisBibit, string kategori)
        {
            // Validasi tanggal
            if (tanggalAwal.Year < 2000)
            {
                MessageBox.Show("Tanggal Terdeteksi tidak boleh di masa depan atau kurang dari tahun 2000.",
                    "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            if (tanggalAwal > tanggalAkhir)
                throw new Exception("Tanggal awal tidak boleh lebih dari tanggal akhir!");

            if (tanggalAkhir > DateTime.Now)
                throw new Exception("Tanggal akhir tidak boleh melebihi hari ini!");

            // Konversi "Semua" → null supaya SP tidak filter
            string bibit = jenisBibit == "Semua" ? null : jenisBibit;
            string kateg = kategori == "Semua" ? null : kategori;

            return dal.GetLaporan(tanggalAwal, tanggalAkhir, bibit, kateg);
        }
    }
}