using Entities.Concrate;
using System;
using System.Collections.Generic;
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
            this.HasKey(c => c.DanisanID);
            this.Property(c => c.DanisanID).IsRequired();

            this.Property(c => c.CoinMiktari).IsRequired();

            //Danışan bilgileri ile ilişkinin bir kısmı
            this.HasRequired(c => c.DanisanKullaniciBilgileri)
                  .WithRequiredPrincipal(dan => dan.CoinBilgileri);
        }
    }
}
