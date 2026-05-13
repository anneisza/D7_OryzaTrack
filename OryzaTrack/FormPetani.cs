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
    public partial class FormPetani : Form
    {
        private int selectedIdPetani = 0;
        private PetaniBLL bll = new PetaniBLL();
        //variable data lama
        private string oldNama, oldNIK, oldAlamat, oldNoTelp;
        private bool oldStatus;

        public FormPetani(int idAdmin)
        {
            InitializeComponent();
        }

        private void FormPetani_Load(object sender, EventArgs e)
        {
            // isi combobox status
            cmbStatusAktif.Items.Clear();
            cmbStatusAktif.Items.Add("Aktif");
            cmbStatusAktif.Items.Add("Tidak Aktif");

            cmbStatusAktif.SelectedIndex = 0;
            // Setting DataGridView saat form dibuka
            dgvPetani.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPetani.MultiSelect = false;
            dgvPetani.ReadOnly = true;
            dgvPetani.AllowUserToAddRows = false;
            dgvPetani.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;    
            
            // Daftarkan event CellClick
            dgvPetani.CellClick += dgvPetani_CellClick;

        }

        // =====================
        // METHOD HELPER
        // =====================

        private void LoadData()
        {
            try
            {
                dgvPetani.DataSource = bll.GetAll();
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

        // =====================
        // EVENT TOMBOL
        // =====================

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
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUbahData_Click(object sender, EventArgs e)
        {
            if (selectedIdPetani == 0) return;

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
            if (string.IsNullOrWhiteSpace(txtCari.Text))
            {
                LoadData();
            }
            else
            {
                dgvPetani.DataSource = bll.Cari(txtCari.Text.Trim());
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
                    dgvPetani.DataSource = bll.Cari(txtCari.Text.Trim());
                }
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
                DataGridViewRow row = dgvPetani.Rows[e.RowIndex];
                selectedIdPetani = Convert.ToInt32(row.Cells["idPetani"].Value);

                // Simpan ke TextBox
                txtNamaPetani.Text = oldNama = row.Cells["namaPetani"].Value.ToString();
                txtNIK.Text = oldNIK = row.Cells["NIK"].Value.ToString();
                txtAlamat.Text = oldAlamat = row.Cells["alamat"].Value.ToString();
                txtNoTelepon.Text = oldNoTelp = row.Cells["noTelepon"].Value.ToString();

                bool status = Convert.ToBoolean(row.Cells["statusAktif"].Value);
                cmbStatusAktif.SelectedIndex = status ? 0 : 1;
                oldStatus = status;
            }

        }

    }
}
