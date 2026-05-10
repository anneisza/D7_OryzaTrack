namespace OryzaTrack
{
    partial class FormPadi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPadi));
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
            this.lblLokasiLahan = new System.Windows.Forms.Label();
            this.lblJenisBibit = new System.Windows.Forms.Label();
            this.lblIdPetani = new System.Windows.Forms.Label();
            this.lblTanggalTanam = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbIdPetani = new System.Windows.Forms.ComboBox();
            this.cmbJB = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpTanggalTanam = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerawatan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(303, 376);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(89, 33);
            this.btnLoadData.TabIndex = 79;
            this.btnLoadData.Text = "Load";
            this.btnLoadData.UseVisualStyleBackColor = true;
            // 
            // btnKoneksi
            // 
            this.btnKoneksi.Location = new System.Drawing.Point(160, 376);
            this.btnKoneksi.Name = "btnKoneksi";
            this.btnKoneksi.Size = new System.Drawing.Size(85, 33);
            this.btnKoneksi.TabIndex = 78;
            this.btnKoneksi.Text = "Connect";
            this.btnKoneksi.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(931, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Location = new System.Drawing.Point(75, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(115, 36);
            this.lblSearch.TabIndex = 76;
            this.lblSearch.Text = "Search";
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblJumlah.Location = new System.Drawing.Point(926, 296);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(87, 25);
            this.lblJumlah.TabIndex = 74;
            this.lblJumlah.Text = "Jumlah :";
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Location = new System.Drawing.Point(806, 376);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(94, 33);
            this.btnBersihkan.TabIndex = 73;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            // 
            // btnHapusData
            // 
            this.btnHapusData.Location = new System.Drawing.Point(696, 376);
            this.btnHapusData.Name = "btnHapusData";
            this.btnHapusData.Size = new System.Drawing.Size(84, 33);
            this.btnHapusData.TabIndex = 72;
            this.btnHapusData.Text = "Hapus";
            this.btnHapusData.UseVisualStyleBackColor = true;
            // 
            // btnUbahData
            // 
            this.btnUbahData.Location = new System.Drawing.Point(573, 376);
            this.btnUbahData.Name = "btnUbahData";
            this.btnUbahData.Size = new System.Drawing.Size(84, 33);
            this.btnUbahData.TabIndex = 71;
            this.btnUbahData.Text = "Update";
            this.btnUbahData.UseVisualStyleBackColor = true;
            // 
            // btnTambahData
            // 
            this.btnTambahData.Location = new System.Drawing.Point(437, 376);
            this.btnTambahData.Name = "btnTambahData";
            this.btnTambahData.Size = new System.Drawing.Size(92, 33);
            this.btnTambahData.TabIndex = 70;
            this.btnTambahData.Text = "Tambah";
            this.btnTambahData.UseVisualStyleBackColor = true;
            // 
            // btnCariData
            // 
            this.btnCariData.Location = new System.Drawing.Point(899, 28);
            this.btnCariData.Name = "btnCariData";
            this.btnCariData.Size = new System.Drawing.Size(105, 33);
            this.btnCariData.TabIndex = 69;
            this.btnCariData.Text = "Cari";
            this.btnCariData.UseVisualStyleBackColor = true;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(216, 28);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(667, 33);
            this.txtCari.TabIndex = 68;
            // 
            // dgvPerawatan
            // 
            this.dgvPerawatan.AllowUserToAddRows = false;
            this.dgvPerawatan.AllowUserToDeleteRows = false;
            this.dgvPerawatan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPerawatan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPerawatan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPerawatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerawatan.Location = new System.Drawing.Point(53, 426);
            this.dgvPerawatan.Name = "dgvPerawatan";
            this.dgvPerawatan.ReadOnly = true;
            this.dgvPerawatan.RowHeadersWidth = 51;
            this.dgvPerawatan.RowTemplate.Height = 24;
            this.dgvPerawatan.Size = new System.Drawing.Size(1086, 281);
            this.dgvPerawatan.TabIndex = 67;
            // 
            // lblLokasiLahan
            // 
            this.lblLokasiLahan.AutoSize = true;
            this.lblLokasiLahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokasiLahan.Location = new System.Drawing.Point(77, 147);
            this.lblLokasiLahan.Name = "lblLokasiLahan";
            this.lblLokasiLahan.Size = new System.Drawing.Size(119, 20);
            this.lblLokasiLahan.TabIndex = 39;
            this.lblLokasiLahan.Text = "Lokasi Lahan :";
            // 
            // lblJenisBibit
            // 
            this.lblJenisBibit.AutoSize = true;
            this.lblJenisBibit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisBibit.Location = new System.Drawing.Point(77, 95);
            this.lblJenisBibit.Name = "lblJenisBibit";
            this.lblJenisBibit.Size = new System.Drawing.Size(98, 20);
            this.lblJenisBibit.TabIndex = 36;
            this.lblJenisBibit.Text = "Jenis Bibit :";
            // 
            // lblIdPetani
            // 
            this.lblIdPetani.AutoSize = true;
            this.lblIdPetani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPetani.Location = new System.Drawing.Point(77, 44);
            this.lblIdPetani.Name = "lblIdPetani";
            this.lblIdPetani.Size = new System.Drawing.Size(84, 20);
            this.lblIdPetani.TabIndex = 35;
            this.lblIdPetani.Text = "Id Petani :";
            // 
            // lblTanggalTanam
            // 
            this.lblTanggalTanam.AutoSize = true;
            this.lblTanggalTanam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalTanam.Location = new System.Drawing.Point(77, 194);
            this.lblTanggalTanam.Name = "lblTanggalTanam";
            this.lblTanggalTanam.Size = new System.Drawing.Size(134, 20);
            this.lblTanggalTanam.TabIndex = 68;
            this.lblTanggalTanam.Text = "Tanggal Tanam :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.dtpTanggalTanam);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cmbJB);
            this.groupBox1.Controls.Add(this.cmbIdPetani);
            this.groupBox1.Controls.Add(this.lblTanggalTanam);
            this.groupBox1.Controls.Add(this.lblIdPetani);
            this.groupBox1.Controls.Add(this.lblJenisBibit);
            this.groupBox1.Controls.Add(this.lblLokasiLahan);
            this.groupBox1.Location = new System.Drawing.Point(53, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 286);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // cmbIdPetani
            // 
            this.cmbIdPetani.FormattingEnabled = true;
            this.cmbIdPetani.Location = new System.Drawing.Point(233, 44);
            this.cmbIdPetani.Name = "cmbIdPetani";
            this.cmbIdPetani.Size = new System.Drawing.Size(220, 24);
            this.cmbIdPetani.TabIndex = 70;
            // 
            // cmbJB
            // 
            this.cmbJB.FormattingEnabled = true;
            this.cmbJB.Location = new System.Drawing.Point(233, 95);
            this.cmbJB.Name = "cmbJB";
            this.cmbJB.Size = new System.Drawing.Size(220, 24);
            this.cmbJB.TabIndex = 71;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(233, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 24);
            this.comboBox1.TabIndex = 72;
            // 
            // dtpTanggalTanam
            // 
            this.dtpTanggalTanam.Location = new System.Drawing.Point(233, 194);
            this.dtpTanggalTanam.Name = "dtpTanggalTanam";
            this.dtpTanggalTanam.Size = new System.Drawing.Size(220, 22);
            this.dtpTanggalTanam.TabIndex = 73;
            // 
            // FormPadi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 733);
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
            this.Name = "FormPadi";
            this.Text = "FormPadi";
            this.Load += new System.EventHandler(this.FormPadi_Load);
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
        private System.Windows.Forms.Label lblLokasiLahan;
        private System.Windows.Forms.Label lblJenisBibit;
        private System.Windows.Forms.Label lblIdPetani;
        private System.Windows.Forms.Label lblTanggalTanam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbJB;
        private System.Windows.Forms.ComboBox cmbIdPetani;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtpTanggalTanam;
    }
}