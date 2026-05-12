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
            this.dtpTanggalAwal = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonTampilkan = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbTingkatKerusakan = new System.Windows.Forms.ComboBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.dtpTanggalAkhir = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelPetani = new System.Windows.Forms.Label();
            this.lblPetani = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPadii = new System.Windows.Forms.Label();
            this.lblPadi = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelRiwayat = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelPenyakit = new System.Windows.Forms.Label();
            this.lblPenyakit = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelPerawatan = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.dgvPetani = new System.Windows.Forms.DataGridView();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.Petani = new System.Windows.Forms.TabPage();
            this.Padi = new System.Windows.Forms.TabPage();
            this.dgvPadi = new System.Windows.Forms.DataGridView();
            this.Penyakit = new System.Windows.Forms.TabPage();
            this.dgvPenyakit = new System.Windows.Forms.DataGridView();
            this.Riwayat = new System.Windows.Forms.TabPage();
            this.Perawatan = new System.Windows.Forms.TabPage();
            this.dgvPerawatan = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvRiwayat = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetani)).BeginInit();
            this.tabCtrl.SuspendLayout();
            this.Petani.SuspendLayout();
            this.Padi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPadi)).BeginInit();
            this.Penyakit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenyakit)).BeginInit();
            this.Riwayat.SuspendLayout();
            this.Perawatan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerawatan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTanggalAwal
            // 
            this.dtpTanggalAwal.Location = new System.Drawing.Point(40, 122);
            this.dtpTanggalAwal.Name = "dtpTanggalAwal";
            this.dtpTanggalAwal.Size = new System.Drawing.Size(361, 22);
            this.dtpTanggalAwal.TabIndex = 0;
            this.dtpTanggalAwal.ValueChanged += new System.EventHandler(this.dtpTanggalAwal_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonTampilkan);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.cmbTingkatKerusakan);
            this.groupBox1.Controls.Add(this.cmbKategori);
            this.groupBox1.Controls.Add(this.dtpTanggalAkhir);
            this.groupBox1.Controls.Add(this.dtpTanggalAwal);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status Petani";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tingkat Kerusakan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "s/d";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tanggal";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Khaki;
            this.buttonReset.Location = new System.Drawing.Point(127, 252);
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
            this.buttonTampilkan.Location = new System.Drawing.Point(23, 251);
            this.buttonTampilkan.Name = "buttonTampilkan";
            this.buttonTampilkan.Size = new System.Drawing.Size(98, 31);
            this.buttonTampilkan.TabIndex = 5;
            this.buttonTampilkan.Text = "Tampilkan";
            this.buttonTampilkan.UseVisualStyleBackColor = false;
            this.buttonTampilkan.Click += new System.EventHandler(this.buttonTampilkan_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Semua",
            "Aktif",
            "Tidak Aktif"});
            this.cmbStatus.Location = new System.Drawing.Point(460, 219);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(358, 24);
            this.cmbStatus.TabIndex = 4;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // cmbTingkatKerusakan
            // 
            this.cmbTingkatKerusakan.FormattingEnabled = true;
            this.cmbTingkatKerusakan.Items.AddRange(new object[] {
            "Semua",
            "Kecil",
            "Sedang",
            "Besar"});
            this.cmbTingkatKerusakan.Location = new System.Drawing.Point(460, 173);
            this.cmbTingkatKerusakan.Name = "cmbTingkatKerusakan";
            this.cmbTingkatKerusakan.Size = new System.Drawing.Size(358, 24);
            this.cmbTingkatKerusakan.TabIndex = 3;
            this.cmbTingkatKerusakan.SelectedIndexChanged += new System.EventHandler(this.cmbTingkatKerusakan_SelectedIndexChanged);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Semua",
            "Hama",
            "Penyakit"});
            this.cmbKategori.Location = new System.Drawing.Point(459, 126);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(358, 24);
            this.cmbKategori.TabIndex = 2;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // dtpTanggalAkhir
            // 
            this.dtpTanggalAkhir.Location = new System.Drawing.Point(40, 169);
            this.dtpTanggalAkhir.Name = "dtpTanggalAkhir";
            this.dtpTanggalAkhir.Size = new System.Drawing.Size(361, 22);
            this.dtpTanggalAkhir.TabIndex = 1;
            this.dtpTanggalAkhir.ValueChanged += new System.EventHandler(this.dtpTanggalAkhir_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.Controls.Add(this.labelPetani);
            this.panel4.Controls.Add(this.lblPetani);
            this.panel4.Location = new System.Drawing.Point(28, 305);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 61);
            this.panel4.TabIndex = 17;
            // 
            // labelPetani
            // 
            this.labelPetani.AutoSize = true;
            this.labelPetani.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetani.Location = new System.Drawing.Point(13, 5);
            this.labelPetani.Name = "labelPetani";
            this.labelPetani.Size = new System.Drawing.Size(50, 54);
            this.labelPetani.TabIndex = 13;
            this.labelPetani.Text = "0";
            this.labelPetani.Click += new System.EventHandler(this.labelPadi_Click);
            // 
            // lblPetani
            // 
            this.lblPetani.AutoSize = true;
            this.lblPetani.Location = new System.Drawing.Point(69, 19);
            this.lblPetani.Name = "lblPetani";
            this.lblPetani.Size = new System.Drawing.Size(45, 32);
            this.lblPetani.TabIndex = 12;
            this.lblPetani.Text = "Total\r\nPetani";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblPadii);
            this.panel1.Controls.Add(this.lblPadi);
            this.panel1.Location = new System.Drawing.Point(192, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 61);
            this.panel1.TabIndex = 18;
            // 
            // lblPadii
            // 
            this.lblPadii.AutoSize = true;
            this.lblPadii.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPadii.Location = new System.Drawing.Point(13, 5);
            this.lblPadii.Name = "lblPadii";
            this.lblPadii.Size = new System.Drawing.Size(50, 54);
            this.lblPadii.TabIndex = 13;
            this.lblPadii.Text = "0";
            this.lblPadii.Click += new System.EventHandler(this.lblPadii_Click);
            // 
            // lblPadi
            // 
            this.lblPadi.AutoSize = true;
            this.lblPadi.Location = new System.Drawing.Point(80, 15);
            this.lblPadi.Name = "lblPadi";
            this.lblPadi.Size = new System.Drawing.Size(38, 32);
            this.lblPadi.TabIndex = 12;
            this.lblPadi.Text = "Total\r\nPadi";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.Controls.Add(this.labelRiwayat);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Location = new System.Drawing.Point(523, 307);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(148, 61);
            this.panel7.TabIndex = 20;
            // 
            // labelRiwayat
            // 
            this.labelRiwayat.AutoSize = true;
            this.labelRiwayat.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRiwayat.Location = new System.Drawing.Point(13, 5);
            this.labelRiwayat.Name = "labelRiwayat";
            this.labelRiwayat.Size = new System.Drawing.Size(50, 54);
            this.labelRiwayat.TabIndex = 13;
            this.labelRiwayat.Text = "0";
            this.labelRiwayat.Click += new System.EventHandler(this.labelRiwayat_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(69, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 48);
            this.label19.TabIndex = 12;
            this.label19.Text = "Total\r\nRiwayat\r\nPenyakit";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.CadetBlue;
            this.panel8.Controls.Add(this.labelPenyakit);
            this.panel8.Controls.Add(this.lblPenyakit);
            this.panel8.Location = new System.Drawing.Point(357, 307);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(148, 61);
            this.panel8.TabIndex = 19;
            // 
            // labelPenyakit
            // 
            this.labelPenyakit.AutoSize = true;
            this.labelPenyakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenyakit.Location = new System.Drawing.Point(13, 5);
            this.labelPenyakit.Name = "labelPenyakit";
            this.labelPenyakit.Size = new System.Drawing.Size(50, 54);
            this.labelPenyakit.TabIndex = 13;
            this.labelPenyakit.Text = "0";
            this.labelPenyakit.Click += new System.EventHandler(this.labelPenyakit_Click);
            // 
            // lblPenyakit
            // 
            this.lblPenyakit.AutoSize = true;
            this.lblPenyakit.Location = new System.Drawing.Point(69, 17);
            this.lblPenyakit.Name = "lblPenyakit";
            this.lblPenyakit.Size = new System.Drawing.Size(59, 32);
            this.lblPenyakit.TabIndex = 12;
            this.lblPenyakit.Text = "Total\r\nPenyakit\r\n";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.CadetBlue;
            this.panel10.Controls.Add(this.labelPerawatan);
            this.panel10.Controls.Add(this.label25);
            this.panel10.Location = new System.Drawing.Point(689, 310);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(148, 61);
            this.panel10.TabIndex = 21;
            // 
            // labelPerawatan
            // 
            this.labelPerawatan.AutoSize = true;
            this.labelPerawatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerawatan.Location = new System.Drawing.Point(13, 5);
            this.labelPerawatan.Name = "labelPerawatan";
            this.labelPerawatan.Size = new System.Drawing.Size(50, 54);
            this.labelPerawatan.TabIndex = 13;
            this.labelPerawatan.Text = "0";
            this.labelPerawatan.Click += new System.EventHandler(this.labelPerawatan_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(66, 4);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 48);
            this.label25.TabIndex = 12;
            this.label25.Text = "Total\r\nPerawatan\r\nPadi";
            // 
            // dgvPetani
            // 
            this.dgvPetani.AllowUserToAddRows = false;
            this.dgvPetani.AllowUserToDeleteRows = false;
            this.dgvPetani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPetani.Location = new System.Drawing.Point(19, 21);
            this.dgvPetani.Name = "dgvPetani";
            this.dgvPetani.ReadOnly = true;
            this.dgvPetani.RowHeadersWidth = 51;
            this.dgvPetani.RowTemplate.Height = 24;
            this.dgvPetani.Size = new System.Drawing.Size(804, 293);
            this.dgvPetani.TabIndex = 22;
            this.dgvPetani.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPetani_CellContentClick);
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.Petani);
            this.tabCtrl.Controls.Add(this.Padi);
            this.tabCtrl.Controls.Add(this.Penyakit);
            this.tabCtrl.Controls.Add(this.Riwayat);
            this.tabCtrl.Controls.Add(this.Perawatan);
            this.tabCtrl.Location = new System.Drawing.Point(10, 374);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(855, 366);
            this.tabCtrl.TabIndex = 23;
            // 
            // Petani
            // 
            this.Petani.BackColor = System.Drawing.Color.Azure;
            this.Petani.Controls.Add(this.dgvPetani);
            this.Petani.Location = new System.Drawing.Point(4, 25);
            this.Petani.Name = "Petani";
            this.Petani.Padding = new System.Windows.Forms.Padding(3);
            this.Petani.Size = new System.Drawing.Size(847, 337);
            this.Petani.TabIndex = 0;
            this.Petani.Text = "Petani";
            // 
            // Padi
            // 
            this.Padi.BackColor = System.Drawing.Color.Honeydew;
            this.Padi.Controls.Add(this.dgvPadi);
            this.Padi.Location = new System.Drawing.Point(4, 25);
            this.Padi.Name = "Padi";
            this.Padi.Size = new System.Drawing.Size(847, 337);
            this.Padi.TabIndex = 2;
            this.Padi.Text = "Padi";
            // 
            // dgvPadi
            // 
            this.dgvPadi.AllowUserToAddRows = false;
            this.dgvPadi.AllowUserToDeleteRows = false;
            this.dgvPadi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPadi.Location = new System.Drawing.Point(19, 17);
            this.dgvPadi.Name = "dgvPadi";
            this.dgvPadi.ReadOnly = true;
            this.dgvPadi.RowHeadersWidth = 51;
            this.dgvPadi.RowTemplate.Height = 24;
            this.dgvPadi.Size = new System.Drawing.Size(807, 296);
            this.dgvPadi.TabIndex = 24;
            this.dgvPadi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPadi_CellContentClick);
            // 
            // Penyakit
            // 
            this.Penyakit.BackColor = System.Drawing.Color.Azure;
            this.Penyakit.Controls.Add(this.dgvPenyakit);
            this.Penyakit.Location = new System.Drawing.Point(4, 25);
            this.Penyakit.Name = "Penyakit";
            this.Penyakit.Padding = new System.Windows.Forms.Padding(3);
            this.Penyakit.Size = new System.Drawing.Size(847, 337);
            this.Penyakit.TabIndex = 1;
            this.Penyakit.Text = "Penyakit";
            // 
            // dgvPenyakit
            // 
            this.dgvPenyakit.AllowUserToAddRows = false;
            this.dgvPenyakit.AllowUserToDeleteRows = false;
            this.dgvPenyakit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenyakit.Location = new System.Drawing.Point(19, 17);
            this.dgvPenyakit.Name = "dgvPenyakit";
            this.dgvPenyakit.ReadOnly = true;
            this.dgvPenyakit.RowHeadersWidth = 51;
            this.dgvPenyakit.RowTemplate.Height = 24;
            this.dgvPenyakit.Size = new System.Drawing.Size(809, 299);
            this.dgvPenyakit.TabIndex = 24;
            this.dgvPenyakit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPenyakit_CellContentClick);
            // 
            // Riwayat
            // 
            this.Riwayat.BackColor = System.Drawing.Color.Honeydew;
            this.Riwayat.Controls.Add(this.dgvRiwayat);
            this.Riwayat.Location = new System.Drawing.Point(4, 25);
            this.Riwayat.Name = "Riwayat";
            this.Riwayat.Size = new System.Drawing.Size(847, 337);
            this.Riwayat.TabIndex = 3;
            this.Riwayat.Text = "Riwayat Penyakit";
            // 
            // Perawatan
            // 
            this.Perawatan.BackColor = System.Drawing.Color.Azure;
            this.Perawatan.Controls.Add(this.dgvPerawatan);
            this.Perawatan.Location = new System.Drawing.Point(4, 25);
            this.Perawatan.Name = "Perawatan";
            this.Perawatan.Size = new System.Drawing.Size(847, 337);
            this.Perawatan.TabIndex = 4;
            this.Perawatan.Text = "Perawatan Padi";
            // 
            // dgvPerawatan
            // 
            this.dgvPerawatan.AllowUserToAddRows = false;
            this.dgvPerawatan.AllowUserToDeleteRows = false;
            this.dgvPerawatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerawatan.Location = new System.Drawing.Point(19, 15);
            this.dgvPerawatan.Name = "dgvPerawatan";
            this.dgvPerawatan.ReadOnly = true;
            this.dgvPerawatan.RowHeadersWidth = 51;
            this.dgvPerawatan.RowTemplate.Height = 24;
            this.dgvPerawatan.Size = new System.Drawing.Size(809, 300);
            this.dgvPerawatan.TabIndex = 24;
            this.dgvPerawatan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerawatan_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 54);
            this.label6.TabIndex = 14;
            this.label6.Text = "LAPORAN";
            // 
            // dgvRiwayat
            // 
            this.dgvRiwayat.AllowUserToAddRows = false;
            this.dgvRiwayat.AllowUserToDeleteRows = false;
            this.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRiwayat.Location = new System.Drawing.Point(19, 19);
            this.dgvRiwayat.Name = "dgvRiwayat";
            this.dgvRiwayat.ReadOnly = true;
            this.dgvRiwayat.RowHeadersWidth = 51;
            this.dgvRiwayat.RowTemplate.Height = 24;
            this.dgvRiwayat.Size = new System.Drawing.Size(809, 299);
            this.dgvRiwayat.TabIndex = 25;
            this.dgvRiwayat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRiwayat_CellContentClick);
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 753);
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLaporan";
            this.Text = "FormLaporan";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetani)).EndInit();
            this.tabCtrl.ResumeLayout(false);
            this.Petani.ResumeLayout(false);
            this.Padi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPadi)).EndInit();
            this.Penyakit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenyakit)).EndInit();
            this.Riwayat.ResumeLayout(false);
            this.Perawatan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerawatan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTanggalAwal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTanggalAkhir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonTampilkan;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbTingkatKerusakan;
        private System.Windows.Forms.ComboBox cmbKategori;
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
        private System.Windows.Forms.DataGridView dgvPetani;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage Petani;
        private System.Windows.Forms.TabPage Penyakit;
        private System.Windows.Forms.TabPage Padi;
        private System.Windows.Forms.TabPage Riwayat;
        private System.Windows.Forms.DataGridView dgvPadi;
        private System.Windows.Forms.DataGridView dgvPenyakit;
        private System.Windows.Forms.TabPage Perawatan;
        private System.Windows.Forms.DataGridView dgvPerawatan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvRiwayat;
    }
}