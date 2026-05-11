namespace OryzaTrack
{
    partial class FormRiwayatPenyakit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRiwayatPenyakit));
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnKoneksi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.btnHapusData = new System.Windows.Forms.Button();
            this.btnUbahData = new System.Windows.Forms.Button();
            this.btnTambahData = new System.Windows.Forms.Button();
            this.btnCariData = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.dgvRiwayat = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.dtpTanggalSelesai = new System.Windows.Forms.DateTimePicker();
            this.lblTanggalSelesai = new System.Windows.Forms.Label();
            this.cmbIdPenyakit = new System.Windows.Forms.ComboBox();
            this.lblIdPadi = new System.Windows.Forms.Label();
            this.dtpTanggalTerdeteksi = new System.Windows.Forms.DateTimePicker();
            this.cmbIdPadi = new System.Windows.Forms.ComboBox();
            this.lblTanggalTerdeteksi = new System.Windows.Forms.Label();
            this.lblIdPenyakit = new System.Windows.Forms.Label();
            this.lblKeterangan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(314, 372);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(89, 33);
            this.btnLoadData.TabIndex = 92;
            this.btnLoadData.Text = "Load";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnKoneksi
            // 
            this.btnKoneksi.Location = new System.Drawing.Point(171, 372);
            this.btnKoneksi.Name = "btnKoneksi";
            this.btnKoneksi.Size = new System.Drawing.Size(85, 33);
            this.btnKoneksi.TabIndex = 91;
            this.btnKoneksi.Text = "Connect";
            this.btnKoneksi.UseVisualStyleBackColor = true;
            this.btnKoneksi.Click += new System.EventHandler(this.btnKoneksi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(942, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Location = new System.Drawing.Point(86, 21);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(115, 36);
            this.lblSearch.TabIndex = 89;
            this.lblSearch.Text = "Search";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(937, 292);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 25);
            this.lblTotal.TabIndex = 87;
            this.lblTotal.Text = "Jumlah :";
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Location = new System.Drawing.Point(817, 372);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(94, 33);
            this.btnBersihkan.TabIndex = 86;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // btnHapusData
            // 
            this.btnHapusData.Location = new System.Drawing.Point(707, 372);
            this.btnHapusData.Name = "btnHapusData";
            this.btnHapusData.Size = new System.Drawing.Size(84, 33);
            this.btnHapusData.TabIndex = 85;
            this.btnHapusData.Text = "Hapus";
            this.btnHapusData.UseVisualStyleBackColor = true;
            this.btnHapusData.Click += new System.EventHandler(this.btnHapusData_Click);
            // 
            // btnUbahData
            // 
            this.btnUbahData.Location = new System.Drawing.Point(584, 372);
            this.btnUbahData.Name = "btnUbahData";
            this.btnUbahData.Size = new System.Drawing.Size(84, 33);
            this.btnUbahData.TabIndex = 84;
            this.btnUbahData.Text = "Update";
            this.btnUbahData.UseVisualStyleBackColor = true;
            this.btnUbahData.Click += new System.EventHandler(this.btnUbahData_Click);
            // 
            // btnTambahData
            // 
            this.btnTambahData.Location = new System.Drawing.Point(448, 372);
            this.btnTambahData.Name = "btnTambahData";
            this.btnTambahData.Size = new System.Drawing.Size(92, 33);
            this.btnTambahData.TabIndex = 83;
            this.btnTambahData.Text = "Tambah";
            this.btnTambahData.UseVisualStyleBackColor = true;
            this.btnTambahData.Click += new System.EventHandler(this.btnTambahData_Click);
            // 
            // btnCariData
            // 
            this.btnCariData.Location = new System.Drawing.Point(910, 24);
            this.btnCariData.Name = "btnCariData";
            this.btnCariData.Size = new System.Drawing.Size(105, 33);
            this.btnCariData.TabIndex = 82;
            this.btnCariData.Text = "Cari";
            this.btnCariData.UseVisualStyleBackColor = true;
            this.btnCariData.Click += new System.EventHandler(this.btnCariData_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(227, 24);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(667, 33);
            this.txtCari.TabIndex = 81;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // dgvRiwayat
            // 
            this.dgvRiwayat.AllowUserToAddRows = false;
            this.dgvRiwayat.AllowUserToDeleteRows = false;
            this.dgvRiwayat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRiwayat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRiwayat.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRiwayat.Location = new System.Drawing.Point(64, 422);
            this.dgvRiwayat.Name = "dgvRiwayat";
            this.dgvRiwayat.ReadOnly = true;
            this.dgvRiwayat.RowHeadersWidth = 51;
            this.dgvRiwayat.RowTemplate.Height = 24;
            this.dgvRiwayat.Size = new System.Drawing.Size(1086, 281);
            this.dgvRiwayat.TabIndex = 80;
            this.dgvRiwayat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRiwayat_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.txtKeterangan);
            this.groupBox1.Controls.Add(this.dtpTanggalSelesai);
            this.groupBox1.Controls.Add(this.lblTanggalSelesai);
            this.groupBox1.Controls.Add(this.cmbIdPenyakit);
            this.groupBox1.Controls.Add(this.lblIdPadi);
            this.groupBox1.Controls.Add(this.dtpTanggalTerdeteksi);
            this.groupBox1.Controls.Add(this.cmbIdPadi);
            this.groupBox1.Controls.Add(this.lblTanggalTerdeteksi);
            this.groupBox1.Controls.Add(this.lblIdPenyakit);
            this.groupBox1.Controls.Add(this.lblKeterangan);
            this.groupBox1.Location = new System.Drawing.Point(64, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 286);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(230, 215);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(579, 22);
            this.txtKeterangan.TabIndex = 78;
            // 
            // dtpTanggalSelesai
            // 
            this.dtpTanggalSelesai.Location = new System.Drawing.Point(230, 164);
            this.dtpTanggalSelesai.Name = "dtpTanggalSelesai";
            this.dtpTanggalSelesai.Size = new System.Drawing.Size(220, 22);
            this.dtpTanggalSelesai.TabIndex = 77;
            // 
            // lblTanggalSelesai
            // 
            this.lblTanggalSelesai.AutoSize = true;
            this.lblTanggalSelesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalSelesai.Location = new System.Drawing.Point(42, 164);
            this.lblTanggalSelesai.Name = "lblTanggalSelesai";
            this.lblTanggalSelesai.Size = new System.Drawing.Size(138, 20);
            this.lblTanggalSelesai.TabIndex = 76;
            this.lblTanggalSelesai.Text = "Tanggal Selesai :";
            // 
            // cmbIdPenyakit
            // 
            this.cmbIdPenyakit.FormattingEnabled = true;
            this.cmbIdPenyakit.Location = new System.Drawing.Point(230, 77);
            this.cmbIdPenyakit.Name = "cmbIdPenyakit";
            this.cmbIdPenyakit.Size = new System.Drawing.Size(220, 24);
            this.cmbIdPenyakit.TabIndex = 75;
            // 
            // lblIdPadi
            // 
            this.lblIdPadi.AutoSize = true;
            this.lblIdPadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPadi.Location = new System.Drawing.Point(42, 33);
            this.lblIdPadi.Name = "lblIdPadi";
            this.lblIdPadi.Size = new System.Drawing.Size(70, 20);
            this.lblIdPadi.TabIndex = 74;
            this.lblIdPadi.Text = "Id Padi :";
            // 
            // dtpTanggalTerdeteksi
            // 
            this.dtpTanggalTerdeteksi.Location = new System.Drawing.Point(230, 121);
            this.dtpTanggalTerdeteksi.Name = "dtpTanggalTerdeteksi";
            this.dtpTanggalTerdeteksi.Size = new System.Drawing.Size(220, 22);
            this.dtpTanggalTerdeteksi.TabIndex = 73;
            // 
            // cmbIdPadi
            // 
            this.cmbIdPadi.FormattingEnabled = true;
            this.cmbIdPadi.Location = new System.Drawing.Point(230, 33);
            this.cmbIdPadi.Name = "cmbIdPadi";
            this.cmbIdPadi.Size = new System.Drawing.Size(220, 24);
            this.cmbIdPadi.TabIndex = 70;
            // 
            // lblTanggalTerdeteksi
            // 
            this.lblTanggalTerdeteksi.AutoSize = true;
            this.lblTanggalTerdeteksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalTerdeteksi.Location = new System.Drawing.Point(42, 121);
            this.lblTanggalTerdeteksi.Name = "lblTanggalTerdeteksi";
            this.lblTanggalTerdeteksi.Size = new System.Drawing.Size(161, 20);
            this.lblTanggalTerdeteksi.TabIndex = 68;
            this.lblTanggalTerdeteksi.Text = "Tanggal Terdeteksi :";
            // 
            // lblIdPenyakit
            // 
            this.lblIdPenyakit.AutoSize = true;
            this.lblIdPenyakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPenyakit.Location = new System.Drawing.Point(42, 77);
            this.lblIdPenyakit.Name = "lblIdPenyakit";
            this.lblIdPenyakit.Size = new System.Drawing.Size(100, 20);
            this.lblIdPenyakit.TabIndex = 35;
            this.lblIdPenyakit.Text = "Id Penyakit :";
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan.Location = new System.Drawing.Point(42, 215);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(104, 20);
            this.lblKeterangan.TabIndex = 39;
            this.lblKeterangan.Text = "Keterangan :";
            // 
            // FormRiwayatPenyakit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 715);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnKoneksi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnBersihkan);
            this.Controls.Add(this.btnHapusData);
            this.Controls.Add(this.btnUbahData);
            this.Controls.Add(this.btnTambahData);
            this.Controls.Add(this.btnCariData);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.dgvRiwayat);
            this.Name = "FormRiwayatPenyakit";
            this.Text = "FormRiwayatPenyakit";
            this.Load += new System.EventHandler(this.FormRiwayatPenyakit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnKoneksi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Button btnHapusData;
        private System.Windows.Forms.Button btnUbahData;
        private System.Windows.Forms.Button btnTambahData;
        private System.Windows.Forms.Button btnCariData;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTanggalTerdeteksi;
        private System.Windows.Forms.ComboBox cmbIdPadi;
        private System.Windows.Forms.Label lblTanggalTerdeteksi;
        private System.Windows.Forms.Label lblIdPenyakit;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.DateTimePicker dtpTanggalSelesai;
        private System.Windows.Forms.Label lblTanggalSelesai;
        private System.Windows.Forms.ComboBox cmbIdPenyakit;
        private System.Windows.Forms.Label lblIdPadi;
        private System.Windows.Forms.TextBox txtKeterangan;
    }
}