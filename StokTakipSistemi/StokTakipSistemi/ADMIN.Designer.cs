namespace StokTakipSistemi
{
    partial class ADMIN
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnKullaniciIslemleri = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(267, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Location = new System.Drawing.Point(12, 61);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(85, 50);
            this.btnRaporlar.TabIndex = 1;
            this.btnRaporlar.Text = "RAPORLAR";
            this.btnRaporlar.UseVisualStyleBackColor = true;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnKullaniciIslemleri
            // 
            this.btnKullaniciIslemleri.Location = new System.Drawing.Point(130, 61);
            this.btnKullaniciIslemleri.Name = "btnKullaniciIslemleri";
            this.btnKullaniciIslemleri.Size = new System.Drawing.Size(79, 50);
            this.btnKullaniciIslemleri.TabIndex = 2;
            this.btnKullaniciIslemleri.Text = "KULLANICI İŞLEMLERİ";
            this.btnKullaniciIslemleri.UseVisualStyleBackColor = true;
            this.btnKullaniciIslemleri.Click += new System.EventHandler(this.btnKullaniciIslemleri_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(165, 150);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(75, 45);
            this.btnGeriDon.TabIndex = 3;
            this.btnGeriDon.Text = "GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 220);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnKullaniciIslemleri);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ADMIN";
            this.Text = "ADMIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnKullaniciIslemleri;
        private System.Windows.Forms.Button btnGeriDon;
    }
}