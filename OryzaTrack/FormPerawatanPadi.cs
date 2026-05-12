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
        private int selectedIdPerawatanPadi;
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
            // Setting DataGridView saat form dibuka
            dgvPerawatanPadi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPerawatanPadi.MultiSelect = false;
            dgvPerawatanPadi.ReadOnly = true;
            dgvPerawatanPadi.AllowUserToAddRows = false;
            dgvPerawatanPadi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Daftarkan event cell click untuk DataGridView
            dgvPerawatanPadi.CellClick += dgvPerawatanPadi_CellClick;

            LoadPadi();
            LoadPenyakit();
        }


        //Handler

        private void LoadData()
        {
            try
            {
                dgvPerawatanPadi.DataSource = bllPerawatan.GetAll();
                
                TampilkanTotal();
            }
            catch (Exception ex) { 
                MessageBox.Show("Gagal load data: " + ex.Message, "Error : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TampilkanTotal()
        {
            lblTotal.Text = "Jumlah : " + bllPerawatan.Total();
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

        private bool ValidasiInput()
        {
            if (cmbIdPadi.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih ID padi!");
                return false;
            }

            if (cmbIdPenyakit.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih ID penyakit!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtJenisPerawatan.Text))
            {
                MessageBox.Show("Isi jenis perawatan!");
                return false;
            }

            if (cmbJenisPestisida.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih jenis pestisida!");
                return false;
            }

            if (dtpTanggalPerawatan.Value > DateTime.Now)
            {
                MessageBox.Show("Tanggal perawatan tidak boleh di masa depan!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHasilPerawatan.Text))
            {
                MessageBox.Show("Isi hasil perawatan!");
                return false;
            }

            return true;
        }



        private void LoadPadi()
        {
            try
            {
                DataTable dt = bllPadi.GetAll();

                cmbIdPadi.ValueMember = "idPadi";
                cmbIdPadi.DisplayMember = "idPadi"; // Sesuaikan nama kolom di DB

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
                cmbIdPenyakit.DisplayMember = "idPenyakit"; // Sesuaikan nama kolom di DB

                cmbIdPenyakit.DataSource = dt;
                cmbIdPenyakit.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Gagal load penyakit: " + ex.Message); }
        }



        //Event Handler

        private void btnKoneksi_Click(object sender, EventArgs e)
        {
            try
            {
                bllPerawatan.GetAll();
                MessageBox.Show("Database Terkoneksi!",
                    "Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCari.Text))
            {
                LoadData();
            }
            else
            {
                dgvPerawatanPadi.DataSource = bllPerawatan.Cari(txtCari.Text.Trim());
            }

        }

        private void btnCariData_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCari.Text))
                {
                    LoadData();
                }
                else
                {
                    dgvPerawatanPadi.DataSource = bllPerawatan.Cari(txtCari.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
            TampilkanTotal();
        }

        private void btnTambahData_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

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
                    MessageBox.Show("Data Perawatan Padi berhasil ditambah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Bersihkan();
                    TampilkanTotal();
                }
                else
                {
                    MessageBox.Show("Gagal menambah data Perawatan Padi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }

        }

        private void btnUbahData_Click(object sender, EventArgs e)
        {
            if (selectedIdPerawatanPadi == 0)
            {
                MessageBox.Show("Pilih data yang akan diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidasiInput()) return;

            DialogResult konfirmasi = MessageBox.Show(
                "Ubah data ini?",
                "Konfirmasi Ubah", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
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
                        MessageBox.Show("Data Perawatan Padi berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        Bersihkan();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
        }

        private void btnHapusData_Click(object sender, EventArgs e)
        {
            if (selectedIdPerawatanPadi == 0)
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Hapus data ini?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    bool hasil = bllPerawatan.Hapus(selectedIdPerawatanPadi);
                    if (hasil)
                    {
                        MessageBox.Show("Data Perawatan Padi berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        Bersihkan();
                        TampilkanTotal();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

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

                //harus sama dengan nama kolom di DataGridView
                selectedIdPerawatanPadi = Convert.ToInt32(row.Cells["idPerawatanPadi"].Value);

                // Set nilai pada form berdasarkan data yang dipilih
                cmbIdPadi.SelectedValue = row.Cells["idPadi"].Value;
                cmbIdPenyakit.SelectedValue = row.Cells["idPenyakit"].Value;
                // Pastikan nama kolom di DataGridView sesuai dengan yang digunakan di sini
                txtJenisPerawatan.Text = row.Cells["jenisPerawatan"].Value.ToString();
                cmbJenisPestisida.Text = row.Cells["jenisPestisida"].Value.ToString();

                dtpTanggalPerawatan.Value = Convert.ToDateTime(row.Cells["tanggalPerawatan"].Value);
                txtHasilPerawatan.Text = row.Cells["hasilPerawatan"].Value.ToString();
            }

        }
    }
}
