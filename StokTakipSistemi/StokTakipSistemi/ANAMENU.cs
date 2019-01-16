using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokTakipSistemi
{
    public partial class ANAMENU : Form
    {
        public ANAMENU()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlDataReader okuyucu;

        public void VeriTabaniBaglan()
        {
            baglanti = new SqlConnection("Data Source=NIRVANA\\SQLEXPRESS;Initial Catalog=StokTakipVeritabani;Integrated Security=True");
            baglanti.Open();
        }

        public void VeriTabaniKapat()
        {
            baglanti.Close();
        }

        private void ANAMENU_Load(object sender, EventArgs e)
        {
            string k = GIRIS.KullaniciAdi;
            string s = GIRIS.Sifre;

            if (k == "eborandag" && s==4567.ToString())
                    btnAdmin.Enabled = true;
           else
                    btnAdmin.Enabled = false;

            if (k == "fbozyigit" && s == 6789.ToString() || 
                k == "pyildirim" && s == 5678.ToString() ||
                k=="eborandag" && s==4567.ToString())
                btnBirimYetkilisi.Enabled = true;
            else
                btnBirimYetkilisi.Enabled = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ADMIN Admin = new ADMIN();
            Admin.Show();
            this.Hide();
        }

        private void btnParcaİslemleri_Click(object sender, EventArgs e)
        {
            PARCAISLEMLERİ ParcaIslem = new PARCAISLEMLERİ();
            ParcaIslem.Show();
            this.Hide();
        }

        private void btnBirimYetkilisi_Click(object sender, EventArgs e)
        {
            BIRIMYETKİLİSİ BirimYetkilisi = new BIRIMYETKİLİSİ();
            BirimYetkilisi.Show();
            this.Hide();
        }

        private void btnZimmetİslemleri_Click(object sender, EventArgs e)
        {
            ZIMMET Zimmet = new ZIMMET();
            Zimmet.Show();
            this.Hide();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            GIRIS form = new GIRIS();
            form.Show();
            this.Hide();
        }
    }
}
