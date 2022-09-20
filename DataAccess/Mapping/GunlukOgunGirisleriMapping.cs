using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class GunlukOgunGirisleriMapping : EntityTypeConfiguration<GunlukOgunGirisleri>
    {
        public GunlukOgunGirisleriMapping()
        {
            this.HasKey(g => g.Tarih);
            this.Property(g => g.Tarih).IsRequired();

            this.Property(g => g.DanisanID).IsRequired();
            this.Property(g => g.OgunID).IsRequired();
            this.Property(g => g.BesinID).IsRequired();

            //Günlük öğün girişleri ile bağlantının çok kısmı
            this.HasRequired(g => g.BesinDegeriBilgileri)
                .WithMany(b => b.GunlukOgunGirisleris)
                .HasForeignKey(g => g.BesinID);

            //Danışan bilgileri ile bağlantının çok kısmı
            this.HasRequired(g => g.DanisanKullaniciBilgileri)
                .WithMany(dan => dan.GunlukOgunGirisleris)
                .HasForeignKey(g => g.DanisanID);

            //Öğün adı tablosu ile bağlantının çok kısmı
            this.HasRequired(oa => oa.OgunAdiTablosu)
                .WithMany(gun => gun.GunlukOgunGirisleris)
                .HasForeignKey(oa => oa.OgunID);

     

        }
    }
}
