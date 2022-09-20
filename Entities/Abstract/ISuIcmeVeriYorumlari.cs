using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface ISuIcmeVeriYorumlari
    {
        DateTime Tarih { get; set; }
        int DanisanID { get; set; }
        string DiyetisyenYorumu { get; set; }

        //Tablo referanslamaları
        DanisanKullaniciBilgileri DanisanKullaniciBilgileri { get; set; }
    }
}
