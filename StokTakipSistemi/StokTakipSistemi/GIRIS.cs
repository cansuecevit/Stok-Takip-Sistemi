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
    public partial class GIRIS : Form
    {
        public GIRIS()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlDataAdapter sda;
        DataTable dt;

        public static string KullaniciAdi, Sifre;
        public void VeriTabaniBaglan()
        {
            baglanti = new SqlConnection("Data Source=NIRVANA\\SQLEXPRESS;Initial Catalog=StokTakipVeritabani;Integrated Security=True");
            baglanti.Open();
        }

        public void VeriTabaniKapat()
        {
            baglanti.Close();
        }

        public int GirisYap(string kullanici, string sifre)
        {
            int a = 0;

            try
            {
                if (txtkullaniciad.Text.Trim() == "") errorProvider1.SetError(txtkullaniciad, "Boş geçilmez");
                else errorProvider1.SetError(txtkullaniciad, "");
                if (txtsifre.Text.Trim() == "") errorProvider1.SetError(txtsifre, "Boş geçilmez");
                else errorProvider1.SetError(txtsifre, "");
                if (txtkullaniciad.Text.Trim() != "" && txtsifre.Text.Trim() != "")
                {
                    VeriTabaniBaglan();
                    sda = new SqlDataAdapter("SELECT COUNT(*) FROM tblPersoneller WHERE KullaniciAdi='" + KullaniciAdi + "' AND Sifre='" + Sifre + "'", baglanti);
                    dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        ANAMENU anamenu = new ANAMENU();
                        anamenu.Show();
                        this.Hide();
                        a = 1;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı giriş yaptınız.Lütfen tekrar giriniz!!!");
                        txtkullaniciad.Text = "";
                        txtsifre.Text = "";
                    }
                    VeriTabaniKapat();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
                VeriTabaniKapat();
            }
       
            return a;
        }
        


        private void btngiris_Click(object sender, EventArgs e)
        {
            KullaniciAdi = txtkullaniciad.Text;
            Sifre = txtsifre.Text;
            GirisYap(KullaniciAdi,Sifre);
        }
    }
}


    
