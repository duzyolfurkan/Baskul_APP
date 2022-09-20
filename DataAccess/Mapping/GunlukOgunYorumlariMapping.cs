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
    public class GunlukOgunYorumlariMapping : EntityTypeConfiguration<GunlukOgunYorumlari>
    {
        public GunlukOgunYorumlariMapping()
        {
            this.HasKey(oy => oy.Tarih);
            this.Property(oy => oy.Tarih).IsRequired();

            this.Property(oy => oy.DanisanID).IsRequired();
            this.Property(oy => oy.DiyetisyenYorumu).HasColumnType("nvarchar").HasMaxLength(200).IsUnicode(true).IsRequired();

            //Danışan ile bireçok bağlantının çok kısmı
            this.HasRequired(oy => oy.DanisanKullaniciBilgileri)
              .WithMany(dkb => dkb.GunlukOgunYorumlaris)
              .HasForeignKey(oy => oy.DanisanID);
        }
    }
}
