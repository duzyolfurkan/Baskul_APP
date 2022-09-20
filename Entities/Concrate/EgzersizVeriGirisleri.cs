using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class EgzersizVeriGirisleri : IBaseEntity, IEgzersizVeriGirisleri
    {
        public DateTime Tarih { get; set; }
        public int DanisanID { get; set; }
        public string EgzersizAdi { get; set; }
        public int EgzersizSüresi { get; set; }
        public int EgzersizMiktari { get; set; }
        public string DiyetisyenYorumu { get; set; }
        public DanisanKullaniciBilgileri DanisanKullaniciBilgileri { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
        public DateTime? GuncellenmeTarihi { get; set; }
        public DateTime? SilinmeTarihi { get; set; }
        public string OlusturanKullanici { get; set; }
        public string GuncelleyenKullanici { get; set; }
        public string SilenKullanici { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
