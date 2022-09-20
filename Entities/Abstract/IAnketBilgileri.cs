using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IAnketBilgileri
    {
        int AnketID { get; set; }
        DateTime Tarih { get; set; }
        int DanisanID { get; set; }
        string Adi { get; set; }
        string Soyadi { get; set; }
        string Cinsiyet { get; set; }
        string UlkeSehir { get; set; }
        string Telefon { get; set; }
        int Yas { get; set; }
        double Kilo { get; set; }
        double Boy { get; set; }
        string KronikHastalik { get; set; }
        string DuzenliKullanilanIlac { get; set; }
        string KullanilanTakviyeler { get; set; }
        string AmeliyatGecmisi { get; set; }
        int OgunSayisi { get; set; }
        string YemekYapma { get; set; }
        string TuzEkleme { get; set; }
        string SekerKullanimi { get; set; }
        string AsitliIcecekKullanimi { get; set; }
        string AlkolKullanimi { get; set; }
        string SigaraKullanimi { get; set; }
        string BagirsakIslevDurumu { get; set; }
        string EgzersizDurumu { get; set; }
        string SuTuketimi { get; set; }
        string MideProblemi { get; set; }
        string AlerjiDurumu { get; set; }
        string SevilmeyenGidalar { get; set; }
        string SevilenGidalar { get; set; }
        string Meslek { get; set; }
        string AktiviteDurumu { get; set; }
        string MotivasyonDegerlendirmesi { get; set; }
        double HedefKilo { get; set; }
        string DiyetGecmisi { get; set; }
        string AcikilanSaat { get; set; }
        string EkNot { get; set; }
        string DiyetistenYorumu { get; set; }


        //Tablo referanslamaları
        DanisanKullaniciBilgileri DanisanKullaniciBilgileri { get; set; }
    }
}
