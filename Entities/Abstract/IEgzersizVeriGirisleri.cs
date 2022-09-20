using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IEgzersizVeriGirisleri
    {
        DateTime Tarih { get; set; }
        int DanisanID { get; set; }
        string EgzersizAdi { get; set; }
        int EgzersizSüresi { get; set; }
        int EgzersizMiktari { get; set; }
        string DiyetisyenYorumu { get; set; }

        //Tablo referanslamaları 
        DanisanKullaniciBilgileri DanisanKullaniciBilgileri { get; set; }
}
}
