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



namespace OryzaTrack
{
    public partial class FormLogin2 : Form
    {
        private AdminBLL bll = new AdminBLL();
        bool isPasswordVisible = false;
        public FormLogin2()
        {
            InitializeComponent();
        }


        private void FormLogin2_Load(object sender, EventArgs e)
        {

            txtPassword.PasswordChar = '●';
            this.AcceptButton = btnLogin;
            pbEyeHide.Image = Properties.Resources.EyeClose;

        }

        //Eye
        private void pbEyeHide_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtPassword.PasswordChar = '\0'; // Tampilkan password
                pbEyeHide.Image = Properties.Resources.EyeOpen; // ikon mata terbuka
            }
            else
            {
                txtPassword.PasswordChar = '●'; // Sembunyikan password
                pbEyeHide.Image = Properties.Resources.EyeClose; // ikon mata tertutup
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validasi input kosong
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username tidak boleh kosong!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password tidak boleh kosong!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                int idAdmin = bll.Login(
                    txtUsername.Text.Trim(),
                    txtPassword.Text.Trim()
                );

                if (idAdmin > 0)
                {
                    MessageBox.Show(
                        "Login berhasil! Selamat datang, " + txtUsername.Text + "!",
                        "Login Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    FormMenu menu = new FormMenu(idAdmin);
                    menu.Show();
                    this.Hide();
                    menu.FormClosed += (s, args) => this.Show();
                }
                else
                {
                    MessageBox.Show(
                        "Username atau password salah!",
                        "Login Gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    // Kosongkan password dan fokus ke username
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


    }
}
