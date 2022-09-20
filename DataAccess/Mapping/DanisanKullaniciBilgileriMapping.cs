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
    public class DanisanKullaniciBilgileriMapping : EntityTypeConfiguration<DanisanKullaniciBilgileri>
    {
        public DanisanKullaniciBilgileriMapping()
        {
            this.HasKey(dkb => dkb.DanisanID);
            this.Property(dkb => dkb.DanisanID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(dkb => dkb.DiyetisyenID).IsRequired();
            this.Property(dkb => dkb.MailAdresi).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(dkb => dkb.Adi).HasColumnType("nvarchar").HasMaxLength(30).IsUnicode(true).IsRequired();
            this.Property(dkb => dkb.Soyadi).HasColumnType("nvarchar").HasMaxLength(30).IsUnicode(true).IsRequired();
            this.Property(dkb => dkb.Sifre).HasColumnType("nvarchar").HasMaxLength(30).IsUnicode(true).IsRequired();
            this.Property(dkb => dkb.ProfilResmi).HasColumnType("varbinary(max)").IsOptional();

            //Diyetisyen danışan bağlantısı çok kısmı
            this.HasRequired(di => di.DiyetisyenKullaniciBilgileri)
                .WithMany(d => d.DanisanKullaniciBilgileris)
                .HasForeignKey(di => di.DiyetisyenID);

            //Anket bilgileri ile ilişkinin bir kısmı
            this.HasRequired(dan => dan.AnketBilgileri)
                .WithRequiredPrincipal(ank => ank.DanisanKullaniciBilgileri);

            //Günlük öğün girişleri ile bağlantının bir kısmı
            this.HasMany(dan => dan.GunlukOgunGirisleris)
                .WithRequired(g => g.DanisanKullaniciBilgileri)
                .HasForeignKey(g => g.DanisanID);

            //ölçü verileri giriş tablosu ve dkb tablosundaki bire-çok bağlantının bir kısmı
            this.HasMany(dkb => dkb.OlcuVeriGirisleris)
                .WithRequired(ov => ov.DanisanKullaniciBilgileri)
                .HasForeignKey(ov => ov.DanisanID);

            //diyetisyen soru cevap tablosu ve dkb tablosundaki bire-çok bağlantının bir kısmı
            this.HasMany(dkb => dkb.SoruCevapVerileris)
                 .WithRequired(g => g.DanisanKullaniciBilgileri)
                 .HasForeignKey(g => g.DanisanID);

            //günlük öğün yorumları ile danışanın bire çok bağlantının "bir" kısmı
            this.HasMany(dkb => dkb.GunlukOgunYorumlaris)
                .WithRequired(oy => oy.DanisanKullaniciBilgileri)
                .HasForeignKey(oy => oy.DanisanID);

            //Danışan ve su içme veri yorumları ile bire çok bağlantının "bir" kısmı
            this.HasMany(dkb => dkb.SuIcmeVeriYorumlaris)
             .WithRequired(g => g.DanisanKullaniciBilgileri)
             .HasForeignKey(g => g.DanisanID);

            //Danışan bilgileri ile ilişkinin bir kısmı
            this.HasRequired(dan => dan.CoinBilgileri)
                .WithRequiredPrincipal(c => c.DanisanKullaniciBilgileri);

            //diyetisyen randevuları ile bire çok bağlantının "bir" kısmı
            this.HasMany(dkb => dkb.DiyetisyenRandevularis)
                .WithRequired(dr => dr.DanisanKullaniciBilgileri)
                .HasForeignKey(dr => dr.DanisanID);

            //Danışan ile egzersiz veri girişleri bireçok bağlantısının bir kısmı
            this.HasMany(dkb => dkb.EgzersizVeriGirisleris)
                .WithRequired(e => e.DanisanKullaniciBilgileri)
                .HasForeignKey(e => e.DanisanID);

            //Danışan kullanıcı bilgileri ile su içme veri girişleri bireçok bağlantısının bir kısmı
            this.HasMany(dkb => dkb.SuIcmeVeriGirisleris)
                .WithRequired(s => s.DanisanKullaniciBilgileri)
                .HasForeignKey(s => s.DanisanID);


        }
    }
}
