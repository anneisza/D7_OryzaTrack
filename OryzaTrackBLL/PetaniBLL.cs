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
            //nama gak boleh kurang dari 2 karakter
            if (namaPetani.Length < 2)
            {
                throw new Exception("Nama petani minimal harus 2 karakter!");
            }

            //nik harus 16 digit angka
            if (nik.Length != 16 || !nik.All(char.IsDigit))
            {
                throw new Exception("NIK harus berjumlah 16 digit angka!");
            }

            //format nomortelepon harus 08 atau +62
            if (!(noTelepon.StartsWith("08") || noTelepon.StartsWith("+62")))
            {
                throw new Exception("Nomor telepon harus diawali dengan '08' atau '+62'!");
            }

            return dal.Insert(namaPetani, nik, alamat, noTelepon);


            //cek nomor telepon sudah terdaftar atau belum
            if (dal.IsNoTeleponExist(noTelepon))
            {
                throw new Exception("Nomor telepon sudah terdaftar!");
            }

            return dal.Insert(namaPetani, nik, alamat, noTelepon);
        }

        /*=======================
                Ubah 
        ========================*/

        public bool Ubah(int idPetani, string namaPetani, string nik, string alamat, string noTelepon, bool statusAktif)
        {
            return dal.Update(idPetani, namaPetani, nik, alamat, noTelepon, statusAktif);

            // Cek duplicate nomor telepon (kecuali milik user ini sendiri)
            if (dal.IsNoTeleponExist(noTelepon, idPetani))
            {
                throw new Exception("Nomor telepon sudah digunakan oleh petani lain!");
            }

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
