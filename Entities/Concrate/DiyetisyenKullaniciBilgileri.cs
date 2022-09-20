using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class DiyetisyenKullaniciBilgileri : IBaseEntity, IDiyetisyenKullaniciBilgileri
    {
        public int DiyetisyenID { get; set; }
        public string MailAdresi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sifre { get; set; }
        public byte[] ProfilResmi { get; set; }
        public List<DiyetisyenRandevulari> DiyetisyenRandevularis { get; set; }
        public List<DanisanKullaniciBilgileri> DanisanKullaniciBilgileris { get; set; }
        public List<SoruCevapVerileri> SoruCevapVerileris { get; set; }
        public List<GunlukTarifler> GunlukTariflers { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
        public DateTime? GuncellenmeTarihi { get; set; }
        public DateTime? SilinmeTarihi { get; set; }
        public string OlusturanKullanici { get; set; }
        public string GuncelleyenKullanici { get; set; }
        public string SilenKullanici { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
