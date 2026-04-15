namespace OryzaTrack
{
    partial class FormMenu
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
            this.btnHama = new System.Windows.Forms.Button();
            this.btnPenyakit = new System.Windows.Forms.Button();
            this.btnPerawatan = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHama
            // 
            this.btnHama.Location = new System.Drawing.Point(150, 91);
            this.btnHama.Name = "btnHama";
            this.btnHama.Size = new System.Drawing.Size(241, 42);
            this.btnHama.TabIndex = 0;
            this.btnHama.Text = "Kelola Hama";
            this.btnHama.UseVisualStyleBackColor = true;
            // 
            // btnPenyakit
            // 
            this.btnPenyakit.Location = new System.Drawing.Point(150, 162);
            this.btnPenyakit.Name = "btnPenyakit";
            this.btnPenyakit.Size = new System.Drawing.Size(241, 42);
            this.btnPenyakit.TabIndex = 1;
            this.btnPenyakit.Text = "Kelola Riwayat Penyakit";
            this.btnPenyakit.UseVisualStyleBackColor = true;
            // 
            // btnPerawatan
            // 
            this.btnPerawatan.Location = new System.Drawing.Point(150, 236);
            this.btnPerawatan.Name = "btnPerawatan";
            this.btnPerawatan.Size = new System.Drawing.Size(241, 42);
            this.btnPerawatan.TabIndex = 2;
            this.btnPerawatan.Text = "Kelola Perawatan Padi";
            this.btnPerawatan.UseVisualStyleBackColor = true;
            // 
            // btnLaporan
            // 
            this.btnLaporan.Location = new System.Drawing.Point(150, 314);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(241, 42);
            this.btnLaporan.TabIndex = 3;
            this.btnLaporan.Text = "Laporan Keseluruhan";
            this.btnLaporan.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(150, 395);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(241, 42);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(235, 36);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 16);
            this.lblWelcome.TabIndex = 5;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnPerawatan);
            this.Controls.Add(this.btnPenyakit);
            this.Controls.Add(this.btnHama);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHama;
        private System.Windows.Forms.Button btnPenyakit;
        private System.Windows.Forms.Button btnPerawatan;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
    }
}