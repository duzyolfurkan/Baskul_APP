using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class SuIcmeVeriYorumlariMapping : EntityTypeConfiguration<SuIcmeVeriYorumlari>
    {
        public SuIcmeVeriYorumlariMapping()
        {
            this.Property(g => g.Tarih).IsRequired();
            this.Property(g => g.DanisanID).IsRequired();
            this.Property(a => a.DiyetisyenYorumu).HasColumnType("nvarchar").HasMaxLength(1000).IsUnicode(true).IsRequired();

            //danışan ile su içme veri yorumları bire çok bağlantının "çok" kısmı
            this.HasRequired(g => g.DanisanKullaniciBilgileri)
                .WithMany(dkb => dkb.SuIcmeVeriYorumlaris)
                .HasForeignKey(g => g.DanisanID);
        }
    }
}
