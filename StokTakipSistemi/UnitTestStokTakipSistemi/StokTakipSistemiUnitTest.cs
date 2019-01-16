using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StokTakipSistemi;

namespace UnitTestStokTakipSistemi
{
    [TestClass]
    public class StokTakipSistemiUnitTest
    {
        [TestMethod]
        public void DogruKullaniciAdveSifreGirisYapTest()
        {
            int beklenenSonuc = 0;
            string kullanici = "eborandag";
            string sifre = "4dasd";
            GIRIS form = new GIRIS();
            int sonuc = form.GirisYap(kullanici, sifre);
            Assert.AreEqual(beklenenSonuc, sonuc);

        }

        [TestMethod]
        public void BosKullaniciAdiveSifreGirisYapTest()
        {
            int beklenenSonuc = 0;
            string kullanici = " ";
            string sifre = " ";
            GIRIS form = new GIRIS();
            int sonuc = form.GirisYap(kullanici, sifre);
            Assert.AreEqual(beklenenSonuc, sonuc);

        }
        [TestMethod]
        public void BosDegerilePersonelEkleTest()
        {
            int beklenenSonuc = 0;
            string PersonelAd = " ";
            string PersonelSoyad = " ";
            string PersonelID = " ";
            string BolumID = " ";
            string DepartmanID = " ";
            string KullaniciAd = " ";
            string sifre = " ";
            KULLANICIISLEMLERI form = new KULLANICIISLEMLERI();
            int sonuc = form.PersonelEkle(PersonelAd, PersonelSoyad, PersonelID, BolumID, 
            DepartmanID, KullaniciAd, sifre);
            Assert.AreEqual(beklenenSonuc, sonuc);

        }
        [TestMethod]
        public void BosDegerParcaEkleTest()
        {
            int beklenenSonuc = 0;
            string ParcaAd = " ";
            string ParcaID = " ";
            string SatınAlmaTarihi = " ";
            string Marka = " ";
            string Aciklama = " ";
            string Adet = " ";
            PARCAISLEMLERİ form = new PARCAISLEMLERİ();
            int sonuc = form.ParcaEkle(ParcaAd, ParcaID, SatınAlmaTarihi, Marka,
            Aciklama, Adet);
            Assert.AreEqual(beklenenSonuc, sonuc);

        }
       [TestMethod]
        public void AdetDegeriTest()
        {
            int beklenenSonuc = 0;
            string zimmetAlan = "Cansu";
            string zimmetVeren = "Gamze";
            string ParcaID = "3";
            string ZimmetID = "4";
            string Adet = "ddasj ";
            ZIMMET form = new ZIMMET();
            int sonuc = form.Zimmetle(zimmetAlan, zimmetVeren, ParcaID, ZimmetID,
            Adet);
            Assert.AreEqual(beklenenSonuc, sonuc);

        } 
    }
}


