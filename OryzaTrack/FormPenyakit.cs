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
    public partial class FormPenyakit : Form
    {
        private int selectedIdPenyakit = 0;
        private PenyakitBLL bll = new PenyakitBLL();
        public FormPenyakit(int idAdmin)
        {
            InitializeComponent();
        }

        private void FormPenyakit_Load(object sender, EventArgs e)
        {
            // Setting DataGridView saat form dibuka
            dgvPenyakit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPenyakit.MultiSelect = false;
            dgvPenyakit.ReadOnly = true;
            dgvPenyakit.AllowUserToAddRows = false;
            dgvPenyakit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Daftarkan event CellClick
            dgvPenyakit.CellClick += dgvPenyakit_CellClick;

        }

        // =====================
        // METHOD HELPER
        // =====================

        private void LoadData()
        {
            try
            {
                // Mengambil data dari PenyakitBLL
                dgvPenyakit.DataSource = bll.GetAll();
                TampilkanTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TampilkanTotal()
        {
            // Menampilkan total record penyakit
            lblTotal.Text = "Total Data: " + bll.Total();
        }

        private void BersihkanForm()
        {
            // Reset ID pilihan dan bersihkan semua field penyakit
            selectedIdPenyakit = 0;
            cmbKategori.SelectedIndex = -1;
            txtGejalaPenyakit.Clear();
            cmbTingkatKerusakan.SelectedIndex = -1;
            txtCari.Clear();
            dtpTanggalSerangan.Focus();
        }

        private bool ValidasiInput()
        {
            //Kategori jgn kosong
            if (cmbKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Kategori harus dipilih!");
                cmbKategori.Focus();
                return false;
            }

            //tingkat kerusakan jgn kosong
            if (cmbTingkatKerusakan.SelectedIndex == -1)
            {
                MessageBox.Show("Tingkat kerusakan harus dipilih!");
                cmbTingkatKerusakan.Focus();
                return false;
            }

            // Validasi Gejala Penyakit
            if (string.IsNullOrWhiteSpace(txtGejalaPenyakit.Text))
            {
                MessageBox.Show("Gejala penyakit tidak boleh kosong!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGejalaPenyakit.Focus();
                return false;
            }

            // Validasi panjang karakter sesuai aturan bisnis (misal min 10 karakter)
            if (txtGejalaPenyakit.Text.Trim().Length < 10)
            {
                MessageBox.Show("Gejala penyakit terlalu pendek (minimal 10 karakter)!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGejalaPenyakit.Focus();
                return false;
            }

            return true;
        }

        //tombol koneksi

        private void btnKoneksi_Click(object sender, EventArgs e)
        {
            try
            {
                bll.GetAll();
                MessageBox.Show("Database Terkoneksi!",
                    "Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //cari
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCari.Text))
            {
                LoadData();
            }
            else
            {
                dgvPenyakit.DataSource = bll.Cari(txtCari.Text.Trim());
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
                    dgvPenyakit.DataSource = bll.Cari(txtCari.Text.Trim());
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
                bool hasil = bll.Tambah(
                    cmbKategori.Text.Trim(),
                    txtGejalaPenyakit.Text.Trim(),
                    cmbTingkatKerusakan.Text.Trim(),
                    dtpTanggalSerangan.Value
                );

                if (hasil)
                {
                    MessageBox.Show("Data penyakit berhasil ditambahkan!",
                        "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BersihkanForm();
                    LoadData();
                    TampilkanTotal();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan data!",
                        "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUbahData_Click(object sender, EventArgs e)
        {
            if (selectedIdPenyakit == 0)
            {
                MessageBox.Show("Pilih data dari tabel yang ingin diubah terlebih dahulu!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidasiInput()) return;

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin mengubah data penyakit ini?",
                "Konfirmasi Ubah",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    bool hasil = bll.Ubah(
                        selectedIdPenyakit,
                        cmbKategori.Text.Trim(),
                        txtGejalaPenyakit.Text.Trim(),
                        cmbTingkatKerusakan.Text.Trim(),
                        dtpTanggalSerangan.Value
                    );

                    if (hasil)
                    {
                        MessageBox.Show("Data penyakit berhasil diubah!",
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BersihkanForm();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnHapusData_Click(object sender, EventArgs e)
        {
            if (selectedIdPenyakit == 0)
            {
                MessageBox.Show("Pilih data dari tabel yang ingin dihapus!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data penyakit ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    bool hasil = bll.Hapus(selectedIdPenyakit);
                    if (hasil)
                    {
                        MessageBox.Show("Data penyakit berhasil dihapus!",
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BersihkanForm();
                        LoadData();
                        TampilkanTotal();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            BersihkanForm();

        }

        private void dgvPenyakit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPenyakit.Rows[e.RowIndex];
                selectedIdPenyakit = Convert.ToInt32(row.Cells["idPenyakit"].Value);
                cmbKategori.Text = row.Cells["kategori"].Value.ToString();
                txtGejalaPenyakit.Text = row.Cells["gejalaPenyakit"].Value.ToString();
                cmbTingkatKerusakan.Text = row.Cells["tingkatKerusakan"].Value.ToString();
                dtpTanggalSerangan.Value = DateTime.Parse(row.Cells["tanggalSerangan"].Value.ToString());
            }

        }

    }
}
