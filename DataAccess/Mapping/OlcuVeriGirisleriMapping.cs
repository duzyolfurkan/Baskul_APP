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
    public class OlcuVeriGirisleriMapping : EntityTypeConfiguration<OlcuVeriGirisleri>
    {
        public OlcuVeriGirisleriMapping()
        {
            this.HasKey(ov => ov.Tarih);
            this.Property(ov => ov.Tarih).IsRequired();

            this.Property(ov => ov.DanisanID).IsRequired();
            this.Property(ov => ov.Agirlik).IsRequired();
            this.Property(ov => ov.BelCevresi).IsRequired();
            this.Property(ov => ov.KolCevresi).IsRequired();
            this.Property(ov => ov.GobekCevresi).IsRequired();
            this.Property(ov => ov.DiyetisyenYorumu).HasColumnType("nvarchar").HasMaxLength(500).IsUnicode(true).IsRequired();

            //ölçü verileri giriş tablosu ve danışan kullanıcı bilgileri tablosundaki bire-çok bağlantının çok kısmı
            this.HasRequired(ov => ov.DanisanKullaniciBilgileri)
                .WithMany(dkb => dkb.OlcuVeriGirisleris)
                .HasForeignKey(ov => ov.DanisanID);
        }
    }
}
