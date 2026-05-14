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
            // TODO: This line of code loads data into the 'view_combo.v_ListKategori' table. You can move, or remove it, as needed.
            this.v_ListKategoriTableAdapter.Fill(this.view_combo.v_ListKategori);
            // TODO: This line of code loads data into the 'view_combo.v_ListBibit' table. You can move, or remove it, as needed.
            this.v_ListBibitTableAdapter.Fill(this.view_combo.v_ListBibit);
            // TODO: This line of code loads data into the 'oryzaTrackDataSet1.vw_RiwayatPenyakit' table. You can move, or remove it, as needed.
            this.vw_RiwayatPenyakitTableAdapter.Fill(this.oryzaTrackDataSet1.vw_RiwayatPenyakit);
            // TODO: This line of code loads data into the 'oryzaTrackDataSet1.vw_Padi' table. You can move, or remove it, as needed.
            this.vw_PadiTableAdapter.Fill(this.oryzaTrackDataSet1.vw_Padi);
            // TODO: This line of code loads data into the 'oryzaTrackDataSet1.vw_Penyakit' table. You can move, or remove it, as needed.
            this.vw_PenyakitTableAdapter.Fill(this.oryzaTrackDataSet1.vw_Penyakit);
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
                    .Where(row => !string.IsNullOrWhiteSpace(row.Field<string>("jenisBibit")))
                    .GroupBy(row => row.Field<string>("jenisBibit").Trim())
                    .Select(g => new {
                        idPadi = g.First().Field<int>("idPadi"),
                        jenisBibit = g.Key
                    })
                    .ToList();

                cmbIdPadi.DataSource = listBibit;
                cmbIdPadi.DisplayMember = "jenisBibit";
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
                DataTable dt = bllPenyakit.GetAll();
                var listKategori = dt.AsEnumerable()
                    .Where(row => !string.IsNullOrWhiteSpace(row.Field<string>("Kategori")))
                    .GroupBy(row => row.Field<string>("Kategori").Trim())
                    .Select(g => new {
                        idPenyakit = g.First().Field<int>("idPenyakit"),
                        Kategori = g.Key
                    })
                    .ToList();

                cmbIdPenyakit.DataSource = listKategori;
                cmbIdPenyakit.DisplayMember = "Kategori";
                cmbIdPenyakit.ValueMember = "idPenyakit";
                cmbIdPenyakit.SelectedIndex = -1;
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
                if (tglSelesaiStr == "Belum Selesai")
                {
                    chkSelesai.Checked = false;      // ini akan trigger event → dtp disable
                                                     // Jangan panggil dtpTanggalSelesai.Enabled = false; karena sudah di event
                    dtpTanggalSelesai.Value = DateTime.Now;
                }
                else
                {
                    chkSelesai.Checked = true;       // trigger event → dtp enable
                    dtpTanggalSelesai.Value = DateTime.ParseExact(tglSelesaiStr, "dd/MM/yyyy", null);
                }

                txtKeterangan.Text = oldKeterangan = row["keterangan"].ToString();
            }
        }

       
    }
}
