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
using OryzaTrackBLL;

namespace OryzaTrack
{
    
    public partial class FormKoneksi : Form
    {
       
        public FormKoneksi()
        {
            InitializeComponent();
        }

        private void CekKoneksi()
        {
            btnMasuk.Enabled = false;

            DatabaseConnectionBLL bll = new DatabaseConnectionBLL();
            string errorMsg;
            bool berhasil = bll.CekKoneksi(out errorMsg);

            if(berhasil)
            {
                lblStatus.Text = $"Koneksi berhasil!";
                btnMasuk.Enabled = true;
            }
            else
            {
                lblStatus.Text = $"Koneksi gagal: {errorMsg}";
                btnMasuk.Enabled = false;
            }


        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin2 frm = new FormLogin2(); 
            frm.Show();


        }

        private void btnCobaLagi_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Mencoba koneksi...";
            CekKoneksi();
        }

        private void FormKoneksi_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Tekan \"Koneksi Database\"!";
            btnMasuk.Enabled = false;

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
