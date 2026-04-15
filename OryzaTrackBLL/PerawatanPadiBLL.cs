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

        public DataTable GetAll() => dal.GetAll();
        public DataTable GetAllRaw() => dal.GetAllRaw();
        public DataTable Search(string keyword) => dal.Search(keyword);
        public int CountData() => dal.CountData();

        public void Insert(int idAdmin, int idPenyakit, int idHama, string jenisPerawatan,
                           string jenisPestisida, DateTime tanggalPerawatan, string hasilPerawatan)
        {
            ValidateInput(idPenyakit, idHama, jenisPerawatan, jenisPestisida, hasilPerawatan);
            dal.Insert(idAdmin, idPenyakit, idHama, jenisPerawatan, jenisPestisida, tanggalPerawatan, hasilPerawatan);
        }

        public void Update(int idPerawatan, int idPenyakit, int idHama, string jenisPerawatan,
                           string jenisPestisida, DateTime tanggalPerawatan, string hasilPerawatan)
        {
            if (idPerawatan <= 0) throw new Exception("Pilih data yang akan diupdate!");
            ValidateInput(idPenyakit, idHama, jenisPerawatan, jenisPestisida, hasilPerawatan);
            dal.Update(idPerawatan, idPenyakit, idHama, jenisPerawatan, jenisPestisida, tanggalPerawatan, hasilPerawatan);
        }

        public void Delete(int idPerawatan)
        {
            if (idPerawatan <= 0) throw new Exception("Pilih data yang akan dihapus!");
            dal.Delete(idPerawatan);
        }

        private void ValidateInput(int idPenyakit, int idHama, string jenisPerawatan,
                                   string jenisPestisida, string hasilPerawatan)
        {
            if (idPenyakit <= 0) throw new Exception("Pilih ID Penyakit!");
            if (idHama <= 0) throw new Exception("Pilih ID Hama!");
            if (string.IsNullOrWhiteSpace(jenisPerawatan)) throw new Exception("Jenis perawatan tidak boleh kosong!");
            if (string.IsNullOrWhiteSpace(jenisPestisida)) throw new Exception("Jenis pestisida tidak boleh kosong!");
            if (string.IsNullOrWhiteSpace(hasilPerawatan)) throw new Exception("Hasil perawatan tidak boleh kosong!");
        }
    }
}
