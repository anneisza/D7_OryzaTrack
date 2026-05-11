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
            this.dgvPerawatanPadi = new System.Windows.Forms.DataGridView();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbIdPadi = new System.Windows.Forms.ComboBox();
            this.lblJenisPsetisida = new System.Windows.Forms.Label();
            this.dtpTanggalPerawatan = new System.Windows.Forms.DateTimePicker();
            this.cmbIdPenyakit = new System.Windows.Forms.ComboBox();
            this.cmbJenisPestisida = new System.Windows.Forms.ComboBox();
            this.lblTanggalPerawatan = new System.Windows.Forms.Label();
            this.lblIdPenyakit = new System.Windows.Forms.Label();
            this.liblIdPadi = new System.Windows.Forms.Label();
            this.lblJenisPerawatan = new System.Windows.Forms.Label();
            this.txtJenisPerawatan = new System.Windows.Forms.TextBox();
            this.lblHasilPerawatan = new System.Windows.Forms.Label();
            this.txtHasilPerawatan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerawatanPadi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPerawatanPadi
            // 
            this.dgvPerawatanPadi.AllowUserToAddRows = false;
            this.dgvPerawatanPadi.AllowUserToDeleteRows = false;
            this.dgvPerawatanPadi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPerawatanPadi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPerawatanPadi.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPerawatanPadi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerawatanPadi.Location = new System.Drawing.Point(51, 434);
            this.dgvPerawatanPadi.Name = "dgvPerawatanPadi";
            this.dgvPerawatanPadi.ReadOnly = true;
            this.dgvPerawatanPadi.RowHeadersWidth = 51;
            this.dgvPerawatanPadi.RowTemplate.Height = 24;
            this.dgvPerawatanPadi.Size = new System.Drawing.Size(1086, 281);
            this.dgvPerawatanPadi.TabIndex = 106;
            this.dgvPerawatanPadi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerawatanPadi_CellClick);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(301, 377);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(89, 33);
            this.btnLoadData.TabIndex = 105;
            this.btnLoadData.Text = "Load";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnKoneksi
            // 
            this.btnKoneksi.Location = new System.Drawing.Point(158, 377);
            this.btnKoneksi.Name = "btnKoneksi";
            this.btnKoneksi.Size = new System.Drawing.Size(85, 33);
            this.btnKoneksi.TabIndex = 104;
            this.btnKoneksi.Text = "Connect";
            this.btnKoneksi.UseVisualStyleBackColor = true;
            this.btnKoneksi.Click += new System.EventHandler(this.btnKoneksi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(929, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Location = new System.Drawing.Point(73, 26);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(115, 36);
            this.lblSearch.TabIndex = 102;
            this.lblSearch.Text = "Search";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(924, 297);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 25);
            this.lblTotal.TabIndex = 100;
            this.lblTotal.Text = "Jumlah :";
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Location = new System.Drawing.Point(804, 377);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(94, 33);
            this.btnBersihkan.TabIndex = 99;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // btnHapusData
            // 
            this.btnHapusData.Location = new System.Drawing.Point(694, 377);
            this.btnHapusData.Name = "btnHapusData";
            this.btnHapusData.Size = new System.Drawing.Size(84, 33);
            this.btnHapusData.TabIndex = 98;
            this.btnHapusData.Text = "Hapus";
            this.btnHapusData.UseVisualStyleBackColor = true;
            this.btnHapusData.Click += new System.EventHandler(this.btnHapusData_Click);
            // 
            // btnUbahData
            // 
            this.btnUbahData.Location = new System.Drawing.Point(571, 377);
            this.btnUbahData.Name = "btnUbahData";
            this.btnUbahData.Size = new System.Drawing.Size(84, 33);
            this.btnUbahData.TabIndex = 97;
            this.btnUbahData.Text = "Update";
            this.btnUbahData.UseVisualStyleBackColor = true;
            this.btnUbahData.Click += new System.EventHandler(this.btnUbahData_Click);
            // 
            // btnTambahData
            // 
            this.btnTambahData.Location = new System.Drawing.Point(435, 377);
            this.btnTambahData.Name = "btnTambahData";
            this.btnTambahData.Size = new System.Drawing.Size(92, 33);
            this.btnTambahData.TabIndex = 96;
            this.btnTambahData.Text = "Tambah";
            this.btnTambahData.UseVisualStyleBackColor = true;
            this.btnTambahData.Click += new System.EventHandler(this.btnTambahData_Click);
            // 
            // btnCariData
            // 
            this.btnCariData.Location = new System.Drawing.Point(897, 29);
            this.btnCariData.Name = "btnCariData";
            this.btnCariData.Size = new System.Drawing.Size(105, 33);
            this.btnCariData.TabIndex = 95;
            this.btnCariData.Text = "Cari";
            this.btnCariData.UseVisualStyleBackColor = true;
            this.btnCariData.Click += new System.EventHandler(this.btnCariData_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(214, 29);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(667, 33);
            this.txtCari.TabIndex = 94;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.txtHasilPerawatan);
            this.groupBox1.Controls.Add(this.lblHasilPerawatan);
            this.groupBox1.Controls.Add(this.cmbIdPadi);
            this.groupBox1.Controls.Add(this.lblJenisPsetisida);
            this.groupBox1.Controls.Add(this.dtpTanggalPerawatan);
            this.groupBox1.Controls.Add(this.cmbIdPenyakit);
            this.groupBox1.Controls.Add(this.cmbJenisPestisida);
            this.groupBox1.Controls.Add(this.lblTanggalPerawatan);
            this.groupBox1.Controls.Add(this.lblIdPenyakit);
            this.groupBox1.Controls.Add(this.liblIdPadi);
            this.groupBox1.Controls.Add(this.lblJenisPerawatan);
            this.groupBox1.Controls.Add(this.txtJenisPerawatan);
            this.groupBox1.Location = new System.Drawing.Point(51, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 286);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            // 
            // cmbIdPadi
            // 
            this.cmbIdPadi.FormattingEnabled = true;
            this.cmbIdPadi.Location = new System.Drawing.Point(256, 18);
            this.cmbIdPadi.Name = "cmbIdPadi";
            this.cmbIdPadi.Size = new System.Drawing.Size(236, 24);
            this.cmbIdPadi.TabIndex = 73;
            // 
            // lblJenisPsetisida
            // 
            this.lblJenisPsetisida.AutoSize = true;
            this.lblJenisPsetisida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisPsetisida.Location = new System.Drawing.Point(77, 135);
            this.lblJenisPsetisida.Name = "lblJenisPsetisida";
            this.lblJenisPsetisida.Size = new System.Drawing.Size(133, 20);
            this.lblJenisPsetisida.TabIndex = 72;
            this.lblJenisPsetisida.Text = "Jenis Pestisida :";
            // 
            // dtpTanggalPerawatan
            // 
            this.dtpTanggalPerawatan.Location = new System.Drawing.Point(256, 179);
            this.dtpTanggalPerawatan.Name = "dtpTanggalPerawatan";
            this.dtpTanggalPerawatan.Size = new System.Drawing.Size(236, 22);
            this.dtpTanggalPerawatan.TabIndex = 71;
            // 
            // cmbIdPenyakit
            // 
            this.cmbIdPenyakit.FormattingEnabled = true;
            this.cmbIdPenyakit.Location = new System.Drawing.Point(256, 55);
            this.cmbIdPenyakit.Name = "cmbIdPenyakit";
            this.cmbIdPenyakit.Size = new System.Drawing.Size(236, 24);
            this.cmbIdPenyakit.TabIndex = 70;
            // 
            // cmbJenisPestisida
            // 
            this.cmbJenisPestisida.FormattingEnabled = true;
            this.cmbJenisPestisida.Location = new System.Drawing.Point(256, 131);
            this.cmbJenisPestisida.Name = "cmbJenisPestisida";
            this.cmbJenisPestisida.Size = new System.Drawing.Size(236, 24);
            this.cmbJenisPestisida.TabIndex = 69;
            // 
            // lblTanggalPerawatan
            // 
            this.lblTanggalPerawatan.AutoSize = true;
            this.lblTanggalPerawatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalPerawatan.Location = new System.Drawing.Point(77, 179);
            this.lblTanggalPerawatan.Name = "lblTanggalPerawatan";
            this.lblTanggalPerawatan.Size = new System.Drawing.Size(167, 20);
            this.lblTanggalPerawatan.TabIndex = 68;
            this.lblTanggalPerawatan.Text = "Tanggal Perawatan : ";
            // 
            // lblIdPenyakit
            // 
            this.lblIdPenyakit.AutoSize = true;
            this.lblIdPenyakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPenyakit.Location = new System.Drawing.Point(77, 59);
            this.lblIdPenyakit.Name = "lblIdPenyakit";
            this.lblIdPenyakit.Size = new System.Drawing.Size(105, 20);
            this.lblIdPenyakit.TabIndex = 35;
            this.lblIdPenyakit.Text = "Id Penyakit  :";
            // 
            // liblIdPadi
            // 
            this.liblIdPadi.AutoSize = true;
            this.liblIdPadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liblIdPadi.Location = new System.Drawing.Point(77, 18);
            this.liblIdPadi.Name = "liblIdPadi";
            this.liblIdPadi.Size = new System.Drawing.Size(70, 20);
            this.liblIdPadi.TabIndex = 36;
            this.liblIdPadi.Text = "Id Padi :";
            // 
            // lblJenisPerawatan
            // 
            this.lblJenisPerawatan.AutoSize = true;
            this.lblJenisPerawatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisPerawatan.Location = new System.Drawing.Point(77, 97);
            this.lblJenisPerawatan.Name = "lblJenisPerawatan";
            this.lblJenisPerawatan.Size = new System.Drawing.Size(143, 20);
            this.lblJenisPerawatan.TabIndex = 39;
            this.lblJenisPerawatan.Text = "Jenis Perawatan :";
            // 
            // txtJenisPerawatan
            // 
            this.txtJenisPerawatan.Location = new System.Drawing.Point(256, 95);
            this.txtJenisPerawatan.Multiline = true;
            this.txtJenisPerawatan.Name = "txtJenisPerawatan";
            this.txtJenisPerawatan.Size = new System.Drawing.Size(236, 22);
            this.txtJenisPerawatan.TabIndex = 51;
            // 
            // lblHasilPerawatan
            // 
            this.lblHasilPerawatan.AutoSize = true;
            this.lblHasilPerawatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasilPerawatan.Location = new System.Drawing.Point(77, 221);
            this.lblHasilPerawatan.Name = "lblHasilPerawatan";
            this.lblHasilPerawatan.Size = new System.Drawing.Size(142, 20);
            this.lblHasilPerawatan.TabIndex = 74;
            this.lblHasilPerawatan.Text = "Hasil Perawatan: ";
            // 
            // txtHasilPerawatan
            // 
            this.txtHasilPerawatan.Location = new System.Drawing.Point(256, 219);
            this.txtHasilPerawatan.Multiline = true;
            this.txtHasilPerawatan.Name = "txtHasilPerawatan";
            this.txtHasilPerawatan.Size = new System.Drawing.Size(236, 22);
            this.txtHasilPerawatan.TabIndex = 75;
            // 
            // FormPerawatanPadi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 741);
            this.Controls.Add(this.dgvPerawatanPadi);
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
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPerawatanPadi";
            this.Text = "FormPerawatanPadi";
            this.Load += new System.EventHandler(this.FormPerawatanPadi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerawatanPadi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPerawatanPadi;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTanggalPerawatan;
        private System.Windows.Forms.ComboBox cmbIdPenyakit;
        private System.Windows.Forms.ComboBox cmbJenisPestisida;
        private System.Windows.Forms.Label lblTanggalPerawatan;
        private System.Windows.Forms.Label lblIdPenyakit;
        private System.Windows.Forms.Label liblIdPadi;
        private System.Windows.Forms.Label lblJenisPerawatan;
        private System.Windows.Forms.TextBox txtJenisPerawatan;
        private System.Windows.Forms.Label lblJenisPsetisida;
        private System.Windows.Forms.ComboBox cmbIdPadi;
        private System.Windows.Forms.TextBox txtHasilPerawatan;
        private System.Windows.Forms.Label lblHasilPerawatan;
    }
}