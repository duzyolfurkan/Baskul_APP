using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IOlcuVeriGirisleri
    {
        DateTime Tarih { get; set; }
        int DanisanID { get; set; }
        int Agirlik { get; set; }
        int KolCevresi { get; set; }
        int BelCevresi { get; set; }
        int GobekCevresi { get; set; }
        string DiyetisyenYorumu { get; set; }

        //Tablo referanslamaları
        DanisanKullaniciBilgileri DanisanKullaniciBilgileri { get; set; }
    }
}
