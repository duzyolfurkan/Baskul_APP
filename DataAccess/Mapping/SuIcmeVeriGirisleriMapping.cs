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
    public class SuIcmeVeriGirisleriMapping : EntityTypeConfiguration<SuIcmeVeriGirisleri>
    {
        public SuIcmeVeriGirisleriMapping()
        {
            this.HasKey(si => si.Tarih);
            this.Property(si => si.Tarih).IsRequired();

            this.Property(si => si.DanisanID).IsRequired();
            this.Property(si => si.BardakHacmi).IsRequired();
            this.Property(si => si.BardakAdet).IsRequired();

            //Danışan kullanıcı bilgileri ile su içme veri girişleri bireçok bağlantısının çok kısmı
            this.HasRequired(s => s.DanisanKullaniciBilgileri)
                .WithMany(dkb => dkb.SuIcmeVeriGirisleris)
                .HasForeignKey(s => s.DanisanID);

           
        }
    }
}
