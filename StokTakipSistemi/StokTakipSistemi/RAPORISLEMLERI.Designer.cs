namespace StokTakipSistemi
{
    partial class RAPORISLEMLERI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPersonelRapor = new System.Windows.Forms.Button();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridPersonelZimmetRaporu = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBolumRapor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.dataGridBolumZimmetRaporu = new System.Windows.Forms.DataGridView();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonelZimmetRaporu)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBolumZimmetRaporu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(483, 318);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPersonelRapor);
            this.tabPage1.Controls.Add(this.cmbPersonel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridPersonelZimmetRaporu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(475, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personele Göre Zimmet Raporu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPersonelRapor
            // 
            this.btnPersonelRapor.Location = new System.Drawing.Point(197, 14);
            this.btnPersonelRapor.Margin = new System.Windows.Forms.Padding(2);
            this.btnPersonelRapor.Name = "btnPersonelRapor";
            this.btnPersonelRapor.Size = new System.Drawing.Size(102, 28);
            this.btnPersonelRapor.TabIndex = 3;
            this.btnPersonelRapor.Text = "Raporu Görüntüle";
            this.btnPersonelRapor.UseVisualStyleBackColor = true;
            this.btnPersonelRapor.Click += new System.EventHandler(this.btnPersonelRapor_Click);
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(72, 17);
            this.cmbPersonel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(92, 21);
            this.cmbPersonel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel ID:";
            // 
            // dataGridPersonelZimmetRaporu
            // 
            this.dataGridPersonelZimmetRaporu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonelZimmetRaporu.Location = new System.Drawing.Point(6, 58);
            this.dataGridPersonelZimmetRaporu.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridPersonelZimmetRaporu.Name = "dataGridPersonelZimmetRaporu";
            this.dataGridPersonelZimmetRaporu.RowTemplate.Height = 24;
            this.dataGridPersonelZimmetRaporu.Size = new System.Drawing.Size(458, 232);
            this.dataGridPersonelZimmetRaporu.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBolumRapor);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cmbBolum);
            this.tabPage2.Controls.Add(this.dataGridBolumZimmetRaporu);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(475, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bölüme Göre Zimmet Raporu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBolumRapor
            // 
            this.btnBolumRapor.Location = new System.Drawing.Point(217, 7);
            this.btnBolumRapor.Margin = new System.Windows.Forms.Padding(2);
            this.btnBolumRapor.Name = "btnBolumRapor";
            this.btnBolumRapor.Size = new System.Drawing.Size(104, 28);
            this.btnBolumRapor.TabIndex = 3;
            this.btnBolumRapor.Text = "Raporu Görüntüle";
            this.btnBolumRapor.UseVisualStyleBackColor = true;
            this.btnBolumRapor.Click += new System.EventHandler(this.btnBolumRapor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bölüm Ad:";
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(91, 12);
            this.cmbBolum.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(99, 21);
            this.cmbBolum.TabIndex = 1;
            // 
            // dataGridBolumZimmetRaporu
            // 
            this.dataGridBolumZimmetRaporu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBolumZimmetRaporu.Location = new System.Drawing.Point(4, 45);
            this.dataGridBolumZimmetRaporu.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridBolumZimmetRaporu.Name = "dataGridBolumZimmetRaporu";
            this.dataGridBolumZimmetRaporu.RowTemplate.Height = 24;
            this.dataGridBolumZimmetRaporu.Size = new System.Drawing.Size(414, 234);
            this.dataGridBolumZimmetRaporu.TabIndex = 0;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(495, 321);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(69, 33);
            this.btnGeriDon.TabIndex = 1;
            this.btnGeriDon.Text = "GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // RAPORISLEMLERI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RAPORISLEMLERI";
            this.Text = "RAPOR ISLEMLERI";
            this.Load += new System.EventHandler(this.RAPORISLEMLERI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonelZimmetRaporu)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBolumZimmetRaporu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridBolumZimmetRaporu;
        private System.Windows.Forms.Button btnPersonelRapor;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridPersonelZimmetRaporu;
        private System.Windows.Forms.Button btnBolumRapor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.Button btnGeriDon;
    }
}