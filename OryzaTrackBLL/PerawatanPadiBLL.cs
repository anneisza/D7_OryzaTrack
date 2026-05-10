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
        PerawatanPadiDAL dal = new PerawatanPadiDAL();

        /*=============================
          View Perawatan | GetAll()
        ==============================*/
        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        /*=============================
                GetById 
        ==============================*/
        public DataRow GetById(int idPerawatan)
        {
            return dal.GetById(idPerawatan);
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

            return dal.Insert(idPadi, idPenyakit, jenisPerawatan, jenisPestisida, tanggalPerawatan, hasilPerawatan);
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

            return dal.Update(idPerawatan, idPadi, idPenyakit, jenisPerawatan, jenisPestisida, tanggalPerawatan, hasilPerawatan);
        }

        /*=============================
                Hapus 
        ==============================*/
        public bool Hapus(int idPerawatan)
        {
            return dal.Delete(idPerawatan);
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
