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
            this.lblTotalPenyakit = new System.Windows.Forms.Label();
            this.lblTotalHama = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            this.lblTotalPerawatan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalPenyakit
            // 
            this.lblTotalPenyakit.AutoSize = true;
            this.lblTotalPenyakit.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPenyakit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTotalPenyakit.Location = new System.Drawing.Point(15, 18);
            this.lblTotalPenyakit.Name = "lblTotalPenyakit";
            this.lblTotalPenyakit.Size = new System.Drawing.Size(270, 49);
            this.lblTotalPenyakit.TabIndex = 56;
            this.lblTotalPenyakit.Text = "Total Penyakit :";
            // 
            // lblTotalHama
            // 
            this.lblTotalHama.AutoSize = true;
            this.lblTotalHama.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHama.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalHama.Location = new System.Drawing.Point(9, 18);
            this.lblTotalHama.Name = "lblTotalHama";
            this.lblTotalHama.Size = new System.Drawing.Size(234, 49);
            this.lblTotalHama.TabIndex = 55;
            this.lblTotalHama.Text = "Total Hama : ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(440, 687);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(257, 56);
            this.btnRefresh.TabIndex = 51;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.AllowUserToAddRows = false;
            this.dgvLaporan.AllowUserToDeleteRows = false;
            this.dgvLaporan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLaporan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLaporan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaporan.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLaporan.Location = new System.Drawing.Point(57, 12);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.ReadOnly = true;
            this.dgvLaporan.RowHeadersWidth = 51;
            this.dgvLaporan.RowTemplate.Height = 24;
            this.dgvLaporan.Size = new System.Drawing.Size(1026, 303);
            this.dgvLaporan.TabIndex = 41;
            // 
            // lblTotalPerawatan
            // 
            this.lblTotalPerawatan.AutoSize = true;
            this.lblTotalPerawatan.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPerawatan.Location = new System.Drawing.Point(21, 18);
            this.lblTotalPerawatan.Name = "lblTotalPerawatan";
            this.lblTotalPerawatan.Size = new System.Drawing.Size(292, 49);
            this.lblTotalPerawatan.TabIndex = 57;
            this.lblTotalPerawatan.Text = "Total Perawatan : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.lblTotalHama);
            this.groupBox1.Location = new System.Drawing.Point(57, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1026, 84);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.Controls.Add(this.lblTotalPenyakit);
            this.groupBox2.Location = new System.Drawing.Point(57, 456);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1026, 84);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox3.Controls.Add(this.lblTotalPerawatan);
            this.groupBox3.Location = new System.Drawing.Point(57, 574);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1026, 84);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1148, 783);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvLaporan);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLaporan";
            this.Text = "Form Laporan";
            this.Load += new System.EventHandler(this.FormLaporan_Load_1);
            this.Click += new System.EventHandler(this.FormLaporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTotalPenyakit;
        private System.Windows.Forms.Label lblTotalHama;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvLaporan;
        private System.Windows.Forms.Label lblTotalPerawatan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}