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
    public class CoinBilgileriMapping : EntityTypeConfiguration<CoinBilgileri>
    {
        public CoinBilgileriMapping()
        {
            this.HasKey(c => c.CoinID);
            this.Property(c => c.CoinID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(c => c.DanisanID).IsRequired();
            this.Property(c => c.CoinMiktari).IsRequired();

            //Danışan bilgileri ile ilişkinin bir kısmı
            this.HasRequired(c => c.DanisanKullaniciBilgileri)
                .WithMany(dkb => dkb.CoinBilgileris)
                .HasForeignKey(c => c.DanisanID);


           
        }
    }
}
