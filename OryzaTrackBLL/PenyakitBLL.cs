using OryzaTrackDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OryzaTrackBLL
{
     public class PenyakitBLL
     {

        private PenyakitDAL dal = new PenyakitDAL();

        public DataTable GetListKategori() => dal.GetKategoriUnik();
        public DataTable GetListKerusakan() => dal.GetTingkatKerusakanUnik();

        /*=============================
          View Penyakit | GetAll()
        ==============================*/
        public DataTable GetAll() => dal.GetAll();

        /*=============================
                GetById 
        ==============================*/
        public DataRow GetById(int idPenyakit) => dal.GetById(idPenyakit);

        /*=============================
                Cari 
        ==============================*/
        public DataTable Cari(string keyword) => dal.Search(keyword);

        /*=============================
                Tambah 
        ==============================*/
        public bool Tambah(string kategori, string gejalaPenyakit, string tingkatKerusakan, DateTime tanggalSerangan)
            {
                // 1. Validasi Kategori (Hama atau Penyakit)
                string[] kategoriValid = { "Hama", "Penyakit" };
                if (!kategoriValid.Contains(kategori))
                {
                    throw new Exception("Kategori tidak valid! Harus 'Hama' atau 'Penyakit'.");
                }

                // 2. Validasi Gejala (Minimal 10 karakter sesuai constraint DB)
                if (string.IsNullOrEmpty(gejalaPenyakit) || gejalaPenyakit.Length < 10)
                {
                    throw new Exception("Deskripsi gejala penyakit minimal harus 10 karakter!");
                }

                // 3. Validasi Tingkat Kerusakan
                string[] tingkatValid = { "Ringan", "Sedang", "Berat" };
                if (!tingkatValid.Contains(tingkatKerusakan))
                {
                    throw new Exception("Tingkat kerusakan harus pilih: Ringan, Sedang, atau Berat.");
                }

                // 4. Validasi Tanggal (Batas tahun 2000 sampai hari ini)
                if (tanggalSerangan.Year < 2000 || tanggalSerangan > DateTime.Now)
                {
                    throw new Exception("Tanggal serangan tidak valid! Pastikan antara tahun 2000 hingga hari ini.");
                }

                // Validasi logika berat → serahkan ke SP
                string hasil = dal.Insert(kategori, gejalaPenyakit, tingkatKerusakan, tanggalSerangan);

                if (hasil != "OK")
                    throw new Exception(hasil);

                return true;
        }

            /*=============================
                    Ubah 
            ==============================*/
            public string Ubah(int idPenyakit, string kategori, string gejalaPenyakit, string tingkatKerusakan, DateTime tanggalSerangan)
            {
                // Re-validasi logika bisnis agar data tetap konsisten saat update
                if (!new[] { "Hama", "Penyakit" }.Contains(kategori))
                    throw new Exception("Kategori tidak valid.");

                if (gejalaPenyakit.Length < 10)
                    throw new Exception("Gejala minimal 10 karakter.");

                if (!new[] { "Ringan", "Sedang", "Berat" }.Contains(tingkatKerusakan))
                    throw new Exception("Tingkat kerusakan tidak valid.");

                if (tanggalSerangan > DateTime.Now)
                    throw new Exception("Tanggal tidak boleh di masa depan.");
                string hasil = dal.Update(idPenyakit, kategori, gejalaPenyakit,
                                  tingkatKerusakan, tanggalSerangan);

                // Kalau error dari SP → lempar exception
                // Kalau PERINGATAN → kembalikan pesannya ke Form untuk ditampilkan
                if (!hasil.StartsWith("OK") && !hasil.StartsWith("PERINGATAN"))
                    throw new Exception(hasil);

                return hasil;
        }

            /*=============================
                    Hapus 
            ==============================*/
            public bool Hapus(int idPenyakit)
            {
                string hasil = dal.Delete(idPenyakit);
                if (hasil != "OK") throw new Exception(hasil);
                return true;
            }

        /*=============================
                Total 
        ==============================*/
        public int Total() => dal.Count();
    }
}
