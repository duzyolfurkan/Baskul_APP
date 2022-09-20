using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IGunlukOgunGirisleri
    {
        DateTime Tarih { get; set; }
        int DanisanID { get; set; }
        int OgunID { get; set; }
        int BesinID { get; set; }

        //Tablo referanslamaları
        DanisanKullaniciBilgileri DanisanKullaniciBilgileri { get; set; }
        BesinDegeriBilgileri BesinDegeriBilgileri { get; set; }
        OgunAdiTablosu OgunAdiTablosu { get; set; }
    }
}
