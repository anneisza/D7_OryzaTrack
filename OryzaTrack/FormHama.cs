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
    public partial class FormHama : Form
    {
        private HamaBLL bll = new HamaBLL();
        private int _idAdmin;
        private int _selectedId = 0;

        public FormHama(int idAdmin)
        {
            InitializeComponent();
            _idAdmin = idAdmin; 
        }

        private void FormHama_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvHama.DataSource = bll.GetAll();
            lblJumlah.Text = "Jumlah Data: " + bll.CountData();
        }

        // Pilih baris di DGV → isi TextBox (sesuai requirement)
        private void dgvHama_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvHama.Rows[e.RowIndex];
            _selectedId = Convert.ToInt32(row.Cells["idHama"].Value);
            txtIdHama.Text = _selectedId.ToString();
            txtNamaHama.Text = row.Cells["namaHama"].Value?.ToString();
            txtJenisHama.Text = row.Cells["jenisHama"].Value?.ToString();
            txtGejalaHama.Text = row.Cells["gejalaHama"].Value?.ToString();
            txtLokasiLahan.Text = row.Cells["lokasiLahan"].Value?.ToString();
            dtpTanggalSerangan.Value = Convert.ToDateTime(row.Cells["tanggalSerangan"].Value);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                bll.Insert(_idAdmin, txtNamaHama.Text, txtJenisHama.Text,
                           txtGejalaHama.Text, txtLokasiLahan.Text, dtpTanggalSerangan.Value);
                MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                BersihkanForm();
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
                // Konfirmasi sebelum UPDATE (sesuai requirement)
                DialogResult confirm = MessageBox.Show(
                    "Yakin ingin mengupdate data ini?", "Konfirmasi Update",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    bll.Update(_selectedId, txtNamaHama.Text, txtJenisHama.Text,
                               txtGejalaHama.Text, txtLokasiLahan.Text, dtpTanggalSerangan.Value);
                    MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    BersihkanForm();
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
                // Konfirmasi sebelum DELETE (sesuai requirement)
                DialogResult confirm = MessageBox.Show(
                    "Yakin ingin menghapus data ini?", "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    bll.Delete(_selectedId);
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    BersihkanForm();
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
            dgvHama.DataSource = string.IsNullOrEmpty(keyword) ? bll.GetAll() : bll.Search(keyword);
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            BersihkanForm();
            LoadData();
        }

        private void BersihkanForm()
        {
            _selectedId = 0;
            txtIdHama.Clear();
            txtNamaHama.Clear();
            txtJenisHama.Clear();
            txtGejalaHama.Clear();
            txtLokasiLahan.Clear();
            dtpTanggalSerangan.Value = DateTime.Now;
            txtCari.Clear();
        }
    }
}
