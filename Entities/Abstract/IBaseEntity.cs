using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IBaseEntity
    {
        //Ekleme-Silme-Güncelleme işlemleri kaydı için propertyler oluşturuldu.
        DateTime OlusturulmaTarihi { get; set; } 
        DateTime? GuncellenmeTarihi { get; set; }
        DateTime? SilinmeTarihi { get; set; } 
        string OlusturanKullanici { get; set; }
        string GuncelleyenKullanici { get; set; }
        string SilenKullanici { get; set; }
        Status Status { get; set; }
    }
}
