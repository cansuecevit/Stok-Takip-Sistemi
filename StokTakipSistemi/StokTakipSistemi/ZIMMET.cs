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
using System.IO;

namespace StokTakipSistemi
{
    public partial class ZIMMET : Form
    {
        public ZIMMET()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut,sc;
        SqlDataReader dr;
        DataSet ds;
        DataTable dt;
        SqlDataAdapter da;
        SqlDataReader okuyucu,okuyucu1;

        public void VeriTabaniBaglan()
        {
            baglanti = new SqlConnection("Data Source=NIRVANA\\SQLEXPRESS;Initial Catalog=StokTakipVeritabani;Integrated Security=True");
            baglanti.Open();
        }

        public void VeriTabaniKapat()
        {
            baglanti.Close();
        }
        public void GuncelleAdet()
        {
            VeriTabaniBaglan();
            string sorgu = "UPDATE tblStok SET Adet=@adet WHERE ParcaID=@parcaID ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@adet", (stok - AlinanAdet));
            komut.Parameters.AddWithValue("@ParcaID", txtParcaID.Text);
            komut.ExecuteNonQuery();
            VeriTabaniKapat();
        }
        void ComboboxDoldur()
        {
            VeriTabaniBaglan();
            komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM tblBolum";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBolum.SelectedItem = null;
                cmbBolum.Items.Add(dr["BolumAd"]);
            }
            VeriTabaniKapat();
        }
        void DataGridPersonelDoldur()
        {
            string bolum = cmbBolum.Text;
            VeriTabaniBaglan();
            da = new SqlDataAdapter("SELECT p.PersonelAd,p.PersonelSoyad,p.PersonelID,p.ZimmetID,b.BolumAd FROM tblPersoneller p INNER JOIN tblBolum b ON p.BolumID=b.BolumID WHERE b.BolumAd= '" + bolum + " ' ", baglanti);
            ds = new DataSet();
            da.Fill(ds, "tblBolum");
            DataGridPersonel.DataSource = ds.Tables["tblBolum"];
            VeriTabaniKapat();
        }

        public void DataGridParcaDoldur()
        {
            VeriTabaniBaglan();
            da = new SqlDataAdapter("SELECT p.ParcaAdi,p.ParcaID,p.SatınAlmaTarihi,p.Marka,pd.Aciklama,s.Adet FROM tblParca p INNER JOIN tblParcaDetay pd ON p.ParcaID=pd.ParcaID INNER JOIN tblStok s ON s.ParcaID=p.ParcaID", baglanti);
            ds = new DataSet();
            da.Fill(ds, "tblParca");
            DataGridParca.DataSource = ds.Tables["tblParca"];
            VeriTabaniKapat();
        }
        private void ZIMMET_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();
            cmbBolum.SelectedIndex = 0;
            DataGridParcaDoldur();
            VeriTabaniBaglan();
            string k = GIRIS.KullaniciAdi;
            sc = new SqlCommand("SELECT PersonelAd FROM tblPersoneller WHERE KullaniciAdi='" + k + "'", baglanti);
            okuyucu = sc.ExecuteReader();
            okuyucu.Read();
            string zimmetVeren = okuyucu[0].ToString();
            txtZimmetVeren.Text = (zimmetVeren);    
        }

        private void btnPersonelAra_Click(object sender, EventArgs e)
        {
            DataGridPersonelDoldur();
        }
                int AlinanAdet,stok;

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            ANAMENU anamenu = new ANAMENU();
            anamenu.Show();
            this.Hide();
        }
        public int Zimmetle(string zimmetAlan,string zimmetVeren,string ParcaID,
            string ZimmetID,string adet)
        {
            int a = 0;
            try
            {
                if (txtAdet.Text.Trim() == "") errorProvider1.SetError(txtAdet, "Boş geçilmez");
                else errorProvider1.SetError(txtAdet, "");
                if (txtAdet.Text.Trim() != "")
                {
                    AlinanAdet = int.Parse(txtAdet.Text);
                    if (AlinanAdet > stok)
                    {
                        MessageBox.Show("Girilen değer stok miktarından fazla.Daha az bir değer giriniz...");
                    }
                    else
                    {
                        VeriTabaniBaglan();
                        komut = new SqlCommand("insert into tblZimmet(ZimmetID,ZimmetAlan,ZimmetVeren,ParcaID,AlinanAdet)values(@ZimmetID,@ZimmetAlan,@ZimmetVeren,@ParcaID,@AlinanAdet)", baglanti);
                        komut.Parameters.AddWithValue("@ZimmetID", txtZimmetID.Text);
                        komut.Parameters.AddWithValue("@ZimmetAlan", txtZimmetAlan.Text);
                        komut.Parameters.AddWithValue("@ZimmetVeren", txtZimmetVeren.Text);
                        komut.Parameters.AddWithValue("@ParcaID", txtParcaID.Text);
                        komut.Parameters.AddWithValue("@AlinanAdet", txtAdet.Text);
                        komut.ExecuteNonQuery();
                        GuncelleAdet();

                        VeriTabaniKapat();
                        MessageBox.Show("Zimmetleme işlemi yapıldı...");
                        DataGridParcaDoldur();
                        txtZimmetID.Text = "";
                        txtZimmetAlan.Text = "";
                        txtZimmetVeren.Text = "";
                        txtParcaID.Text = "";
                        txtAdet.Text = "";
                        a = 1;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hatalı İşlem Yaptınız.Tekrar deneyiniz...");
            }
            return a;
        }
        private void btnZimmetle_Click(object sender, EventArgs e)
        {
            Zimmetle(txtZimmetAlan.Text, txtZimmetVeren.Text, txtParcaID.Text, txtZimmetID.Text, txtAdet.Text);
        }
    

        private void btnPersonelSec_Click(object sender, EventArgs e)
        {
            string zimmetAlan = DataGridPersonel.CurrentRow.Cells[0].Value.ToString();
            txtZimmetAlan.Text = (zimmetAlan);
            string zimmetID = DataGridPersonel.CurrentRow.Cells[3].Value.ToString();
            txtZimmetID.Text=(zimmetID); 
        }

        private void btnParcaSec_Click(object sender, EventArgs e)
        {
            string parcaID = DataGridParca.CurrentRow.Cells[1].Value.ToString();
            txtParcaID.Text = (parcaID );
            VeriTabaniBaglan();
            sc = new SqlCommand("SELECT s.Adet FROM tblStok s INNER JOIN tblParca p ON s.ParcaID=p.ParcaID WHERE s.ParcaID='" + txtParcaID.Text + "'", baglanti);
            okuyucu1= sc.ExecuteReader();
            okuyucu1.Read();
            string deger = okuyucu1[0].ToString();
            stok = int.Parse(deger);
            VeriTabaniKapat();
        }
    }
}
