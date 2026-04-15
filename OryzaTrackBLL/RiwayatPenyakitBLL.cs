using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OryzaTrackDAL;

namespace OryzaTrackBLL
{
    public class RiwayatPenyakitBLL
    {
        private RiwayatPenyakitDAL dal = new RiwayatPenyakitDAL();

        public DataTable GetAll() => dal.GetAll();
        public DataTable Search(string keyword) => dal.Search(keyword);
        public int CountData() => dal.CountData();

        public void Insert(int idAdmin, string gejalaPenyakit, string tingkatKerusakan,
                           string lokasiLahan, DateTime tanggalSerangan)
        {
            ValidateInput(gejalaPenyakit, tingkatKerusakan, lokasiLahan);
            dal.Insert(idAdmin, gejalaPenyakit, tingkatKerusakan, lokasiLahan, tanggalSerangan);
        }

        public void Update(int idPenyakit, string gejalaPenyakit, string tingkatKerusakan,
                           string lokasiLahan, DateTime tanggalSerangan)
        {
            if (idPenyakit <= 0) throw new Exception("Pilih data yang akan diupdate!");
            ValidateInput(gejalaPenyakit, tingkatKerusakan, lokasiLahan);
            dal.Update(idPenyakit, gejalaPenyakit, tingkatKerusakan, lokasiLahan, tanggalSerangan);
        }

        public void Delete(int idPenyakit)
        {
            if (idPenyakit <= 0) throw new Exception("Pilih data yang akan dihapus!");
            dal.Delete(idPenyakit);
        }

        private void ValidateInput(string gejalaPenyakit, string tingkatKerusakan, string lokasiLahan)
        {
            if (string.IsNullOrWhiteSpace(gejalaPenyakit)) throw new Exception("Gejala penyakit tidak boleh kosong!");
            if (string.IsNullOrWhiteSpace(tingkatKerusakan)) throw new Exception("Tingkat kerusakan tidak boleh kosong!");
            if (string.IsNullOrWhiteSpace(lokasiLahan)) throw new Exception("Lokasi lahan tidak boleh kosong!");
        }
    }
}
