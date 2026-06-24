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
using ExcelDataReader;
using System.IO;

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
            catch(SqlException ex)
            {
                bll.SimpanLog("Tabel Petani", ex.Message);
                MessageBox.Show("SQL Error : " + ex.Message);
            }
            catch (Exception ex)
            {
                bll.SimpanLog("General System", ex.Message);
                MessageBox.Show("General Error: " + ex.Message,
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
            catch (SqlException ex)

            {

                bll.SimpanLog("Tabel Petani", ex.Message);

                MessageBox.Show("SQL Error : " + ex.Message);

            }

            catch (Exception ex)

            {

                bll.SimpanLog("General System", ex.Message);

                MessageBox.Show("General Error: " + ex.Message,

                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                catch (SqlException ex)
                {
                    bll.SimpanLog("Tabel Petani", ex.Message);
                    MessageBox.Show("SQL Error : " + ex.Message);
                }
                catch (Exception ex)
                {
                    bll.SimpanLog("General System", ex.Message);
                    MessageBox.Show("General Error: " + ex.Message,
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
                catch (SqlException ex)

                {

                    bll.SimpanLog("Tabel Petani", ex.Message);

                    MessageBox.Show("SQL Error : " + ex.Message);

                }

                catch (Exception ex)

                {

                    bll.SimpanLog("General System", ex.Message);

                    MessageBox.Show("General Error: " + ex.Message,

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
                    "Isi txtCari dulu!\n\nContoh: ' OR '1'='1' --",
                    "Petunjuk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tampilkan query yang akan dijalankan
            string queryInfo =
                "DELETE FROM petani WHERE namaPetani = '" + inputBerbahaya + "'";

            MessageBox.Show(
                "⚠️ Query berbahaya yang akan dijalankan:\n\n" + queryInfo,
                "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            try
            {
                // Jalankan DELETE rentan
                bll.HapusRentan(inputBerbahaya);

                // Refresh grid → data kosong
                LoadData();

                // Tampilkan popup seram
                FormHacked formHacked = new FormHacked();
                formHacked.ShowDialog();
            }
            catch (SqlException ex)

            {

                bll.SimpanLog("Tabel Petani", ex.Message);

                MessageBox.Show("SQL Error : " + ex.Message);

            }

            catch (Exception ex)

            {

                bll.SimpanLog("General System", ex.Message);

                MessageBox.Show("General Error: " + ex.Message,

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
                catch (SqlException ex)

                {

                    bll.SimpanLog("Tabel Petani", ex.Message);

                    MessageBox.Show("SQL Error : " + ex.Message);

                }

                catch (Exception ex)

                {
                    bll.SimpanLog("General System", ex.Message);

                    MessageBox.Show("General Error: " + ex.Message,

                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Button buat import excel
        private DataTable dtPreviewImport;

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Excel Workbook|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (var reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                var result = reader.AsDataSet();
                                DataTable dtSheet = result.Tables[0];

                                // Buat struktur DataTable baru untuk menampung preview sesuai kolom di modul
                                dtPreviewImport = new DataTable();
                                foreach (DataColumn col in dtSheet.Columns)
                                {
                                    // Mengambil baris pertama (index 0) sebagai nama kolom
                                    dtPreviewImport.Columns.Add(dtSheet.Rows[0][col].ToString());
                                }

                                // Melakukan perulangan untuk memasukkan data baris ke-2 dst (index 1 ke atas)
                                for (int i = 1; i < dtSheet.Rows.Count; i++)
                                {
                                    dtPreviewImport.Rows.Add(dtSheet.Rows[i].ItemArray);
                                }

                                // Tampilkan ke DataGridView
                                dgvPetani.DataSource = dtPreviewImport;
                                dgvPetani.Enabled = false; // preview only, belum masuk DB

                                // Atur status tombol UI sesuai ketentuan
                                btnImportDb.Enabled = true;
                                btnTambahData.Enabled = false;
                                btnUbahData.Enabled = false;
                                btnHapusData.Enabled = false;
                            }
                        }
                    }
                    catch (SqlException ex)

                    {

                        bll.SimpanLog("Tabel Petani", ex.Message);

                        MessageBox.Show("SQL Error : " + ex.Message);

                    }

                    catch (Exception ex)

                    {

                        bll.SimpanLog("General System", ex.Message);

                        MessageBox.Show("General Error: " + ex.Message,

                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }

        }

        private void btnImportDb_Click(object sender, EventArgs e)
        {
            if (dtPreviewImport == null || dtPreviewImport.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk diimport.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Mengikuti variabel penghitung sesuai modul (baris 17)
            int barisBerhasil = 0;

            // 2. Lakukan perulangan untuk menyimpan data ke database (baris 19)
            foreach (DataRow row in dtPreviewImport.Rows)
            {
                try
                {
                    // Ambil data berdasarkan index posisi kolom di Excel secara berurutan
                    string nama = row[0].ToString().Trim();
                    string nik = row[1].ToString().Trim();
                    string alamat = row[2].ToString().Trim();
                    string telp = row[3].ToString().Trim();
                    bool statusAktif = true; // Default aktif saat diimport

                    // Validasi dasar agar data kosong di baris terbawah excel tidak ikut masuk
                    if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(nik))
                        continue;

                    // Panggil method Tambah dari objek bll Petani kamu
                    bool hasil = bll.Tambah(nama, nik, alamat, telp, statusAktif);

                    if (hasil)
                    {
                        barisBerhasil++;
                    }
                }
                catch (SqlException ex)
                {
                    bll.SimpanLog("Tabel Petani", ex.Message);
                    MessageBox.Show("SQL Error : " + ex.Message);
                }
                catch (Exception ex)
                {
                    bll.SimpanLog("General System", ex.Message);
                    MessageBox.Show("General Error: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
            }

            // 3. Pesan Box sukses 
            MessageBox.Show(barisBerhasil + " data berhasil disimpan ke database.",
                "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 4. Kembalikan status tombol UI ke kondisi normal
            btnImportDb.Enabled = false;
            btnTambahData.Enabled = true;
            btnUbahData.Enabled = true;
            btnHapusData.Enabled = true;
            dgvPetani.Enabled = true;

            // 5. Refresh DataGridView utama menggunakan method LoadData milikmu
            LoadData();
        }

        private void btnMasifUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bll.TestMassUpdate();
                MessageBox.Show("Update berhasil tanpa trigger.", "Normal",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                // Trigger akan ROLLBACK dan RAISERROR
                MessageBox.Show("⚠️ " + ex.Message,
                    "Trigger Aktif!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Cek LogKeamanan
                MessageBox.Show("Update massal dicegah!\nLog keamanan telah dicatat.",
                    "Trigger PreventMassUpdate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            catch (SqlException ex)
            {
                bll.SimpanLog("Tabel Petani", ex.Message);
                MessageBox.Show("SQL Error : " + ex.Message);
            }
            catch (Exception ex)
            {
                bll.SimpanLog("General System", ex.Message);
                MessageBox.Show("General Error: " + ex.Message,
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
