using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OryzaTrackBLL;

namespace OryzaTrack
{
    public partial class FormLaporan : Form
    {
        private HamaBLL hamaBLL = new HamaBLL();
        private RiwayatPenyakitBLL sakitBLL = new RiwayatPenyakitBLL();
        private PerawatanPadiBLL rawatBLL = new PerawatanPadiBLL();

        public FormLaporan()
        {
            InitializeComponent();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            LoadLaporan();
        }

        private void LoadLaporan()
        {
            // Laporan JOIN dari PerawatanPadi
            dgvLaporan.DataSource = rawatBLL.GetAll();

            // Hitung jumlah menggunakan ExecuteScalar (sesuai requirement)
            lblTotalHama.Text = "Total Data Hama: " + hamaBLL.CountData();
            lblTotalPenyakit.Text = "Total Data Penyakit: " + sakitBLL.CountData();
            lblTotalPerawatan.Text = "Total Data Perawatan: " + rawatBLL.CountData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLaporan();
        }

        private void FormLaporan_Load_1(object sender, EventArgs e)
        {

        }
    }
}
