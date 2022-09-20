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
    public class OgunAdiTablosuMapping : EntityTypeConfiguration<OgunAdiTablosu>
    {
        public OgunAdiTablosuMapping()
        {
            this.HasKey(oa => oa.OgunID);
            this.Property(oa => oa.OgunID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(oa => oa.OgunAdi).HasColumnType("nvarchar").HasMaxLength(30).IsUnicode(true).IsRequired();

            //Günlük öğün girişleri ile bağlantının bir kısmı
            this.HasMany(oa => oa.GunlukOgunGirisleris)
                .WithRequired(gun => gun.OgunAdiTablosu)
                .HasForeignKey(gun => gun.OgunID);
        }
    }
}
