using DataAccess.Mapping;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class BaskulAppDbContext : DbContext
    {
        public BaskulAppDbContext() : base("Server=FURKANDUZYOL\\MSSQLSERVERFD;Database=BaskulAppDb;Trusted_Connection=True;")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BaskulAppDbContext>());
        }

        public DbSet<AnketBilgileri> AnketBilgileris { get; set; }
        public DbSet<BesinDegeriBilgileri> BesinDegeriBilgileris { get; set; }
        public DbSet<BesinKategoriTablosu> BesinKategoriTablosus { get; set; }
        public DbSet<CoinBilgileri> CoinBilgileris { get; set; }
        public DbSet<DanisanKullaniciBilgileri> DanisanKullaniciBilgileris { get; set; }
        public DbSet<DiyetisyenKullaniciBilgileri> DiyetisyenKullaniciBilgileris { get; set; }
        public DbSet<DiyetisyenRandevulari> DiyetisyenRandevularis { get; set; }
        public DbSet<EgzersizVeriGirisleri> EgzersizVeriGirisleris { get; set; }
        public DbSet<GunlukOgunGirisleri> GunlukOgunGirisleris {get; set; }
        public DbSet<GunlukOgunYorumlari> GunlukOgunYorumlaris { get; set; }
        public DbSet<GunlukTarifler> GunlukTariflers { get; set; }
        public DbSet<OgunAdiTablosu> OgunAdis { get; set; }
        public DbSet<OlcuVeriGirisleri> OlcuVeriGirisleris { get; set; }
        public DbSet<SifreKonfirmasyonBilgileri> SifreKonfirmasyonBilgileris { get; set; }
        public DbSet<SoruCevapVerileri> SoruCevapVerileris { get; set; }
        public DbSet<SuIcmeVeriGirisleri> SuIcmeVeriGirisleris { get; set; }
        public DbSet<SuIcmeVeriYorumlari> SuIcmeVeriYorumlaris { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AnketBilgileriMapping());
            modelBuilder.Configurations.Add(new BesinDegeriBilgileriMapping());
            modelBuilder.Configurations.Add(new BesinKategoriTablosuMapping());
            modelBuilder.Configurations.Add(new CoinBilgileriMapping());
            modelBuilder.Configurations.Add(new DanisanKullaniciBilgileriMapping());
            modelBuilder.Configurations.Add(new DiyetisyenKullaniciBilgileriMapping());
            modelBuilder.Configurations.Add(new DiyetisyenRandevulariMapping());
            modelBuilder.Configurations.Add(new EgzersizVeriGirisleriMapping());
            modelBuilder.Configurations.Add(new GunlukOgunGirisleriMapping());
            modelBuilder.Configurations.Add(new GunlukOgunYorumlariMapping());
            modelBuilder.Configurations.Add(new GunlukTariflerMapping());
            modelBuilder.Configurations.Add(new OgunAdiTablosuMapping());
            modelBuilder.Configurations.Add(new OlcuVeriGirisleriMapping());
            modelBuilder.Configurations.Add(new SifreKonfirmasyonBilgileriMapping());
            modelBuilder.Configurations.Add(new SoruCevapVerileriMapping());
            modelBuilder.Configurations.Add(new SuIcmeVeriGirisleriMapping());
            modelBuilder.Configurations.Add(new SuIcmeVeriYorumlariMapping());

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }


    }
}
