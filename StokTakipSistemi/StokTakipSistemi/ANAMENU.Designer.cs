namespace StokTakipSistemi
{
    partial class ANAMENU
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
            this.btnZimmetİslemleri = new System.Windows.Forms.Button();
            this.btnParcaİslemleri = new System.Windows.Forms.Button();
            this.btnBirimYetkilisi = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZimmetİslemleri
            // 
            this.btnZimmetİslemleri.Location = new System.Drawing.Point(155, 110);
            this.btnZimmetİslemleri.Name = "btnZimmetİslemleri";
            this.btnZimmetİslemleri.Size = new System.Drawing.Size(87, 72);
            this.btnZimmetİslemleri.TabIndex = 0;
            this.btnZimmetİslemleri.Text = "Zimmet İşlemleri";
            this.btnZimmetİslemleri.UseVisualStyleBackColor = true;
            this.btnZimmetİslemleri.Click += new System.EventHandler(this.btnZimmetİslemleri_Click);
            // 
            // btnParcaİslemleri
            // 
            this.btnParcaİslemleri.Location = new System.Drawing.Point(155, 14);
            this.btnParcaİslemleri.Name = "btnParcaİslemleri";
            this.btnParcaİslemleri.Size = new System.Drawing.Size(87, 70);
            this.btnParcaİslemleri.TabIndex = 1;
            this.btnParcaİslemleri.Text = "Parça İşlemleri";
            this.btnParcaİslemleri.UseVisualStyleBackColor = true;
            this.btnParcaİslemleri.Click += new System.EventHandler(this.btnParcaİslemleri_Click);
            // 
            // btnBirimYetkilisi
            // 
            this.btnBirimYetkilisi.Location = new System.Drawing.Point(30, 112);
            this.btnBirimYetkilisi.Name = "btnBirimYetkilisi";
            this.btnBirimYetkilisi.Size = new System.Drawing.Size(87, 70);
            this.btnBirimYetkilisi.TabIndex = 2;
            this.btnBirimYetkilisi.Text = "Birim Yetkilisi";
            this.btnBirimYetkilisi.UseVisualStyleBackColor = true;
            this.btnBirimYetkilisi.Click += new System.EventHandler(this.btnBirimYetkilisi_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(30, 14);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(87, 70);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Admin ";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(223, 207);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(75, 23);
            this.btnGeriDon.TabIndex = 4;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // ANAMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 242);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnBirimYetkilisi);
            this.Controls.Add(this.btnParcaİslemleri);
            this.Controls.Add(this.btnZimmetİslemleri);
            this.Name = "ANAMENU";
            this.Text = "ANAMENU";
            this.Load += new System.EventHandler(this.ANAMENU_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZimmetİslemleri;
        private System.Windows.Forms.Button btnParcaİslemleri;
        private System.Windows.Forms.Button btnBirimYetkilisi;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnGeriDon;
    }
}