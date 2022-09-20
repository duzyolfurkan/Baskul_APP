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
    public class AnketBilgileriMapping : EntityTypeConfiguration<AnketBilgileri>
    {
        public AnketBilgileriMapping()
        {
            this.HasKey(a => a.AnketID);
            this.Property(a => a.AnketID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(a => a.Tarih).HasColumnType("datetime2").IsRequired();
            this.Property(a => a.DanisanID).IsRequired();
            this.Property(a => a.Adi).HasColumnType("nvarchar").HasMaxLength(30).IsUnicode(true).IsRequired();
            this.Property(a => a.Soyadi).HasColumnType("nvarchar").HasMaxLength(30).IsUnicode(true).IsRequired();
            this.Property(a => a.Cinsiyet).HasColumnType("nvarchar").HasMaxLength(30).IsUnicode(true).IsRequired();
            this.Property(a => a.UlkeSehir).HasColumnType("nvarchar").HasMaxLength(30).IsUnicode(true).IsRequired();
            this.Property(a => a.Telefon).HasColumnType("nvarchar").HasMaxLength(20).IsUnicode(true).IsRequired();
            this.Property(a => a.Yas).IsRequired();
            this.Property(a => a.Kilo).IsRequired();
            this.Property(a => a.Boy).IsRequired();
            this.Property(a => a.KronikHastalik).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(a => a.DuzenliKullanilanIlac).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(a => a.KullanilanTakviyeler).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(a => a.AmeliyatGecmisi).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(a => a.OgunSayisi).IsRequired();
            this.Property(a => a.YemekYapma).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(a => a.TuzEkleme).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(a => a.SekerKullanimi).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(a => a.AsitliIcecekKullanimi).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(a => a.AlkolKullanimi).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(a => a.SigaraKullanimi).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(a => a.BagirsakIslevDurumu).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(a => a.EgzersizDurumu).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(a => a.SuTuketimi).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(a => a.MideProblemi).HasColumnType("nvarchar").HasMaxLength(200).IsUnicode(true).IsRequired();
            this.Property(a => a.AlerjiDurumu).HasColumnType("nvarchar").HasMaxLength(200).IsUnicode(true).IsRequired();
            this.Property(a => a.SevilmeyenGidalar).HasColumnType("nvarchar").HasMaxLength(200).IsUnicode(true).IsRequired();
            this.Property(a => a.SevilenGidalar).HasColumnType("nvarchar").HasMaxLength(200).IsUnicode(true).IsRequired();
            this.Property(a => a.Meslek).HasColumnType("nvarchar").HasMaxLength(60).IsUnicode(true).IsRequired();
            this.Property(a => a.AktiviteDurumu).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(a => a.MotivasyonDegerlendirmesi).HasColumnType("nvarchar").HasMaxLength(20).IsUnicode(true).IsRequired();
            this.Property(a => a.HedefKilo).IsRequired();
            this.Property(a => a.DiyetGecmisi).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(a => a.AcikilanSaat).HasColumnType("nvarchar").HasMaxLength(30).IsUnicode(true).IsRequired();
            this.Property(a => a.EkNot).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(a => a.DiyetistenYorumu).HasColumnType("nvarchar").HasMaxLength(200).IsUnicode(true).IsRequired();

            //Danışan bilgileri ile ilişkinin çok kısmı
            this.HasRequired(a => a.DanisanKullaniciBilgileri)
                .WithMany(dkb => dkb.AnketBilgileris)
                .HasForeignKey(a => a.DanisanID);

        }
    }
}
