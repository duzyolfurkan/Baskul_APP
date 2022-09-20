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
    public class SifreKonfirmasyonBilgileriMapping : EntityTypeConfiguration<SifreKonfirmasyonBilgileri>
    {
        public SifreKonfirmasyonBilgileriMapping()
        {
            this.HasKey(k => k.SifreID);
            this.Property(k => k.SifreID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(k => k.MailAdresi).HasColumnType("nvarchar").HasMaxLength(100).IsUnicode(true).IsRequired();
            this.Property(k => k.Sifre).IsRequired();
        }
    }
}
