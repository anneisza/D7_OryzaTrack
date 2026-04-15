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
    public partial class FormRiwayatPenyakit : Form
    {
        private RiwayatPenyakitBLL bll = new RiwayatPenyakitBLL();
        private int _idAdmin;
        private int _selectedId = 0;

        public FormRiwayatPenyakit(int idAdmin)
        {
            InitializeComponent();
            _idAdmin = idAdmin;
        }

        private void FormRiwayatPenyakit_Load(object sender, EventArgs e)
        {
            cmbTingkatKerusakan.Items.AddRange(new string[] { "Ringan", "Sedang", "Berat", "Sangat Berat" });
            cmbTingkatKerusakan.SelectedIndex = 0;
            LoadData();
        }

        private void LoadData()
        {
            dgvPenyakit.DataSource = bll.GetAll();
            lblJumlah.Text = "Jumlah Data: " + bll.CountData();
        }

        private void dgvPenyakit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvPenyakit.Rows[e.RowIndex];
            _selectedId = Convert.ToInt32(row.Cells["idPenyakit"].Value);
            txtIdPenyakit.Text = _selectedId.ToString();
            txtGejalaPenyakit.Text = row.Cells["gejalaPenyakit"].Value?.ToString();
            cmbTingkatKerusakan.Text = row.Cells["tingkatKerusakan"].Value?.ToString();
            txtLokasiLahan.Text = row.Cells["lokasiLahan"].Value?.ToString();
            dtpTanggalSerangan.Value = Convert.ToDateTime(row.Cells["tanggalSerangan"].Value);
        }
    }
}
