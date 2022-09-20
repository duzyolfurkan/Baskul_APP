using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class EgzersizVeriGirisleriMapping : EntityTypeConfiguration<EgzersizVeriGirisleri>
    {
        public EgzersizVeriGirisleriMapping()
        {
            this.Property(eg => eg.Tarih).HasColumnType("datetime2").IsRequired();
            this.Property(eg => eg.DanisanID).IsRequired();
            this.Property(eg => eg.EgzersizAdi).HasColumnType("nvarchar").HasMaxLength(30).IsUnicode(true).IsRequired();
            this.Property(eg => eg.EgzersizSüresi).IsRequired();
            this.Property(eg => eg.EgzersizSüresi).IsRequired();
            this.Property(eg => eg.DiyetisyenYorumu).HasColumnType("nvarchar").HasMaxLength(200).IsUnicode(true).IsRequired();

            //Danışan ile egzersiz veri girişleri bireçok bağlantısının çok kısmı
            this.HasRequired(e => e.DanisanKullaniciBilgileri)
                .WithMany(dkb => dkb.EgzersizVeriGirisleris)
                .HasForeignKey(e => e.DanisanID);


        }
    }
}
