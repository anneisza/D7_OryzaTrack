using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OryzaTrack
{
    public partial class FormMenu : Form
    {

        public FormMenu(string username)
        {
            InitializeComponent();
            lblWelcome.Text = $"Selamat datang {username} !";
        }

        private void btnPetani_Click(object sender, EventArgs e)
        {
            new FormHama(username).ShowDialog();
        }

        private void btnPenyakit_Click(object sender, EventArgs e)
        {
            new FormRiwayatPenyakit(_idAdmin).ShowDialog();
        }

        private void btnPerawatan_Click(object sender, EventArgs e)
        {
            new FormPerawatanPadi(_idAdmin).ShowDialog();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            new FormLaporan().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin2().Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
