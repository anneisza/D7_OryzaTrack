namespace OryzaTrack
{
    partial class FormPerawatanPadi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerawatanPadi));
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
            this.lblJenisPestisida = new System.Windows.Forms.Label();
            this.lblTanggalPerawatan = new System.Windows.Forms.Label();
            this.lblPenyakit = new System.Windows.Forms.Label();
            this.lblPadi = new System.Windows.Forms.Label();
            this.lblJenisPerawatan = new System.Windows.Forms.Label();
            this.cmbJenisPestisida = new System.Windows.Forms.ComboBox();
            this.cmbPadi = new System.Windows.Forms.ComboBox();
            this.cmbIdPenyakit = new System.Windows.Forms.ComboBox();
            this.txtJenisPerawatan = new System.Windows.Forms.TextBox();
            this.dtpTanggalPerawatan = new System.Windows.Forms.DateTimePicker();
            this.lblHasilPerawatan = new System.Windows.Forms.Label();
            this.cmbHasilPerawatan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerawatan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(288, 372);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(89, 33);
            this.btnLoadData.TabIndex = 92;
            this.btnLoadData.Text = "Load";
            this.btnLoadData.UseVisualStyleBackColor = true;
            // 
            // btnKoneksi
            // 
            this.btnKoneksi.Location = new System.Drawing.Point(145, 372);
            this.btnKoneksi.Name = "btnKoneksi";
            this.btnKoneksi.Size = new System.Drawing.Size(85, 33);
            this.btnKoneksi.TabIndex = 91;
            this.btnKoneksi.Text = "Connect";
            this.btnKoneksi.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(916, 71);
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
            this.lblSearch.Location = new System.Drawing.Point(60, 21);
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
            this.lblJumlah.Location = new System.Drawing.Point(911, 292);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(87, 25);
            this.lblJumlah.TabIndex = 87;
            this.lblJumlah.Text = "Jumlah :";
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Location = new System.Drawing.Point(791, 372);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(94, 33);
            this.btnBersihkan.TabIndex = 86;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            // 
            // btnHapusData
            // 
            this.btnHapusData.Location = new System.Drawing.Point(681, 372);
            this.btnHapusData.Name = "btnHapusData";
            this.btnHapusData.Size = new System.Drawing.Size(84, 33);
            this.btnHapusData.TabIndex = 85;
            this.btnHapusData.Text = "Hapus";
            this.btnHapusData.UseVisualStyleBackColor = true;
            // 
            // btnUbahData
            // 
            this.btnUbahData.Location = new System.Drawing.Point(558, 372);
            this.btnUbahData.Name = "btnUbahData";
            this.btnUbahData.Size = new System.Drawing.Size(84, 33);
            this.btnUbahData.TabIndex = 84;
            this.btnUbahData.Text = "Update";
            this.btnUbahData.UseVisualStyleBackColor = true;
            // 
            // btnTambahData
            // 
            this.btnTambahData.Location = new System.Drawing.Point(422, 372);
            this.btnTambahData.Name = "btnTambahData";
            this.btnTambahData.Size = new System.Drawing.Size(92, 33);
            this.btnTambahData.TabIndex = 83;
            this.btnTambahData.Text = "Tambah";
            this.btnTambahData.UseVisualStyleBackColor = true;
            // 
            // btnCariData
            // 
            this.btnCariData.Location = new System.Drawing.Point(884, 24);
            this.btnCariData.Name = "btnCariData";
            this.btnCariData.Size = new System.Drawing.Size(105, 33);
            this.btnCariData.TabIndex = 82;
            this.btnCariData.Text = "Cari";
            this.btnCariData.UseVisualStyleBackColor = true;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(201, 24);
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
            this.dgvPerawatan.Location = new System.Drawing.Point(38, 422);
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
            this.groupBox1.Controls.Add(this.cmbHasilPerawatan);
            this.groupBox1.Controls.Add(this.lblHasilPerawatan);
            this.groupBox1.Controls.Add(this.dtpTanggalPerawatan);
            this.groupBox1.Controls.Add(this.txtJenisPerawatan);
            this.groupBox1.Controls.Add(this.cmbIdPenyakit);
            this.groupBox1.Controls.Add(this.cmbPadi);
            this.groupBox1.Controls.Add(this.cmbJenisPestisida);
            this.groupBox1.Controls.Add(this.lblJenisPestisida);
            this.groupBox1.Controls.Add(this.lblTanggalPerawatan);
            this.groupBox1.Controls.Add(this.lblPenyakit);
            this.groupBox1.Controls.Add(this.lblPadi);
            this.groupBox1.Controls.Add(this.lblJenisPerawatan);
            this.groupBox1.Location = new System.Drawing.Point(38, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 286);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            // 
            // lblJenisPestisida
            // 
            this.lblJenisPestisida.AutoSize = true;
            this.lblJenisPestisida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisPestisida.Location = new System.Drawing.Point(77, 158);
            this.lblJenisPestisida.Name = "lblJenisPestisida";
            this.lblJenisPestisida.Size = new System.Drawing.Size(133, 20);
            this.lblJenisPestisida.TabIndex = 68;
            this.lblJenisPestisida.Text = "Jenis Pestisida :";
            // 
            // lblTanggalPerawatan
            // 
            this.lblTanggalPerawatan.AutoSize = true;
            this.lblTanggalPerawatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalPerawatan.Location = new System.Drawing.Point(77, 194);
            this.lblTanggalPerawatan.Name = "lblTanggalPerawatan";
            this.lblTanggalPerawatan.Size = new System.Drawing.Size(162, 20);
            this.lblTanggalPerawatan.TabIndex = 45;
            this.lblTanggalPerawatan.Text = "Tanggal Perawatan :";
            // 
            // lblPenyakit
            // 
            this.lblPenyakit.AutoSize = true;
            this.lblPenyakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenyakit.Location = new System.Drawing.Point(77, 44);
            this.lblPenyakit.Name = "lblPenyakit";
            this.lblPenyakit.Size = new System.Drawing.Size(100, 20);
            this.lblPenyakit.TabIndex = 35;
            this.lblPenyakit.Text = "Id Penyakit :";
            // 
            // lblPadi
            // 
            this.lblPadi.AutoSize = true;
            this.lblPadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPadi.Location = new System.Drawing.Point(77, 79);
            this.lblPadi.Name = "lblPadi";
            this.lblPadi.Size = new System.Drawing.Size(70, 20);
            this.lblPadi.TabIndex = 36;
            this.lblPadi.Text = "Id Padi :";
            // 
            // lblJenisPerawatan
            // 
            this.lblJenisPerawatan.AutoSize = true;
            this.lblJenisPerawatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisPerawatan.Location = new System.Drawing.Point(77, 117);
            this.lblJenisPerawatan.Name = "lblJenisPerawatan";
            this.lblJenisPerawatan.Size = new System.Drawing.Size(143, 20);
            this.lblJenisPerawatan.TabIndex = 39;
            this.lblJenisPerawatan.Text = "Jenis Perawatan :";
            // 
            // cmbJenisPestisida
            // 
            this.cmbJenisPestisida.FormattingEnabled = true;
            this.cmbJenisPestisida.Location = new System.Drawing.Point(250, 158);
            this.cmbJenisPestisida.Name = "cmbJenisPestisida";
            this.cmbJenisPestisida.Size = new System.Drawing.Size(220, 24);
            this.cmbJenisPestisida.TabIndex = 69;
            // 
            // cmbPadi
            // 
            this.cmbPadi.FormattingEnabled = true;
            this.cmbPadi.Location = new System.Drawing.Point(250, 75);
            this.cmbPadi.Name = "cmbPadi";
            this.cmbPadi.Size = new System.Drawing.Size(220, 24);
            this.cmbPadi.TabIndex = 71;
            // 
            // cmbIdPenyakit
            // 
            this.cmbIdPenyakit.FormattingEnabled = true;
            this.cmbIdPenyakit.Location = new System.Drawing.Point(250, 44);
            this.cmbIdPenyakit.Name = "cmbIdPenyakit";
            this.cmbIdPenyakit.Size = new System.Drawing.Size(220, 24);
            this.cmbIdPenyakit.TabIndex = 72;
            // 
            // txtJenisPerawatan
            // 
            this.txtJenisPerawatan.Location = new System.Drawing.Point(250, 117);
            this.txtJenisPerawatan.Name = "txtJenisPerawatan";
            this.txtJenisPerawatan.Size = new System.Drawing.Size(313, 22);
            this.txtJenisPerawatan.TabIndex = 73;
            // 
            // dtpTanggalPerawatan
            // 
            this.dtpTanggalPerawatan.Location = new System.Drawing.Point(250, 194);
            this.dtpTanggalPerawatan.Name = "dtpTanggalPerawatan";
            this.dtpTanggalPerawatan.Size = new System.Drawing.Size(236, 22);
            this.dtpTanggalPerawatan.TabIndex = 74;
            // 
            // lblHasilPerawatan
            // 
            this.lblHasilPerawatan.AutoSize = true;
            this.lblHasilPerawatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasilPerawatan.Location = new System.Drawing.Point(77, 241);
            this.lblHasilPerawatan.Name = "lblHasilPerawatan";
            this.lblHasilPerawatan.Size = new System.Drawing.Size(142, 20);
            this.lblHasilPerawatan.TabIndex = 75;
            this.lblHasilPerawatan.Text = "Hasil Perawatan :";
            // 
            // cmbHasilPerawatan
            // 
            this.cmbHasilPerawatan.FormattingEnabled = true;
            this.cmbHasilPerawatan.Location = new System.Drawing.Point(250, 241);
            this.cmbHasilPerawatan.Name = "cmbHasilPerawatan";
            this.cmbHasilPerawatan.Size = new System.Drawing.Size(220, 24);
            this.cmbHasilPerawatan.TabIndex = 76;
            // 
            // FormPerawatanPadi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 724);
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
            this.Name = "FormPerawatanPadi";
            this.Text = "Perawatan Padi";
            this.Load += new System.EventHandler(this.FormPerawatanPadi_Load);
            this.Click += new System.EventHandler(this.FormPerawatanPadi_Load);
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
        private System.Windows.Forms.Label lblJenisPestisida;
        private System.Windows.Forms.Label lblTanggalPerawatan;
        private System.Windows.Forms.Label lblPenyakit;
        private System.Windows.Forms.Label lblPadi;
        private System.Windows.Forms.Label lblJenisPerawatan;
        private System.Windows.Forms.TextBox txtJenisPerawatan;
        private System.Windows.Forms.ComboBox cmbIdPenyakit;
        private System.Windows.Forms.ComboBox cmbPadi;
        private System.Windows.Forms.ComboBox cmbJenisPestisida;
        private System.Windows.Forms.Label lblHasilPerawatan;
        private System.Windows.Forms.DateTimePicker dtpTanggalPerawatan;
        private System.Windows.Forms.ComboBox cmbHasilPerawatan;
    }
}