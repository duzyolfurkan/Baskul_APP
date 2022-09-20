using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IGunlukTarifler
    {
        int TarifID { get; set; }
        int KategoriID { get; set; }
        int DiyetisyenID { get; set; }
        string YemekAdi { get; set; }
        string Tarif { get; set; }

        //Tablo referanslamaları
        DiyetisyenKullaniciBilgileri DiyetisyenKullaniciBilgileri { get; set; }
        BesinKategoriTablosu BesinKategoriTablosu { get; set; }
    }
}
