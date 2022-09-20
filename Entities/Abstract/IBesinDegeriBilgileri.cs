using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IBesinDegeriBilgileri
    {
        int BesinID { get; set; }
        string BesinAdi { get; set; }
        int KategoriID { get; set; }
        int Miktar { get; set; }
        string Porsiyon { get; set; }
        double KarbonhidratOrani { get; set; }
        double YagOrani { get; set; }
        double ProteinOrani { get; set; }
        double Kalori { get; set; }

        //Tablo referanslamaları
        BesinKategoriTablosu BesinKategoriTablosu { get; set; }
        List<GunlukOgunGirisleri> GunlukOgunGirisleris { get; set; }

    }
}
