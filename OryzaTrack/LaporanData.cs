using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OryzaTrack
{
    public class LaporanData
    {
        public LaporanData() { }
        public string NamaPetani { get; set; }
        public string JenisBibit { get; set; }
        public string LokasiLahan { get; set; }
        public string KategoriPenyakit { get; set; }
        public string TingkatKerusakan { get; set; }
        public System.DateTime TanggalTerdeteksi { get; set; }
        public string TanggalSelesai { get; set; }
        public string Keterangan { get; set; }
        public string JenisPerawatan { get; set; }
        public string JenisPestisida { get; set; }
        public string HasilPerawatan { get; set; }
    }
}
