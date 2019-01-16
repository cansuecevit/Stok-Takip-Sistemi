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
    public partial class RAPORISLEMLERI : Form
    {
        public RAPORISLEMLERI()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr,okuyucu;
        DataSet ds;
        DataTable dt;
        SqlDataAdapter da;
        public void VeriTabaniBaglan()
        {
            baglanti = new SqlConnection("Data Source=NIRVANA\\SQLEXPRESS;Initial Catalog=StokTakipVeritabani;Integrated Security=True");
            baglanti.Open();
        }

        public void VeriTabaniKapat()
        {
            baglanti.Close();
        }

        private void RAPORISLEMLERI_Load(object sender, EventArgs e)
        {

            ComboboxPersonelDoldur();
            ComboboxBolumDoldur();
            cmbBolum.SelectedIndex = 0;
            cmbPersonel.SelectedIndex = 0;

        }


        void ComboboxPersonelDoldur()
        {
            VeriTabaniBaglan();
            komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM tblpersoneller";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbPersonel.SelectedItem = null;
                cmbPersonel.Items.Add(dr["PersonelID"]);
            }
            VeriTabaniKapat();
        }
         void ComboboxBolumDoldur()
        {
            VeriTabaniBaglan();
            komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM tblBolum";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                cmbBolum.SelectedItem = null;
                cmbBolum.Items.Add(okuyucu["BolumAd"]);
            }
            VeriTabaniKapat();
        }
        void DataGridPersonelZimmetDoldur()
        {
            string PersonelID = cmbPersonel.Text;
            VeriTabaniBaglan();
            da = new SqlDataAdapter("SELECT p.PersonelAd,p.PersonelSoyad,pa.ParcaAdi FROM tblPersoneller p INNER JOIN tblZimmet z ON p.ZimmetID=z.ZimmetID " +
                "                                                                                                 INNER JOIN tblParca pa ON pa.ParcaID=z.ParcaID " +
                "                                                                                                 INNER JOIN tblStok s ON s.ParcaID=pa.ParcaID " +
                "                                                                                                 INNER JOIN tblBolum b ON b.BolumID=p.BolumID WHERE p.PersonelID='"+PersonelID+"'", baglanti);
            ds = new DataSet();
            da.Fill(ds, "tblPersoneller");
            dataGridPersonelZimmetRaporu.DataSource = ds.Tables["tblPersoneller"];
            VeriTabaniKapat();
        }
        public void DataGridBolumZimmetRaporuDoldur()
        {

            string BolumAd = cmbBolum.Text;
            VeriTabaniBaglan();
            da = new SqlDataAdapter("SELECT p.PersonelAd,p.PersonelSoyad,pa.ParcaAdi FROM tblPersoneller p INNER JOIN tblZimmet z ON p.ZimmetID=z.ZimmetID " +
                "                                                                                                 INNER JOIN tblParca pa ON pa.ParcaID=z.ParcaID " +
                "                                                                                                 INNER JOIN tblStok s ON s.ParcaID=pa.ParcaID " +
                "                                                                                                 INNER JOIN tblBolum b ON b.BolumID=p.BolumID WHERE b.BolumAd='" + BolumAd + "'", baglanti);
            ds = new DataSet();
            da.Fill(ds, "tblPersoneller");
            dataGridBolumZimmetRaporu.DataSource = ds.Tables["tblPersoneller"];
            VeriTabaniKapat();
        }

        private void btnPersonelRapor_Click(object sender, EventArgs e)
        {
            DataGridPersonelZimmetDoldur();
        }

        private void btnBolumRapor_Click(object sender, EventArgs e)
        {
            DataGridBolumZimmetRaporuDoldur();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            ANAMENU anamenu = new ANAMENU();
            anamenu.Show();
            this.Hide();
        }
    }

    }

