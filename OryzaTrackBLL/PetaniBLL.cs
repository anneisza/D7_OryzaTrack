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

            // Validasi duplikat sekarang ditangani SP, BLL tinggal cek pesannya
            string hasil = dal.Insert(namaPetani, nik, alamat, noTelepon);

            if (hasil != "OK")
                throw new Exception(hasil); // Lempar pesan dari SP ke Form

            return true;
        }

        /*=======================
                Ubah 
        ========================*/

        public bool Ubah(int idPetani, string namaPetani, string nik, string alamat, string noTelepon, bool statusAktif)
        {
            // 1. Validasi format telepon
            if (!(noTelepon.StartsWith("08") || noTelepon.StartsWith("+62"))) throw new Exception("Format nomor telepon salah!");

            string hasil = dal.Update(idPetani, namaPetani, nik, alamat, noTelepon, statusAktif);

            if (hasil != "OK")
                throw new Exception(hasil);

            return true;
        }

        /*=======================
                Hapus 
        ========================*/

        public bool Hapus(int idPetani)
        {
            string hasil = dal.Delete(idPetani);

            if (hasil != "OK")
                throw new Exception(hasil); // Lempar pesan dari SP ke Form

            return true;
        }                       

        /*=======================
                Total 
        ========================*/
        public int Total()
        {
            return dal.Count();
        }

        //injection
        public DataTable CariRentan(string keyword)
        {
            return dal.SearchRentan(keyword);
        }

        public bool ResetData()
        {
            return dal.ResetData();
        }
    }
}
