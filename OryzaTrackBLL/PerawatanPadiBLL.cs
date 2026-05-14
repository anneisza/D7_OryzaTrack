using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OryzaTrackDAL;

namespace OryzaTrackBLL
{
    public class PerawatanPadiBLL
    {
        private PerawatanPadiDAL dal = new PerawatanPadiDAL();

        public DataTable GetListHasil() => dal.GetHasilPerawatanUnik();

        /*=============================
          View Perawatan | GetAll()
        ==============================*/
        public DataTable GetAll() => dal.GetAll();

        /*=============================
                GetById 
        ==============================*/
        public DataRow GetById(int idPerawatan) => dal.GetById(idPerawatan);

        /*=============================
                Cari 
        ==============================*/
        public DataTable Cari(string keyword) => dal.Search(keyword);

        /*=============================
                Tambah 
        ==============================*/
        public bool Tambah(int idPadi, int idPenyakit, string jenisPerawatan, string jenisPestisida, DateTime tanggalPerawatan, string hasilPerawatan)
        {
            // 1. Validasi Jenis Pestisida (Sesuai constraint CK_Perawatan_JenisPestisida)
            string[] pestisidaValid = { "Insektisida Furadan", "Fungisida Dithane", "Herbisida Glyphosate" };
            if (!pestisidaValid.Contains(jenisPestisida))
            {
                throw new Exception("Jenis pestisida tidak valid! Pilih: Insektisida Furadan, Fungisida Dithane, atau Herbisida Glyphosate.");
            }

            // 2. Validasi Hasil Perawatan (Sesuai constraint CK_Perawatan_HasilPerawatan)
            string[] hasilValid = { "Berhasil", "Sebagian Berhasil", "Gagal" };
            if (!hasilValid.Contains(hasilPerawatan))
            {
                throw new Exception("Hasil perawatan harus: Berhasil, Sebagian Berhasil, atau Gagal.");
            }

            // 3. Validasi Tanggal (Batas tahun 2000 sampai hari ini sesuai constraint baru)
            if (tanggalPerawatan.Year < 2000 || tanggalPerawatan > DateTime.Now)
            {
                throw new Exception("Tanggal perawatan tidak valid! Pastikan antara tahun 2000 hingga hari ini.");
            }

            // 4. Validasi Deskripsi Jenis Perawatan
            if (string.IsNullOrWhiteSpace(jenisPerawatan))
            {
                throw new Exception("Jenis perawatan wajib diisi!");
            }

            if (jenisPerawatan.Trim().Length < 5)
            {
                throw new Exception("Jenis perawatan terlalu singkat, minimal harus 5 karakter!");
            }

            // Logika konsistensi pestisida vs penyakit → ditangani SP
            string hasil = dal.Insert(idPadi, idPenyakit, jenisPerawatan,
                                      jenisPestisida, tanggalPerawatan, hasilPerawatan);
            if (hasil != "OK") throw new Exception(hasil);
            return true;
        }

        /*=============================
                Ubah 
        ==============================*/
        public bool Ubah(int idPerawatan, int idPadi, int idPenyakit, string jenisPerawatan, string jenisPestisida, DateTime tanggalPerawatan, string hasilPerawatan)
        {
            // Re-validasi logika bisnis agar tetap sinkron dengan database
            if (!new[] { "Insektisida Furadan", "Fungisida Dithane", "Herbisida Glyphosate" }.Contains(jenisPestisida))
                throw new Exception("Jenis pestisida tidak valid.");

            if (!new[] { "Berhasil", "Sebagian Berhasil", "Gagal" }.Contains(hasilPerawatan))
                throw new Exception("Hasil perawatan tidak valid.");

            if (tanggalPerawatan > DateTime.Now)
                throw new Exception("Tanggal perawatan tidak boleh di masa depan.");

            //sp
            string hasil = dal.Update(idPerawatan, idPadi, idPenyakit, jenisPerawatan,
                                      jenisPestisida, tanggalPerawatan, hasilPerawatan);
            if (hasil != "OK") throw new Exception(hasil);
            return true;
        }

        /*=============================
                Hapus 
        ==============================*/
        public bool Hapus(int idPerawatan)
        {
            string hasil = dal.Delete(idPerawatan);
            if (hasil != "OK") throw new Exception(hasil);
            return true;
        }

        /*=============================
                Total 
        ==============================*/
        public int Total() => dal.Count();
    }
}
