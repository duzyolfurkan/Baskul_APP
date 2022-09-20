using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IDiyetistenRandevulari
    {
        int RandevuID { get; set; }
        int DanisanID { get; set; }
        int DiyetisyenID { get; set; }
        DateTime Tarih { get; set; }
        string Saat { get; set; }
        string EklenecekNot { get; set; }

        //Tablo referanslamaları
        DiyetisyenKullaniciBilgileri DiyetisyenKullaniciBilgileri { get; set; }
        DanisanKullaniciBilgileri DanisanKullaniciBilgileri { get; set; }
    }
}
