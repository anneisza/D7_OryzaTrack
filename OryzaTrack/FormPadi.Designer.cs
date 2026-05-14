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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPadi));
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
            this.vwPetaniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oryzaTrackDataSet1 = new OryzaTrack.OryzaTrackDataSet1();
            this.dgvPadi = new System.Windows.Forms.DataGridView();
            this.idPadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPetaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPetaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisBibitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokasiLahanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalTanamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwPadiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblLokasiLahan = new System.Windows.Forms.Label();
            this.lblJenisBibit = new System.Windows.Forms.Label();
            this.lblIdPetani = new System.Windows.Forms.Label();
            this.lblTanggalTanam = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTanggalTanam = new System.Windows.Forms.DateTimePicker();
            this.cmbLokasiLahan = new System.Windows.Forms.ComboBox();
            this.cmbJB = new System.Windows.Forms.ComboBox();
            this.cmbIdPetani = new System.Windows.Forms.ComboBox();
            this.vwPetaniBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vw_PetaniTableAdapter = new OryzaTrack.OryzaTrackDataSet1TableAdapters.vw_PetaniTableAdapter();
            this.vw_PadiTableAdapter = new OryzaTrack.OryzaTrackDataSet1TableAdapters.vw_PadiTableAdapter();
            this.view_combo = new OryzaTrack.view_combo();
            this.vListPetaniComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_ListPetaniComboTableAdapter = new OryzaTrack.view_comboTableAdapters.v_ListPetaniComboTableAdapter();
            this.vListBibitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_ListBibitTableAdapter = new OryzaTrack.view_comboTableAdapters.v_ListBibitTableAdapter();
            this.vListLahanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_ListLahanTableAdapter = new OryzaTrack.view_comboTableAdapters.v_ListLahanTableAdapter();
            this.petaniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petaniTableAdapter = new OryzaTrack.OryzaTrackDataSet1TableAdapters.petaniTableAdapter();
            this.padiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.padiTableAdapter = new OryzaTrack.OryzaTrackDataSet1TableAdapters.PadiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPetaniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oryzaTrackDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPadi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPadiBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwPetaniBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_combo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vListPetaniComboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vListBibitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vListLahanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petaniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padiBindingSource)).BeginInit();
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
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnKoneksi
            // 
            this.btnKoneksi.Location = new System.Drawing.Point(160, 376);
            this.btnKoneksi.Name = "btnKoneksi";
            this.btnKoneksi.Size = new System.Drawing.Size(85, 33);
            this.btnKoneksi.TabIndex = 78;
            this.btnKoneksi.Text = "Connect";
            this.btnKoneksi.UseVisualStyleBackColor = true;
            this.btnKoneksi.Click += new System.EventHandler(this.btnKoneksi_Click);
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
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(926, 296);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 25);
            this.lblTotal.TabIndex = 74;
            this.lblTotal.Text = "Jumlah :";
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Location = new System.Drawing.Point(806, 376);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(94, 33);
            this.btnBersihkan.TabIndex = 73;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // btnHapusData
            // 
            this.btnHapusData.Location = new System.Drawing.Point(696, 376);
            this.btnHapusData.Name = "btnHapusData";
            this.btnHapusData.Size = new System.Drawing.Size(84, 33);
            this.btnHapusData.TabIndex = 72;
            this.btnHapusData.Text = "Hapus";
            this.btnHapusData.UseVisualStyleBackColor = true;
            this.btnHapusData.Click += new System.EventHandler(this.btnHapusData_Click);
            // 
            // btnUbahData
            // 
            this.btnUbahData.Location = new System.Drawing.Point(573, 376);
            this.btnUbahData.Name = "btnUbahData";
            this.btnUbahData.Size = new System.Drawing.Size(84, 33);
            this.btnUbahData.TabIndex = 71;
            this.btnUbahData.Text = "Update";
            this.btnUbahData.UseVisualStyleBackColor = true;
            this.btnUbahData.Click += new System.EventHandler(this.btnUbahData_Click);
            // 
            // btnTambahData
            // 
            this.btnTambahData.Location = new System.Drawing.Point(437, 376);
            this.btnTambahData.Name = "btnTambahData";
            this.btnTambahData.Size = new System.Drawing.Size(92, 33);
            this.btnTambahData.TabIndex = 70;
            this.btnTambahData.Text = "Tambah";
            this.btnTambahData.UseVisualStyleBackColor = true;
            this.btnTambahData.Click += new System.EventHandler(this.btnTambahData_Click);
            // 
            // btnCariData
            // 
            this.btnCariData.Location = new System.Drawing.Point(899, 28);
            this.btnCariData.Name = "btnCariData";
            this.btnCariData.Size = new System.Drawing.Size(105, 33);
            this.btnCariData.TabIndex = 69;
            this.btnCariData.Text = "Cari";
            this.btnCariData.UseVisualStyleBackColor = true;
            this.btnCariData.Click += new System.EventHandler(this.btnCariData_Click);
            // 
            // txtCari
            // 
            this.txtCari.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwPetaniBindingSource, "namaPetani", true));
            this.txtCari.Location = new System.Drawing.Point(216, 28);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(667, 33);
            this.txtCari.TabIndex = 68;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // vwPetaniBindingSource
            // 
            this.vwPetaniBindingSource.DataMember = "vw_Petani";
            this.vwPetaniBindingSource.DataSource = this.oryzaTrackDataSet1;
            // 
            // oryzaTrackDataSet1
            // 
            this.oryzaTrackDataSet1.DataSetName = "OryzaTrackDataSet1";
            this.oryzaTrackDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvPadi
            // 
            this.dgvPadi.AllowUserToAddRows = false;
            this.dgvPadi.AllowUserToDeleteRows = false;
            this.dgvPadi.AutoGenerateColumns = false;
            this.dgvPadi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPadi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPadi.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPadi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPadi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPadiDataGridViewTextBoxColumn,
            this.idPetaniDataGridViewTextBoxColumn,
            this.namaPetaniDataGridViewTextBoxColumn,
            this.jenisBibitDataGridViewTextBoxColumn,
            this.lokasiLahanDataGridViewTextBoxColumn,
            this.tanggalTanamDataGridViewTextBoxColumn});
            this.dgvPadi.DataSource = this.vwPadiBindingSource;
            this.dgvPadi.Location = new System.Drawing.Point(53, 426);
            this.dgvPadi.Name = "dgvPadi";
            this.dgvPadi.ReadOnly = true;
            this.dgvPadi.RowHeadersWidth = 51;
            this.dgvPadi.RowTemplate.Height = 24;
            this.dgvPadi.Size = new System.Drawing.Size(1086, 281);
            this.dgvPadi.TabIndex = 67;
            this.dgvPadi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPadi_CellClick);
            // 
            // idPadiDataGridViewTextBoxColumn
            // 
            this.idPadiDataGridViewTextBoxColumn.DataPropertyName = "idPadi";
            this.idPadiDataGridViewTextBoxColumn.HeaderText = "idPadi";
            this.idPadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPadiDataGridViewTextBoxColumn.Name = "idPadiDataGridViewTextBoxColumn";
            this.idPadiDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPadiDataGridViewTextBoxColumn.Width = 75;
            // 
            // idPetaniDataGridViewTextBoxColumn
            // 
            this.idPetaniDataGridViewTextBoxColumn.DataPropertyName = "idPetani";
            this.idPetaniDataGridViewTextBoxColumn.HeaderText = "idPetani";
            this.idPetaniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPetaniDataGridViewTextBoxColumn.Name = "idPetaniDataGridViewTextBoxColumn";
            this.idPetaniDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPetaniDataGridViewTextBoxColumn.Width = 85;
            // 
            // namaPetaniDataGridViewTextBoxColumn
            // 
            this.namaPetaniDataGridViewTextBoxColumn.DataPropertyName = "namaPetani";
            this.namaPetaniDataGridViewTextBoxColumn.HeaderText = "namaPetani";
            this.namaPetaniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaPetaniDataGridViewTextBoxColumn.Name = "namaPetaniDataGridViewTextBoxColumn";
            this.namaPetaniDataGridViewTextBoxColumn.ReadOnly = true;
            this.namaPetaniDataGridViewTextBoxColumn.Width = 108;
            // 
            // jenisBibitDataGridViewTextBoxColumn
            // 
            this.jenisBibitDataGridViewTextBoxColumn.DataPropertyName = "jenisBibit";
            this.jenisBibitDataGridViewTextBoxColumn.HeaderText = "jenisBibit";
            this.jenisBibitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisBibitDataGridViewTextBoxColumn.Name = "jenisBibitDataGridViewTextBoxColumn";
            this.jenisBibitDataGridViewTextBoxColumn.ReadOnly = true;
            this.jenisBibitDataGridViewTextBoxColumn.Width = 90;
            // 
            // lokasiLahanDataGridViewTextBoxColumn
            // 
            this.lokasiLahanDataGridViewTextBoxColumn.DataPropertyName = "lokasiLahan";
            this.lokasiLahanDataGridViewTextBoxColumn.HeaderText = "lokasiLahan";
            this.lokasiLahanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lokasiLahanDataGridViewTextBoxColumn.Name = "lokasiLahanDataGridViewTextBoxColumn";
            this.lokasiLahanDataGridViewTextBoxColumn.ReadOnly = true;
            this.lokasiLahanDataGridViewTextBoxColumn.Width = 109;
            // 
            // tanggalTanamDataGridViewTextBoxColumn
            // 
            this.tanggalTanamDataGridViewTextBoxColumn.DataPropertyName = "tanggalTanam";
            this.tanggalTanamDataGridViewTextBoxColumn.HeaderText = "tanggalTanam";
            this.tanggalTanamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalTanamDataGridViewTextBoxColumn.Name = "tanggalTanamDataGridViewTextBoxColumn";
            this.tanggalTanamDataGridViewTextBoxColumn.ReadOnly = true;
            this.tanggalTanamDataGridViewTextBoxColumn.Width = 124;
            // 
            // vwPadiBindingSource
            // 
            this.vwPadiBindingSource.DataMember = "vw_Padi";
            this.vwPadiBindingSource.DataSource = this.oryzaTrackDataSet1;
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
            this.lblIdPetani.Size = new System.Drawing.Size(115, 20);
            this.lblIdPetani.TabIndex = 35;
            this.lblIdPetani.Text = "Nama Petani :";
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
            this.groupBox1.Controls.Add(this.cmbLokasiLahan);
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
            // dtpTanggalTanam
            // 
            this.dtpTanggalTanam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.padiBindingSource, "tanggalTanam", true));
            this.dtpTanggalTanam.Location = new System.Drawing.Point(233, 194);
            this.dtpTanggalTanam.Name = "dtpTanggalTanam";
            this.dtpTanggalTanam.Size = new System.Drawing.Size(220, 22);
            this.dtpTanggalTanam.TabIndex = 73;
            // 
            // cmbLokasiLahan
            // 
            this.cmbLokasiLahan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.padiBindingSource, "lokasiLahan", true));
            this.cmbLokasiLahan.DataSource = this.padiBindingSource;
            this.cmbLokasiLahan.FormattingEnabled = true;
            this.cmbLokasiLahan.Location = new System.Drawing.Point(233, 147);
            this.cmbLokasiLahan.Name = "cmbLokasiLahan";
            this.cmbLokasiLahan.Size = new System.Drawing.Size(220, 24);
            this.cmbLokasiLahan.TabIndex = 72;
            this.cmbLokasiLahan.ValueMember = "lokasiLahan";
            // 
            // cmbJB
            // 
            this.cmbJB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.padiBindingSource, "jenisBibit", true));
            this.cmbJB.DataSource = this.padiBindingSource;
            this.cmbJB.FormattingEnabled = true;
            this.cmbJB.Location = new System.Drawing.Point(233, 95);
            this.cmbJB.Name = "cmbJB";
            this.cmbJB.Size = new System.Drawing.Size(220, 24);
            this.cmbJB.TabIndex = 71;
            this.cmbJB.ValueMember = "jenisBibit";
            // 
            // cmbIdPetani
            // 
            this.cmbIdPetani.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petaniBindingSource, "namaPetani", true));
            this.cmbIdPetani.DataSource = this.petaniBindingSource;
            this.cmbIdPetani.FormattingEnabled = true;
            this.cmbIdPetani.Location = new System.Drawing.Point(233, 44);
            this.cmbIdPetani.Name = "cmbIdPetani";
            this.cmbIdPetani.Size = new System.Drawing.Size(220, 24);
            this.cmbIdPetani.TabIndex = 70;
            this.cmbIdPetani.ValueMember = "namaPetani";
            // 
            // vwPetaniBindingSource1
            // 
            this.vwPetaniBindingSource1.DataMember = "vw_Petani";
            this.vwPetaniBindingSource1.DataSource = this.oryzaTrackDataSet1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(1164, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(53, 733);
            this.bindingNavigator1.TabIndex = 80;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(50, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(50, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(50, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(50, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(50, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(50, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(50, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(50, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(50, 6);
            // 
            // vw_PetaniTableAdapter
            // 
            this.vw_PetaniTableAdapter.ClearBeforeFill = true;
            // 
            // vw_PadiTableAdapter
            // 
            this.vw_PadiTableAdapter.ClearBeforeFill = true;
            // 
            // view_combo
            // 
            this.view_combo.DataSetName = "view_combo";
            this.view_combo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vListPetaniComboBindingSource
            // 
            this.vListPetaniComboBindingSource.DataMember = "v_ListPetaniCombo";
            this.vListPetaniComboBindingSource.DataSource = this.view_combo;
            // 
            // v_ListPetaniComboTableAdapter
            // 
            this.v_ListPetaniComboTableAdapter.ClearBeforeFill = true;
            // 
            // vListBibitBindingSource
            // 
            this.vListBibitBindingSource.DataMember = "v_ListBibit";
            this.vListBibitBindingSource.DataSource = this.view_combo;
            // 
            // v_ListBibitTableAdapter
            // 
            this.v_ListBibitTableAdapter.ClearBeforeFill = true;
            // 
            // vListLahanBindingSource
            // 
            this.vListLahanBindingSource.DataMember = "v_ListLahan";
            this.vListLahanBindingSource.DataSource = this.view_combo;
            // 
            // v_ListLahanTableAdapter
            // 
            this.v_ListLahanTableAdapter.ClearBeforeFill = true;
            // 
            // petaniBindingSource
            // 
            this.petaniBindingSource.DataMember = "petani";
            this.petaniBindingSource.DataSource = this.oryzaTrackDataSet1;
            // 
            // petaniTableAdapter
            // 
            this.petaniTableAdapter.ClearBeforeFill = true;
            // 
            // padiBindingSource
            // 
            this.padiBindingSource.DataMember = "Padi";
            this.padiBindingSource.DataSource = this.oryzaTrackDataSet1;
            // 
            // padiTableAdapter
            // 
            this.padiTableAdapter.ClearBeforeFill = true;
            // 
            // FormPadi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 733);
            this.Controls.Add(this.bindingNavigator1);
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
            this.Controls.Add(this.dgvPadi);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPadi";
            this.Text = "FormPadi";
            this.Load += new System.EventHandler(this.FormPadi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPetaniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oryzaTrackDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPadi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPadiBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwPetaniBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_combo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vListPetaniComboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vListBibitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vListLahanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petaniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgvPadi;
        private System.Windows.Forms.Label lblLokasiLahan;
        private System.Windows.Forms.Label lblJenisBibit;
        private System.Windows.Forms.Label lblIdPetani;
        private System.Windows.Forms.Label lblTanggalTanam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbJB;
        private System.Windows.Forms.ComboBox cmbIdPetani;
        private System.Windows.Forms.ComboBox cmbLokasiLahan;
        private System.Windows.Forms.DateTimePicker dtpTanggalTanam;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private OryzaTrackDataSet1 oryzaTrackDataSet1;
        private System.Windows.Forms.BindingSource vwPetaniBindingSource;
        private OryzaTrackDataSet1TableAdapters.vw_PetaniTableAdapter vw_PetaniTableAdapter;
        private System.Windows.Forms.BindingSource vwPetaniBindingSource1;
        private System.Windows.Forms.BindingSource vwPadiBindingSource;
        private OryzaTrackDataSet1TableAdapters.vw_PadiTableAdapter vw_PadiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPetaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPetaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisBibitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokasiLahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalTanamDataGridViewTextBoxColumn;
        private view_combo view_combo;
        private System.Windows.Forms.BindingSource vListPetaniComboBindingSource;
        private view_comboTableAdapters.v_ListPetaniComboTableAdapter v_ListPetaniComboTableAdapter;
        private System.Windows.Forms.BindingSource vListBibitBindingSource;
        private view_comboTableAdapters.v_ListBibitTableAdapter v_ListBibitTableAdapter;
        private System.Windows.Forms.BindingSource vListLahanBindingSource;
        private view_comboTableAdapters.v_ListLahanTableAdapter v_ListLahanTableAdapter;
        private System.Windows.Forms.BindingSource petaniBindingSource;
        private OryzaTrackDataSet1TableAdapters.petaniTableAdapter petaniTableAdapter;
        private System.Windows.Forms.BindingSource padiBindingSource;
        private OryzaTrackDataSet1TableAdapters.PadiTableAdapter padiTableAdapter;
    }
}