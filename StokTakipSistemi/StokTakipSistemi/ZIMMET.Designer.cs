namespace StokTakipSistemi
{
    partial class ZIMMET
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
            this.gbPersonelArama = new System.Windows.Forms.GroupBox();
            this.btnPersonelSec = new System.Windows.Forms.Button();
            this.btnPersonelAra = new System.Windows.Forms.Button();
            this.DataGridPersonel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.gbParcaSec = new System.Windows.Forms.GroupBox();
            this.btnParcaSec = new System.Windows.Forms.Button();
            this.DataGridParca = new System.Windows.Forms.DataGridView();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.lblZimmetVeren = new System.Windows.Forms.Label();
            this.lblZimmetAlan = new System.Windows.Forms.Label();
            this.lblParcaID = new System.Windows.Forms.Label();
            this.lblZimmetID = new System.Windows.Forms.Label();
            this.btnZimmetle = new System.Windows.Forms.Button();
            this.lblAdet = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtZimmetVeren = new System.Windows.Forms.TextBox();
            this.txtZimmetAlan = new System.Windows.Forms.TextBox();
            this.txtParcaID = new System.Windows.Forms.TextBox();
            this.txtZimmetID = new System.Windows.Forms.TextBox();
            this.gbPersonelArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPersonel)).BeginInit();
            this.gbParcaSec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridParca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPersonelArama
            // 
            this.gbPersonelArama.Controls.Add(this.btnPersonelSec);
            this.gbPersonelArama.Controls.Add(this.btnPersonelAra);
            this.gbPersonelArama.Controls.Add(this.DataGridPersonel);
            this.gbPersonelArama.Controls.Add(this.label1);
            this.gbPersonelArama.Controls.Add(this.cmbBolum);
            this.gbPersonelArama.Location = new System.Drawing.Point(12, 12);
            this.gbPersonelArama.Name = "gbPersonelArama";
            this.gbPersonelArama.Size = new System.Drawing.Size(270, 302);
            this.gbPersonelArama.TabIndex = 0;
            this.gbPersonelArama.TabStop = false;
            this.gbPersonelArama.Text = "Personel Ara ve Seç";
            // 
            // btnPersonelSec
            // 
            this.btnPersonelSec.Location = new System.Drawing.Point(82, 260);
            this.btnPersonelSec.Name = "btnPersonelSec";
            this.btnPersonelSec.Size = new System.Drawing.Size(72, 25);
            this.btnPersonelSec.TabIndex = 4;
            this.btnPersonelSec.Text = "Seç";
            this.btnPersonelSec.UseVisualStyleBackColor = true;
            this.btnPersonelSec.Click += new System.EventHandler(this.btnPersonelSec_Click);
            // 
            // btnPersonelAra
            // 
            this.btnPersonelAra.Location = new System.Drawing.Point(67, 75);
            this.btnPersonelAra.Name = "btnPersonelAra";
            this.btnPersonelAra.Size = new System.Drawing.Size(75, 23);
            this.btnPersonelAra.TabIndex = 3;
            this.btnPersonelAra.Text = "ARA";
            this.btnPersonelAra.UseVisualStyleBackColor = true;
            this.btnPersonelAra.Click += new System.EventHandler(this.btnPersonelAra_Click);
            // 
            // DataGridPersonel
            // 
            this.DataGridPersonel.AllowUserToAddRows = false;
            this.DataGridPersonel.AllowUserToDeleteRows = false;
            this.DataGridPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPersonel.Location = new System.Drawing.Point(0, 104);
            this.DataGridPersonel.Name = "DataGridPersonel";
            this.DataGridPersonel.ReadOnly = true;
            this.DataGridPersonel.Size = new System.Drawing.Size(264, 150);
            this.DataGridPersonel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personeli aramak istediğiniz bölümü seçin";
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(6, 48);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(201, 21);
            this.cmbBolum.TabIndex = 0;
            // 
            // gbParcaSec
            // 
            this.gbParcaSec.Controls.Add(this.btnParcaSec);
            this.gbParcaSec.Controls.Add(this.DataGridParca);
            this.gbParcaSec.Location = new System.Drawing.Point(332, 22);
            this.gbParcaSec.Name = "gbParcaSec";
            this.gbParcaSec.Size = new System.Drawing.Size(403, 292);
            this.gbParcaSec.TabIndex = 1;
            this.gbParcaSec.TabStop = false;
            this.gbParcaSec.Text = "Parça Seç";
            // 
            // btnParcaSec
            // 
            this.btnParcaSec.Location = new System.Drawing.Point(104, 209);
            this.btnParcaSec.Name = "btnParcaSec";
            this.btnParcaSec.Size = new System.Drawing.Size(130, 35);
            this.btnParcaSec.TabIndex = 5;
            this.btnParcaSec.Text = "Seç";
            this.btnParcaSec.UseVisualStyleBackColor = true;
            this.btnParcaSec.Click += new System.EventHandler(this.btnParcaSec_Click);
            // 
            // DataGridParca
            // 
            this.DataGridParca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridParca.Location = new System.Drawing.Point(6, 22);
            this.DataGridParca.Name = "DataGridParca";
            this.DataGridParca.Size = new System.Drawing.Size(391, 181);
            this.DataGridParca.TabIndex = 0;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(670, 418);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(65, 36);
            this.btnGeriDon.TabIndex = 6;
            this.btnGeriDon.Text = "GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // lblZimmetVeren
            // 
            this.lblZimmetVeren.AutoSize = true;
            this.lblZimmetVeren.Location = new System.Drawing.Point(226, 332);
            this.lblZimmetVeren.Name = "lblZimmetVeren";
            this.lblZimmetVeren.Size = new System.Drawing.Size(92, 13);
            this.lblZimmetVeren.TabIndex = 2;
            this.lblZimmetVeren.Text = "ZİMMET VEREN:";
            // 
            // lblZimmetAlan
            // 
            this.lblZimmetAlan.AutoSize = true;
            this.lblZimmetAlan.Location = new System.Drawing.Point(226, 360);
            this.lblZimmetAlan.Name = "lblZimmetAlan";
            this.lblZimmetAlan.Size = new System.Drawing.Size(83, 13);
            this.lblZimmetAlan.TabIndex = 3;
            this.lblZimmetAlan.Text = "ZİMMET ALAN:";
            // 
            // lblParcaID
            // 
            this.lblParcaID.AutoSize = true;
            this.lblParcaID.Location = new System.Drawing.Point(226, 385);
            this.lblParcaID.Name = "lblParcaID";
            this.lblParcaID.Size = new System.Drawing.Size(60, 13);
            this.lblParcaID.TabIndex = 4;
            this.lblParcaID.Text = "PARÇA ID:";
            // 
            // lblZimmetID
            // 
            this.lblZimmetID.AutoSize = true;
            this.lblZimmetID.Location = new System.Drawing.Point(226, 410);
            this.lblZimmetID.Name = "lblZimmetID";
            this.lblZimmetID.Size = new System.Drawing.Size(66, 13);
            this.lblZimmetID.TabIndex = 5;
            this.lblZimmetID.Text = "ZİMMET ID:";
            // 
            // btnZimmetle
            // 
            this.btnZimmetle.Location = new System.Drawing.Point(520, 368);
            this.btnZimmetle.Name = "btnZimmetle";
            this.btnZimmetle.Size = new System.Drawing.Size(93, 46);
            this.btnZimmetle.TabIndex = 6;
            this.btnZimmetle.Text = "ZİMMETLE";
            this.btnZimmetle.UseVisualStyleBackColor = true;
            this.btnZimmetle.Click += new System.EventHandler(this.btnZimmetle_Click);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(226, 434);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(39, 13);
            this.lblAdet.TabIndex = 7;
            this.lblAdet.Text = "ADET:";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(324, 434);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 20);
            this.txtAdet.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtZimmetVeren
            // 
            this.txtZimmetVeren.Location = new System.Drawing.Point(324, 329);
            this.txtZimmetVeren.Name = "txtZimmetVeren";
            this.txtZimmetVeren.ReadOnly = true;
            this.txtZimmetVeren.Size = new System.Drawing.Size(100, 20);
            this.txtZimmetVeren.TabIndex = 9;
            // 
            // txtZimmetAlan
            // 
            this.txtZimmetAlan.Location = new System.Drawing.Point(324, 355);
            this.txtZimmetAlan.Name = "txtZimmetAlan";
            this.txtZimmetAlan.ReadOnly = true;
            this.txtZimmetAlan.Size = new System.Drawing.Size(100, 20);
            this.txtZimmetAlan.TabIndex = 10;
            // 
            // txtParcaID
            // 
            this.txtParcaID.Location = new System.Drawing.Point(324, 381);
            this.txtParcaID.Name = "txtParcaID";
            this.txtParcaID.ReadOnly = true;
            this.txtParcaID.Size = new System.Drawing.Size(100, 20);
            this.txtParcaID.TabIndex = 11;
            // 
            // txtZimmetID
            // 
            this.txtZimmetID.Location = new System.Drawing.Point(324, 407);
            this.txtZimmetID.Name = "txtZimmetID";
            this.txtZimmetID.ReadOnly = true;
            this.txtZimmetID.Size = new System.Drawing.Size(100, 20);
            this.txtZimmetID.TabIndex = 12;
            // 
            // ZIMMET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 456);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.txtZimmetID);
            this.Controls.Add(this.txtParcaID);
            this.Controls.Add(this.txtZimmetAlan);
            this.Controls.Add(this.txtZimmetVeren);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.btnZimmetle);
            this.Controls.Add(this.lblZimmetID);
            this.Controls.Add(this.lblParcaID);
            this.Controls.Add(this.lblZimmetAlan);
            this.Controls.Add(this.lblZimmetVeren);
            this.Controls.Add(this.gbParcaSec);
            this.Controls.Add(this.gbPersonelArama);
            this.Name = "ZIMMET";
            this.Text = "ZIMMET";
            this.Load += new System.EventHandler(this.ZIMMET_Load);
            this.gbPersonelArama.ResumeLayout(false);
            this.gbPersonelArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPersonel)).EndInit();
            this.gbParcaSec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridParca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonelArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.Button btnPersonelAra;
        private System.Windows.Forms.DataGridView DataGridPersonel;
        private System.Windows.Forms.Button btnPersonelSec;
        private System.Windows.Forms.GroupBox gbParcaSec;
        private System.Windows.Forms.Button btnParcaSec;
        private System.Windows.Forms.DataGridView DataGridParca;
        private System.Windows.Forms.Label lblZimmetVeren;
        private System.Windows.Forms.Label lblZimmetAlan;
        private System.Windows.Forms.Label lblParcaID;
        private System.Windows.Forms.Label lblZimmetID;
        private System.Windows.Forms.Button btnZimmetle;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtZimmetID;
        private System.Windows.Forms.TextBox txtParcaID;
        private System.Windows.Forms.TextBox txtZimmetAlan;
        private System.Windows.Forms.TextBox txtZimmetVeren;
        private System.Windows.Forms.Button btnGeriDon;
    }
}