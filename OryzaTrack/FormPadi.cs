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

            LoadPetani();
        }

        // =====================
        // METHOD HELPER
        // =====================

        private void LoadData()
        {
            try
            {
                // Mengambil data dari PadiBLL
                dgvPadi.DataSource = bll.GetAll();
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
            cmbIdPetani.SelectedIndex = -1;
            cmbJB.SelectedIndex = -1;
            cmbLokasiLahan.SelectedIndex = -1;
            dtpTanggalTanam.Value = DateTime.Now;
        }

        private bool ValidasiInput()
        {
            //idPetani harus dipilih
            if (cmbIdPetani.SelectedIndex == -1) return true;

            //jenis benih harus dipilih
            if (cmbJB.SelectedIndex == -1) return true;

            //lokasi lahan harus dipilih
            if (cmbLokasiLahan.SelectedIndex == -1) return true;

            //tanggal tanam tidak boleh lebih dari hari ini dan kurang dari tahun 2000
            if (dtpTanggalTanam.Value > DateTime.Now || dtpTanggalTanam.Value.Year < 2000)
            {
                MessageBox.Show("Tanggal tanam tidak valid! Harus antara tahun 2000 dan hari ini.");
                dtpTanggalTanam.Focus();
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data petani: " + ex.Message);
            }
        }

        // =====================
        //     EVENT HANDLER
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

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCari.Text))
            {
                LoadData();
            }
            else
            {
                dgvPadi.DataSource = bll.Cari(txtCari.Text.Trim());
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
                    dgvPadi.DataSource = bll.Cari(txtCari.Text.Trim());
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

        private void btnUbahData_Click(object sender, EventArgs e)
        {
            if (selectedIdPadi == 0)
            {
                MessageBox.Show("Pilih data dari tabel yang ingin diubah terlebih dahulu!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                "Yakin ingin menghapus data penyakit ini?",
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
                DataGridViewRow row =  dgvPadi.Rows[e.RowIndex];
                selectedIdPadi = Convert.ToInt32(row.Cells["idPadi"].Value);
                cmbIdPetani.Text = row.Cells["idPetani"].Value.ToString();
                cmbJB.Text = row.Cells["jenisBibit"].Value.ToString();
                cmbLokasiLahan.Text = row.Cells["lokasiLahan"].Value.ToString();
                dtpTanggalTanam.Value = DateTime.Parse(row.Cells["tanggalTanam"].Value.ToString());
            }
        }



    }
}
