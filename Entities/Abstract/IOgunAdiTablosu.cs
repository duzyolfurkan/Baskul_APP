using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IOgunAdiTablosu
    {
        int OgunID { get; set; }
        string OgunAdi { get; set; }

        //Tablo referanslamaları
        List<GunlukOgunGirisleri> GunlukOgunGirisleris { get; set; }
    }
}
