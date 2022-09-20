using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class BesinDegeriBilgileri : IBaseEntity, IBesinDegeriBilgileri
    {
        public int BesinID { get; set; }
        public string BesinAdi { get; set; }
        public int KategoriID { get; set; }
        public int Miktar { get; set; }
        public string Porsiyon { get; set; }
        public double KarbonhidratOrani { get; set; }
        public double YagOrani { get; set; }
        public double ProteinOrani { get; set; }
        public double Kalori { get; set; }
        public BesinKategoriTablosu BesinKategoriTablosu { get; set; }
        public List<GunlukOgunGirisleri> GunlukOgunGirisleris { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
        public DateTime? GuncellenmeTarihi { get; set; }
        public DateTime? SilinmeTarihi { get; set; }
        public string OlusturanKullanici { get; set; }
        public string GuncelleyenKullanici { get; set; }
        public string SilenKullanici { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
