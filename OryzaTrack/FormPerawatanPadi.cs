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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                bll.Insert(_idAdmin, (int)nudIdPenyakit.Value, (int)nudIdHama.Value,
                           txtJenisPerawatan.Text, txtJenisPestisida.Text,
                           dtpTanggalPerawatan.Value, cmbHasilPerawatan.Text);
                MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); BersihkanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Yakin ingin mengupdate data ini?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bll.Update(_selectedId, (int)nudIdPenyakit.Value, (int)nudIdHama.Value,
                               txtJenisPerawatan.Text, txtJenisPestisida.Text,
                               dtpTanggalPerawatan.Value, cmbHasilPerawatan.Text);
                    MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); BersihkanForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bll.Delete(_selectedId);
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); BersihkanForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim();
            dgvPerawatan.DataSource = string.IsNullOrEmpty(keyword) ? bll.GetAll() : bll.Search(keyword);
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            BersihkanForm(); LoadData();
        }

        private void BersihkanForm()
        {
            _selectedId = 0;
            txtIdPerawatan.Clear(); txtJenisPerawatan.Clear(); txtJenisPestisida.Clear();
            nudIdPenyakit.Value = 1; nudIdHama.Value = 1;
            cmbHasilPerawatan.SelectedIndex = 0;
            dtpTanggalPerawatan.Value = DateTime.Now;
            txtCari.Clear();
        }
    }
}
