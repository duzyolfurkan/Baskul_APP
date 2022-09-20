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
    public class GunlukTariflerMapping : EntityTypeConfiguration<GunlukTarifler>
    {
        public GunlukTariflerMapping()
        {
            this.HasKey(t => t.TarifID);
            this.Property(t => t.TarifID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(t => t.KategoriID).IsRequired();
            this.Property(t => t.YemekAdi).HasColumnType("nvarchar").HasMaxLength(70).IsUnicode(true).IsRequired();
            this.Property(t => t.Tarif).HasColumnType("nvarchar").HasMaxLength(1000).IsUnicode(true).IsRequired();
            this.Property(t => t.DiyetisyenID).IsRequired();

            // günlük tarifler ve besin kategori tablosundaki bire çok bağlantının çok kısmı
            this.HasRequired(t => t.BesinKategoriTablosu)
                   .WithMany(bkt => bkt.GunlukTariflers)
                   .HasForeignKey(t => t.KategoriID);

            // günlük tarifler ve diyetisyen kullanıcı bilgileri tablosundaki bire çok bağlantının çok kısmı
            this.HasRequired(t => t.DiyetisyenKullaniciBilgileri)
                   .WithMany(dyt => dyt.GunlukTariflers)
                   .HasForeignKey(t => t.DiyetisyenID);

        }
    }
}
