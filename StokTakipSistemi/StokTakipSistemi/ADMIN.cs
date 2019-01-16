using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipSistemi
{
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
        }

        private void btnKullaniciIslemleri_Click(object sender, EventArgs e)
        {
            KULLANICIISLEMLERI KullaniciIslemleri = new KULLANICIISLEMLERI();
            KullaniciIslemleri.Show();
            this.Hide();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            RAPORISLEMLERI Raporlar = new RAPORISLEMLERI();
            Raporlar.Show();
            this.Hide();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            ANAMENU anamenu = new ANAMENU();
            anamenu.Show();
            this.Hide();
        }
    }
}
