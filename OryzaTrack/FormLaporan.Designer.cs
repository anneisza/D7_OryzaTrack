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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalPenyakit
            // 
            this.lblTotalPenyakit.AutoSize = true;
            this.lblTotalPenyakit.Location = new System.Drawing.Point(65, 226);
            this.lblTotalPenyakit.Name = "lblTotalPenyakit";
            this.lblTotalPenyakit.Size = new System.Drawing.Size(99, 16);
            this.lblTotalPenyakit.TabIndex = 56;
            this.lblTotalPenyakit.Text = "Total Penyakit :";
            // 
            // lblTotalHama
            // 
            this.lblTotalHama.AutoSize = true;
            this.lblTotalHama.Location = new System.Drawing.Point(65, 171);
            this.lblTotalHama.Name = "lblTotalHama";
            this.lblTotalHama.Size = new System.Drawing.Size(87, 16);
            this.lblTotalHama.TabIndex = 55;
            this.lblTotalHama.Text = "Total Hama : ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(68, 69);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(668, 33);
            this.btnRefresh.TabIndex = 51;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.AllowUserToAddRows = false;
            this.dgvLaporan.AllowUserToDeleteRows = false;
            this.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaporan.Location = new System.Drawing.Point(68, 384);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.ReadOnly = true;
            this.dgvLaporan.RowHeadersWidth = 51;
            this.dgvLaporan.RowTemplate.Height = 24;
            this.dgvLaporan.Size = new System.Drawing.Size(668, 162);
            this.dgvLaporan.TabIndex = 41;
            // 
            // lblTotalPerawatan
            // 
            this.lblTotalPerawatan.AutoSize = true;
            this.lblTotalPerawatan.Location = new System.Drawing.Point(71, 284);
            this.lblTotalPerawatan.Name = "lblTotalPerawatan";
            this.lblTotalPerawatan.Size = new System.Drawing.Size(114, 16);
            this.lblTotalPerawatan.TabIndex = 57;
            this.lblTotalPerawatan.Text = "Total Perawatan : ";
            // 
            // Form1Laporancs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.lblTotalPerawatan);
            this.Controls.Add(this.lblTotalPenyakit);
            this.Controls.Add(this.lblTotalHama);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvLaporan);
            this.Name = "Form1Laporancs";
            this.Text = "Form Laporan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotalPenyakit;
        private System.Windows.Forms.Label lblTotalHama;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvLaporan;
        private System.Windows.Forms.Label lblTotalPerawatan;
    }
}