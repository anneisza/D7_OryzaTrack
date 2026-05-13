using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
        private LaporanBLL laporanBLL = new LaporanBLL();

        public FormLaporan()
        {
            InitializeComponent();
        }

        /*==============================
            FORM LOAD
        ================================*/
        private void FormLaporan_Load(object sender, EventArgs e)
        {
            // Set Default Tanggal
            dtpTanggalAwal.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpTanggalAkhir.Value = DateTime.Now;

            // Inisialisasi ComboBox (Sesuaikan dengan data di DB)
            MuatFilterComboBox();

            MuatSemuaData();
        }

        //filter combo box untuk jenis bibit dan jenis penyakit
        private void MuatFilterComboBox()
        {
            try
            {
                // --- Filter Kategori (Hama/Penyakit) ---
                cmbJenisPenyakit.Items.Clear();
                cmbJenisPenyakit.Items.Add("Semua");
                cmbJenisPenyakit.Items.Add("Hama");
                cmbJenisPenyakit.Items.Add("Penyakit");
                cmbJenisPenyakit.SelectedIndex = 0; // Pilih "Semua" sebagai default

                // --- Filter Jenis Bibit (Dari Database + "Semua") ---
                DataTable dtPadi = padiBLL.GetAll();
                cmbJenisBibit.Items.Clear();
                cmbJenisBibit.Items.Add("Semua");

                // Pakai HashSet supaya tidak ada duplikat
                HashSet<string> bibitSudahAda = new HashSet<string>();
                foreach (DataRow row in dtPadi.Rows)
                {
                    string bibit = row["jenisBibit"].ToString();
                    if (!bibitSudahAda.Contains(bibit))
                    {
                        cmbJenisBibit.Items.Add(bibit);
                        bibitSudahAda.Add(bibit);
                    }
                }
                cmbJenisBibit.SelectedIndex = 0; // Pilih "Semua" sebagai default
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat filter: " + ex.Message);
            }
        }

        //muat semua data
        private void MuatSemuaData()
        {
            MuatKartuRingkasan();
            MuatLaporanUtama(); // Menggantikan MuatPetani, MuatPadi, dll
            MuatPieChart();     // Fungsi baru untuk grafik
        }

        //muat kartu ringkasan
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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void MuatLaporanUtama()
        {
            try
            {
                string jenisBibit = cmbJenisBibit.Text;
                string kategori = cmbJenisPenyakit.Text;

                // sp_GetLaporan dipanggil dari sini via LaporanBLL → LaporanDAL
                DataTable dt = laporanBLL.GetLaporan(
                    dtpTanggalAwal.Value,
                    dtpTanggalAkhir.Value,
                    jenisBibit,
                    kategori
                );

                dgvLaporan.DataSource = dt; // langsung, tanpa DataView
                AturKolomDgv(dgvLaporan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memfilter data: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MuatPieChart()
        {
            try
            {
                DataTable dt = riwayatBLL.GetStatistikPenyakit();

                // Cek jika data kosong, jangan lanjut biar tidak error
                if (dt == null || dt.Rows.Count == 0) return;

                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.Titles.Add("Sebaran Penyakit Padi");

                Series s = new Series("Penyakit");
                s.ChartType = SeriesChartType.Pie;

                foreach (DataRow row in dt.Rows)
                {
                    // Pastikan row["Total"] dikonversi ke double/int
                    double jumlah = Convert.ToDouble(row["Total"]);
                    string nama = row["kategori"].ToString();

                    s.Points.AddXY(nama, jumlah);
                }

                // Tampilkan angka/persentase di dalam Pie
                s.IsValueShownAsLabel = true;
                s.LabelFormat = "0"; // Menampilkan jumlah angka bulat

                chart1.Series.Add(s);
                chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
            catch (Exception ex)
            {
                // Jangan cuma Console.WriteLine, MessageBox saja biar kelihatan errornya
                MessageBox.Show("Gagal muat Chart: " + ex.Message);
            }
        }


        /*==============================
            TOMBOL TAMPILKAN
        ================================*/
        private void buttonTampilkan_Click(object sender, EventArgs e)
        {

            MuatSemuaData();
        }

        /*==============================
            TOMBOL RESET
        ================================*/
        private void buttonReset_Click(object sender, EventArgs e)
        {
            cmbJenisBibit.SelectedIndex = 0;
            cmbJenisPenyakit.SelectedIndex = 0;
            dtpTanggalAwal.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpTanggalAkhir.Value = DateTime.Now;
            MuatSemuaData();
        }

        private void AturKolomDgv(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void labelPadi_Click(object sender, EventArgs e) { }
        private void lblPadii_Click(object sender, EventArgs e) { }
        private void labelPenyakit_Click(object sender, EventArgs e) { }
        private void labelRiwayat_Click(object sender, EventArgs e) { }
        private void labelPerawatan_Click(object sender, EventArgs e) { }

        private void dtpTanggalAwal_ValueChanged(object sender, EventArgs e) { }
        private void dtpTanggalAkhir_ValueChanged(object sender, EventArgs e) { }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void cmbJenisBibit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbJenisPenyakit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}