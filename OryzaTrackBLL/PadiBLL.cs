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

        /*=============================
          View Padi | GetAll()
        ==============================*/
        public DataTable GetAll()
        {
            return dal.GetAll();
        }


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
        public bool Tambah(int idPadi, int idPetani, string jenisBibit, string lokasiLahan, DateTime tanggalTanam)
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

            return dal.Insert(idPadi, idPetani, jenisBibit, lokasiLahan, tanggalTanam);
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


            return dal.Update(idPadi, idPetani, jenisBibit, lokasiLahan, tanggalTanam);
        }

        /*=============================
                Hapus 
        ==============================*/
        public bool Hapus(int idPadi)
        {
            return dal.Delete(idPadi);
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
