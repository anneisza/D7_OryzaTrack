namespace OryzaTrack
{
    partial class FormLaporan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtpTanggalAwal = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbJenisBibit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbJenisPenyakit = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.labelPerawatan = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.labelRiwayat = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblPenyakit = new System.Windows.Forms.Label();
            this.labelPenyakit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPadi = new System.Windows.Forms.Label();
            this.lblPadii = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPetani = new System.Windows.Forms.Label();
            this.labelPetani = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonTampilkan = new System.Windows.Forms.Button();
            this.dtpTanggalAkhir = new System.Windows.Forms.DateTimePicker();
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTanggalAwal
            // 
            this.dtpTanggalAwal.Location = new System.Drawing.Point(99, 76);
            this.dtpTanggalAwal.Name = "dtpTanggalAwal";
            this.dtpTanggalAwal.Size = new System.Drawing.Size(214, 22);
            this.dtpTanggalAwal.TabIndex = 0;
            this.dtpTanggalAwal.ValueChanged += new System.EventHandler(this.dtpTanggalAwal_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbJenisBibit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbJenisPenyakit);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonTampilkan);
            this.groupBox1.Controls.Add(this.dtpTanggalAkhir);
            this.groupBox1.Controls.Add(this.dtpTanggalAwal);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1818, 357);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Jenis Bibit";
            // 
            // cmbJenisBibit
            // 
            this.cmbJenisBibit.FormattingEnabled = true;
            this.cmbJenisBibit.Location = new System.Drawing.Point(99, 202);
            this.cmbJenisBibit.Name = "cmbJenisBibit";
            this.cmbJenisBibit.Size = new System.Drawing.Size(213, 24);
            this.cmbJenisBibit.TabIndex = 25;
            this.cmbJenisBibit.SelectedIndexChanged += new System.EventHandler(this.cmbJenisBibit_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Jenis Penyakit";
            // 
            // cmbJenisPenyakit
            // 
            this.cmbJenisPenyakit.FormattingEnabled = true;
            this.cmbJenisPenyakit.Location = new System.Drawing.Point(99, 260);
            this.cmbJenisPenyakit.Name = "cmbJenisPenyakit";
            this.cmbJenisPenyakit.Size = new System.Drawing.Size(213, 24);
            this.cmbJenisPenyakit.TabIndex = 23;
            this.cmbJenisPenyakit.SelectedIndexChanged += new System.EventHandler(this.cmbJenisPenyakit_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(1243, 16);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(539, 325);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(672, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 54);
            this.label6.TabIndex = 14;
            this.label6.Text = "LAPORAN";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.CadetBlue;
            this.panel10.Controls.Add(this.label25);
            this.panel10.Controls.Add(this.labelPerawatan);
            this.panel10.Location = new System.Drawing.Point(1059, 77);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(145, 110);
            this.panel10.TabIndex = 21;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(42, 7);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 48);
            this.label25.TabIndex = 12;
            this.label25.Text = "Total\r\nPerawatan\r\nPadi";
            // 
            // labelPerawatan
            // 
            this.labelPerawatan.AutoSize = true;
            this.labelPerawatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerawatan.Location = new System.Drawing.Point(3, 4);
            this.labelPerawatan.Name = "labelPerawatan";
            this.labelPerawatan.Size = new System.Drawing.Size(50, 54);
            this.labelPerawatan.TabIndex = 13;
            this.labelPerawatan.Text = "0";
            this.labelPerawatan.Click += new System.EventHandler(this.labelPerawatan_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.labelRiwayat);
            this.panel7.Location = new System.Drawing.Point(889, 76);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(145, 110);
            this.panel7.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(44, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 48);
            this.label19.TabIndex = 12;
            this.label19.Text = "Total\r\nRiwayat\r\nPenyakit";
            // 
            // labelRiwayat
            // 
            this.labelRiwayat.AutoSize = true;
            this.labelRiwayat.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRiwayat.Location = new System.Drawing.Point(3, 3);
            this.labelRiwayat.Name = "labelRiwayat";
            this.labelRiwayat.Size = new System.Drawing.Size(50, 54);
            this.labelRiwayat.TabIndex = 13;
            this.labelRiwayat.Text = "0";
            this.labelRiwayat.Click += new System.EventHandler(this.labelRiwayat_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.CadetBlue;
            this.panel8.Controls.Add(this.lblPenyakit);
            this.panel8.Controls.Add(this.labelPenyakit);
            this.panel8.Location = new System.Drawing.Point(724, 77);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(139, 110);
            this.panel8.TabIndex = 19;
            // 
            // lblPenyakit
            // 
            this.lblPenyakit.AutoSize = true;
            this.lblPenyakit.Location = new System.Drawing.Point(42, 9);
            this.lblPenyakit.Name = "lblPenyakit";
            this.lblPenyakit.Size = new System.Drawing.Size(59, 32);
            this.lblPenyakit.TabIndex = 12;
            this.lblPenyakit.Text = "Total\r\nPenyakit\r\n";
            // 
            // labelPenyakit
            // 
            this.labelPenyakit.AutoSize = true;
            this.labelPenyakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenyakit.Location = new System.Drawing.Point(3, 4);
            this.labelPenyakit.Name = "labelPenyakit";
            this.labelPenyakit.Size = new System.Drawing.Size(50, 54);
            this.labelPenyakit.TabIndex = 13;
            this.labelPenyakit.Text = "0";
            this.labelPenyakit.Click += new System.EventHandler(this.labelPenyakit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblPadi);
            this.panel1.Controls.Add(this.lblPadii);
            this.panel1.Location = new System.Drawing.Point(575, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 110);
            this.panel1.TabIndex = 18;
            // 
            // lblPadi
            // 
            this.lblPadi.AutoSize = true;
            this.lblPadi.Location = new System.Drawing.Point(48, 7);
            this.lblPadi.Name = "lblPadi";
            this.lblPadi.Size = new System.Drawing.Size(38, 32);
            this.lblPadi.TabIndex = 12;
            this.lblPadi.Text = "Total\r\nPadi";
            // 
            // lblPadii
            // 
            this.lblPadii.AutoSize = true;
            this.lblPadii.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPadii.Location = new System.Drawing.Point(3, 4);
            this.lblPadii.Name = "lblPadii";
            this.lblPadii.Size = new System.Drawing.Size(50, 54);
            this.lblPadii.TabIndex = 13;
            this.lblPadii.Text = "0";
            this.lblPadii.Click += new System.EventHandler(this.lblPadii_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.Controls.Add(this.lblPetani);
            this.panel4.Controls.Add(this.labelPetani);
            this.panel4.Location = new System.Drawing.Point(428, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(123, 110);
            this.panel4.TabIndex = 17;
            // 
            // lblPetani
            // 
            this.lblPetani.AutoSize = true;
            this.lblPetani.Location = new System.Drawing.Point(40, 9);
            this.lblPetani.Name = "lblPetani";
            this.lblPetani.Size = new System.Drawing.Size(45, 32);
            this.lblPetani.TabIndex = 12;
            this.lblPetani.Text = "Total\r\nPetani";
            // 
            // labelPetani
            // 
            this.labelPetani.AutoSize = true;
            this.labelPetani.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetani.Location = new System.Drawing.Point(0, 3);
            this.labelPetani.Name = "labelPetani";
            this.labelPetani.Size = new System.Drawing.Size(50, 54);
            this.labelPetani.TabIndex = 13;
            this.labelPetani.Text = "0";
            this.labelPetani.Click += new System.EventHandler(this.labelPadi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "s/d";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tanggal";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Khaki;
            this.buttonReset.Location = new System.Drawing.Point(203, 311);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(96, 29);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonTampilkan
            // 
            this.buttonTampilkan.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonTampilkan.Location = new System.Drawing.Point(99, 310);
            this.buttonTampilkan.Name = "buttonTampilkan";
            this.buttonTampilkan.Size = new System.Drawing.Size(98, 31);
            this.buttonTampilkan.TabIndex = 5;
            this.buttonTampilkan.Text = "Tampilkan";
            this.buttonTampilkan.UseVisualStyleBackColor = false;
            this.buttonTampilkan.Click += new System.EventHandler(this.buttonTampilkan_Click);
            // 
            // dtpTanggalAkhir
            // 
            this.dtpTanggalAkhir.Location = new System.Drawing.Point(96, 131);
            this.dtpTanggalAkhir.Name = "dtpTanggalAkhir";
            this.dtpTanggalAkhir.Size = new System.Drawing.Size(214, 22);
            this.dtpTanggalAkhir.TabIndex = 1;
            this.dtpTanggalAkhir.ValueChanged += new System.EventHandler(this.dtpTanggalAkhir_ValueChanged);
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.AllowUserToAddRows = false;
            this.dgvLaporan.AllowUserToDeleteRows = false;
            this.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaporan.Location = new System.Drawing.Point(12, 374);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.ReadOnly = true;
            this.dgvLaporan.RowHeadersWidth = 51;
            this.dgvLaporan.RowTemplate.Height = 24;
            this.dgvLaporan.Size = new System.Drawing.Size(1816, 443);
            this.dgvLaporan.TabIndex = 27;
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 844);
            this.Controls.Add(this.dgvLaporan);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLaporan";
            this.Text = "FormLaporan";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTanggalAwal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTanggalAkhir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonTampilkan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelPetani;
        private System.Windows.Forms.Label lblPetani;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPadii;
        private System.Windows.Forms.Label lblPadi;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelRiwayat;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labelPenyakit;
        private System.Windows.Forms.Label lblPenyakit;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label labelPerawatan;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbJenisBibit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbJenisPenyakit;
        private System.Windows.Forms.DataGridView dgvLaporan;
    }
}