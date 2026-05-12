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
    public partial class FormLaporan : Form
    {
        // Instance semua BLL
        private PetaniBLL petaniBLL = new PetaniBLL();
        private PadiBLL padiBLL = new PadiBLL();
        private PenyakitBLL penyakitBLL = new PenyakitBLL();
        private RiwayatPenyakitBLL riwayatBLL = new RiwayatPenyakitBLL();
        private PerawatanPadiBLL perawatanBLL = new PerawatanPadiBLL();

        public FormLaporan()
        {
            InitializeComponent();
        }

        /*==============================
            FORM LOAD
        ================================*/
        private void FormLaporan_Load(object sender, EventArgs e)
        {
            // Isi ComboBox filter
            cmbKategori.Items.Clear();
            cmbKategori.Items.Add("Semua");
            cmbKategori.Items.Add("Hama");
            cmbKategori.Items.Add("Penyakit");
            cmbKategori.SelectedIndex = 0;

            cmbTingkatKerusakan.Items.Clear();
            cmbTingkatKerusakan.Items.Add("Semua");
            cmbTingkatKerusakan.Items.Add("Ringan");
            cmbTingkatKerusakan.Items.Add("Sedang");
            cmbTingkatKerusakan.Items.Add("Berat");
            cmbTingkatKerusakan.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Semua");
            cmbStatus.Items.Add("Aktif");
            cmbStatus.Items.Add("Nonaktif");
            cmbStatus.SelectedIndex = 0;

            // Set default rentang tanggal (awal tahun ini s/d hari ini)
            dtpTanggalAwal.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpTanggalAkhir.Value = DateTime.Now;

            // Muat semua data pertama kali
            MuatSemuaData();
        }

        /*==============================
            MUAT SEMUA DATA
        ================================*/
        private void MuatSemuaData()
        {
            MuatKartuRingkasan();
            MuatPetani();
            MuatPadi();
            MuatPenyakit();
            MuatRiwayat();
            MuatPerawatan();
        }

        /*==============================
            KARTU RINGKASAN (Label angka)
        ================================*/
        private void MuatKartuRingkasan()
        {
            try
            {
                labelPetani.Text = petaniBLL.Total().ToString();
                lblPadii.Text = padiBLL.Total().ToString();
                labelPenyakit.Text = penyakitBLL.Total().ToString();
                labelRiwayat.Text = riwayatBLL.Total().ToString();
                labelPerawatan.Text = perawatanBLL.Total().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat ringkasan: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*==============================
            TAB PETANI
        ================================*/
        private void MuatPetani()
        {
            try
            {
                string statusFilter = cmbStatus.SelectedItem?.ToString();
                DataTable dt;

                if (statusFilter == "Aktif")
                    dt = petaniBLL.GetAktif();
                else
                    dt = petaniBLL.GetAll();

                // Filter Nonaktif manual karena BLL tidak punya GetNonAktif
                if (statusFilter == "Nonaktif")
                {
                    DataView dv = new DataView(dt);
                    dv.RowFilter = "statusAktif = 0";
                    dt = dv.ToTable();
                }

                dgvPetani.DataSource = dt;
                AturKolomDgv(dgvPetani);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data petani: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*==============================
            TAB PADI
        ================================*/
        private void MuatPadi()
        {
            try
            {
                DataTable dt = padiBLL.GetAll();

                // Filter tanggal tanam
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format(
                    "tanggalTanam >= #{0}# AND tanggalTanam <= #{1}#",
                    dtpTanggalAwal.Value.ToString("MM/dd/yyyy"),
                    dtpTanggalAkhir.Value.ToString("MM/dd/yyyy")
                );
                dt = dv.ToTable();

                dgvPadi.DataSource = dt;
                AturKolomDgv(dgvPadi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data padi: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*==============================
            TAB PENYAKIT
        ================================*/
        private void MuatPenyakit()
        {
            try
            {
                DataTable dt = penyakitBLL.GetAll();
                DataView dv = new DataView(dt);

                // Bangun filter string
                List<string> filters = new List<string>();

                // Filter tanggal serangan
                filters.Add(string.Format(
                    "tanggalSerangan >= #{0}# AND tanggalSerangan <= #{1}#",
                    dtpTanggalAwal.Value.ToString("MM/dd/yyyy"),
                    dtpTanggalAkhir.Value.ToString("MM/dd/yyyy")
                ));

                // Filter kategori
                string kategori = cmbKategori.SelectedItem?.ToString();
                if (kategori != "Semua" && !string.IsNullOrEmpty(kategori))
                    filters.Add(string.Format("Kategori = '{0}'", kategori));

                // Filter tingkat kerusakan
                string tingkat = cmbTingkatKerusakan.SelectedItem?.ToString();
                if (tingkat != "Semua" && !string.IsNullOrEmpty(tingkat))
                    filters.Add(string.Format("tingkatKerusakan = '{0}'", tingkat));

                dv.RowFilter = string.Join(" AND ", filters);
                dt = dv.ToTable();

                dgvPenyakit.DataSource = dt;
                AturKolomDgv(dgvPenyakit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data penyakit: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*==============================
            TAB RIWAYAT PENYAKIT
        ================================*/
        private void MuatRiwayat()
        {
            try
            {
                DataTable dt = riwayatBLL.GetAll();
                DataView dv = new DataView(dt);

                // Filter tanggal terdeteksi
                List<string> filters = new List<string>();
                filters.Add(string.Format(
                    "tanggalTerdeteksi >= #{0}# AND tanggalTerdeteksi <= #{1}#",
                    dtpTanggalAwal.Value.ToString("MM/dd/yyyy"),
                    dtpTanggalAkhir.Value.ToString("MM/dd/yyyy")
                ));

                dv.RowFilter = string.Join(" AND ", filters);
                dt = dv.ToTable();

                dgvRiwayat.DataSource = dt;
                AturKolomDgv(dgvRiwayat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data riwayat: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*==============================
            TAB PERAWATAN PADI
        ================================*/
        private void MuatPerawatan()
        {
            try
            {
                DataTable dt = perawatanBLL.GetAll();
                DataView dv = new DataView(dt);

                // Filter tanggal perawatan
                List<string> filters = new List<string>();
                filters.Add(string.Format(
                    "tanggalPerawatan >= #{0}# AND tanggalPerawatan <= #{1}#",
                    dtpTanggalAwal.Value.ToString("MM/dd/yyyy"),
                    dtpTanggalAkhir.Value.ToString("MM/dd/yyyy")
                ));

                dv.RowFilter = string.Join(" AND ", filters);
                dt = dv.ToTable();

                dgvPerawatan.DataSource = dt;
                AturKolomDgv(dgvPerawatan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data perawatan: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*==============================
            HELPER: Atur tampilan DGV
        ================================*/
        private void AturKolomDgv(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /*==============================
            TOMBOL TAMPILKAN
        ================================*/
        private void buttonTampilkan_Click(object sender, EventArgs e)
        {
            // Validasi rentang tanggal
            if (dtpTanggalAwal.Value > dtpTanggalAkhir.Value)
            {
                MessageBox.Show("Tanggal awal tidak boleh lebih besar dari tanggal akhir!",
                    "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MuatSemuaData();
        }

        /*==============================
            TOMBOL RESET
        ================================*/
        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Reset semua filter ke default
            dtpTanggalAwal.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpTanggalAkhir.Value = DateTime.Now;
            cmbKategori.SelectedIndex = 0;
            cmbTingkatKerusakan.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;

            MuatSemuaData();
        }

        /*==============================
            EVENT HANDLERS (tidak dipakai,
            filter hanya lewat tombol Tampilkan)
        ================================*/
        private void dgvPetani_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvPadi_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvPenyakit_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvPerawatan_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void labelPadi_Click(object sender, EventArgs e) { }
        private void lblPadii_Click(object sender, EventArgs e) { }
        private void labelPenyakit_Click(object sender, EventArgs e) { }
        private void labelRiwayat_Click(object sender, EventArgs e) { }
        private void labelPerawatan_Click(object sender, EventArgs e) { }

        private void dtpTanggalAwal_ValueChanged(object sender, EventArgs e) { }
        private void dtpTanggalAkhir_ValueChanged(object sender, EventArgs e) { }
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbTingkatKerusakan_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}