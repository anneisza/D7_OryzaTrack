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
        //binding
        private BindingSource bindingSource = new BindingSource();

        private int IDAdmin;
        private int selectedIdPerawatanPadi = -1;
        private PerawatanPadiBLL bllPerawatan = new PerawatanPadiBLL();
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

            // Jika ada kolom ID (misal idPestisida), set ValueMember juga
            // cmbJenisPestisida.ValueMember = "idPestisida";
            cmbJenisPestisida.DataSource = bllPerawatan.GetListPestisida();
            cmbJenisPestisida.SelectedIndex = -1;

            //Daftarkan event cell click untuk DataGridView
            dgvPerawatanPadi.CellClick += dgvPerawatanPadi_CellClick;

            // Isi Dropdown Hasil Perawatan
            cmbHasil.DataSource = bllPerawatan.GetListHasil();
            cmbHasil.DisplayMember = "hasilPerawatan";
            cmbHasil.ValueMember = "hasilPerawatan";

            LoadComboBoxSources();
            Bersihkan();

            //matiin tombol dulu, nanti diaktifkan setelah koneksi berhasil
            SetButtonsEnabled(false);
            Application.DoEvents();
        }

        //method baru untuk load combo box dengan data dari BLL
        private bool sedangMuat = false;
        private void LoadComboBoxSources()
        {
            if (sedangMuat) return;
            sedangMuat = true;
            try
            {
                // Mengikat ke data gabungan baru dari BLL
                cmbIdRiwayat.DataSource = bllPerawatan.GetLookupRiwayat();
                cmbIdRiwayat.DisplayMember = "TeksTampilan";
                cmbIdRiwayat.ValueMember = "idRiwayat"; // <-- Menyimpan ID Riwayat berantai
                cmbIdRiwayat.SelectedIndex = -1;

                // FIX SINKRONISASI DATABASE: Mengisi item pestisida secara manual
                cmbJenisPestisida.DataSource = null; // Lepas datasource lama jika ada
                cmbJenisPestisida.Items.Clear();
                cmbJenisPestisida.Items.Add("Tanpa Pestisida");
                cmbJenisPestisida.Items.Add("Insektisida Furadan");
                cmbJenisPestisida.Items.Add("Fungisida Dithane");
                cmbJenisPestisida.Items.Add("Herbisida Glyphosate");
                cmbJenisPestisida.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbJenisPestisida.SelectedIndex = -1;

                // Ganti bagian cmbHasil
                cmbHasil.DataSource = null;
                cmbHasil.Items.Clear();
                cmbHasil.Items.Add("Proses");           // ← tambahan
                cmbHasil.Items.Add("Berhasil");
                cmbHasil.Items.Add("Sebagian Berhasil");
                cmbHasil.Items.Add("Gagal");
                cmbHasil.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbHasil.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Gagal memuat pilihan: " + ex.Message); }
            finally
            {
                sedangMuat = false;

            }
        }

        private void cmbHasil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sedangMuat) return;

            if (cmbHasil.Text == "Berhasil" && cmbIdRiwayat.SelectedValue != null)
            {
                try
                {
                    int idRiwayat = Convert.ToInt32(cmbIdRiwayat.SelectedValue);
                    RiwayatPenyakitBLL riwayatBLL = new RiwayatPenyakitBLL();
                    DataRow row = riwayatBLL.GetById(idRiwayat);

                    if (row != null && row["tanggalSelesai"] == DBNull.Value)
                    {
                        MessageBox.Show(
                            "Riwayat penyakit ini masih berlangsung!\n" +
                            "Tutup riwayat di Form Riwayat Penyakit terlebih dahulu.",
                            "Riwayat Masih Aktif",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbHasil.SelectedIndex = -1;
                    }
                }
                catch { }
            }
        }

        //otamatisasi text jenis perawatan
        private void txtJenisPerawatan_TextChanged(object sender, EventArgs e)
        {
            string perawatan = txtJenisPerawatan.Text.ToLower();

            // FITUR PINTAR: Jika mendeteksi kata kunci perawatan manual, arahkan ke Tanpa Pestisida
            if (perawatan.Contains("manual") || perawatan.Contains("cabut") ||
                perawatan.Contains("potong") || perawatan.Contains("fisik") ||
                perawatan.Contains("jaring") || perawatan.Contains("bersih"))
            {
                cmbJenisPestisida.Text = "Tanpa Pestisida";
            }
        }
        //Handler

        private void LoadData()
        {
            try
            {
                // Ambil data dari BLL dan set ke BindingSource
                DataTable dt = bllPerawatan.GetAll();
                bindingSource.DataSource = dt;
                dgvPerawatanPadi.DataSource = bindingSource;
                bindingNavigator1.BindingSource = bindingSource;

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
            cmbIdRiwayat.SelectedIndex = -1;
            txtJenisPerawatan.Clear();
            cmbJenisPestisida.SelectedIndex = -1;
            dtpTanggalPerawatan.Value = DateTime.Now;
            cmbHasil.SelectedIndex = -1;
            txtCari.Clear();
        }

        private bool ValidasiInput()
        {
            if (cmbIdRiwayat.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih ID padi!");
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

            if (cmbHasil.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih hasil perawatan!");
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

                bllPerawatan.GetAll();
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
                    MessageBox.Show("Masukkan data yang ingin dicari!"); return;
                }
                bindingSource.DataSource = bllPerawatan.Cari(txtCari.Text.Trim());
                dgvPerawatanPadi.DataSource = bindingSource;
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
                    Convert.ToInt32(cmbIdRiwayat.SelectedValue),
                    txtJenisPerawatan.Text,
                    cmbJenisPestisida.Text,
                    dtpTanggalPerawatan.Value,
                    cmbHasil.Text
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
            if (selectedIdPerawatanPadi == -1)
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
                    bool hasil = bllPerawatan.Ubah(
                        selectedIdPerawatanPadi,
                    Convert.ToInt32(cmbIdRiwayat.SelectedValue),
                    txtJenisPerawatan.Text.Trim(),
                    cmbJenisPestisida.Text,
                    dtpTanggalPerawatan.Value,
                    cmbHasil.Text
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
            if (selectedIdPerawatanPadi == -1)
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
                //pakai bindingSource untuk dapatkan data dari baris yang diklik
                DataRowView row = (DataRowView)bindingSource.Current;

                //harus sama dengan nama kolom di DataGridView
                selectedIdPerawatanPadi = Convert.ToInt32(row["idPerawatan"]);

                // Set nilai pada form berdasarkan data yang dipilih
                cmbIdRiwayat.SelectedValue = row["idRiwayat"];
                // Pastikan nama kolom di DataGridView sesuai dengan yang digunakan di sini
                txtJenisPerawatan.Text = row["jenisPerawatan"].ToString();
                cmbJenisPestisida.Text = row["jenisPestisida"].ToString();

                dtpTanggalPerawatan.Value = DateTime.ParseExact(
                    row["tanggalPerawatan"].ToString(), "dd/MM/yyyy", null);

                cmbHasil.Text = row["hasilPerawatan"].ToString();
            }

        }

        private void liblIdPadi_Click(object sender, EventArgs e)
        {

        }

        private void cmbIdRiwayat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvPerawatanPadi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
