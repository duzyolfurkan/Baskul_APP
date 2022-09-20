using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IDiyetisyenKullaniciBilgileri
    {
        int DiyetisyenID { get; set; }
        string MailAdresi { get; set; }
        string Adi { get; set; }
        string Soyadi { get; set; }
        string Sifre { get; set; }
        byte[] ProfilResmi { get; set; }

        //Tablo referanslamaları
        List<DiyetisyenRandevulari> DiyetisyenRandevularis { get; set; }
        List<DanisanKullaniciBilgileri> DanisanKullaniciBilgileris { get; set; }
        List<SoruCevapVerileri> SoruCevapVerileris { get; set; }
        List<GunlukTarifler> GunlukTariflers { get; set; }
    }
}
