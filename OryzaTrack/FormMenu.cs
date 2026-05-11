using OryzaTrackBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OryzaTrack
{
    public partial class FormMenu : Form
    {
        private int IDAdmin;
        public FormMenu(int idAdmin)
        {
            InitializeComponent();
            IDAdmin = idAdmin;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
        }

        private void btnPetani_Click(object sender, EventArgs e)
        {
            FormPetani form = new FormPetani(IDAdmin);
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
        }

        private void btnPadi_Click(object sender, EventArgs e)
        {
            FormPadi form = new FormPadi(IDAdmin);
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
        }

        private void btnPenyakit_Click(object sender, EventArgs e)
        {
            FormPenyakit form = new FormPenyakit(IDAdmin);
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayatPenyakit form = new FormRiwayatPenyakit(IDAdmin);
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
        }

        private void btnPerawatan_Click(object sender, EventArgs e)
        {
            FormPerawatanPadi form = new FormPerawatanPadi(IDAdmin);
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();

        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            FormLaporan form = new FormLaporan();
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Apakah Anda yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                FormLogin2 login = new FormLogin2();
                login.Show();
                this.Hide();
            }
        }
    }
}
