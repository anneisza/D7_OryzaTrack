using System;
using System.Data;
using OryzaTrackDAL;

namespace OryzaTrackBLL
{
    public class LaporanBLL
    {
        LaporanDAL dal = new LaporanDAL();

        public DataTable GetLaporan(DateTime tanggalAwal, DateTime tanggalAkhir,
                                     string jenisBibit, string kategori)
        {
            // Validasi tanggal
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