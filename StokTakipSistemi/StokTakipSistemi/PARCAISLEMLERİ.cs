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
    public partial class PARCAISLEMLERİ : Form
    {
        public PARCAISLEMLERİ()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlDataAdapter sda;
        DataSet ds;
        SqlCommand komut;
        SqlCommand komut2, komut3;

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

        public void DataGridParcaDoldur()
        {
            VeriTabaniBaglan();
            sda = new SqlDataAdapter("SELECT p.ParcaAdi,p.ParcaID,p.SatınAlmaTarihi,p.Marka,pd.Aciklama FROM tblParca p INNER JOIN tblParcaDetay pd ON p.ParcaID=pd.ParcaID", baglanti);
            ds = new DataSet();
            sda.Fill(ds, "tblParca");
            DataGridParca.DataSource = ds.Tables["tblParca"];
            VeriTabaniKapat();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            ANAMENU anamenu = new ANAMENU();
            anamenu.Show();
            this.Hide();
        }

        private void PARCAISLEMLERİ_Load(object sender, EventArgs e)
        {
            DataGridParcaDoldur();
            VeriTabaniBaglan();
            komut = new SqlCommand();
            komut2 = new SqlCommand();
            komut.CommandText = "SELECT *FROM tblParca";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut2.CommandText = "SELECT *FROM tblParcaDetay";
            komut2.Connection = baglanti;
            komut2.CommandType = CommandType.Text;
            VeriTabaniKapat();
        }
        public int ParcaEkle(string parcaAdi, string ParcaID, string SatinAlmaTarihi, string Marka
            , string aciklama, string adet)
        {
            int a = 0;
            try
            {

                if (txtParcaAdi.Text.Trim() == "") errorProvider1.SetError(txtParcaAdi, "Boş geçilmez");
                else errorProvider1.SetError(txtParcaAdi, "");
                if (txtParcaID.Text.Trim() == "") errorProvider1.SetError(txtParcaID, "Boş geçilmez");
                else errorProvider1.SetError(txtParcaID, "");
                if (txtMarka.Text.Trim() == "") errorProvider1.SetError(txtMarka, "Boş geçilmez");
                else errorProvider1.SetError(txtParcaAdi, "");
                if (txtAciklama.Text.Trim() == "") errorProvider1.SetError(txtAciklama, "Boş geçilmez");
                else errorProvider1.SetError(txtParcaID, "");
                if (txtAdet.Text.Trim() == "") errorProvider1.SetError(txtAdet, "Boş geçilmez");
                else errorProvider1.SetError(txtParcaID, "");
                if (txtParcaAdi.Text.Trim() != "" && txtParcaID.Text.Trim() != ""
                    && txtMarka.Text.Trim() != "" && txtAciklama.Text.Trim() != ""
                    && txtAdet.Text.Trim() != "")
                {
                    VeriTabaniBaglan();
                    komut = new SqlCommand("insert into tblParca(ParcaAdi,ParcaID,SatınAlmaTarihi) values (@ParcaAdi,@ParcaID,@SatınAlmaTarihi)", baglanti);
                    komut2 = new SqlCommand("insert into tblParcaDetay(Aciklama) values (@Aciklama)", baglanti);
                    komut3 = new SqlCommand("insert into tblStok(Aciklama) values (@Adet)", baglanti);
                    komut.Parameters.AddWithValue("@ParcaAdi", txtParcaAdi.Text);
                    komut.Parameters.AddWithValue("@ParcaID", txtParcaID.Text);
                    komut.Parameters.AddWithValue("@SatınAlmaTarihi", dtpSatinAlmaTarihi.Value);
                    komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
                    komut2.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                    komut3.Parameters.AddWithValue("@Adet", txtAdet.Text);

                    komut.ExecuteNonQuery();
                    komut2.ExecuteNonQuery();
                    komut3.ExecuteNonQuery();

                    DataGridParcaDoldur();
                    MessageBox.Show("Parça başarıyla eklendi.");


                    VeriTabaniKapat();
                    a = 1;
                }

            }
            catch
            {
                MessageBox.Show("Hatalı İşlem...");
                VeriTabaniKapat();
            }
            return a;
        }




        private void btnParcaEkle_Click(object sender, EventArgs e)
        {
            ParcaEkle(txtParcaAdi.Text, txtParcaID.Text, dtpSatinAlmaTarihi.Value.ToString(), txtMarka.Text
                , txtAciklama.Text, txtAdet.Text);
        }
    }
}
