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
    public class DiyetisyenKullaniciBilgileriMapping : EntityTypeConfiguration<DiyetisyenKullaniciBilgileri>
    {
        public DiyetisyenKullaniciBilgileriMapping()
        {
            this.HasKey(dyt => dyt.DiyetisyenID);
            this.Property(dyt => dyt.DiyetisyenID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(dyt => dyt.Adi).HasColumnType("nvarchar").HasMaxLength(30).IsUnicode(true).IsRequired();
            this.Property(dyt => dyt.Soyadi).HasColumnType("nvarchar").HasMaxLength(30).IsUnicode(true).IsRequired();
            this.Property(dyt => dyt.Sifre).HasColumnType("nvarchar").HasMaxLength(30).IsUnicode(true).IsRequired();
            this.Property(dyt => dyt.ProfilResmi).HasColumnType("varbinary(max)");

            //Diyetisyen danışan bağlantısı bir kısmı
            this.HasMany(d => d.DanisanKullaniciBilgileris)
                .WithRequired(di => di.DiyetisyenKullaniciBilgileri)
                .HasForeignKey(di => di.DiyetisyenID);

            //diyetisyen soru cevap tablosu ve diyetisyen kullanıcı bilgileri tablosundaki bire-çok bağlantının bir  kısmı
            this.HasMany(dyt => dyt.SoruCevapVerileris)
                .WithRequired(g => g.DiyetisyenKullaniciBilgileri)
                .HasForeignKey(g => g.DiyetisyenID);

            // günlük tarifler ve diyetisyen kullanıcı bilgileri tablosundaki bire çok bağlantının bir kısmı
            this.HasMany(dyt => dyt.GunlukTariflers)
                .WithRequired(t => t.DiyetisyenKullaniciBilgileri)
                .HasForeignKey(t => t.DiyetisyenID);

            //diyetisyen randevuları ile bire çok bağlantının "bir" kısmı
            this.HasMany(dyt => dyt.DiyetisyenRandevularis)
                .WithRequired(dr => dr.DiyetisyenKullaniciBilgileri)
                .HasForeignKey(dr => dr.DiyetisyenID);

        }
    }
}
