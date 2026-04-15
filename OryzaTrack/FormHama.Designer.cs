namespace OryzaTrack
{
    partial class FormHama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvHama = new System.Windows.Forms.DataGridView();
            this.txtIdHama = new System.Windows.Forms.TextBox();
            this.txtNamaHama = new System.Windows.Forms.TextBox();
            this.txtJenisHama = new System.Windows.Forms.TextBox();
            this.txtGejalaHama = new System.Windows.Forms.TextBox();
            this.txtLokasiLahan = new System.Windows.Forms.TextBox();
            this.dtpTanggalSerangan = new System.Windows.Forms.DateTimePicker();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNamaHama = new System.Windows.Forms.Label();
            this.lblJenisHama = new System.Windows.Forms.Label();
            this.lblGejala = new System.Windows.Forms.Label();
            this.lblLokasiLahan = new System.Windows.Forms.Label();
            this.lblTanggalSerangan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHama)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHama
            // 
            this.dgvHama.AllowUserToAddRows = false;
            this.dgvHama.AllowUserToDeleteRows = false;
            this.dgvHama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHama.Location = new System.Drawing.Point(64, 375);
            this.dgvHama.Name = "dgvHama";
            this.dgvHama.ReadOnly = true;
            this.dgvHama.RowHeadersWidth = 51;
            this.dgvHama.RowTemplate.Height = 24;
            this.dgvHama.Size = new System.Drawing.Size(668, 162);
            this.dgvHama.TabIndex = 0;
            // 
            // txtIdHama
            // 
            this.txtIdHama.Location = new System.Drawing.Point(207, 75);
            this.txtIdHama.Multiline = true;
            this.txtIdHama.Name = "txtIdHama";
            this.txtIdHama.Size = new System.Drawing.Size(364, 22);
            this.txtIdHama.TabIndex = 1;
            // 
            // txtNamaHama
            // 
            this.txtNamaHama.Location = new System.Drawing.Point(207, 115);
            this.txtNamaHama.Multiline = true;
            this.txtNamaHama.Name = "txtNamaHama";
            this.txtNamaHama.Size = new System.Drawing.Size(364, 22);
            this.txtNamaHama.TabIndex = 2;
            // 
            // txtJenisHama
            // 
            this.txtJenisHama.Location = new System.Drawing.Point(207, 157);
            this.txtJenisHama.Multiline = true;
            this.txtJenisHama.Name = "txtJenisHama";
            this.txtJenisHama.Size = new System.Drawing.Size(364, 22);
            this.txtJenisHama.TabIndex = 3;
            // 
            // txtGejalaHama
            // 
            this.txtGejalaHama.Location = new System.Drawing.Point(207, 202);
            this.txtGejalaHama.Multiline = true;
            this.txtGejalaHama.Name = "txtGejalaHama";
            this.txtGejalaHama.Size = new System.Drawing.Size(364, 22);
            this.txtGejalaHama.TabIndex = 4;
            // 
            // txtLokasiLahan
            // 
            this.txtLokasiLahan.Location = new System.Drawing.Point(207, 244);
            this.txtLokasiLahan.Multiline = true;
            this.txtLokasiLahan.Name = "txtLokasiLahan";
            this.txtLokasiLahan.Size = new System.Drawing.Size(364, 22);
            this.txtLokasiLahan.TabIndex = 5;
            // 
            // dtpTanggalSerangan
            // 
            this.dtpTanggalSerangan.Location = new System.Drawing.Point(207, 284);
            this.dtpTanggalSerangan.Name = "dtpTanggalSerangan";
            this.dtpTanggalSerangan.Size = new System.Drawing.Size(200, 22);
            this.dtpTanggalSerangan.TabIndex = 6;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(207, 12);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(364, 33);
            this.txtCari.TabIndex = 7;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(594, 12);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 33);
            this.btnCari.TabIndex = 8;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(203, 327);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 33);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(300, 327);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(405, 327);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 33);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Location = new System.Drawing.Point(507, 327);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(75, 33);
            this.btnBersihkan.TabIndex = 12;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Location = new System.Drawing.Point(606, 75);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(50, 16);
            this.lblJumlah.TabIndex = 13;
            this.lblJumlah.Text = "Jumlah";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(61, 78);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            // 
            // lblNamaHama
            // 
            this.lblNamaHama.AutoSize = true;
            this.lblNamaHama.Location = new System.Drawing.Point(61, 118);
            this.lblNamaHama.Name = "lblNamaHama";
            this.lblNamaHama.Size = new System.Drawing.Size(90, 16);
            this.lblNamaHama.TabIndex = 15;
            this.lblNamaHama.Text = "Nama Hama :";
            // 
            // lblJenisHama
            // 
            this.lblJenisHama.AutoSize = true;
            this.lblJenisHama.Location = new System.Drawing.Point(61, 160);
            this.lblJenisHama.Name = "lblJenisHama";
            this.lblJenisHama.Size = new System.Drawing.Size(85, 16);
            this.lblJenisHama.TabIndex = 16;
            this.lblJenisHama.Text = "Jenis Hama :";
            // 
            // lblGejala
            // 
            this.lblGejala.AutoSize = true;
            this.lblGejala.Location = new System.Drawing.Point(61, 205);
            this.lblGejala.Name = "lblGejala";
            this.lblGejala.Size = new System.Drawing.Size(93, 16);
            this.lblGejala.TabIndex = 17;
            this.lblGejala.Text = "Gejala Hama :";
            // 
            // lblLokasiLahan
            // 
            this.lblLokasiLahan.AutoSize = true;
            this.lblLokasiLahan.Location = new System.Drawing.Point(61, 247);
            this.lblLokasiLahan.Name = "lblLokasiLahan";
            this.lblLokasiLahan.Size = new System.Drawing.Size(93, 16);
            this.lblLokasiLahan.TabIndex = 18;
            this.lblLokasiLahan.Text = "Lokasi Lahan :";
            // 
            // lblTanggalSerangan
            // 
            this.lblTanggalSerangan.AutoSize = true;
            this.lblTanggalSerangan.Location = new System.Drawing.Point(61, 289);
            this.lblTanggalSerangan.Name = "lblTanggalSerangan";
            this.lblTanggalSerangan.Size = new System.Drawing.Size(126, 16);
            this.lblTanggalSerangan.TabIndex = 19;
            this.lblTanggalSerangan.Text = "Tanggal Serangan :";
            // 
            // FormHama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.lblTanggalSerangan);
            this.Controls.Add(this.lblLokasiLahan);
            this.Controls.Add(this.lblGejala);
            this.Controls.Add(this.lblJenisHama);
            this.Controls.Add(this.lblNamaHama);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.btnBersihkan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.dtpTanggalSerangan);
            this.Controls.Add(this.txtLokasiLahan);
            this.Controls.Add(this.txtGejalaHama);
            this.Controls.Add(this.txtJenisHama);
            this.Controls.Add(this.txtNamaHama);
            this.Controls.Add(this.txtIdHama);
            this.Controls.Add(this.dgvHama);
            this.Name = "FormHama";
            this.Text = "FormHama";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHama;
        private System.Windows.Forms.TextBox txtIdHama;
        private System.Windows.Forms.TextBox txtNamaHama;
        private System.Windows.Forms.TextBox txtJenisHama;
        private System.Windows.Forms.TextBox txtGejalaHama;
        private System.Windows.Forms.TextBox txtLokasiLahan;
        private System.Windows.Forms.DateTimePicker dtpTanggalSerangan;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNamaHama;
        private System.Windows.Forms.Label lblJenisHama;
        private System.Windows.Forms.Label lblGejala;
        private System.Windows.Forms.Label lblLokasiLahan;
        private System.Windows.Forms.Label lblTanggalSerangan;
    }
}