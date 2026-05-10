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
            this.btnPerawatan = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnPadi = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.btnPetani = new System.Windows.Forms.Button();
            this.btnPenyakit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPerawatan
            // 
            this.btnPerawatan.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerawatan.Location = new System.Drawing.Point(510, 331);
            this.btnPerawatan.Name = "btnPerawatan";
            this.btnPerawatan.Size = new System.Drawing.Size(241, 42);
            this.btnPerawatan.TabIndex = 2;
            this.btnPerawatan.Text = "Kelola Perawatan Padi";
            this.btnPerawatan.UseVisualStyleBackColor = true;
            this.btnPerawatan.Click += new System.EventHandler(this.btnPerawatan_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.Location = new System.Drawing.Point(782, 331);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(241, 42);
            this.btnLaporan.TabIndex = 3;
            this.btnLaporan.Text = "Laporan Keseluruhan";
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Teal;
            this.btnLogout.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(645, 445);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(241, 42);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(566, 151);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 20);
            this.lblWelcome.TabIndex = 5;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(698, 59);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(138, 39);
            this.lblMenu.TabIndex = 6;
            this.lblMenu.Text = "MENU";
            // 
            // btnPadi
            // 
            this.btnPadi.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPadi.Location = new System.Drawing.Point(782, 186);
            this.btnPadi.Name = "btnPadi";
            this.btnPadi.Size = new System.Drawing.Size(241, 42);
            this.btnPadi.TabIndex = 7;
            this.btnPadi.Text = "Kelola Padi";
            this.btnPadi.UseVisualStyleBackColor = true;
            this.btnPadi.Click += new System.EventHandler(this.btnPadi_Click);
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiwayat.Location = new System.Drawing.Point(782, 257);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(241, 42);
            this.btnRiwayat.TabIndex = 8;
            this.btnRiwayat.Text = "Kelola Riwayat Penyakit";
            this.btnRiwayat.UseVisualStyleBackColor = true;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // btnPetani
            // 
            this.btnPetani.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPetani.Location = new System.Drawing.Point(510, 186);
            this.btnPetani.Name = "btnPetani";
            this.btnPetani.Size = new System.Drawing.Size(241, 42);
            this.btnPetani.TabIndex = 9;
            this.btnPetani.Text = "Kelola Petani";
            this.btnPetani.UseVisualStyleBackColor = true;
            this.btnPetani.Click += new System.EventHandler(this.btnPetani_Click);
            // 
            // btnPenyakit
            // 
            this.btnPenyakit.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenyakit.Location = new System.Drawing.Point(510, 257);
            this.btnPenyakit.Name = "btnPenyakit";
            this.btnPenyakit.Size = new System.Drawing.Size(241, 42);
            this.btnPenyakit.TabIndex = 10;
            this.btnPenyakit.Text = "Kelola Penyakit";
            this.btnPenyakit.UseVisualStyleBackColor = true;
            this.btnPenyakit.Click += new System.EventHandler(this.btnPenyakit_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1573, 579);
            this.Controls.Add(this.btnPenyakit);
            this.Controls.Add(this.btnPetani);
            this.Controls.Add(this.btnRiwayat);
            this.Controls.Add(this.btnPadi);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnPerawatan);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPerawatan;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnPadi;
        private System.Windows.Forms.Button btnRiwayat;
        private System.Windows.Forms.Button btnPetani;
        private System.Windows.Forms.Button btnPenyakit;
    }
}