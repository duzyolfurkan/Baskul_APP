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
    public class SoruCevapVerileriMapping : EntityTypeConfiguration<SoruCevapVerileri>
    {
        public SoruCevapVerileriMapping()
        {
            this.HasKey(g => g.Tarih);
            this.Property(g => g.Tarih).IsRequired();

            this.Property(g => g.DanisanID).IsRequired();
            this.Property(g => g.DiyetisyenID).IsRequired();
            this.Property(g => g.DanisanSorusu).HasColumnType("nvarchar").HasMaxLength(1000).IsUnicode(true).IsRequired();
            this.Property(g => g.DiyetisyenYaniti).HasColumnType("nvarchar").HasMaxLength(1000).IsUnicode(true).IsRequired();

            //diyetisyen soru cevap tablosu ve dkb tablosundaki bire-çok bağlantının çok kısmı
            this.HasRequired(g => g.DanisanKullaniciBilgileri)
                .WithMany(dkb => dkb.SoruCevapVerileris)
                .HasForeignKey(g => g.DanisanID);

            //diyetisyen soru cevap tablosu ve diyetisyen kullanıcı bilgileri tablosundaki bire-çok bağlantının çok kısmı
            this.HasRequired(g => g.DiyetisyenKullaniciBilgileri)
                .WithMany(dyt => dyt.SoruCevapVerileris)
                .HasForeignKey(g => g.DiyetisyenID);
        }
    }
}
