using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface ISuIcmeVeriGirisleri
    {
        DateTime Tarih { get; set; }
        int DanisanID { get; set; }
        int BardakHacmi { get; set; }
        int BardakAdet { get; set; }

        //Tablo referanslamaları
        DanisanKullaniciBilgileri DanisanKullaniciBilgileri { get; set; }
    }
}
