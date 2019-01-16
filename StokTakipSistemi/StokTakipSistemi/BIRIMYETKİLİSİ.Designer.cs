namespace StokTakipSistemi
{
    partial class BIRIMYETKİLİSİ
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
            this.tcPersonelListeleme = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataGridBPersonel = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DataGridBZimmet = new System.Windows.Forms.DataGridView();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.tcPersonelListeleme.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBPersonel)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBZimmet)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPersonelListeleme
            // 
            this.tcPersonelListeleme.Controls.Add(this.tabPage1);
            this.tcPersonelListeleme.Controls.Add(this.tabPage2);
            this.tcPersonelListeleme.Location = new System.Drawing.Point(3, 3);
            this.tcPersonelListeleme.Name = "tcPersonelListeleme";
            this.tcPersonelListeleme.SelectedIndex = 0;
            this.tcPersonelListeleme.Size = new System.Drawing.Size(408, 281);
            this.tcPersonelListeleme.TabIndex = 0;
            this.tcPersonelListeleme.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DataGridBPersonel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(400, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bölümdeki Personelleri Listele";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DataGridBPersonel
            // 
            this.DataGridBPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridBPersonel.Location = new System.Drawing.Point(7, 7);
            this.DataGridBPersonel.Name = "DataGridBPersonel";
            this.DataGridBPersonel.Size = new System.Drawing.Size(383, 227);
            this.DataGridBPersonel.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DataGridBZimmet);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(400, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bölümdeki Personellerin Zimmet Dökümü";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DataGridBZimmet
            // 
            this.DataGridBZimmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridBZimmet.Location = new System.Drawing.Point(3, 6);
            this.DataGridBZimmet.Name = "DataGridBZimmet";
            this.DataGridBZimmet.Size = new System.Drawing.Size(387, 243);
            this.DataGridBZimmet.TabIndex = 0;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(409, 278);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(75, 32);
            this.btnGeriDon.TabIndex = 1;
            this.btnGeriDon.Text = "GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // BIRIMYETKİLİSİ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 322);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.tcPersonelListeleme);
            this.Name = "BIRIMYETKİLİSİ";
            this.Text = "BIRIMYETKİLİSİ";
            this.Load += new System.EventHandler(this.BIRIMYETKİLİSİ_Load);
            this.tcPersonelListeleme.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBPersonel)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBZimmet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPersonelListeleme;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DataGridBPersonel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DataGridBZimmet;
        private System.Windows.Forms.Button btnGeriDon;
    }
}