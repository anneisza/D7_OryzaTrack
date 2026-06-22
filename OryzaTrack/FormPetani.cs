using OryzaTrackBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OryzaTrack
{
    public partial class FormPetani : Form
    {

        private int selectedIdPetani = 0;
        private PetaniBLL bll = new PetaniBLL();
        //variable data lama
        private string oldNama, oldNIK, oldAlamat, oldNoTelp;
        private bool oldStatus;
        //binding source untuk datagridview
        private BindingSource bindingSource = new BindingSource();

        public FormPetani(int idAdmin)
        {
            InitializeComponent();
        }

        private void FormPetani_Load(object sender, EventArgs e)
        {

            cmbStatusAktif.Items.Clear();
            cmbStatusAktif.Items.Add("Aktif");
            cmbStatusAktif.Items.Add("Tidak Aktif");
            // Setting DataGridView saat form dibuka
            dgvPetani.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPetani.MultiSelect = false;
            dgvPetani.ReadOnly = true;
            dgvPetani.AllowUserToAddRows = false;
            dgvPetani.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;    
            
            // Daftarkan event CellClick
            dgvPetani.CellClick += dgvPetani_CellClick;

            //matiin tombol dulu sampai koneksi berhasil
            SetButtonsEnabled(false);
            Application.DoEvents();

            BersihkanForm();

        }

        // =====================
        // METHOD HELPER
        // =====================

        private void LoadData()
        {
            try
            {
                // Ambil data petani dari BLL dan set ke BindingSource
                DataTable dt = bll.GetAll();
                bindingSource.DataSource = dt;

                // Binding DGV ke BindingSource
                dgvPetani.DataSource = bindingSource;

                // Binding Navigator ke BindingSource
                bindingNavigator1.BindingSource = bindingSource;

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
            lblTotal.Text = "Total Data: " + bll.Total();
        }

        private void BersihkanForm()
        {
            selectedIdPetani = 0;
            txtNamaPetani.Clear();
            txtNIK.Clear();
            txtAlamat.Clear();
            txtNoTelepon.Clear();
            txtCari.Clear();
            cmbStatusAktif.SelectedIndex = 0;
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtNamaPetani.Text))
            {
                MessageBox.Show("Nama petani tidak boleh kosong!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaPetani.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNIK.Text))
            {
                MessageBox.Show("NIK tidak boleh kosong!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNIK.Focus();
                return false;
            }
            if (txtNIK.Text.Length != 16)
            {
                MessageBox.Show("NIK harus 16 digit!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNIK.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAlamat.Text))
            {
                MessageBox.Show("Alamat tidak boleh kosong!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAlamat.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNoTelepon.Text))
            {
                MessageBox.Show("No Telepon tidak boleh kosong!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoTelepon.Focus();
                return false;
            }
            if (!txtNoTelepon.Text.StartsWith("08") &&
                !txtNoTelepon.Text.StartsWith("+62"))
            {
                MessageBox.Show("No Telepon harus dimulai dengan 08 atau +62!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoTelepon.Focus();
                return false;
            }
            return true;
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
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
            TampilkanTotal();

        }

        private void btnTambahData_Click(object sender, EventArgs e)
        {
            bool statusAktif = cmbStatusAktif.SelectedIndex == 0;

            if (!ValidasiInput()) return;

            try
            {
                bool hasil = bll.Tambah(
                    txtNamaPetani.Text.Trim(),
                    txtNIK.Text.Trim(),
                    txtAlamat.Text.Trim(),
                    txtNoTelepon.Text.Trim(),
                    statusAktif
                );

                if (hasil)
                {
                    MessageBox.Show("Data petani berhasil ditambahkan!",
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
                MessageBox.Show(ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnUbahData_Click(object sender, EventArgs e)
        {
            if (selectedIdPetani == 0)
            {
                MessageBox.Show("Pilih data dari tabel yang ingin diubah!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool currentStatus = cmbStatusAktif.SelectedIndex == 0;

            // VALIDASI: Cek apakah ada perubahan data
            if (txtNamaPetani.Text.Trim() == oldNama &&
                txtNIK.Text.Trim() == oldNIK &&
                txtAlamat.Text.Trim() == oldAlamat &&
                txtNoTelepon.Text.Trim() == oldNoTelp &&
                currentStatus == oldStatus)
            {
                MessageBox.Show("Tidak ada data yang diubah.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidasiInput()) return;

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin mengubah data petani ini?",
                "Konfirmasi Ubah",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    bool statusAktif = cmbStatusAktif.SelectedIndex == 0;
                    bool hasil = bll.Ubah(
                        selectedIdPetani,
                        txtNamaPetani.Text.Trim(),
                        txtNIK.Text.Trim(),
                        txtAlamat.Text.Trim(),
                        txtNoTelepon.Text.Trim(),
                        statusAktif
                    );

                    if (hasil)
                    {
                        MessageBox.Show("Data petani berhasil diubah!",
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BersihkanForm();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengubah data!",
                            "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (selectedIdPetani == 0)
            {
                MessageBox.Show("Pilih data dari tabel yang ingin dihapus!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data petani ini?\nData yang dihapus tidak bisa dikembalikan!",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    bool hasil = bll.Hapus(selectedIdPetani);

                    if (hasil)
                    {
                        MessageBox.Show("Data petani berhasil dihapus!",
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BersihkanForm();
                        LoadData();
                        TampilkanTotal();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data!",
                            "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtCari_TextChanged(object sender, EventArgs e)
        {


        }


        private void btnTestInjection_Click(object sender, EventArgs e)
        {
            string inputBerbahaya = txtCari.Text;

            if (string.IsNullOrWhiteSpace(inputBerbahaya))
            {
                MessageBox.Show(
                    "Isi txtCari dulu!\n\n" +
                    "Contoh input berbahaya:\n" +
                    "' OR '1'='1' --\n" +
                    "' OR 1=1 --",
                    "Petunjuk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tampilkan query yang terbentuk (untuk edukasi)
            string queryInfo =
                "SELECT idPetani, namaPetani, NIK, alamat, noTelepon " +
                "FROM petani " +
                "WHERE namaPetani = '" + inputBerbahaya + "'";

            MessageBox.Show(
                "Query yang dijalankan:\n\n" + queryInfo,
                "⚠️ Query Tidak Aman",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            try
            {
                // Panggil via BLL → DAL (tidak perlu DatabaseConnection di Form)
                DataTable dt = bll.CariRentan(inputBerbahaya);
                dgvPetani.DataSource = dt;

                if (dt.Rows.Count > 1)
                {
                    MessageBox.Show(
                        $"⚠️ SQL INJECTION BERHASIL!\n\n" +
                        $"Jumlah data bocor: {dt.Rows.Count} baris\n\n" +
                        $"Semua data petani berhasil diakses\n" +
                        $"tanpa mengetahui nama yang benar!",
                        "Injection Berhasil!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else if (dt.Rows.Count == 1)
                {
                    MessageBox.Show(
                        "Query normal — hanya 1 data ditemukan.",
                        "Normal", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Data tidak ditemukan.",
                        "Kosong", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show(
                "Reset data petani ke kondisi awal demo?\n" +
                "Semua perubahan akan dikembalikan!",
                "Konfirmasi Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    // Panggil via BLL → DAL
                    bool hasil = bll.ResetData();
                    if (hasil)
                    {
                        LoadData();
                        MessageBox.Show(
                            "Data berhasil direset ke kondisi awal!",
                            "Reset Berhasil",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal reset: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCariData_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCari.Text))
                {
                    MessageBox.Show("Masukkan kata kunci pencarian!",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    return;
                }
                bindingSource.DataSource = bll.Cari(txtCari.Text.Trim());
                dgvPetani.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNIK_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtNIK.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("NIK hanya boleh berisi angka!",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNIK.Text = txtNIK.Text.Replace(c.ToString(), "");
                    txtNIK.SelectionStart = txtNIK.Text.Length;
                    break;
                }
            }
        }

        // =====================
        // EVENT DATAGRIDVIEW
        // =====================
        private void dgvPetani_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Ambil row langsung dari DataGridView
                DataGridViewRow selectedRow = dgvPetani.Rows[e.RowIndex];

                selectedIdPetani = Convert.ToInt32(selectedRow.Cells["idPetani"].Value);

                // Isi textbox
                txtNamaPetani.Text = oldNama =
                    selectedRow.Cells["namaPetani"].Value.ToString();

                txtNIK.Text = oldNIK =
                    selectedRow.Cells["NIK"].Value.ToString();

                txtAlamat.Text = oldAlamat =
                    selectedRow.Cells["alamat"].Value.ToString();

                txtNoTelepon.Text = oldNoTelp =
                    selectedRow.Cells["noTelepon"].Value.ToString();

                // Status aktif
                cmbStatusAktif.SelectedIndex =
                    selectedRow.Cells["statusAktif"].Value.ToString() == "Aktif"
                    ? 0 : 1;

                oldStatus = cmbStatusAktif.SelectedIndex == 0;
            }

        }

    }
}
