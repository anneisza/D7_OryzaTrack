using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OryzaTrackDAL;

namespace OryzaTrackBLL
{
    public class PetaniBLL
    {
        PetaniDAL dal = new PetaniDAL();

        /*=======================
          View Petani | GetAll()
        ========================*/
        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        //=======================
        //filter petani aktif
        //=======================   
        public DataTable GetAktif()
        {
            return dal.GetAktif();
        }

        /*=======================
                GetById 
        ========================*/
        public DataRow GetById(int idPetani)
        {
            return dal.GetById(idPetani);
        }

        /*=======================
                Cari 
        ========================*/

        public DataTable Cari(string keyword)
        {
            return dal.Search(keyword);
        }

        /*=======================
                Tambah 
        ========================*/
        public bool Tambah(string namaPetani, string nik, string alamat, string noTelepon, bool statusAktif)
        {
            // 1. Validasi Input Dasar
            if (namaPetani.Length < 2) 
                throw new Exception("Nama petani minimal harus 2 karakter!");

            if (nik.Length != 16 || !nik.All(char.IsDigit)) 
                throw new Exception("NIK harus 16 digit angka!");

            if (!(noTelepon.StartsWith("08") || noTelepon.StartsWith("+62")))
                throw new Exception("Format nomor telepon salah!");

            // 2. CEK DUPLIKASI (PENTING: Harus sebelum Insert)
            if (dal.IsNoTeleponExist(noTelepon))
            {
                throw new Exception("Nomor telepon sudah terdaftar!");
            }

            // 3. Simpan ke Database
            return dal.Insert(namaPetani, nik, alamat, noTelepon);
        }

        /*=======================
                Ubah 
        ========================*/

        public bool Ubah(int idPetani, string namaPetani, string nik, string alamat, string noTelepon, bool statusAktif)
        {
            // 1. Validasi format telepon
            if (!(noTelepon.StartsWith("08") || noTelepon.StartsWith("+62"))) throw new Exception("Format nomor telepon salah!");

            // 2. Cek Duplikasi (Mengabaikan ID sendiri agar tidak bentrok dengan data lama)
            if (dal.IsNoTeleponExist(noTelepon, idPetani))
            {
                throw new Exception("Nomor telepon sudah digunakan oleh petani lain!");
            }

            // 3. Update Database
            return dal.Update(idPetani, namaPetani, nik, alamat, noTelepon, statusAktif);
        }

        /*=======================
                Hapus 
        ========================*/

        public bool Hapus(int idPetani)
        {
            return dal.Delete(idPetani);

        }

        /*=======================
                Total 
        ========================*/
        public int Total()
        {
            return dal.Count();
        }

    }
}
