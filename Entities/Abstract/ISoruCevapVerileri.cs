using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface ISoruCevapVerileri
    {
        DateTime Tarih { get; set; }
        int DanisanID { get; set; }
        int DiyetisyenID { get; set; }
        string DanisanSorusu { get; set; }
        string DiyetisyenYaniti { get; set; }

        //Tablo referanslamaları
        DiyetisyenKullaniciBilgileri DiyetisyenKullaniciBilgileri { get; set; }
        DanisanKullaniciBilgileri DanisanKullaniciBilgileri { get; set; }
    }
}
