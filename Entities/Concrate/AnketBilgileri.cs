using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class AnketBilgileri : IBaseEntity, IAnketBilgileri
    {
        public int AnketID { get; set; }
        public DateTime Tarih { get; set; }
        public int DanisanID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Cinsiyet { get; set; }
        public string UlkeSehir { get; set; }
        public string Telefon { get; set; }
        public int Yas { get; set; }
        public double Kilo { get; set; }
        public double Boy { get; set; }
        public string KronikHastalik { get; set; }
        public string DuzenliKullanilanIlac { get; set; }
        public string KullanilanTakviyeler { get; set; }
        public string AmeliyatGecmisi { get; set; }
        public int OgunSayisi { get; set; }
        public string YemekYapma { get; set; }
        public string TuzEkleme { get; set; }
        public string SekerKullanimi { get; set; }
        public string AsitliIcecekKullanimi { get; set; }
        public string AlkolKullanimi { get; set; }
        public string SigaraKullanimi { get; set; }
        public string BagirsakIslevDurumu { get; set; }
        public string EgzersizDurumu { get; set; }
        public string SuTuketimi { get; set; }
        public string MideProblemi { get; set; }
        public string AlerjiDurumu { get; set; }
        public string SevilmeyenGidalar { get; set; }
        public string SevilenGidalar { get; set; }
        public string Meslek { get; set; }
        public string AktiviteDurumu { get; set; }
        public string MotivasyonDegerlendirmesi { get; set; }
        public double HedefKilo { get; set; }
        public string DiyetGecmisi { get; set; }
        public string AcikilanSaat { get; set; }
        public string EkNot { get; set; }
        public string DiyetistenYorumu { get; set; }
        public DanisanKullaniciBilgileri DanisanKullaniciBilgileri { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
        public DateTime? GuncellenmeTarihi { get; set; }
        public DateTime? SilinmeTarihi { get; set; }
        public string OlusturanKullanici { get; set; }
        public string GuncelleyenKullanici { get; set; }
        public string SilenKullanici { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
