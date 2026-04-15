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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHama));
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHama)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHama
            // 
            this.dgvHama.AllowUserToAddRows = false;
            this.dgvHama.AllowUserToDeleteRows = false;
            this.dgvHama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHama.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHama.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHama.Location = new System.Drawing.Point(12, 375);
            this.dgvHama.Name = "dgvHama";
            this.dgvHama.ReadOnly = true;
            this.dgvHama.RowHeadersWidth = 51;
            this.dgvHama.RowTemplate.Height = 24;
            this.dgvHama.Size = new System.Drawing.Size(983, 233);
            this.dgvHama.TabIndex = 0;
            // 
            // txtIdHama
            // 
            this.txtIdHama.Location = new System.Drawing.Point(237, 75);
            this.txtIdHama.Multiline = true;
            this.txtIdHama.Name = "txtIdHama";
            this.txtIdHama.Size = new System.Drawing.Size(494, 22);
            this.txtIdHama.TabIndex = 1;
            // 
            // txtNamaHama
            // 
            this.txtNamaHama.Location = new System.Drawing.Point(237, 115);
            this.txtNamaHama.Multiline = true;
            this.txtNamaHama.Name = "txtNamaHama";
            this.txtNamaHama.Size = new System.Drawing.Size(494, 22);
            this.txtNamaHama.TabIndex = 2;
            // 
            // txtJenisHama
            // 
            this.txtJenisHama.Location = new System.Drawing.Point(237, 157);
            this.txtJenisHama.Multiline = true;
            this.txtJenisHama.Name = "txtJenisHama";
            this.txtJenisHama.Size = new System.Drawing.Size(494, 22);
            this.txtJenisHama.TabIndex = 3;
            // 
            // txtGejalaHama
            // 
            this.txtGejalaHama.Location = new System.Drawing.Point(237, 202);
            this.txtGejalaHama.Multiline = true;
            this.txtGejalaHama.Name = "txtGejalaHama";
            this.txtGejalaHama.Size = new System.Drawing.Size(494, 22);
            this.txtGejalaHama.TabIndex = 4;
            // 
            // txtLokasiLahan
            // 
            this.txtLokasiLahan.Location = new System.Drawing.Point(237, 244);
            this.txtLokasiLahan.Multiline = true;
            this.txtLokasiLahan.Name = "txtLokasiLahan";
            this.txtLokasiLahan.Size = new System.Drawing.Size(494, 22);
            this.txtLokasiLahan.TabIndex = 5;
            // 
            // dtpTanggalSerangan
            // 
            this.dtpTanggalSerangan.Location = new System.Drawing.Point(225, 235);
            this.dtpTanggalSerangan.Name = "dtpTanggalSerangan";
            this.dtpTanggalSerangan.Size = new System.Drawing.Size(218, 22);
            this.dtpTanggalSerangan.TabIndex = 6;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(237, 12);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(512, 33);
            this.txtCari.TabIndex = 7;
            // 
            // btnCari
            // 
            this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.Location = new System.Drawing.Point(785, 12);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 33);
            this.btnCari.TabIndex = 8;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(259, 327);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(105, 33);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(391, 327);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 33);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(522, 327);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(104, 33);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Location = new System.Drawing.Point(650, 327);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(99, 33);
            this.btnBersihkan.TabIndex = 12;
            this.btnBersihkan.Text = "Refresh";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblJumlah.Location = new System.Drawing.Point(783, 271);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(77, 22);
            this.lblJumlah.TabIndex = 13;
            this.lblJumlah.Text = "Jumlah :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.CadetBlue;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(61, 78);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(86, 20);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID Hama :";
            // 
            // lblNamaHama
            // 
            this.lblNamaHama.AutoSize = true;
            this.lblNamaHama.BackColor = System.Drawing.Color.CadetBlue;
            this.lblNamaHama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaHama.Location = new System.Drawing.Point(61, 118);
            this.lblNamaHama.Name = "lblNamaHama";
            this.lblNamaHama.Size = new System.Drawing.Size(113, 20);
            this.lblNamaHama.TabIndex = 15;
            this.lblNamaHama.Text = "Nama Hama :";
            // 
            // lblJenisHama
            // 
            this.lblJenisHama.AutoSize = true;
            this.lblJenisHama.BackColor = System.Drawing.Color.CadetBlue;
            this.lblJenisHama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisHama.Location = new System.Drawing.Point(61, 160);
            this.lblJenisHama.Name = "lblJenisHama";
            this.lblJenisHama.Size = new System.Drawing.Size(109, 20);
            this.lblJenisHama.TabIndex = 16;
            this.lblJenisHama.Text = "Jenis Hama :";
            // 
            // lblGejala
            // 
            this.lblGejala.AutoSize = true;
            this.lblGejala.BackColor = System.Drawing.Color.CadetBlue;
            this.lblGejala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGejala.Location = new System.Drawing.Point(61, 205);
            this.lblGejala.Name = "lblGejala";
            this.lblGejala.Size = new System.Drawing.Size(117, 20);
            this.lblGejala.TabIndex = 17;
            this.lblGejala.Text = "Gejala Hama :";
            // 
            // lblLokasiLahan
            // 
            this.lblLokasiLahan.AutoSize = true;
            this.lblLokasiLahan.BackColor = System.Drawing.Color.CadetBlue;
            this.lblLokasiLahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokasiLahan.Location = new System.Drawing.Point(61, 247);
            this.lblLokasiLahan.Name = "lblLokasiLahan";
            this.lblLokasiLahan.Size = new System.Drawing.Size(119, 20);
            this.lblLokasiLahan.TabIndex = 18;
            this.lblLokasiLahan.Text = "Lokasi Lahan :";
            // 
            // lblTanggalSerangan
            // 
            this.lblTanggalSerangan.AutoSize = true;
            this.lblTanggalSerangan.BackColor = System.Drawing.Color.CadetBlue;
            this.lblTanggalSerangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalSerangan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTanggalSerangan.Location = new System.Drawing.Point(48, 235);
            this.lblTanggalSerangan.Name = "lblTanggalSerangan";
            this.lblTanggalSerangan.Size = new System.Drawing.Size(154, 20);
            this.lblTanggalSerangan.TabIndex = 19;
            this.lblTanggalSerangan.Text = "Tanggal Serangan :";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Teal;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Location = new System.Drawing.Point(99, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(115, 36);
            this.lblSearch.TabIndex = 20;
            this.lblSearch.Text = "Search";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.lblTanggalSerangan);
            this.groupBox1.Controls.Add(this.dtpTanggalSerangan);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 270);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(785, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // FormHama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1007, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSearch);
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
            this.Controls.Add(this.txtLokasiLahan);
            this.Controls.Add(this.txtGejalaHama);
            this.Controls.Add(this.txtJenisHama);
            this.Controls.Add(this.txtNamaHama);
            this.Controls.Add(this.txtIdHama);
            this.Controls.Add(this.dgvHama);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormHama";
            this.Text = "FormHama";
            this.Click += new System.EventHandler(this.FormHama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHama)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}