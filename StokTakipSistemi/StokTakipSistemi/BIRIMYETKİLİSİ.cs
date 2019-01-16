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
    public partial class BIRIMYETKİLİSİ : Form
    {
        public BIRIMYETKİLİSİ()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand sc;
        SqlDataReader okuyucu;


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

        private void BIRIMYETKİLİSİ_Load(object sender, EventArgs e)
        {
            DataGridViewDoldur();
            DataGridZimmetDokumuDoldur();
        }
        public void DataGridZimmetDokumuDoldur()
        {

            VeriTabaniBaglan();
            string k = GIRIS.KullaniciAdi;
            sc = new SqlCommand("SELECT b.BolumAd FROM tblPersoneller p INNER JOIN tblBolum b ON p.BolumID=b.BolumID WHERE p.KullaniciAdi='" + k + "'", baglanti);
            okuyucu = sc.ExecuteReader();
            okuyucu.Read();
            string BolumAd = okuyucu[0].ToString();
            VeriTabaniKapat();

            VeriTabaniBaglan();
            da = new SqlDataAdapter("SELECT p.PersonelAd,p.PersonelSoyad,pa.ParcaAdi FROM tblPersoneller p INNER JOIN tblZimmet z ON p.ZimmetID=z.ZimmetID " +
                "                                                                                                 INNER JOIN tblParca pa ON pa.ParcaID=z.ParcaID " +
                "                                                                                                 INNER JOIN tblStok s ON s.ParcaID=pa.ParcaID " +
                "                                                                                                 INNER JOIN tblBolum b ON b.BolumID=p.BolumID WHERE b.BolumAd='" + BolumAd + "'", baglanti);
            ds = new DataSet();
            da.Fill(ds, "tblPersoneller");
            DataGridBZimmet.DataSource = ds.Tables["tblPersoneller"];
            VeriTabaniKapat();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            ANAMENU anamenu = new ANAMENU();
            anamenu.Show();
            this.Hide();
        }

        public void DataGridViewDoldur()
        {
            
            VeriTabaniBaglan();
            string k = GIRIS.KullaniciAdi;
            sc = new SqlCommand("SELECT b.BolumAd FROM tblPersoneller p INNER JOIN tblBolum b ON p.BolumID=b.BolumID WHERE p.KullaniciAdi='" + k + "'", baglanti);
            okuyucu = sc.ExecuteReader();
            okuyucu.Read();
            string BolumAd = okuyucu[0].ToString();
            VeriTabaniKapat();
            VeriTabaniBaglan();
            da = new SqlDataAdapter("SELECT p.PersonelAd,p.PersonelSoyad,p.PersonelID,b.BolumAd FROM tblPersoneller p INNER JOIN tblBolum b ON p.BolumID=b.BolumID WHERE b.BolumAd='" + BolumAd + "'", baglanti);
            ds = new DataSet();
            da.Fill(ds, "tblPersoneller");
            DataGridBPersonel.DataSource = ds.Tables["tblPersoneller"];
            VeriTabaniKapat();
        }
        


    }
}
    

