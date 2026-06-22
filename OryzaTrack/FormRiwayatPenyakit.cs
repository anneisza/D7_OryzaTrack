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
        //binding
        private BindingSource bindingSource = new BindingSource();

        private int IDAdmin;
        private int selectedIdRiwayatPenyakit = 0; // Menyimpan ID riwayat penyakit yang dipilih
        private RiwayatPenyakitBLL bll = new RiwayatPenyakitBLL();
        PadiBLL bllPadi = new PadiBLL();
        PenyakitBLL bllPenyakit = new PenyakitBLL();
        //var data lama untuk validasi perubahan
        private int oldIdPadi, oldIdPenyakit;
        private DateTime oldTglDeteksi;
        private DateTime? oldTglSelesai;
        private string oldKeterangan;
        public FormRiwayatPenyakit(int idAdmin)
        {
            InitializeComponent();
            IDAdmin = idAdmin;
            // Pasang event secara manual (pasti terpanggil)
            chkSelesai.CheckedChanged += chkSelesai_CheckedChanged;
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

            // Daftarkan event checkbox secara eksplisit di Load
            chkSelesai.CheckedChanged += chkSelesai_CheckedChanged;

            // Set kondisi awal dtpTanggalSelesai
            dtpTanggalSelesai.Enabled = false;

            btnLoadData.Enabled = false; // Disable tombol load data sampai koneksi dicek
            LoadPadi();
            LoadPenyakit();
            BersihkanForm();

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
                //binding source 
                DataTable dt = bll.GetAll();
                bindingSource.DataSource = dt;
                dgvRiwayat.DataSource = bindingSource;
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
            // Menampilkan total record penyakit
            lblTotal.Text = "Total Data: " + bll.Total();
        }

        private void BersihkanForm()
        {
            selectedIdRiwayatPenyakit = 0;
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
            if (chkSelesai.Checked)
            {
                if (dtpTanggalSelesai.Value < dtpTanggalTerdeteksi.Value)
                {
                    MessageBox.Show("Tanggal Selesai tidak boleh sebelum Tanggal Terdeteksi.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                // FIX: tidak boleh lebih dari hari ini
                if (dtpTanggalSelesai.Value > DateTime.Now)
                {
                    MessageBox.Show("Tanggal Selesai tidak boleh melebihi hari ini.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (string.IsNullOrWhiteSpace(txtKeterangan.Text) || txtKeterangan.Text.Trim().Length < 5)
            {
                MessageBox.Show("Keterangan minimal harus 5 karakter!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        //checkbox Selesai mengontrol enable/disable dtpTanggalSelesai
        private void chkSelesai_CheckedChanged(object sender, EventArgs e)
        {
            dtpTanggalSelesai.Enabled = chkSelesai.Checked;
            if (!chkSelesai.Checked)
            {
                dtpTanggalSelesai.Value = DateTime.Now; // reset value
            }
        }

        //combo box untuk id padi
        private void LoadPadi()
        {
            try
            {
                DataTable dt = bllPadi.GetAll();
                // Filter data unik berdasarkan jenisBibit, buang baris kosong/null
                var listBibit = dt.AsEnumerable()
                                    .Where(row => row["idPadi"] != DBNull.Value && !string.IsNullOrWhiteSpace(row["jenisBibit"].ToString()))
                                    .Select(row => new {
                                        idPadi = Convert.ToInt32(row["idPadi"]),
                                        // Menampilkan format: "IR64 (ID: 1)" supaya informatif dan menghindari bug duplikasi nama
                                        DisplayTeks = $"{row["jenisBibit"].ToString().Trim()} (ID: {row["idPadi"]})"
                                    })
                                    .ToList();

                cmbIdPadi.DataSource = listBibit;
                cmbIdPadi.DisplayMember = "DisplayTeks";
                cmbIdPadi.ValueMember = "idPadi";   // ← harus idPadi, bukan string
                cmbIdPadi.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Gagal load padi: " + ex.Message); }
        }

        //combo box untuk id penyakit
        private void LoadPenyakit()
        {
            try
            {
                // Ambil data dari BLL Penyakit
                PenyakitBLL penyakitBLL = new PenyakitBLL();
                DataTable dtPenyakit = penyakitBLL.GetAll();
                DataTable dt = bllPenyakit.GetAll();
                //gejala : id penyakit
                dtPenyakit.Columns.Add("DisplayForm", typeof(string), "gejalaPenyakit + ' (ID: ' + idPenyakit + ')'");

                cmbIdPenyakit.DataSource = dtPenyakit;
                cmbIdPenyakit.DisplayMember = "DisplayForm";
                cmbIdPenyakit.ValueMember = "idPenyakit";
                cmbIdPenyakit.SelectedIndex = -1;
                cmbIdPenyakit.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex) { MessageBox.Show("Gagal load penyakit: " + ex.Message); }
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
                bindingSource.DataSource = bll.Cari(txtCari.Text.Trim());
                dgvRiwayat.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
                // kirim null jika checkbox tidak dicentang
                DateTime? tglSelesai = chkSelesai.Checked ? dtpTanggalSelesai.Value : (DateTime?)null;

                bool hasil = bll.Tambah(
                    Convert.ToInt32(cmbIdPadi.SelectedValue),
                    Convert.ToInt32(cmbIdPenyakit.SelectedValue),
                    dtpTanggalTerdeteksi.Value,
                    tglSelesai,
                    txtKeterangan.Text.Trim());

                if (hasil)
                {
                    MessageBox.Show("Data riwayat penyakit berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnUbahData_Click(object sender, EventArgs e)
        {
            if (selectedIdRiwayatPenyakit == 0)
            {
                MessageBox.Show("Pilih data dari tabel yang ingin diubah!",
                    "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; }

            // VALIDASI: Apakah user benar-benar mengubah sesuatu?
            DateTime? tglSelesaiBaru = chkSelesai.Checked ? dtpTanggalSelesai.Value.Date : (DateTime?)null;
            DateTime? tglSelesaiLama = oldTglSelesai.HasValue ? oldTglSelesai.Value.Date : (DateTime?)null;

            if (Convert.ToInt32(cmbIdPadi.SelectedValue) == oldIdPadi &&
                Convert.ToInt32(cmbIdPenyakit.SelectedValue) == oldIdPenyakit &&
                dtpTanggalTerdeteksi.Value.Date == oldTglDeteksi.Date &&
                tglSelesaiBaru == tglSelesaiLama &&
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
                        tglSelesaiBaru,
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
                DataRowView row = (DataRowView)bindingSource.Current;
                selectedIdRiwayatPenyakit = Convert.ToInt32(row["idRiwayat"]);

                // TIPS: Jangan gunakan .Text jika datanya dari hasil JOIN. 
                // Gunakan pencarian index berdasarkan value asli jika memungkinkan.
                cmbIdPadi.SelectedValue = row["idPadi"];
                cmbIdPenyakit.SelectedValue = row["idPenyakit"];

                // Simpan data lama untuk validasi redundansi
                oldIdPadi = Convert.ToInt32(row["idPadi"]);
                oldIdPenyakit = Convert.ToInt32(row["idPenyakit"]);

                // tanggalTerdeteksi dari VIEW berupa string DD/MM/YYYY
                dtpTanggalTerdeteksi.Value = oldTglDeteksi = DateTime.ParseExact(
                    row["tanggalTerdeteksi"].ToString(), "dd/MM/yyyy", null);


                // tanggalSelesai bisa "Belum Selesai" (dari CASE di VIEW)
                string tglSelesaiStr = row["tanggalSelesai"].ToString();
                if (tglSelesaiStr == "Belum Selesai" || string.IsNullOrEmpty(tglSelesaiStr))
                {
                    chkSelesai.Checked = false;
                    dtpTanggalSelesai.Value = DateTime.Now;
                    oldTglSelesai = null; // <-- WAJIB set null ke variabel lamanya agar sinkron dengan database lama
                }
                else
                {
                    chkSelesai.Checked = true;
                    dtpTanggalSelesai.Value = DateTime.ParseExact(tglSelesaiStr, "dd/MM/yyyy", null);
                    oldTglSelesai = dtpTanggalSelesai.Value; // <-- Isi dengan tanggal aslinya
                }

                txtKeterangan.Text = oldKeterangan = row["keterangan"].ToString();
            }
        }

       
    }
}
