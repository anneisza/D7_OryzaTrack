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
    public partial class FormPadi : Form
    {
        private BindingSource bindingSource = new BindingSource();

        private int selectedIdPadi = 0;
        private int IDAdmin;
        private PadiBLL bll = new PadiBLL();
        public FormPadi(int idAdmin)
        {
            InitializeComponent();
            IDAdmin = idAdmin;
        }

        private void FormPadi_Load(object sender, EventArgs e)
        {

            // Setting DataGridView saat form dibuka
            dgvPadi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPadi.MultiSelect = false;
            dgvPadi.ReadOnly = true;
            dgvPadi.AllowUserToAddRows = false;
            dgvPadi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Daftarkan event CellClick
            dgvPadi.CellClick += dgvPadi_CellClick;

            // 1. Mengisi pilihan Jenis Bibit Padi (Sesuai CK_Padi_JenisBibit)
            cmbJB.Items.Clear();
            cmbJB.Items.Add("IR64");
            cmbJB.Items.Add("Ciherang");
            cmbJB.Items.Add("Inpari 32");
            cmbJB.Items.Add("Mekongga");
            // AKTIFKAN FITUR PENCARIAN & SCROLL UNTUK JENIS BIBIT
            cmbJB.DropDownStyle = ComboBoxStyle.DropDown;
            cmbJB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbJB.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbJB.DropDownHeight = 150;

            // 2. Mengisi pilihan Lokasi Lahan (Sesuai CK_Padi_LokasiLahan)
            cmbLokasiLahan.Items.Clear();
            cmbLokasiLahan.Items.Add("Lahan Utara");
            cmbLokasiLahan.Items.Add("Lahan Selatan");
            cmbLokasiLahan.Items.Add("Lahan Barat");
            cmbLokasiLahan.Items.Add("Lahan Timur");
            // AKTIFKAN FITUR PENCARIAN & SCROLL UNTUK LOKASI LAHAN
            cmbLokasiLahan.DropDownStyle = ComboBoxStyle.DropDown;
            cmbLokasiLahan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbLokasiLahan.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbLokasiLahan.DropDownHeight = 150;

            LoadPetani();
            BersihkanForm();

            //matiin tombol sampai koneksi berhasil
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
                DataTable dt = bll.GetAll();
                bindingSource.DataSource = dt;
                dgvPadi.DataSource = bindingSource;
                bindingNavigator1.BindingSource = bindingSource; // hubungkan navigator
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
            selectedIdPadi = 0;
            cmbIdPetani.SelectedIndex = -1;
            cmbJB.SelectedIndex = -1;
            cmbLokasiLahan.SelectedIndex = -1;
            dtpTanggalTanam.Value = DateTime.Now;
        }

        private bool ValidasiInput()
        {
            if (cmbIdPetani.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih Petani terlebih dahulu!");
                return false;
            }
            if (cmbJB.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih Jenis Bibit!");
                return false;
            }
            if (cmbLokasiLahan.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih Lokasi Lahan!");
                return false;
            }

            if (dtpTanggalTanam.Value > DateTime.Now || dtpTanggalTanam.Value.Year < 2000)
            {
                MessageBox.Show("Tanggal tanam tidak valid!");
                return false;
            }
            return true;
        }

        //combobox id petani diisi dengan data petani dari database
        private void LoadPetani()
        {
            try
            {
                PetaniBLL petaniBLL = new PetaniBLL();

                // Ambil GetAktif()
                cmbIdPetani.DataSource = petaniBLL.GetAktif();

                cmbIdPetani.DisplayMember = "namaPetani";
                cmbIdPetani.ValueMember = "idPetani";
                cmbIdPetani.SelectedIndex = -1;

                // fitur auto search dan scroll bar
                cmbIdPetani.DropDownStyle = ComboBoxStyle.DropDown;
                cmbIdPetani.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbIdPetani.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmbIdPetani.MaxDropDownItems = 10;
                cmbIdPetani.DropDownHeight = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data petani: " + ex.Message);
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
                    MessageBox.Show("Masukkan kata kunci pencarian!",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
                bindingSource.DataSource = bll.Cari(txtCari.Text.Trim());
                dgvPadi.DataSource = bindingSource;
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
                    Convert.ToInt32(cmbIdPetani.SelectedValue),
                    cmbJB.Text.Trim(),
                    cmbLokasiLahan.Text.Trim(),
                    dtpTanggalTanam .Value
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

        // Tambah variabel data lama
        private string oldJenisBibit, oldLokasiLahan;
        private int oldIdPetani;
        private DateTime oldTanggalTanam;

        private void btnUbahData_Click(object sender, EventArgs e)
        {

            if (selectedIdPadi == 0)
            {
                MessageBox.Show("Pilih data yang ingin diubah!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Cek apakah ada perubahan
            if (Convert.ToInt32(cmbIdPetani.SelectedValue) == oldIdPetani &&
                cmbJB.Text == oldJenisBibit &&
                cmbLokasiLahan.Text == oldLokasiLahan &&
                dtpTanggalTanam.Value.Date == oldTanggalTanam.Date)
            {
                MessageBox.Show("Tidak ada data yang diubah.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        selectedIdPadi,
                        Convert.ToInt32(cmbIdPetani.SelectedValue),
                        cmbJB.Text.Trim(),
                        cmbLokasiLahan.Text.Trim(),
                        dtpTanggalTanam.Value
                    );

                    if (hasil)
                    {
                        MessageBox.Show("Data padi berhasil diubah!",
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
            if (selectedIdPadi == 0)
            {
                MessageBox.Show("Pilih data dari tabel yang ingin dihapus!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data padi ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    bool hasil = bll.Hapus(selectedIdPadi);
                    if (hasil)
                    {
                        MessageBox.Show("Data padi berhasil dihapus!",
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

        private void dgvPadi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRowView row = (DataRowView)bindingSource.Current;
                selectedIdPadi = Convert.ToInt32(row["idPadi"]);

                cmbIdPetani.SelectedValue = row["idPetani"];
                cmbJB.Text = row["jenisBibit"].ToString();
                cmbLokasiLahan.Text = row["lokasiLahan"].ToString();
                dtpTanggalTanam.Value = DateTime.ParseExact(
                    row["tanggalTanam"].ToString(), "dd/MM/yyyy", null);

                // ✅ Simpan data lama
                oldIdPetani = Convert.ToInt32(row["idPetani"]);
                oldJenisBibit = row["jenisBibit"].ToString();
                oldLokasiLahan = row["lokasiLahan"].ToString();
                oldTanggalTanam = dtpTanggalTanam.Value;
            }
        }



    }
}
