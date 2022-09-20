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
    public class DiyetisyenRandevulariMapping : EntityTypeConfiguration<DiyetisyenRandevulari>
    {
        public DiyetisyenRandevulariMapping()
        {
            this.HasKey(dr => dr.RandevuID);
            this.Property(dr => dr.RandevuID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(dr => dr.DanisanID).IsRequired();
            this.Property(dr => dr.DiyetisyenID).IsRequired();
            this.Property(dr => dr.Tarih).HasColumnType("datetime2").IsRequired();
            this.Property(dr => dr.Saat).HasColumnType("nvarchar").HasMaxLength(10).IsUnicode(true).IsRequired();
            this.Property(dr => dr.EklenecekNot).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();

            //DanisanKullaniciBilgileri ile bire çok bağlantının çok kısmı:
            this.HasRequired(dr => dr.DanisanKullaniciBilgileri)
                .WithMany(dkb => dkb.DiyetisyenRandevularis)
                .HasForeignKey(dr => dr.DanisanID);

            //DiyetisyenKullaniciBilgileri ile bire çok bağlantının çok kısmı
            this.HasRequired(dr => dr.DanisanKullaniciBilgileri)
                .WithMany(dyt => dyt.DiyetisyenRandevularis)
                .HasForeignKey(dr => dr.DiyetisyenID);
        }
    }
}
