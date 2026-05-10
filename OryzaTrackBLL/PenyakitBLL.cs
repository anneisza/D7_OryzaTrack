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
            PenyakitDAL dal = new PenyakitDAL();

            /*=============================
              View Penyakit | GetAll()
            ==============================*/
            public DataTable GetAll()
            {
                return dal.GetAll();
            }

            /*=============================
                    GetById 
            ==============================*/
            public DataRow GetById(int idPenyakit)
            {
                return dal.GetById(idPenyakit);
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

                return dal.Insert(kategori, gejalaPenyakit, tingkatKerusakan, tanggalSerangan);
            }

            /*=============================
                    Ubah 
            ==============================*/
            public bool Ubah(int idPenyakit, string kategori, string gejalaPenyakit, string tingkatKerusakan, DateTime tanggalSerangan)
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

                return dal.Update(idPenyakit, kategori, gejalaPenyakit, tingkatKerusakan, tanggalSerangan);
            }

            /*=============================
                    Hapus 
            ==============================*/
            public bool Hapus(int idPenyakit)
            {
                return dal.Delete(idPenyakit);
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
