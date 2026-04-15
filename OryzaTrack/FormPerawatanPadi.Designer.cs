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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerawatan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdPenyakit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdHama)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTanggalPerawatan
            // 
            this.lblTanggalPerawatan.AutoSize = true;
            this.lblTanggalPerawatan.Location = new System.Drawing.Point(60, 302);
            this.lblTanggalPerawatan.Name = "lblTanggalPerawatan";
            this.lblTanggalPerawatan.Size = new System.Drawing.Size(131, 16);
            this.lblTanggalPerawatan.TabIndex = 39;
            this.lblTanggalPerawatan.Text = "Tanggal Perawatan :";
            // 
            // lblJenisPestisida
            // 
            this.lblJenisPestisida.AutoSize = true;
            this.lblJenisPestisida.Location = new System.Drawing.Point(60, 264);
            this.lblJenisPestisida.Name = "lblJenisPestisida";
            this.lblJenisPestisida.Size = new System.Drawing.Size(107, 16);
            this.lblJenisPestisida.TabIndex = 36;
            this.lblJenisPestisida.Text = "Jenis  Pestisida :";
            // 
            // lblJenisPerawatan
            // 
            this.lblJenisPerawatan.AutoSize = true;
            this.lblJenisPerawatan.Location = new System.Drawing.Point(60, 222);
            this.lblJenisPerawatan.Name = "lblJenisPerawatan";
            this.lblJenisPerawatan.Size = new System.Drawing.Size(112, 16);
            this.lblJenisPerawatan.TabIndex = 35;
            this.lblJenisPerawatan.Text = "Jenis Perawatan :";
            // 
            // lblIDPerawatan
            // 
            this.lblIDPerawatan.AutoSize = true;
            this.lblIDPerawatan.Location = new System.Drawing.Point(65, 97);
            this.lblIDPerawatan.Name = "lblIDPerawatan";
            this.lblIDPerawatan.Size = new System.Drawing.Size(87, 16);
            this.lblIDPerawatan.TabIndex = 34;
            this.lblIDPerawatan.Text = "ID Perawatan";
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Location = new System.Drawing.Point(610, 94);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(50, 16);
            this.lblJumlah.TabIndex = 33;
            this.lblJumlah.Text = "Jumlah";
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Location = new System.Drawing.Point(511, 434);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(75, 33);
            this.btnBersihkan.TabIndex = 32;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(409, 434);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 33);
            this.btnHapus.TabIndex = 31;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(304, 434);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(207, 434);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 33);
            this.btnTambah.TabIndex = 29;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(598, 31);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 33);
            this.btnCari.TabIndex = 28;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(211, 31);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(364, 33);
            this.txtCari.TabIndex = 27;
            // 
            // dtpTanggalPerawatan
            // 
            this.dtpTanggalPerawatan.Location = new System.Drawing.Point(211, 302);
            this.dtpTanggalPerawatan.Name = "dtpTanggalPerawatan";
            this.dtpTanggalPerawatan.Size = new System.Drawing.Size(200, 22);
            this.dtpTanggalPerawatan.TabIndex = 26;
            // 
            // txtJenisPestisida
            // 
            this.txtJenisPestisida.Location = new System.Drawing.Point(211, 258);
            this.txtJenisPestisida.Multiline = true;
            this.txtJenisPestisida.Name = "txtJenisPestisida";
            this.txtJenisPestisida.Size = new System.Drawing.Size(364, 22);
            this.txtJenisPestisida.TabIndex = 23;
            // 
            // txtJenisPerawatan
            // 
            this.txtJenisPerawatan.Location = new System.Drawing.Point(211, 219);
            this.txtJenisPerawatan.Multiline = true;
            this.txtJenisPerawatan.Name = "txtJenisPerawatan";
            this.txtJenisPerawatan.Size = new System.Drawing.Size(364, 22);
            this.txtJenisPerawatan.TabIndex = 22;
            // 
            // txtIdPerawatan
            // 
            this.txtIdPerawatan.Location = new System.Drawing.Point(211, 94);
            this.txtIdPerawatan.Multiline = true;
            this.txtIdPerawatan.Name = "txtIdPerawatan";
            this.txtIdPerawatan.Size = new System.Drawing.Size(364, 22);
            this.txtIdPerawatan.TabIndex = 21;
            // 
            // dgvPerawatan
            // 
            this.dgvPerawatan.AllowUserToAddRows = false;
            this.dgvPerawatan.AllowUserToDeleteRows = false;
            this.dgvPerawatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerawatan.Location = new System.Drawing.Point(68, 504);
            this.dgvPerawatan.Name = "dgvPerawatan";
            this.dgvPerawatan.ReadOnly = true;
            this.dgvPerawatan.RowHeadersWidth = 51;
            this.dgvPerawatan.RowTemplate.Height = 24;
            this.dgvPerawatan.Size = new System.Drawing.Size(668, 162);
            this.dgvPerawatan.TabIndex = 20;
            // 
            // nudIdPenyakit
            // 
            this.nudIdPenyakit.Location = new System.Drawing.Point(211, 136);
            this.nudIdPenyakit.Name = "nudIdPenyakit";
            this.nudIdPenyakit.Size = new System.Drawing.Size(364, 22);
            this.nudIdPenyakit.TabIndex = 40;
            // 
            // nudIdHama
            // 
            this.nudIdHama.Location = new System.Drawing.Point(211, 179);
            this.nudIdHama.Name = "nudIdHama";
            this.nudIdHama.Size = new System.Drawing.Size(364, 22);
            this.nudIdHama.TabIndex = 41;
            // 
            // lblIdPenyakit
            // 
            this.lblIdPenyakit.AutoSize = true;
            this.lblIdPenyakit.Location = new System.Drawing.Point(65, 138);
            this.lblIdPenyakit.Name = "lblIdPenyakit";
            this.lblIdPenyakit.Size = new System.Drawing.Size(75, 16);
            this.lblIdPenyakit.TabIndex = 42;
            this.lblIdPenyakit.Text = "ID Penyakit";
            // 
            // lblIdHama
            // 
            this.lblIdHama.AutoSize = true;
            this.lblIdHama.Location = new System.Drawing.Point(65, 181);
            this.lblIdHama.Name = "lblIdHama";
            this.lblIdHama.Size = new System.Drawing.Size(60, 16);
            this.lblIdHama.TabIndex = 43;
            this.lblIdHama.Text = "ID Hama";
            // 
            // cmbHasilPerawatan
            // 
            this.cmbHasilPerawatan.FormattingEnabled = true;
            this.cmbHasilPerawatan.Location = new System.Drawing.Point(211, 347);
            this.cmbHasilPerawatan.Name = "cmbHasilPerawatan";
            this.cmbHasilPerawatan.Size = new System.Drawing.Size(121, 24);
            this.cmbHasilPerawatan.TabIndex = 44;
            // 
            // lblHasilPerawatan
            // 
            this.lblHasilPerawatan.AutoSize = true;
            this.lblHasilPerawatan.Location = new System.Drawing.Point(65, 350);
            this.lblHasilPerawatan.Name = "lblHasilPerawatan";
            this.lblHasilPerawatan.Size = new System.Drawing.Size(111, 16);
            this.lblHasilPerawatan.TabIndex = 45;
            this.lblHasilPerawatan.Text = "Hasil Perawatan :";
            // 
            // FormPerawatanPadi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 730);
            this.Controls.Add(this.lblHasilPerawatan);
            this.Controls.Add(this.cmbHasilPerawatan);
            this.Controls.Add(this.lblIdHama);
            this.Controls.Add(this.lblIdPenyakit);
            this.Controls.Add(this.nudIdHama);
            this.Controls.Add(this.nudIdPenyakit);
            this.Controls.Add(this.lblTanggalPerawatan);
            this.Controls.Add(this.lblJenisPestisida);
            this.Controls.Add(this.lblJenisPerawatan);
            this.Controls.Add(this.lblIDPerawatan);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.btnBersihkan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.dtpTanggalPerawatan);
            this.Controls.Add(this.txtJenisPestisida);
            this.Controls.Add(this.txtJenisPerawatan);
            this.Controls.Add(this.txtIdPerawatan);
            this.Controls.Add(this.dgvPerawatan);
            this.Name = "FormPerawatanPadi";
            this.Text = "Perawatan Padi";
            this.Load += new System.EventHandler(this.FormPerawatanPadi_Load);
            this.Click += new System.EventHandler(this.FormPerawatanPadi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerawatan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdPenyakit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdHama)).EndInit();
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
    }
}