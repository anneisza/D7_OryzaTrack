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
            this.lblJenisPsetisida = new System.Windows.Forms.Label();
            this.dtpTanggalSerangan = new System.Windows.Forms.DateTimePicker();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.cmbTingkatKerusakan = new System.Windows.Forms.ComboBox();
            this.lblTanggalPerawatan = new System.Windows.Forms.Label();
            this.lblIdPenyakit = new System.Windows.Forms.Label();
            this.lblIdPadi = new System.Windows.Forms.Label();
            this.lblJanisPerawatan = new System.Windows.Forms.Label();
            this.txtGejalaPenyakit = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(301, 377);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(89, 33);
            this.btnLoadData.TabIndex = 105;
            this.btnLoadData.Text = "Load";
            this.btnLoadData.UseVisualStyleBackColor = true;
            // 
            // btnKoneksi
            // 
            this.btnKoneksi.Location = new System.Drawing.Point(158, 377);
            this.btnKoneksi.Name = "btnKoneksi";
            this.btnKoneksi.Size = new System.Drawing.Size(85, 33);
            this.btnKoneksi.TabIndex = 104;
            this.btnKoneksi.Text = "Connect";
            this.btnKoneksi.UseVisualStyleBackColor = true;
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
            // 
            // btnHapusData
            // 
            this.btnHapusData.Location = new System.Drawing.Point(694, 377);
            this.btnHapusData.Name = "btnHapusData";
            this.btnHapusData.Size = new System.Drawing.Size(84, 33);
            this.btnHapusData.TabIndex = 98;
            this.btnHapusData.Text = "Hapus";
            this.btnHapusData.UseVisualStyleBackColor = true;
            // 
            // btnUbahData
            // 
            this.btnUbahData.Location = new System.Drawing.Point(571, 377);
            this.btnUbahData.Name = "btnUbahData";
            this.btnUbahData.Size = new System.Drawing.Size(84, 33);
            this.btnUbahData.TabIndex = 97;
            this.btnUbahData.Text = "Update";
            this.btnUbahData.UseVisualStyleBackColor = true;
            // 
            // btnTambahData
            // 
            this.btnTambahData.Location = new System.Drawing.Point(435, 377);
            this.btnTambahData.Name = "btnTambahData";
            this.btnTambahData.Size = new System.Drawing.Size(92, 33);
            this.btnTambahData.TabIndex = 96;
            this.btnTambahData.Text = "Tambah";
            this.btnTambahData.UseVisualStyleBackColor = true;
            // 
            // btnCariData
            // 
            this.btnCariData.Location = new System.Drawing.Point(897, 29);
            this.btnCariData.Name = "btnCariData";
            this.btnCariData.Size = new System.Drawing.Size(105, 33);
            this.btnCariData.TabIndex = 95;
            this.btnCariData.Text = "Cari";
            this.btnCariData.UseVisualStyleBackColor = true;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(214, 29);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(667, 33);
            this.txtCari.TabIndex = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblJenisPsetisida);
            this.groupBox1.Controls.Add(this.dtpTanggalSerangan);
            this.groupBox1.Controls.Add(this.cmbKategori);
            this.groupBox1.Controls.Add(this.cmbTingkatKerusakan);
            this.groupBox1.Controls.Add(this.lblTanggalPerawatan);
            this.groupBox1.Controls.Add(this.lblIdPenyakit);
            this.groupBox1.Controls.Add(this.lblIdPadi);
            this.groupBox1.Controls.Add(this.lblJanisPerawatan);
            this.groupBox1.Controls.Add(this.txtGejalaPenyakit);
            this.groupBox1.Location = new System.Drawing.Point(51, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 286);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
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
            // dtpTanggalSerangan
            // 
            this.dtpTanggalSerangan.Location = new System.Drawing.Point(256, 179);
            this.dtpTanggalSerangan.Name = "dtpTanggalSerangan";
            this.dtpTanggalSerangan.Size = new System.Drawing.Size(236, 22);
            this.dtpTanggalSerangan.TabIndex = 71;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(256, 55);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(236, 24);
            this.cmbKategori.TabIndex = 70;
            // 
            // cmbTingkatKerusakan
            // 
            this.cmbTingkatKerusakan.FormattingEnabled = true;
            this.cmbTingkatKerusakan.Location = new System.Drawing.Point(256, 131);
            this.cmbTingkatKerusakan.Name = "cmbTingkatKerusakan";
            this.cmbTingkatKerusakan.Size = new System.Drawing.Size(236, 24);
            this.cmbTingkatKerusakan.TabIndex = 69;
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
            // lblIdPadi
            // 
            this.lblIdPadi.AutoSize = true;
            this.lblIdPadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPadi.Location = new System.Drawing.Point(77, 18);
            this.lblIdPadi.Name = "lblIdPadi";
            this.lblIdPadi.Size = new System.Drawing.Size(70, 20);
            this.lblIdPadi.TabIndex = 36;
            this.lblIdPadi.Text = "Id Padi :";
            // 
            // lblJanisPerawatan
            // 
            this.lblJanisPerawatan.AutoSize = true;
            this.lblJanisPerawatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJanisPerawatan.Location = new System.Drawing.Point(77, 97);
            this.lblJanisPerawatan.Name = "lblJanisPerawatan";
            this.lblJanisPerawatan.Size = new System.Drawing.Size(143, 20);
            this.lblJanisPerawatan.TabIndex = 39;
            this.lblJanisPerawatan.Text = "Jenis Perawatan :";
            // 
            // txtGejalaPenyakit
            // 
            this.txtGejalaPenyakit.Location = new System.Drawing.Point(256, 95);
            this.txtGejalaPenyakit.Multiline = true;
            this.txtGejalaPenyakit.Name = "txtGejalaPenyakit";
            this.txtGejalaPenyakit.Size = new System.Drawing.Size(236, 22);
            this.txtGejalaPenyakit.TabIndex = 51;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(256, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 24);
            this.comboBox1.TabIndex = 73;
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
        private System.Windows.Forms.DateTimePicker dtpTanggalSerangan;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbTingkatKerusakan;
        private System.Windows.Forms.Label lblTanggalPerawatan;
        private System.Windows.Forms.Label lblIdPenyakit;
        private System.Windows.Forms.Label lblIdPadi;
        private System.Windows.Forms.Label lblJanisPerawatan;
        private System.Windows.Forms.TextBox txtGejalaPenyakit;
        private System.Windows.Forms.Label lblJenisPsetisida;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}