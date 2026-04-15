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
            this.lblTanggalPerawatan = new System.Windows.Forms.Label();
            this.lblJenisPestisida = new System.Windows.Forms.Label();
            this.lblJenisPerawatan = new System.Windows.Forms.Label();
            this.lblIDPerawatan = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.dtpTanggalPerawatan = new System.Windows.Forms.DateTimePicker();
            this.txtJenisPestisida = new System.Windows.Forms.TextBox();
            this.txtJenisPerawatan = new System.Windows.Forms.TextBox();
            this.txtIdPerawatan = new System.Windows.Forms.TextBox();
            this.dgvPerawatan = new System.Windows.Forms.DataGridView();
            this.nudIdPenyakit = new System.Windows.Forms.NumericUpDown();
            this.nudIdHama = new System.Windows.Forms.NumericUpDown();
            this.lblIdPenyakit = new System.Windows.Forms.Label();
            this.lblIdHama = new System.Windows.Forms.Label();
            this.cmbHasilPerawatan = new System.Windows.Forms.ComboBox();
            this.lblHasilPerawatan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerawatan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdPenyakit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdHama)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTanggalPerawatan
            // 
            this.lblTanggalPerawatan.AutoSize = true;
            this.lblTanggalPerawatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalPerawatan.Location = new System.Drawing.Point(6, 224);
            this.lblTanggalPerawatan.Name = "lblTanggalPerawatan";
            this.lblTanggalPerawatan.Size = new System.Drawing.Size(162, 20);
            this.lblTanggalPerawatan.TabIndex = 39;
            this.lblTanggalPerawatan.Text = "Tanggal Perawatan :";
            // 
            // lblJenisPestisida
            // 
            this.lblJenisPestisida.AutoSize = true;
            this.lblJenisPestisida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisPestisida.Location = new System.Drawing.Point(5, 186);
            this.lblJenisPestisida.Name = "lblJenisPestisida";
            this.lblJenisPestisida.Size = new System.Drawing.Size(138, 20);
            this.lblJenisPestisida.TabIndex = 36;
            this.lblJenisPestisida.Text = "Jenis  Pestisida :";
            // 
            // lblJenisPerawatan
            // 
            this.lblJenisPerawatan.AutoSize = true;
            this.lblJenisPerawatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisPerawatan.Location = new System.Drawing.Point(5, 147);
            this.lblJenisPerawatan.Name = "lblJenisPerawatan";
            this.lblJenisPerawatan.Size = new System.Drawing.Size(143, 20);
            this.lblJenisPerawatan.TabIndex = 35;
            this.lblJenisPerawatan.Text = "Jenis Perawatan :";
            // 
            // lblIDPerawatan
            // 
            this.lblIDPerawatan.AutoSize = true;
            this.lblIDPerawatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPerawatan.Location = new System.Drawing.Point(12, 22);
            this.lblIDPerawatan.Name = "lblIDPerawatan";
            this.lblIDPerawatan.Size = new System.Drawing.Size(110, 20);
            this.lblIDPerawatan.TabIndex = 34;
            this.lblIDPerawatan.Text = "ID Perawatan";
            this.lblIDPerawatan.Click += new System.EventHandler(this.lblIDPerawatan_Click);
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblJumlah.Location = new System.Drawing.Point(919, 281);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(87, 25);
            this.lblJumlah.TabIndex = 33;
            this.lblJumlah.Text = "Jumlah :";
            this.lblJumlah.Click += new System.EventHandler(this.lblJumlah_Click);
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Location = new System.Drawing.Point(799, 377);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(94, 33);
            this.btnBersihkan.TabIndex = 32;
            this.btnBersihkan.Text = "Refresh";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(697, 377);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 33);
            this.btnHapus.TabIndex = 31;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(592, 377);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(495, 377);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 33);
            this.btnTambah.TabIndex = 29;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(892, 13);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(105, 33);
            this.btnCari.TabIndex = 28;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(209, 13);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(667, 33);
            this.txtCari.TabIndex = 27;
            // 
            // dtpTanggalPerawatan
            // 
            this.dtpTanggalPerawatan.Location = new System.Drawing.Point(213, 224);
            this.dtpTanggalPerawatan.Name = "dtpTanggalPerawatan";
            this.dtpTanggalPerawatan.Size = new System.Drawing.Size(220, 22);
            this.dtpTanggalPerawatan.TabIndex = 26;
            // 
            // txtJenisPestisida
            // 
            this.txtJenisPestisida.Location = new System.Drawing.Point(259, 240);
            this.txtJenisPestisida.Multiline = true;
            this.txtJenisPestisida.Name = "txtJenisPestisida";
            this.txtJenisPestisida.Size = new System.Drawing.Size(617, 22);
            this.txtJenisPestisida.TabIndex = 23;
            // 
            // txtJenisPerawatan
            // 
            this.txtJenisPerawatan.Location = new System.Drawing.Point(259, 201);
            this.txtJenisPerawatan.Multiline = true;
            this.txtJenisPerawatan.Name = "txtJenisPerawatan";
            this.txtJenisPerawatan.Size = new System.Drawing.Size(617, 22);
            this.txtJenisPerawatan.TabIndex = 22;
            // 
            // txtIdPerawatan
            // 
            this.txtIdPerawatan.Location = new System.Drawing.Point(259, 76);
            this.txtIdPerawatan.Multiline = true;
            this.txtIdPerawatan.Name = "txtIdPerawatan";
            this.txtIdPerawatan.Size = new System.Drawing.Size(617, 22);
            this.txtIdPerawatan.TabIndex = 21;
            // 
            // dgvPerawatan
            // 
            this.dgvPerawatan.AllowUserToAddRows = false;
            this.dgvPerawatan.AllowUserToDeleteRows = false;
            this.dgvPerawatan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPerawatan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPerawatan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPerawatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerawatan.Location = new System.Drawing.Point(46, 429);
            this.dgvPerawatan.Name = "dgvPerawatan";
            this.dgvPerawatan.ReadOnly = true;
            this.dgvPerawatan.RowHeadersWidth = 51;
            this.dgvPerawatan.RowTemplate.Height = 24;
            this.dgvPerawatan.Size = new System.Drawing.Size(1086, 162);
            this.dgvPerawatan.TabIndex = 20;
            // 
            // nudIdPenyakit
            // 
            this.nudIdPenyakit.Location = new System.Drawing.Point(259, 118);
            this.nudIdPenyakit.Name = "nudIdPenyakit";
            this.nudIdPenyakit.Size = new System.Drawing.Size(617, 22);
            this.nudIdPenyakit.TabIndex = 40;
            // 
            // nudIdHama
            // 
            this.nudIdHama.Location = new System.Drawing.Point(259, 161);
            this.nudIdHama.Name = "nudIdHama";
            this.nudIdHama.Size = new System.Drawing.Size(617, 22);
            this.nudIdHama.TabIndex = 41;
            // 
            // lblIdPenyakit
            // 
            this.lblIdPenyakit.AutoSize = true;
            this.lblIdPenyakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPenyakit.Location = new System.Drawing.Point(12, 60);
            this.lblIdPenyakit.Name = "lblIdPenyakit";
            this.lblIdPenyakit.Size = new System.Drawing.Size(94, 20);
            this.lblIdPenyakit.TabIndex = 42;
            this.lblIdPenyakit.Text = "ID Penyakit";
            // 
            // lblIdHama
            // 
            this.lblIdHama.AutoSize = true;
            this.lblIdHama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdHama.Location = new System.Drawing.Point(12, 103);
            this.lblIdHama.Name = "lblIdHama";
            this.lblIdHama.Size = new System.Drawing.Size(76, 20);
            this.lblIdHama.TabIndex = 43;
            this.lblIdHama.Text = "ID Hama";
            // 
            // cmbHasilPerawatan
            // 
            this.cmbHasilPerawatan.FormattingEnabled = true;
            this.cmbHasilPerawatan.Location = new System.Drawing.Point(213, 269);
            this.cmbHasilPerawatan.Name = "cmbHasilPerawatan";
            this.cmbHasilPerawatan.Size = new System.Drawing.Size(220, 24);
            this.cmbHasilPerawatan.TabIndex = 44;
            // 
            // lblHasilPerawatan
            // 
            this.lblHasilPerawatan.AutoSize = true;
            this.lblHasilPerawatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasilPerawatan.Location = new System.Drawing.Point(6, 269);
            this.lblHasilPerawatan.Name = "lblHasilPerawatan";
            this.lblHasilPerawatan.Size = new System.Drawing.Size(142, 20);
            this.lblHasilPerawatan.TabIndex = 45;
            this.lblHasilPerawatan.Text = "Hasil Perawatan :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.lblHasilPerawatan);
            this.groupBox1.Controls.Add(this.cmbHasilPerawatan);
            this.groupBox1.Controls.Add(this.lblIdHama);
            this.groupBox1.Controls.Add(this.lblIdPenyakit);
            this.groupBox1.Controls.Add(this.lblJenisPerawatan);
            this.groupBox1.Controls.Add(this.lblJenisPestisida);
            this.groupBox1.Controls.Add(this.lblTanggalPerawatan);
            this.groupBox1.Controls.Add(this.lblIDPerawatan);
            this.groupBox1.Controls.Add(this.dtpTanggalPerawatan);
            this.groupBox1.Location = new System.Drawing.Point(46, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 311);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Location = new System.Drawing.Point(68, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(115, 36);
            this.lblSearch.TabIndex = 47;
            this.lblSearch.Text = "Search";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(924, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // FormPerawatanPadi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1162, 610);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.nudIdHama);
            this.Controls.Add(this.nudIdPenyakit);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.btnBersihkan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.txtJenisPestisida);
            this.Controls.Add(this.txtJenisPerawatan);
            this.Controls.Add(this.txtIdPerawatan);
            this.Controls.Add(this.dgvPerawatan);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPerawatanPadi";
            this.Text = "Perawatan Padi";
            this.Load += new System.EventHandler(this.FormPerawatanPadi_Load);
            this.Click += new System.EventHandler(this.FormPerawatanPadi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerawatan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdPenyakit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdHama)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTanggalPerawatan;
        private System.Windows.Forms.Label lblJenisPestisida;
        private System.Windows.Forms.Label lblJenisPerawatan;
        private System.Windows.Forms.Label lblIDPerawatan;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DateTimePicker dtpTanggalPerawatan;
        private System.Windows.Forms.TextBox txtJenisPestisida;
        private System.Windows.Forms.TextBox txtJenisPerawatan;
        private System.Windows.Forms.TextBox txtIdPerawatan;
        private System.Windows.Forms.DataGridView dgvPerawatan;
        private System.Windows.Forms.NumericUpDown nudIdPenyakit;
        private System.Windows.Forms.NumericUpDown nudIdHama;
        private System.Windows.Forms.Label lblIdPenyakit;
        private System.Windows.Forms.Label lblIdHama;
        private System.Windows.Forms.ComboBox cmbHasilPerawatan;
        private System.Windows.Forms.Label lblHasilPerawatan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}