using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IDanisanKullaniciBilgileri
    {
        int DanisanID { get; set; }
        int DiyetisyenID { get; set; }
        string MailAdresi { get; set; }
        string Adi { get; set; }
        string Soyadi { get; set; }
        string Sifre { get; set; }
        byte[] ProfilResmi { get; set; }

        //Tablo referanslamaları
        List<AnketBilgileri> AnketBilgileris { get; set; }
        List<CoinBilgileri> CoinBilgileris { get; set; }
        DiyetisyenKullaniciBilgileri DiyetisyenKullaniciBilgileri { get; set; }
        List<SuIcmeVeriGirisleri> SuIcmeVeriGirisleris { get; set; }
        List<SuIcmeVeriYorumlari> SuIcmeVeriYorumlaris { get; set; }
        List<GunlukOgunGirisleri> GunlukOgunGirisleris { get; set; }
        List<GunlukOgunYorumlari> GunlukOgunYorumlaris { get; set; }
        List<EgzersizVeriGirisleri> EgzersizVeriGirisleris { get; set; }
        List<OlcuVeriGirisleri> OlcuVeriGirisleris { get; set; }
        List<SoruCevapVerileri> SoruCevapVerileris { get; set; }
        List<DiyetisyenRandevulari> DiyetisyenRandevularis { get; set; }

    }
}
