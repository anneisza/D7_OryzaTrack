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
            this.lblTanggalSerangan = new System.Windows.Forms.Label();
            this.lblLokasiLahan = new System.Windows.Forms.Label();
            this.lblTingkatKerusakan = new System.Windows.Forms.Label();
            this.lblNamaHama = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.dtpTanggalSerangan = new System.Windows.Forms.DateTimePicker();
            this.txtLokasiLahan = new System.Windows.Forms.TextBox();
            this.txtGejalaPenyakit = new System.Windows.Forms.TextBox();
            this.txtIdPenyakit = new System.Windows.Forms.TextBox();
            this.dgvPenyakit = new System.Windows.Forms.DataGridView();
            this.cmbTingkatKerusakan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenyakit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTanggalSerangan
            // 
            this.lblTanggalSerangan.AutoSize = true;
            this.lblTanggalSerangan.Location = new System.Drawing.Point(65, 301);
            this.lblTanggalSerangan.Name = "lblTanggalSerangan";
            this.lblTanggalSerangan.Size = new System.Drawing.Size(126, 16);
            this.lblTanggalSerangan.TabIndex = 39;
            this.lblTanggalSerangan.Text = "Tanggal Serangan :";
            // 
            // lblLokasiLahan
            // 
            this.lblLokasiLahan.AutoSize = true;
            this.lblLokasiLahan.Location = new System.Drawing.Point(65, 229);
            this.lblLokasiLahan.Name = "lblLokasiLahan";
            this.lblLokasiLahan.Size = new System.Drawing.Size(93, 16);
            this.lblLokasiLahan.TabIndex = 38;
            this.lblLokasiLahan.Text = "Lokasi Lahan :";
            // 
            // lblTingkatKerusakan
            // 
            this.lblTingkatKerusakan.AutoSize = true;
            this.lblTingkatKerusakan.Location = new System.Drawing.Point(65, 174);
            this.lblTingkatKerusakan.Name = "lblTingkatKerusakan";
            this.lblTingkatKerusakan.Size = new System.Drawing.Size(125, 16);
            this.lblTingkatKerusakan.TabIndex = 37;
            this.lblTingkatKerusakan.Text = "Tingkat Kerusakan :";
            // 
            // lblNamaHama
            // 
            this.lblNamaHama.AutoSize = true;
            this.lblNamaHama.Location = new System.Drawing.Point(65, 130);
            this.lblNamaHama.Name = "lblNamaHama";
            this.lblNamaHama.Size = new System.Drawing.Size(90, 16);
            this.lblNamaHama.TabIndex = 35;
            this.lblNamaHama.Text = "Nama Hama :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(65, 90);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 34;
            this.lblID.Text = "ID";
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Location = new System.Drawing.Point(610, 87);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(50, 16);
            this.lblJumlah.TabIndex = 33;
            this.lblJumlah.Text = "Jumlah";
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Location = new System.Drawing.Point(511, 339);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(75, 33);
            this.btnBersihkan.TabIndex = 32;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(409, 339);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 33);
            this.btnHapus.TabIndex = 31;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(304, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(207, 339);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 33);
            this.btnTambah.TabIndex = 29;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(598, 24);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 33);
            this.btnCari.TabIndex = 28;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(211, 24);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(364, 33);
            this.txtCari.TabIndex = 27;
            // 
            // dtpTanggalSerangan
            // 
            this.dtpTanggalSerangan.Location = new System.Drawing.Point(211, 296);
            this.dtpTanggalSerangan.Name = "dtpTanggalSerangan";
            this.dtpTanggalSerangan.Size = new System.Drawing.Size(200, 22);
            this.dtpTanggalSerangan.TabIndex = 26;
            // 
            // txtLokasiLahan
            // 
            this.txtLokasiLahan.Location = new System.Drawing.Point(211, 223);
            this.txtLokasiLahan.Multiline = true;
            this.txtLokasiLahan.Name = "txtLokasiLahan";
            this.txtLokasiLahan.Size = new System.Drawing.Size(364, 22);
            this.txtLokasiLahan.TabIndex = 25;
            // 
            // txtGejalaPenyakit
            // 
            this.txtGejalaPenyakit.Location = new System.Drawing.Point(211, 127);
            this.txtGejalaPenyakit.Multiline = true;
            this.txtGejalaPenyakit.Name = "txtGejalaPenyakit";
            this.txtGejalaPenyakit.Size = new System.Drawing.Size(364, 22);
            this.txtGejalaPenyakit.TabIndex = 22;
            // 
            // txtIdPenyakit
            // 
            this.txtIdPenyakit.Location = new System.Drawing.Point(211, 87);
            this.txtIdPenyakit.Multiline = true;
            this.txtIdPenyakit.Name = "txtIdPenyakit";
            this.txtIdPenyakit.Size = new System.Drawing.Size(364, 22);
            this.txtIdPenyakit.TabIndex = 21;
            // 
            // dgvPenyakit
            // 
            this.dgvPenyakit.AllowUserToAddRows = false;
            this.dgvPenyakit.AllowUserToDeleteRows = false;
            this.dgvPenyakit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenyakit.Location = new System.Drawing.Point(68, 387);
            this.dgvPenyakit.Name = "dgvPenyakit";
            this.dgvPenyakit.ReadOnly = true;
            this.dgvPenyakit.RowHeadersWidth = 51;
            this.dgvPenyakit.RowTemplate.Height = 24;
            this.dgvPenyakit.Size = new System.Drawing.Size(668, 162);
            this.dgvPenyakit.TabIndex = 20;
            // 
            // cmbTingkatKerusakan
            // 
            this.cmbTingkatKerusakan.FormattingEnabled = true;
            this.cmbTingkatKerusakan.Location = new System.Drawing.Point(211, 174);
            this.cmbTingkatKerusakan.Name = "cmbTingkatKerusakan";
            this.cmbTingkatKerusakan.Size = new System.Drawing.Size(364, 24);
            this.cmbTingkatKerusakan.TabIndex = 40;
            // 
            // FormRiwayatPenyakit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.cmbTingkatKerusakan);
            this.Controls.Add(this.lblTanggalSerangan);
            this.Controls.Add(this.lblLokasiLahan);
            this.Controls.Add(this.lblTingkatKerusakan);
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
            this.Controls.Add(this.txtGejalaPenyakit);
            this.Controls.Add(this.txtIdPenyakit);
            this.Controls.Add(this.dgvPenyakit);
            this.Name = "FormRiwayatPenyakit";
            this.Text = "FormRiwayatPenyakit";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenyakit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTanggalSerangan;
        private System.Windows.Forms.Label lblLokasiLahan;
        private System.Windows.Forms.Label lblTingkatKerusakan;
        private System.Windows.Forms.Label lblNamaHama;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DateTimePicker dtpTanggalSerangan;
        private System.Windows.Forms.TextBox txtLokasiLahan;
        private System.Windows.Forms.TextBox txtGejalaPenyakit;
        private System.Windows.Forms.TextBox txtIdPenyakit;
        private System.Windows.Forms.DataGridView dgvPenyakit;
        private System.Windows.Forms.ComboBox cmbTingkatKerusakan;
    }
}