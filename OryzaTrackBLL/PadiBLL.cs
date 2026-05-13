using OryzaTrackDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OryzaTrackBLL
{
    public class PadiBLL
    {
        PadiDAL dal = new PadiDAL();


        public DataRow GetById(int idPadi) => dal.GetById(idPadi);
        public DataTable Cari(string keyword) => dal.Search(keyword);

        /*=============================
          View Padi | GetAll()
        ==============================*/
        public DataTable GetAll() => dal.GetAll();

        /*=============================
                GetById 
        ==============================*/
        public DataRow GetById(int idPadi)
        {
            return dal.GetById(idPadi);
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
        public bool Tambah(int idPetani, string jenisBibit, string lokasiLahan, DateTime tanggalTanam)
        {
            // 1. Validasi Jenis Bibit
            string[] bibitValid = { "IR64", "Ciherang", "Inpari 32", "Mekongga" };
            if (!bibitValid.Contains(jenisBibit))
            {
                throw new Exception("Jenis bibit harus dipilih dari daftar yang tersedia!");
            }

            // 2. Validasi Lokasi Lahan
            string[] lokasiValid = { "Lahan Utara", "Lahan Selatan", "Lahan Barat", "Lahan Timur" };
            if (!lokasiValid.Contains(lokasiLahan))
            {
                throw new Exception("Lokasi lahan harus dipilih: Lahan Utara, Selatan, Barat, atau Timur!");
            }

            // 3. Validasi Tanggal (Tidak boleh masa depan)
            if (tanggalTanam > DateTime.Now)
            {
                throw new Exception("Tanggal tanam tidak valid!");
            }

            // 4. Validasi lahan harus sesuai dengan yang ada
            if (string.IsNullOrEmpty(lokasiLahan) || lokasiLahan.Length < 5)
            {
                throw new Exception("Lokasi lahan tidak valid.");
            }

            // Validasi logika berat → serahkan ke SP
            string hasil = dal.Insert(idPetani, jenisBibit, lokasiLahan, tanggalTanam);
            if (hasil != "OK") throw new Exception(hasil);
            return true;
        }

        /*=============================
                Ubah 
        ==============================*/
        public bool Ubah(int idPadi, int idPetani, string jenisBibit, string lokasiLahan, DateTime tanggalTanam)
        {
            // 1. Validasi Jenis Bibit
            string[] bibitValid = { "IR64", "Ciherang", "Inpari 32", "Mekongga" };
            if (!bibitValid.Contains(jenisBibit))
            {
                throw new Exception("Jenis bibit harus dipilih dari daftar yang tersedia!");
            }

            // 2. Validasi Lokasi Lahan
            string[] lokasiValid = { "Lahan Utara", "Lahan Selatan", "Lahan Barat", "Lahan Timur" };
            if (!lokasiValid.Contains(lokasiLahan))
            {
                throw new Exception("Lokasi lahan harus dipilih: Lahan Utara, Selatan, Barat, atau Timur!");
            }

            // 3. Validasi Tanggal (Tidak boleh masa depan)
            if (tanggalTanam > DateTime.Now)
            {
                throw new Exception("Tanggal tanam tidak valid!");
            }

            // 4. Validasi lahan harus sesuai dengan yang ada
            if (string.IsNullOrEmpty(lokasiLahan) || lokasiLahan.Length < 5)
            {
                throw new Exception("Lokasi lahan tidak valid.");
            }

            string hasil = dal.Update(idPadi, idPetani, jenisBibit, lokasiLahan, tanggalTanam);
            if (hasil != "OK") throw new Exception(hasil);
            return true;
        }

        /*=============================
                Hapus 
        ==============================*/
        public bool Hapus(int idPadi)
        {
            string hasil = dal.Delete(idPadi);
            if (hasil != "OK") throw new Exception(hasil);
            return true;
        }

        /*=============================
                Total 
        ==============================*/

        public int Total() => dal.Count();
    }
}
