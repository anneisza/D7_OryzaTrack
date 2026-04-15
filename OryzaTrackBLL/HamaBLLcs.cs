using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OryzaTrackDAL;

namespace OryzaTrackBLL
{
    public class HamaBLL
    {
        private HamaDAL dal = new HamaDAL();

        public DataTable GetAll() => dal.GetAll();
        public DataTable Search(string keyword) => dal.Search(keyword);
        public int CountData() => dal.CountData();

        public void Insert(int idAdmin, string namaHama, string jenisHama,
                           string gejalaHama, string lokasiLahan, DateTime tanggalSerangan)
        {
            ValidateInput(namaHama, jenisHama, gejalaHama, lokasiLahan);
            dal.Insert(idAdmin, namaHama, jenisHama, gejalaHama, lokasiLahan, tanggalSerangan);
        }

        public void Update(int idHama, string namaHama, string jenisHama,
                           string gejalaHama, string lokasiLahan, DateTime tanggalSerangan)
        {
            if (idHama <= 0) throw new Exception("Pilih data yang akan diupdate!");
            ValidateInput(namaHama, jenisHama, gejalaHama, lokasiLahan);
            dal.Update(idHama, namaHama, jenisHama, gejalaHama, lokasiLahan, tanggalSerangan);
        }

        public void Delete(int idHama)
        {
            if (idHama <= 0) throw new Exception("Pilih data yang akan dihapus!");
            dal.Delete(idHama);
        }

        private void ValidateInput(string namaHama, string jenisHama, string gejalaHama, string lokasiLahan)
        {
            if (string.IsNullOrWhiteSpace(namaHama)) throw new Exception("Nama hama tidak boleh kosong!");
            if (string.IsNullOrWhiteSpace(jenisHama)) throw new Exception("Jenis hama tidak boleh kosong!");
            if (string.IsNullOrWhiteSpace(gejalaHama)) throw new Exception("Gejala hama tidak boleh kosong!");
            if (string.IsNullOrWhiteSpace(lokasiLahan)) throw new Exception("Lokasi lahan tidak boleh kosong!");
        }
    }
}
