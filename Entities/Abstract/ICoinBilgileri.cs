using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface ICoinBilgileri
    {
        int DanisanID { get; set; }
        int CoinMiktari { get; set; }

        //Tablo referanslamaları
        DanisanKullaniciBilgileri DanisanKullaniciBilgileri { get; set; }
    }
}
