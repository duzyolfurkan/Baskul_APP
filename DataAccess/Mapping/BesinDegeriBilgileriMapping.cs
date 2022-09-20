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
    public class BesinDegeriBilgileriMapping : EntityTypeConfiguration<BesinDegeriBilgileri>
    {
        public BesinDegeriBilgileriMapping()
        {
            this.HasKey(b => b.BesinID);
            this.Property(b => b.BesinID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(b => b.BesinAdi).HasColumnType("nvarchar").HasMaxLength(70).IsUnicode(true).IsRequired();
            this.Property(b => b.KategoriID).IsRequired();
            this.Property(b => b.Miktar).IsRequired();
            this.Property(b => b.Porsiyon).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(b => b.KarbonhidratOrani).IsRequired();
            this.Property(b => b.YagOrani).IsRequired();
            this.Property(b => b.ProteinOrani).IsRequired();
            this.Property(b => b.Kalori).IsRequired();

            //Günlük öğün girişleri ile bağlantının bir kısmı
            this.HasMany(b => b.GunlukOgunGirisleris)
                .WithRequired(g => g.BesinDegeriBilgileri)
                .HasForeignKey(g => g.BesinID);

            //Besin kategori tablosu ile besin değeri bilgileri tablosu arasındaki bireçok bağlantının çok kısmı
            this.HasRequired(bdb => bdb.BesinKategoriTablosu)
                .WithMany(bkt => bkt.BesinDegeriBilgileris)
                .HasForeignKey(bdb => bdb.KategoriID);

        }
    }
}
