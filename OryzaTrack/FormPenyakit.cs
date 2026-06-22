using System;
using System.Data;
using System.Windows.Forms;
using OryzaTrackBLL;

namespace OryzaTrack
{
    public partial class FormPenyakit : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private int selectedIdPenyakit = 0;
        private PenyakitBLL bll = new PenyakitBLL();
        private string oldKategori, oldGejala, oldTingkat;
        private DateTime oldTanggal;

        public FormPenyakit(int idAdmin)
        {
            InitializeComponent();
        }

        private void FormPenyakit_Load(object sender, EventArgs e)
        {
            dgvPenyakit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPenyakit.MultiSelect = false;
            dgvPenyakit.ReadOnly = true;
            dgvPenyakit.AllowUserToAddRows = false;
            dgvPenyakit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPenyakit.CellClick += dgvPenyakit_CellClick;
            // 1. Mengisi pilihan Kategori Penyakit
            cmbKategori.Items.Clear();
            cmbKategori.Items.Add("Hama");
            cmbKategori.Items.Add("Penyakit");

            // 2. Mengisi pilihan Tingkat Kerusakan
            cmbTingkatKerusakan.Items.Clear();
            cmbTingkatKerusakan.Items.Add("Ringan");
            cmbTingkatKerusakan.Items.Add("Sedang");
            cmbTingkatKerusakan.Items.Add("Berat");
            cmbTingkatKerusakan.DropDownStyle = ComboBoxStyle.DropDownList; // Mengunci inputan hanya dari list


            BersihkanForm();

            SetButtonsEnabled(false);
            Application.DoEvents();
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = bll.GetAll();
                bindingSource.DataSource = dt;
                dgvPenyakit.DataSource = bindingSource;
                bindingNavigator1.BindingSource = bindingSource;
                TampilkanTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TampilkanTotal()
        {
            lblTotal.Text = "Total Data: " + bll.Total();
        }

        private void BersihkanForm()
        {
            selectedIdPenyakit = 0;
            cmbKategori.SelectedIndex = -1;
            txtGejalaPenyakit.Clear();
            cmbTingkatKerusakan.SelectedIndex = -1;
            dtpTanggalSerangan.Value = DateTime.Now;
            txtCari.Clear();
        }

        private bool ValidasiInput()
        {
            if (cmbKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Kategori harus dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbKategori.Focus(); return false;
            }
            if (cmbTingkatKerusakan.SelectedIndex == -1)
            {
                MessageBox.Show("Tingkat kerusakan harus dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTingkatKerusakan.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(txtGejalaPenyakit.Text))
            {
                MessageBox.Show("Gejala penyakit tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGejalaPenyakit.Focus(); return false;
            }
            if (txtGejalaPenyakit.Text.Trim().Length < 10)
            {
                MessageBox.Show("Gejala penyakit terlalu pendek (minimal 10 karakter)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGejalaPenyakit.Focus(); return false;
            }
            if (dtpTanggalSerangan.Value.Year < 2000 || dtpTanggalSerangan.Value > DateTime.Now)
            {
                MessageBox.Show("Tanggal serangan tidak valid! Harus antara tahun 2000 hingga hari ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void SetButtonsEnabled(bool status)
        {
            btnLoadData.Enabled = status;
            btnTambahData.Enabled = status;
            btnUbahData.Enabled = status;
            btnHapusData.Enabled = status;
            btnBersihkan.Enabled = status;
            btnCariData.Enabled = status;
        }

        private void btnKoneksi_Click(object sender, EventArgs e)
        {
            try
            {
                bll.GetAll();
                MessageBox.Show("Database Terkoneksi!", "Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { SetButtonsEnabled(true); }
        }

        private void btnLoadData_Click(object sender, EventArgs e) => LoadData();

        private void btnTambahData_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;
            try
            {
                bool hasil = bll.Tambah(
                    cmbKategori.Text.Trim(),
                    txtGejalaPenyakit.Text.Trim(),
                    cmbTingkatKerusakan.Text.Trim(),
                    dtpTanggalSerangan.Value);

                if (hasil)
                {
                    MessageBox.Show("Data penyakit berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BersihkanForm();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbahData_Click(object sender, EventArgs e)
        {
            if (selectedIdPenyakit == 0)
            {
                MessageBox.Show("Pilih data yang ingin diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbKategori.Text == oldKategori &&
                txtGejalaPenyakit.Text.Trim() == oldGejala &&
                cmbTingkatKerusakan.Text == oldTingkat &&
                dtpTanggalSerangan.Value == oldTanggal)
            {
                MessageBox.Show("Tidak ada perubahan data untuk diperbarui.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidasiInput()) return;

            DialogResult konfirmasi = MessageBox.Show("Yakin ingin mengubah data penyakit ini?",
                "Konfirmasi Ubah", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    string hasil = bll.Ubah(selectedIdPenyakit,
                        cmbKategori.Text.Trim(),
                        txtGejalaPenyakit.Text.Trim(),
                        cmbTingkatKerusakan.Text.Trim(),
                        dtpTanggalSerangan.Value);

                    if (hasil == "OK")
                        MessageBox.Show("Data penyakit berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (hasil.StartsWith("PERINGATAN"))
                        MessageBox.Show(hasil, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // FIX: BersihkanForm dan LoadData hanya dipanggil sekali di sini
                    BersihkanForm();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHapusData_Click(object sender, EventArgs e)
        {
            if (selectedIdPenyakit == 0)
            {
                MessageBox.Show("Pilih data dari tabel yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show("Yakin ingin menghapus data penyakit ini?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    bool hasil = bll.Hapus(selectedIdPenyakit);
                    if (hasil)
                    {
                        MessageBox.Show("Data penyakit berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BersihkanForm();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBersihkan_Click(object sender, EventArgs e) => BersihkanForm();

        private void txtCari_TextChanged(object sender, EventArgs e) { }

        // FIX: lewat bindingSource
        private void btnCariData_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCari.Text))
                {
                    MessageBox.Show("Masukkan kata kunci untuk mencari data penyakit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bindingSource.DataSource = bll.Cari(txtCari.Text.Trim());
                dgvPenyakit.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPenyakit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRowView row = (DataRowView)bindingSource.Current;
                selectedIdPenyakit = Convert.ToInt32(row["idPenyakit"]);

                cmbKategori.Text = oldKategori = row["kategori"].ToString();
                txtGejalaPenyakit.Text = oldGejala = row["gejalaPenyakit"].ToString();
                cmbTingkatKerusakan.Text = oldTingkat = row["tingkatKerusakan"].ToString();
                dtpTanggalSerangan.Value = oldTanggal = DateTime.ParseExact(
                    row["tanggalSerangan"].ToString(), "dd/MM/yyyy", null);
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
{

}

private void cmbTingkatKerusakan_SelectedIndexChanged(object sender, EventArgs e)
{

}
    }
}