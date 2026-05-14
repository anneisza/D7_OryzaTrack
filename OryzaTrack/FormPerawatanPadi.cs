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
        private int selectedIdPerawatanPadi;
        private PerawatanPadiBLL bllPerawatan = new PerawatanPadiBLL();
        private PadiBLL bllPadi = new PadiBLL();
        private PenyakitBLL bllPenyakit = new PenyakitBLL();
        public FormPerawatanPadi(int idAdmin)
        {
            InitializeComponent();
            IDAdmin = idAdmin;
        }

        private void FormPerawatanPadi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oryzaTrackDataSet2.v_ListHasil' table. You can move, or remove it, as needed.
            this.v_ListHasilTableAdapter.Fill(this.oryzaTrackDataSet2.v_ListHasil);
            // TODO: This line of code loads data into the 'viewpestisida.v_ListPestisida' table. You can move, or remove it, as needed.
            this.v_ListPestisidaTableAdapter.Fill(this.viewpestisida.v_ListPestisida);
            // TODO: This line of code loads data into the 'view_combo.v_ListKategori' table. You can move, or remove it, as needed.
            this.v_ListKategoriTableAdapter.Fill(this.view_combo.v_ListKategori);
            // TODO: This line of code loads data into the 'view_combo.v_ListBibit' table. You can move, or remove it, as needed.
            this.v_ListBibitTableAdapter.Fill(this.view_combo.v_ListBibit);
            // TODO: This line of code loads data into the 'oryzaTrackDataSet1.vw_Penyakit' table. You can move, or remove it, as needed.
            this.vw_PenyakitTableAdapter.Fill(this.oryzaTrackDataSet1.vw_Penyakit);
            // TODO: This line of code loads data into the 'oryzaTrackDataSet1.vw_Padi' table. You can move, or remove it, as needed.
            this.vw_PadiTableAdapter.Fill(this.oryzaTrackDataSet1.vw_Padi);
            // TODO: This line of code loads data into the 'oryzaTrackDataSet1.vw_PerawatanPadi' table. You can move, or remove it, as needed.
            this.vw_PerawatanPadiTableAdapter.Fill(this.oryzaTrackDataSet1.vw_PerawatanPadi);
            // Setting DataGridView saat form dibuka
            dgvPerawatanPadi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPerawatanPadi.MultiSelect = false;
            dgvPerawatanPadi.ReadOnly = true;
            dgvPerawatanPadi.AllowUserToAddRows = false;
            dgvPerawatanPadi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataTable dtPestisida = this.viewpestisida.v_ListPestisida;
            DataView dv = new DataView(dtPestisida);
            dv.RowFilter = "namaPestisida IS NOT NULL AND namaPestisida <> ''";
            cmbJenisPestisida.DataSource = dv;
            cmbJenisPestisida.DisplayMember = "namaPestisida";
            // Jika ada kolom ID (misal idPestisida), set ValueMember juga
            // cmbJenisPestisida.ValueMember = "idPestisida";
            cmbJenisPestisida.SelectedIndex = -1;

            //Daftarkan event cell click untuk DataGridView
            dgvPerawatanPadi.CellClick += dgvPerawatanPadi_CellClick;

            // Isi Dropdown Hasil Perawatan
            cmbHasil.DataSource = bllPerawatan.GetListHasil();
            cmbHasil.DisplayMember = "hasilPerawatan";
            cmbHasil.ValueMember = "hasilPerawatan";

            LoadPadi();
            LoadPenyakit();
            Bersihkan();

            //matiin tombol dulu, nanti diaktifkan setelah koneksi berhasil
            SetButtonsEnabled(false);
            Application.DoEvents();
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
            cmbIdPadi.SelectedIndex = -1;
            cmbIdPenyakit.SelectedIndex = -1;
            txtJenisPerawatan.Clear();
            cmbJenisPestisida.SelectedIndex = -1;
            dtpTanggalPerawatan.Value = DateTime.Now;
            cmbHasil.SelectedIndex = -1;
            txtCari.Clear();
        }

        private bool ValidasiInput()
        {
            if (cmbIdPadi.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih ID padi!");
                return false;
            }

            if (cmbIdPenyakit.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih ID penyakit!");
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
                    Convert.ToInt32(cmbIdPadi.SelectedValue),
                    Convert.ToInt32(cmbIdPenyakit.SelectedValue),
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
            if (selectedIdPerawatanPadi == 0)
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
                    Convert.ToInt32(cmbIdPadi.SelectedValue),
                    Convert.ToInt32(cmbIdPenyakit.SelectedValue),
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
            if (selectedIdPerawatanPadi == 0)
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
                cmbIdPadi.SelectedValue = row["idPadi"];
                cmbIdPenyakit.SelectedValue = row["idPenyakit"];
                // Pastikan nama kolom di DataGridView sesuai dengan yang digunakan di sini
                txtJenisPerawatan.Text = row["jenisPerawatan"].ToString();
                cmbJenisPestisida.Text = row["jenisPestisida"].ToString();

                dtpTanggalPerawatan.Value = DateTime.ParseExact(
                    row["tanggalPerawatan"].ToString(), "dd/MM/yyyy", null);

                cmbHasil.Text = row["hasilPerawatan"].ToString();
            }

        }
    }
}
