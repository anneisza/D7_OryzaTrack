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
    public partial class FormPerawatanPadi : Form
    {
        private PerawatanPadiBLL bll = new PerawatanPadiBLL();
        private int _idAdmin;
        private int _selectedId = 0;
        public FormPerawatanPadi(int idAdmin)
        {
            InitializeComponent();
            _idAdmin = idAdmin;
        }

        private void FormPerawatanPadi_Load(object sender, EventArgs e)
        {
            cmbHasilPerawatan.Items.AddRange(new string[] { "Berhasil", "Sebagian Berhasil", "Gagal" });
            cmbHasilPerawatan.SelectedIndex = 0;
            LoadData();
        }

        private void dgvPerawatan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Ambil data raw (dengan idPenyakit dan idHama) untuk edit
            var rawDt = bll.GetAllRaw();
            DataGridViewRow row = dgvPerawatan.Rows[e.RowIndex];
            _selectedId = Convert.ToInt32(row.Cells["idPerawatan"].Value);

            // Cari data raw berdasarkan idPerawatan
            foreach (System.Data.DataRow rawRow in rawDt.Rows)
            {
                if (Convert.ToInt32(rawRow["idPerawatan"]) == _selectedId)
                {
                    txtIdPerawatan.Text = _selectedId.ToString();
                    nudIdPenyakit.Value = Convert.ToInt32(rawRow["idPenyakit"]);
                    nudIdHama.Value = Convert.ToInt32(rawRow["idHama"]);
                    txtJenisPerawatan.Text = rawRow["jenisPerawatan"]?.ToString();
                    txtJenisPestisida.Text = rawRow["jenisPestisida"]?.ToString();
                    dtpTanggalPerawatan.Value = Convert.ToDateTime(rawRow["tanggalPerawatan"]);
                    cmbHasilPerawatan.Text = rawRow["hasilPerawatan"]?.ToString();
                    break;
                }
            }
        }
    }
}
