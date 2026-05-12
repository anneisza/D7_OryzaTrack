using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OryzaTrackBLL;

namespace OryzaTrack
{
   
    public partial class FormPerawatanPadi : Form
    {
        private int IDAdmin;
        private PerawatanPadiBLL bllPerawatan = new PerawatanPadiBLL();
        private PadiBLL bllPadi = new PadiBLL();
        private PenyakitBLL bllPenyakit = new PenyakitBLL();
        public FormPerawatanPadi(int idAdmin)
        {
            InitializeComponent();
            IDAdmin = idAdmin;
        }

        private void FormPerawatanPadi_Load(object sender, EventArgs e)
        {
            LoadPadi();
            LoadPenyakit();
        }


        //Handler
        private void LoadPadi()
        {
            try
            {
                DataTable dt = bllPadi.GetAll();
                cmbIdPadi.ValueMember = "idPadi";
                cmbIdPadi.DisplayMember = "jenisBibit"; // Sesuaikan nama kolom di DB
                cmbIdPadi.DataSource = dt;
                cmbIdPadi.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Gagal load padi: " + ex.Message); }
        }

        private void LoadPenyakit()
        {
            try
            {
                DataTable dt = bllPenyakit.GetAll();
                cmbIdPenyakit.ValueMember = "idPenyakit";
                cmbIdPenyakit.DisplayMember = "namaPenyakit"; // Sesuaikan nama kolom di DB
                cmbIdPenyakit.DataSource = dt;
                cmbIdPenyakit.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Gagal load penyakit: " + ex.Message); }
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = bllPerawatan.GetAll();
                dgvPerawatanPadi.DataSource = dt;
                lblTotal.Text = "Jumlah : " + dt.Rows.Count.ToString();
            }
            catch (Exception ex) { MessageBox.Show("Gagal load data: " + ex.Message); }
        }

        private void Bersihkan()
        {
            cmbIdPadi.SelectedIndex = -1;
            cmbIdPenyakit.SelectedIndex = -1;
            txtJenisPerawatan.Clear();
            cmbJenisPestisida.SelectedIndex = -1;
            dtpTanggalPerawatan.Value = DateTime.Now;
            txtHasilPerawatan.Clear();
            txtCari.Clear();
        }



        //Event Handler

        private void btnKoneksi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Koneksi Berhasil & Data Diperbarui!");
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCariData_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCari.Text))
            {
                dgvPerawatanPadi.DataSource = bllPerawatan.Cari(txtCari.Text);
            }
            else
            {
                LoadData();
            }

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnTambahData_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasil = bllPerawatan.Tambah(
                    Convert.ToInt32(cmbIdPadi.SelectedValue),
                    Convert.ToInt32(cmbIdPenyakit.SelectedValue),
                    txtJenisPerawatan.Text,
                    cmbJenisPestisida.Text,
                    dtpTanggalPerawatan.Value,
                    txtHasilPerawatan.Text
                );

                if (hasil)
                {
                    MessageBox.Show("Data berhasil ditambah!");
                    LoadData();
                    Bersihkan();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }

        }

        private void btnUbahData_Click(object sender, EventArgs e)
        {
            try
            {
                int idPerawatan = Convert.ToInt32(dgvPerawatanPadi.CurrentRow.Cells[0].Value);
                bool hasil = bllPerawatan.Ubah(
                    idPerawatan,
                    Convert.ToInt32(cmbIdPadi.SelectedValue),
                    Convert.ToInt32(cmbIdPenyakit.SelectedValue),
                    txtJenisPerawatan.Text,
                    cmbJenisPestisida.Text,
                    dtpTanggalPerawatan.Value,
                    txtHasilPerawatan.Text
                );

                if (hasil)
                {
                    MessageBox.Show("Data berhasil diubah!");
                    LoadData();
                    Bersihkan();
                }
            }
            catch (Exception) { MessageBox.Show("Pilih data di tabel dulu!"); }

        }

        private void btnHapusData_Click(object sender, EventArgs e)
        {
            try
            {
                int idPerawatan = Convert.ToInt32(dgvPerawatanPadi.CurrentRow.Cells[0].Value);
                if (MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bllPerawatan.Hapus(idPerawatan))
                    {
                        LoadData();
                        Bersihkan();
                    }
                }
            }
            catch { MessageBox.Show("Pilih data yang akan dihapus!"); }

        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            Bersihkan();

        }

        //DGV
        private void dgvPerawatanPadi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPerawatanPadi.Rows[e.RowIndex];
                cmbIdPadi.SelectedValue = row.Cells["idPadi"].Value;
                cmbIdPenyakit.SelectedValue = row.Cells["idPenyakit"].Value;
                txtJenisPerawatan.Text = row.Cells["jenisPerawatan"].Value.ToString();
                cmbJenisPestisida.Text = row.Cells["jenisPestisida"].Value.ToString();
                dtpTanggalPerawatan.Value = Convert.ToDateTime(row.Cells["tanggalPerawatan"].Value);
                txtHasilPerawatan.Text = row.Cells["hasilPerawatan"].Value.ToString();
            }

        }
    }
}
