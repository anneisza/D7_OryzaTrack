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
        private int IDAdmin;
        private int selectedIdRiwayatPenyakit = 0; // Menyimpan ID riwayat penyakit yang dipilih
        private RiwayatPenyakitBLL bll = new RiwayatPenyakitBLL();
        PadiBLL bllPadi = new PadiBLL();
        PenyakitBLL bllPenyakit = new PenyakitBLL();
        //var data lama untuk validasi perubahan
        private int oldIdPadi, oldIdPenyakit;
        private DateTime oldTglDeteksi, oldTglSelesai;
        private string oldKeterangan;
        public FormRiwayatPenyakit(int idAdmin)
        {
            InitializeComponent();
            IDAdmin = idAdmin;
        }

        private void FormRiwayatPenyakit_Load(object sender, EventArgs e)
        {
            // Setting DataGridView saat form dibuka
            dgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayat.MultiSelect = false;
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Daftarkan event CellClick
            dgvRiwayat.CellClick += dgvRiwayat_CellClick;

            btnLoadData.Enabled = false; // Disable tombol load data sampai koneksi dicek
            LoadPadi();
            LoadPenyakit();

            SetButtonsEnabled(false);
            Application.DoEvents();

        }

        // =====================
        // METHOD HELPER
        // =====================
        private void LoadData()
        {
            try
            {
                // Mengambil data dari PadiBLL
                dgvRiwayat.DataSource = bll.GetAll();
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
            cmbIdPadi.SelectedIndex = -1;
            cmbIdPenyakit.SelectedIndex = -1;
            dtpTanggalTerdeteksi.Value = DateTime.Now;
            dtpTanggalSelesai.Value = DateTime.Now;
            txtKeterangan.Clear();
        }

        private bool ValidasiInput()
        {
            if (cmbIdPadi.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih ID Padi terlebih dahulu.",
                    "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbIdPenyakit.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih ID Penyakit terlebih dahulu.",
                    "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpTanggalTerdeteksi.Value > DateTime.Now || dtpTanggalTerdeteksi.Value.Year < 2000)
            {
                MessageBox.Show("Tanggal Terdeteksi tidak boleh di masa depan atau kurang dari tahun 2000.",
                    "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpTanggalSelesai.Value < dtpTanggalTerdeteksi.Value)
            {
                MessageBox.Show("Tanggal Selesai tidak boleh sebelum Tanggal Terdeteksi.",
                    "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        //combo box untuk id padi
        private void LoadPadi()
        {
            try
            {
                // Pakai PadiBLL untuk mengambil data padi, karena kita butuh jenisBibit untuk ditampilkan di ComboBox
                DataTable dt = bllPadi.GetAll();

                // ATUR MEMBER DULU SEBELUM DATASOURCE
                cmbIdPadi.ValueMember = "idPadi";
                cmbIdPadi.DisplayMember = "idPadi";

                cmbIdPadi.DataSource = dt;
                cmbIdPadi.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data petani: " + ex.Message);
            }
        }

        //combo box untuk id penyakit
        private void LoadPenyakit()
        {
            try
            {

                DataTable dt = bllPenyakit.GetAll();

                // ATUR MEMBER DULU SEBELUM DATASOURCE
                cmbIdPenyakit.ValueMember = "idPenyakit";
                cmbIdPenyakit.DisplayMember = "idPenyakit";

                cmbIdPenyakit.DataSource = dt;
                cmbIdPenyakit.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data penyakit: " + ex.Message);
            }
        }



        //matiin tombol
        private void SetButtonsEnabled(bool status)
        {
            btnLoadData.Enabled = status;
            btnTambahData.Enabled = status;
            btnUbahData.Enabled = status;
            btnHapusData.Enabled = status;
            btnBersihkan.Enabled = status;
            btnCariData.Enabled = status;
        }

        // =====================
        //     EVENT HANDLER
        // =====================

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
                btnLoadData.Enabled = false;
            }

            finally
            {
                // 2. NYALAKAN KEMBALI di blok finally
                SetButtonsEnabled(true);
            }

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCariData_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCari.Text))
                {
                    MessageBox.Show("Masukkan kata kunci pencarian terlebih dahulu.",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dgvRiwayat.DataSource = bll.Cari(txtCari.Text.Trim());
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
                    Convert.ToInt32(cmbIdPadi.SelectedValue),
                    Convert.ToInt32(cmbIdPenyakit.SelectedValue),
                    dtpTanggalTerdeteksi.Value,
                    dtpTanggalSelesai.Value,
                    txtKeterangan.Text.Trim()
                );

                if (hasil)
                {
                    MessageBox.Show("Data riwayat penyakit berhasil ditambahkan!",
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
            if (selectedIdRiwayatPenyakit == 0)
            {
                MessageBox.Show("Pilih data dari tabel yang ingin diubah!",
                    "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; }

            // VALIDASI: Apakah user benar-benar mengubah sesuatu?
            if ((int)cmbIdPadi.SelectedValue == oldIdPadi &&
                (int)cmbIdPenyakit.SelectedValue == oldIdPenyakit &&
                dtpTanggalTerdeteksi.Value == oldTglDeteksi &&
                dtpTanggalSelesai.Value == oldTglSelesai &&
                txtKeterangan.Text.Trim() == oldKeterangan)
            {
                MessageBox.Show("Data masih sama dengan sebelumnya. Tidak ada yang perlu diubah.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        selectedIdRiwayatPenyakit,
                        Convert.ToInt32(cmbIdPadi.SelectedValue),
                        Convert.ToInt32(cmbIdPenyakit.SelectedValue),
                        dtpTanggalTerdeteksi.Value,
                        dtpTanggalSelesai.Value,
                        txtKeterangan.Text.Trim()
                    );

                    if (hasil)
                    {
                        MessageBox.Show("Data riwayat penyakit berhasil diubah!",
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
            if (selectedIdRiwayatPenyakit == 0)
            {
                MessageBox.Show("Pilih data dari tabel yang ingin dihapus!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data riwayat penyakit ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    bool hasil = bll.Hapus(selectedIdRiwayatPenyakit);
                    if (hasil)
                    {
                        MessageBox.Show("Data riwayat penyakit berhasil dihapus!",
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


        // =============================
        // Data Grid View Event Handler
        // =============================
        private void dgvRiwayat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRiwayat.Rows[e.RowIndex];
                selectedIdRiwayatPenyakit = Convert.ToInt32(row.Cells["idRiwayat"].Value);

                // TIPS: Jangan gunakan .Text jika datanya dari hasil JOIN. 
                // Gunakan pencarian index berdasarkan value asli jika memungkinkan.
                cmbIdPadi.Text = row.Cells["jenisBibit"].Value.ToString();
                cmbIdPenyakit.Text = row.Cells["Kategori"].Value.ToString();

                // Simpan data lama untuk validasi redundansi
                oldIdPadi = (int)cmbIdPadi.SelectedValue;
                oldIdPenyakit = (int)cmbIdPenyakit.SelectedValue;

                dtpTanggalTerdeteksi.Value = oldTglDeteksi = Convert.ToDateTime(row.Cells["tanggalTerdeteksi"].Value);

                if (row.Cells["tanggalSelesai"].Value != DBNull.Value)
                {
                    dtpTanggalSelesai.Value = oldTglSelesai = Convert.ToDateTime(row.Cells["tanggalSelesai"].Value);
                }

                txtKeterangan.Text = oldKeterangan = row.Cells["keterangan"].Value.ToString();
            }
        }

       
    }
}
