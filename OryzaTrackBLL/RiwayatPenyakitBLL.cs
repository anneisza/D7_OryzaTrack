using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OryzaTrackDAL;

namespace OryzaTrackBLL
{
    public class RiwayatPenyakitBLL
    {
        RiwayatPenyakitDAL dal = new RiwayatPenyakitDAL();

        /*=============================
          View Riwayat | GetAll()
        ==============================*/
        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        /*=============================
                GetById 
        ==============================*/
        public DataRow GetById(int idRiwayat)
        {
            return dal.GetById(idRiwayat);
        }

        /*=============================
                Cari 
        ==============================*/
        public DataTable Cari(string keyword)
        {
            return dal.Search(keyword);
        }

        /*=============================
                Tambah 
        ==============================*/
        public bool Tambah(int idPadi, int idPenyakit, DateTime tanggalTerdeteksi, string keterangan)
        {
            // 1. Validasi Tanggal Terdeteksi (Tidak boleh masa depan & minimal tahun 2000)
            if (tanggalTerdeteksi > DateTime.Now || tanggalTerdeteksi.Year < 2000)
            {
                throw new Exception("Tanggal terdeteksi tidak valid! Pastikan antara tahun 2000 hingga hari ini.");
            }

            // 2. Validasi Keterangan (Jangan sampai kosong)
            if (string.IsNullOrEmpty(keterangan) || keterangan.Length < 5)
            {
                throw new Exception("Keterangan riwayat minimal harus 5 karakter!");
            }

            return dal.Insert(idPadi, idPenyakit, tanggalTerdeteksi, keterangan);
        }

        /*=============================
                Ubah 
        ==============================*/
        public bool Ubah(int idRiwayat, int idPadi, int idPenyakit, DateTime tanggalTerdeteksi, DateTime? tanggalSelesai, string keterangan)
        {
            // 1. Validasi Dasar
            if (tanggalTerdeteksi > DateTime.Now)
            {
                throw new Exception("Tanggal terdeteksi tidak boleh di masa depan.");
            }

            // 2. Validasi Urutan Tanggal (Sesuai CONSTRAINT CK_Riwayat_UrutanTanggal)
            if (tanggalSelesai.HasValue)
            {
                if (tanggalSelesai.Value < tanggalTerdeteksi)
                {
                    throw new Exception("Tanggal selesai tidak boleh lebih awal dari tanggal terdeteksi!");
                }

                if (tanggalSelesai.Value > DateTime.Now.AddYears(1))
                {
                    throw new Exception("Tanggal selesai tidak valid (terlalu jauh di masa depan).");
                }
            }

            if (string.IsNullOrEmpty(keterangan))
            {
                throw new Exception("Keterangan tidak boleh kosong.");
            }

            return dal.Update(idRiwayat, idPadi, idPenyakit, tanggalTerdeteksi, tanggalSelesai, keterangan);
        }

        /*=============================
                Hapus 
        ==============================*/
        public bool Hapus(int idRiwayat)
        {
            return dal.Delete(idRiwayat);
        }

        /*=============================
                Total 
        ==============================*/
        public int Total()
        {
            return dal.Count();
        }
    }
}
