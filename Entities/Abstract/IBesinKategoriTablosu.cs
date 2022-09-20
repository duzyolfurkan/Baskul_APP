using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IBesinKategoriTablosu
    {
        int KategoriID { get; set; }
        string KategoriAdi { get; set; }

        //Tablo referanslamaları
        List<GunlukTarifler> GunlukTariflers { get; set; }
        List<BesinDegeriBilgileri> BesinDegeriBilgileris { get; set; }
    }
}
