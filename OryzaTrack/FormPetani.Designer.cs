namespace OryzaTrack
{
    partial class FormPetani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPetani));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.nudIdHama = new System.Windows.Forms.NumericUpDown();
            this.nudIdPenyakit = new System.Windows.Forms.NumericUpDown();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.txtJenisPestisida = new System.Windows.Forms.TextBox();
            this.txtJenisPerawatan = new System.Windows.Forms.TextBox();
            this.txtIdPerawatan = new System.Windows.Forms.TextBox();
            this.dgvPerawatan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHasilPerawatan = new System.Windows.Forms.Label();
            this.cmbHasilPerawatan = new System.Windows.Forms.ComboBox();
            this.lblIdHama = new System.Windows.Forms.Label();
            this.lblIdPenyakit = new System.Windows.Forms.Label();
            this.lblJenisPerawatan = new System.Windows.Forms.Label();
            this.lblJenisPestisida = new System.Windows.Forms.Label();
            this.lblTanggalPerawatan = new System.Windows.Forms.Label();
            this.lblIDPerawatan = new System.Windows.Forms.Label();
            this.dtpTanggalPerawatan = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdHama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdPenyakit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerawatan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(946, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Location = new System.Drawing.Point(90, 21);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(115, 36);
            this.lblSearch.TabIndex = 63;
            this.lblSearch.Text = "Search";
            // 
            // nudIdHama
            // 
            this.nudIdHama.Location = new System.Drawing.Point(281, 172);
            this.nudIdHama.Name = "nudIdHama";
            this.nudIdHama.Size = new System.Drawing.Size(617, 22);
            this.nudIdHama.TabIndex = 61;
            // 
            // nudIdPenyakit
            // 
            this.nudIdPenyakit.Location = new System.Drawing.Point(281, 129);
            this.nudIdPenyakit.Name = "nudIdPenyakit";
            this.nudIdPenyakit.Size = new System.Drawing.Size(617, 22);
            this.nudIdPenyakit.TabIndex = 60;
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblJumlah.Location = new System.Drawing.Point(941, 292);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(87, 25);
            this.lblJumlah.TabIndex = 59;
            this.lblJumlah.Text = "Jumlah :";
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Location = new System.Drawing.Point(821, 388);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(94, 33);
            this.btnBersihkan.TabIndex = 58;
            this.btnBersihkan.Text = "Refresh";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(719, 388);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 33);
            this.btnHapus.TabIndex = 57;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(614, 388);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(517, 388);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 33);
            this.btnTambah.TabIndex = 55;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(914, 24);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(105, 33);
            this.btnCari.TabIndex = 54;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(231, 24);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(667, 33);
            this.txtCari.TabIndex = 53;
            // 
            // txtJenisPestisida
            // 
            this.txtJenisPestisida.Location = new System.Drawing.Point(281, 251);
            this.txtJenisPestisida.Multiline = true;
            this.txtJenisPestisida.Name = "txtJenisPestisida";
            this.txtJenisPestisida.Size = new System.Drawing.Size(617, 22);
            this.txtJenisPestisida.TabIndex = 52;
            // 
            // txtJenisPerawatan
            // 
            this.txtJenisPerawatan.Location = new System.Drawing.Point(281, 212);
            this.txtJenisPerawatan.Multiline = true;
            this.txtJenisPerawatan.Name = "txtJenisPerawatan";
            this.txtJenisPerawatan.Size = new System.Drawing.Size(617, 22);
            this.txtJenisPerawatan.TabIndex = 51;
            // 
            // txtIdPerawatan
            // 
            this.txtIdPerawatan.Location = new System.Drawing.Point(281, 87);
            this.txtIdPerawatan.Multiline = true;
            this.txtIdPerawatan.Name = "txtIdPerawatan";
            this.txtIdPerawatan.Size = new System.Drawing.Size(617, 22);
            this.txtIdPerawatan.TabIndex = 50;
            // 
            // dgvPerawatan
            // 
            this.dgvPerawatan.AllowUserToAddRows = false;
            this.dgvPerawatan.AllowUserToDeleteRows = false;
            this.dgvPerawatan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPerawatan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPerawatan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPerawatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerawatan.Location = new System.Drawing.Point(68, 440);
            this.dgvPerawatan.Name = "dgvPerawatan";
            this.dgvPerawatan.ReadOnly = true;
            this.dgvPerawatan.RowHeadersWidth = 51;
            this.dgvPerawatan.RowTemplate.Height = 24;
            this.dgvPerawatan.Size = new System.Drawing.Size(1086, 162);
            this.dgvPerawatan.TabIndex = 49;
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
            this.groupBox1.Location = new System.Drawing.Point(68, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 311);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
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
            // cmbHasilPerawatan
            // 
            this.cmbHasilPerawatan.FormattingEnabled = true;
            this.cmbHasilPerawatan.Location = new System.Drawing.Point(213, 269);
            this.cmbHasilPerawatan.Name = "cmbHasilPerawatan";
            this.cmbHasilPerawatan.Size = new System.Drawing.Size(220, 24);
            this.cmbHasilPerawatan.TabIndex = 44;
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
            // lblIDPerawatan
            // 
            this.lblIDPerawatan.AutoSize = true;
            this.lblIDPerawatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPerawatan.Location = new System.Drawing.Point(12, 22);
            this.lblIDPerawatan.Name = "lblIDPerawatan";
            this.lblIDPerawatan.Size = new System.Drawing.Size(110, 20);
            this.lblIDPerawatan.TabIndex = 34;
            this.lblIDPerawatan.Text = "ID Perawatan";
            // 
            // dtpTanggalPerawatan
            // 
            this.dtpTanggalPerawatan.Location = new System.Drawing.Point(213, 224);
            this.dtpTanggalPerawatan.Name = "dtpTanggalPerawatan";
            this.dtpTanggalPerawatan.Size = new System.Drawing.Size(220, 22);
            this.dtpTanggalPerawatan.TabIndex = 26;
            // 
            // FormPetani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 616);
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
            this.Name = "FormPetani";
            this.Text = "FormPetani";
            this.Load += new System.EventHandler(this.FormPetani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdHama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdPenyakit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerawatan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.NumericUpDown nudIdHama;
        private System.Windows.Forms.NumericUpDown nudIdPenyakit;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.TextBox txtJenisPestisida;
        private System.Windows.Forms.TextBox txtJenisPerawatan;
        private System.Windows.Forms.TextBox txtIdPerawatan;
        private System.Windows.Forms.DataGridView dgvPerawatan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHasilPerawatan;
        private System.Windows.Forms.ComboBox cmbHasilPerawatan;
        private System.Windows.Forms.Label lblIdHama;
        private System.Windows.Forms.Label lblIdPenyakit;
        private System.Windows.Forms.Label lblJenisPerawatan;
        private System.Windows.Forms.Label lblJenisPestisida;
        private System.Windows.Forms.Label lblTanggalPerawatan;
        private System.Windows.Forms.Label lblIDPerawatan;
        private System.Windows.Forms.DateTimePicker dtpTanggalPerawatan;
    }
}