using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class GunlukOgunGirisleri : IBaseEntity, IGunlukOgunGirisleri
    {
        public DateTime Tarih { get; set; }
        public int DanisanID { get; set; }
        public int OgunID { get; set; }
        public int BesinID { get; set; }
        public DanisanKullaniciBilgileri DanisanKullaniciBilgileri { get; set; }
        public BesinDegeriBilgileri BesinDegeriBilgileri { get; set; }
        public OgunAdiTablosu OgunAdiTablosu { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
        public DateTime? GuncellenmeTarihi { get; set; }
        public DateTime? SilinmeTarihi { get; set; }
        public string OlusturanKullanici { get; set; }
        public string GuncelleyenKullanici { get; set; }
        public string SilenKullanici { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
