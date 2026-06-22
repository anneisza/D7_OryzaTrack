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
    public partial class FormHacked : Form
    {
        public FormHacked()
        {
            InitializeComponent();

            // Desain seram
            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void FormHacked_Load(object sender, EventArgs e)
        {
            // Label utama
            Label lblHacked = new Label();
            lblHacked.Text = "⚠️ YOU HAVE BEEN HACKED ⚠️";
            lblHacked.ForeColor = Color.Red;
            lblHacked.Font = new Font("Courier New", 36, FontStyle.Bold);
            lblHacked.AutoSize = true;
            lblHacked.Location = new Point(
                (this.Width - lblHacked.PreferredWidth) / 2, 200);
            this.Controls.Add(lblHacked);

            // Label info
            Label lblInfo = new Label();
            lblInfo.Text = "SEMUA DATA PETANI TELAH DIHAPUS\n\n" +
                           "SQL INJECTION BERHASIL DIEKSEKUSI\n\n" +
                           "Query: DELETE FROM petani WHERE namaPetani = '' OR '1'='1' --";
            lblInfo.ForeColor = Color.LimeGreen;
            lblInfo.Font = new Font("Courier New", 14, FontStyle.Regular);
            lblInfo.AutoSize = true;
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            lblInfo.Location = new Point(
                (this.Width - lblInfo.PreferredWidth) / 2, 350);
            this.Controls.Add(lblInfo);

            // Tombol close
            Button btnClose = new Button();
            btnClose.Text = "TUTUP";
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = Color.White;
            btnClose.Font = new Font("Courier New", 14, FontStyle.Bold);
            btnClose.Size = new Size(200, 50);
            btnClose.Location = new Point(
                (this.Width - 200) / 2, 550);
            btnClose.Click += (s, e2) => this.Close();
            this.Controls.Add(btnClose);

            // Timer kedip
            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Tick += (s, e2) =>
            {
                lblHacked.ForeColor = lblHacked.ForeColor == Color.Red
                    ? Color.DarkRed : Color.Red;
            };
            timer.Start();
        }
    }
}
