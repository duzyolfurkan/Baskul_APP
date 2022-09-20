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
    public class BesinKategoriTablosuMapping : EntityTypeConfiguration<BesinKategoriTablosu>
    {
        public BesinKategoriTablosuMapping()
        {
            this.HasKey(bkt => bkt.KategoriID);
            this.Property(bkt => bkt.KategoriID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(bkt => bkt.KategoriAdi).HasColumnName("nvarchar").HasMaxLength(75).IsUnicode(true);

            // günlük tarifler ve besin kategori tablosundaki bire çok bağlantının bir kısmı
            this.HasMany(bkt => bkt.GunlukTariflers)
                .WithRequired(t => t.BesinKategoriTablosu)
                .HasForeignKey(t => t.KategoriID);

            //Besin kategori tablosu ile besin değeri bilgileri tablosu arasındaki bireçok bağlantının bir kısmı
            this.HasMany(bkt => bkt.BesinDegeriBilgileris)
                .WithRequired(bdb => bdb.BesinKategoriTablosu)
                .HasForeignKey(bdb => bdb.KategoriID);
        }
    }
}
