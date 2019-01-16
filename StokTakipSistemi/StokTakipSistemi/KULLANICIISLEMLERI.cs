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
    public partial class KULLANICIISLEMLERI : Form
    {
        public KULLANICIISLEMLERI()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlDataAdapter sda;
        DataSet ds;
        SqlCommand komut;

        public void VeriTabaniBaglan()
        {
            baglanti = new SqlConnection("Data Source=NIRVANA\\SQLEXPRESS;Initial Catalog=StokTakipVeritabani;Integrated Security=True");
            baglanti.Open();
        }

        public void VeriTabaniKapat()
        {
            baglanti.Close();
        }

        public void DataGridPersonelDoldur()
        {
            VeriTabaniBaglan();
            sda = new SqlDataAdapter("SELECT * FROM tblPersoneller ", baglanti);
            ds = new DataSet();
            sda.Fill(ds, "tblPersoneller");
            DataGridPersonel.DataSource = ds.Tables["tblPersoneller"];
            VeriTabaniKapat();
        }

        public int PersonelEkle(string PersonelAd,string PersonelSoyad,string PersonelID,string BolumID
            ,string DepartmanID,string KullaniciAdi,string Sifre)
        {
            int a = 0;
            try
            {

                if (txtPersonelAd.Text.Trim() == "") errorProvider1.SetError(txtPersonelAd, "Boş geçilmez");
                else errorProvider1.SetError(txtPersonelAd, "");
                if (txtPersonelSoyad.Text.Trim() == "") errorProvider1.SetError(txtPersonelSoyad, "Boş geçilmez");
                else errorProvider1.SetError(txtPersonelSoyad, "");
                if (txtPersonelID.Text.Trim() == "") errorProvider1.SetError(txtPersonelID, "Boş geçilmez");
                else errorProvider1.SetError(txtPersonelID, "");
                if (txtBolumID.Text.Trim() == "") errorProvider1.SetError(txtBolumID, "Boş geçilmez");
                else errorProvider1.SetError(txtBolumID, "");
                if (txtDepartmanID.Text.Trim() == "") errorProvider1.SetError(txtDepartmanID, "Boş geçilmez");
                else errorProvider1.SetError(txtDepartmanID, "");
                if (txtKullaniciAdi.Text.Trim() == "") errorProvider1.SetError(txtKullaniciAdi, "Boş geçilmez");
                else errorProvider1.SetError(txtKullaniciAdi, "");
                if (txtSifre.Text.Trim() == "") errorProvider1.SetError(txtSifre, "Boş geçilmez");
                else errorProvider1.SetError(txtSifre, "");
                if (txtPersonelAd.Text.Trim() != "" && txtPersonelSoyad.Text.Trim() != "" &&
                    txtPersonelID.Text.Trim() != "" && txtBolumID.Text.Trim() != "" &&
                    txtDepartmanID.Text.Trim() != "" && txtKullaniciAdi.Text.Trim() != "" &&
                    txtSifre.Text.Trim() != "")
                {
                    VeriTabaniBaglan();
                    komut = new SqlCommand("insert into tblPersoneller(PersonelAd,PersonelSoyad,PersonelID,BolumID,DepartmanID,KullaniciAdi,Sifre) values (@PersonelAd,@PersonelSoyad,@PersonelID, @BolumID,@DepartmanID,@KullaniciAdi,@Sifre)", baglanti);
                    komut.Parameters.AddWithValue("@PersonelAd", txtPersonelAd.Text);
                    komut.Parameters.AddWithValue("@PersonelSoyad", txtPersonelSoyad.Text);
                    komut.Parameters.AddWithValue("@PersonelID", txtPersonelID.Text);
                    komut.Parameters.AddWithValue("@BolumID", txtBolumID.Text);
                    komut.Parameters.AddWithValue("@DepartmanID", txtDepartmanID.Text);
                    komut.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);

                    komut.ExecuteNonQuery();

                    DataGridPersonelDoldur();
                    MessageBox.Show("Kullanıcı başarıyla eklendi.");
                    a = 0;

                    VeriTabaniKapat();
                }

            }
            catch
            {
                MessageBox.Show("Hatalı İşlem...");
                VeriTabaniKapat();
            }
            return a;


        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            PersonelEkle(txtPersonelAd.Text, txtPersonelSoyad.Text, txtPersonelID.Text, txtBolumID.Text
                , txtDepartmanID.Text, txtKullaniciAdi.Text, txtSifre.Text );
  
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            VeriTabaniBaglan();
            string sorgu = "SELECT * FROM tblPersoneller WHERE PersonelID=@PersonelID";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@PersonelID", txtSilinecekPersonelID.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            {
                string isim = dr["PersonelAd"].ToString() + " " + dr["PersonelSoyad"].ToString();
                dr.Close();

                DialogResult durum = MessageBox.Show(isim + " Kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == durum) 
                {
                    string silmeSorgusu = "DELETE from tblPersoneller where PersonelID=@PersonelID";
                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                    silKomutu.Parameters.AddWithValue("@PersonelID", txtSilinecekPersonelID.Text);
                    silKomutu.ExecuteNonQuery();
                    DataGridPersonelDoldur();
                    MessageBox.Show("Kayıt Silindi...");
                }
            }
            else
                MessageBox.Show("Kayıt Bulunamadı.");
            baglanti.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataGridPersonelDoldur();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            ANAMENU anamenu = new ANAMENU();
            anamenu.Show();
            this.Hide();
        }
    }
    }


        
    

