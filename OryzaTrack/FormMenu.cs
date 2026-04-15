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
        private int _idAdmin;

        public FormMenu(int idAdmin)
        {
            InitializeComponent();
            _idAdmin = idAdmin;
            lblWelcome.Text = $"Selamat datang! ID Admin: {idAdmin}";
        }

        private void btnHama_Click(object sender, EventArgs e)
        {
            new FormHama(_idAdmin).ShowDialog();
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
            new FormLogin().Show();
        }
    }
}
