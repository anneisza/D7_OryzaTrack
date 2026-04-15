using OryzaTrackBLL;
using OryzaTrackDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OryzaTrackDAL;
using OryzaTrackBLL;


namespace OryzaTrack
{
    public partial class FormLogin2 : Form
    {
        private AdminBLL bll = new AdminBLL();

        public FormLogin2()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Buka koneksi saat aplikasi start (sesuai requirement)
            try
            {
                DatabaseConnection.GetConnection();
                lblStatus.Text = "Koneksi database berhasil.";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Koneksi gagal: " + ex.Message;
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int idAdmin = bll.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());

                if (idAdmin > 0)
                {
                    FormMenu menu = new FormMenu(idAdmin);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah!", "Login Gagal",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
