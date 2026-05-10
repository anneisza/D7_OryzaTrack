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
            this.lblJumlah = new System.Windows.Forms.Label();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.btnHapusData = new System.Windows.Forms.Button();
            this.btnUbahData = new System.Windows.Forms.Button();
            this.btnTambahData = new System.Windows.Forms.Button();
            this.btnCariData = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.dgvPerawatan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.lblTanggalSelesai = new System.Windows.Forms.Label();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.cmbIdPadi = new System.Windows.Forms.ComboBox();
            this.lblIdPenyakit = new System.Windows.Forms.Label();
            this.lblPadi = new System.Windows.Forms.Label();
            this.lblTanggalTerdeteksi = new System.Windows.Forms.Label();
            this.cmbIdPenyakit = new System.Windows.Forms.ComboBox();
            this.dtpTanggalTerdeteksi = new System.Windows.Forms.DateTimePicker();
            this.dtpTanggalSelesai = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerawatan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(286, 379);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(89, 33);
            this.btnLoadData.TabIndex = 92;
            this.btnLoadData.Text = "Load";
            this.btnLoadData.UseVisualStyleBackColor = true;
            // 
            // btnKoneksi
            // 
            this.btnKoneksi.Location = new System.Drawing.Point(143, 379);
            this.btnKoneksi.Name = "btnKoneksi";
            this.btnKoneksi.Size = new System.Drawing.Size(85, 33);
            this.btnKoneksi.TabIndex = 91;
            this.btnKoneksi.Text = "Connect";
            this.btnKoneksi.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(914, 78);
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
            this.lblSearch.Location = new System.Drawing.Point(58, 28);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(115, 36);
            this.lblSearch.TabIndex = 89;
            this.lblSearch.Text = "Search";
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblJumlah.Location = new System.Drawing.Point(909, 299);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(87, 25);
            this.lblJumlah.TabIndex = 87;
            this.lblJumlah.Text = "Jumlah :";
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Location = new System.Drawing.Point(789, 379);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(94, 33);
            this.btnBersihkan.TabIndex = 86;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            // 
            // btnHapusData
            // 
            this.btnHapusData.Location = new System.Drawing.Point(679, 379);
            this.btnHapusData.Name = "btnHapusData";
            this.btnHapusData.Size = new System.Drawing.Size(84, 33);
            this.btnHapusData.TabIndex = 85;
            this.btnHapusData.Text = "Hapus";
            this.btnHapusData.UseVisualStyleBackColor = true;
            // 
            // btnUbahData
            // 
            this.btnUbahData.Location = new System.Drawing.Point(556, 379);
            this.btnUbahData.Name = "btnUbahData";
            this.btnUbahData.Size = new System.Drawing.Size(84, 33);
            this.btnUbahData.TabIndex = 84;
            this.btnUbahData.Text = "Update";
            this.btnUbahData.UseVisualStyleBackColor = true;
            // 
            // btnTambahData
            // 
            this.btnTambahData.Location = new System.Drawing.Point(420, 379);
            this.btnTambahData.Name = "btnTambahData";
            this.btnTambahData.Size = new System.Drawing.Size(92, 33);
            this.btnTambahData.TabIndex = 83;
            this.btnTambahData.Text = "Tambah";
            this.btnTambahData.UseVisualStyleBackColor = true;
            // 
            // btnCariData
            // 
            this.btnCariData.Location = new System.Drawing.Point(882, 31);
            this.btnCariData.Name = "btnCariData";
            this.btnCariData.Size = new System.Drawing.Size(105, 33);
            this.btnCariData.TabIndex = 82;
            this.btnCariData.Text = "Cari";
            this.btnCariData.UseVisualStyleBackColor = true;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(199, 31);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(667, 33);
            this.txtCari.TabIndex = 81;
            // 
            // dgvPerawatan
            // 
            this.dgvPerawatan.AllowUserToAddRows = false;
            this.dgvPerawatan.AllowUserToDeleteRows = false;
            this.dgvPerawatan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPerawatan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPerawatan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPerawatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerawatan.Location = new System.Drawing.Point(36, 429);
            this.dgvPerawatan.Name = "dgvPerawatan";
            this.dgvPerawatan.ReadOnly = true;
            this.dgvPerawatan.RowHeadersWidth = 51;
            this.dgvPerawatan.RowTemplate.Height = 24;
            this.dgvPerawatan.Size = new System.Drawing.Size(1086, 281);
            this.dgvPerawatan.TabIndex = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.dtpTanggalSelesai);
            this.groupBox1.Controls.Add(this.dtpTanggalTerdeteksi);
            this.groupBox1.Controls.Add(this.cmbIdPenyakit);
            this.groupBox1.Controls.Add(this.txtKeterangan);
            this.groupBox1.Controls.Add(this.lblTanggalSelesai);
            this.groupBox1.Controls.Add(this.lblKeterangan);
            this.groupBox1.Controls.Add(this.cmbIdPadi);
            this.groupBox1.Controls.Add(this.lblIdPenyakit);
            this.groupBox1.Controls.Add(this.lblPadi);
            this.groupBox1.Controls.Add(this.lblTanggalTerdeteksi);
            this.groupBox1.Location = new System.Drawing.Point(36, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 286);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(250, 239);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(617, 22);
            this.txtKeterangan.TabIndex = 69;
            // 
            // lblTanggalSelesai
            // 
            this.lblTanggalSelesai.AutoSize = true;
            this.lblTanggalSelesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalSelesai.Location = new System.Drawing.Point(77, 194);
            this.lblTanggalSelesai.Name = "lblTanggalSelesai";
            this.lblTanggalSelesai.Size = new System.Drawing.Size(143, 20);
            this.lblTanggalSelesai.TabIndex = 68;
            this.lblTanggalSelesai.Text = "Tanggal Selesai : ";
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan.Location = new System.Drawing.Point(77, 241);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(104, 20);
            this.lblKeterangan.TabIndex = 45;
            this.lblKeterangan.Text = "Keterangan :";
            // 
            // cmbIdPadi
            // 
            this.cmbIdPadi.FormattingEnabled = true;
            this.cmbIdPadi.Location = new System.Drawing.Point(250, 91);
            this.cmbIdPadi.Name = "cmbIdPadi";
            this.cmbIdPadi.Size = new System.Drawing.Size(220, 24);
            this.cmbIdPadi.TabIndex = 44;
            // 
            // lblIdPenyakit
            // 
            this.lblIdPenyakit.AutoSize = true;
            this.lblIdPenyakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPenyakit.Location = new System.Drawing.Point(77, 48);
            this.lblIdPenyakit.Name = "lblIdPenyakit";
            this.lblIdPenyakit.Size = new System.Drawing.Size(105, 20);
            this.lblIdPenyakit.TabIndex = 35;
            this.lblIdPenyakit.Text = "Id Penyakit  :";
            // 
            // lblPadi
            // 
            this.lblPadi.AutoSize = true;
            this.lblPadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPadi.Location = new System.Drawing.Point(77, 95);
            this.lblPadi.Name = "lblPadi";
            this.lblPadi.Size = new System.Drawing.Size(70, 20);
            this.lblPadi.TabIndex = 36;
            this.lblPadi.Text = "Id Padi :";
            // 
            // lblTanggalTerdeteksi
            // 
            this.lblTanggalTerdeteksi.AutoSize = true;
            this.lblTanggalTerdeteksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalTerdeteksi.Location = new System.Drawing.Point(77, 147);
            this.lblTanggalTerdeteksi.Name = "lblTanggalTerdeteksi";
            this.lblTanggalTerdeteksi.Size = new System.Drawing.Size(161, 20);
            this.lblTanggalTerdeteksi.TabIndex = 39;
            this.lblTanggalTerdeteksi.Text = "Tanggal Terdeteksi :";
            // 
            // cmbIdPenyakit
            // 
            this.cmbIdPenyakit.FormattingEnabled = true;
            this.cmbIdPenyakit.Location = new System.Drawing.Point(250, 44);
            this.cmbIdPenyakit.Name = "cmbIdPenyakit";
            this.cmbIdPenyakit.Size = new System.Drawing.Size(220, 24);
            this.cmbIdPenyakit.TabIndex = 70;
            // 
            // dtpTanggalTerdeteksi
            // 
            this.dtpTanggalTerdeteksi.Location = new System.Drawing.Point(250, 144);
            this.dtpTanggalTerdeteksi.Name = "dtpTanggalTerdeteksi";
            this.dtpTanggalTerdeteksi.Size = new System.Drawing.Size(200, 22);
            this.dtpTanggalTerdeteksi.TabIndex = 71;
            // 
            // dtpTanggalSelesai
            // 
            this.dtpTanggalSelesai.Location = new System.Drawing.Point(250, 194);
            this.dtpTanggalSelesai.Name = "dtpTanggalSelesai";
            this.dtpTanggalSelesai.Size = new System.Drawing.Size(200, 22);
            this.dtpTanggalSelesai.TabIndex = 72;
            // 
            // FormRiwayatPenyakit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 738);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnKoneksi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.btnBersihkan);
            this.Controls.Add(this.btnHapusData);
            this.Controls.Add(this.btnUbahData);
            this.Controls.Add(this.btnTambahData);
            this.Controls.Add(this.btnCariData);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.dgvPerawatan);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRiwayatPenyakit";
            this.Text = "FormRiwayatPenyakit";
            this.Click += new System.EventHandler(this.FormRiwayatPenyakit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerawatan)).EndInit();
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
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Button btnHapusData;
        private System.Windows.Forms.Button btnUbahData;
        private System.Windows.Forms.Button btnTambahData;
        private System.Windows.Forms.Button btnCariData;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DataGridView dgvPerawatan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Label lblTanggalSelesai;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.ComboBox cmbIdPadi;
        private System.Windows.Forms.Label lblPadi;
        private System.Windows.Forms.Label lblTanggalTerdeteksi;
        private System.Windows.Forms.ComboBox cmbIdPenyakit;
        protected System.Windows.Forms.Label lblIdPenyakit;
        private System.Windows.Forms.DateTimePicker dtpTanggalSelesai;
        private System.Windows.Forms.DateTimePicker dtpTanggalTerdeteksi;
    }
}