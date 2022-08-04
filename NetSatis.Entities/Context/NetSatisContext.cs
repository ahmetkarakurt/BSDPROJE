using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSDPROJE.Entities.Mapping.IsTakip;
using BSDPROJE.Entities.Mapping.IsTakip.Ozellikler;
using BSDPROJE.Entities.Tables;
using BSDPROJE.Entities.Tables.isTakip;
using BSDPROJE.Entities.Tables.isTakip.Ozellikler;
using BSDPROJE.Entities.Tables.ODEMEGIDER;
using BSDPROJE.Entities.Tables.RAPORLAR;
using BSDPROJE.Entities.Tables.Views;
using NetSatis.Entities.Mapping;
using NetSatis.Entities.Migrations;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;

namespace NetSatis.Entities.Context
{
    public class NetSatisContext : DbContext
    {//EFAppointments
        public enum MigrationSecenek
        {
            IslemYapma,
            YoksaYeniOlustur,
            ModeliDegistir,
            SilveYenidenOlustur,
            ModelDegistiyseSilveYenidenOlustur
        }
       public NetSatisContext() : base(ConnectionStringTool.ConnectionString() ?? "Bağlantı Yok")
   //public NetSatisContext() : base("Data Source=BASODASRVARSV;Initial Catalog=ALM2022Q;Integrated Security=True")
        {
          //  System.Windows.Forms.MessageBox.Show(ConnectionStringTool.ConnectionString());
            //   Configuration.LazyLoadingEnabled = false;
            //    Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer<NetSatisContext>(new MigrateDatabaseToLatestVersion<NetSatisContext, Configuration>());
        }

        public NetSatisContext(string connString,MigrationSecenek migration=MigrationSecenek.ModeliDegistir) :base(connString)
        {
        //    Configuration.LazyLoadingEnabled = false;
        //    Configuration.ProxyCreationEnabled = false;
            switch (migration)
            {
                case MigrationSecenek.IslemYapma:
                    Database.SetInitializer<NetSatisContext>(null);

                    break;
                case MigrationSecenek.YoksaYeniOlustur:
                    Database.SetInitializer<NetSatisContext>(new CreateDatabaseIfNotExists<NetSatisContext>());
                    break;
                case MigrationSecenek.ModelDegistiyseSilveYenidenOlustur:
                    Database.SetInitializer<NetSatisContext>(new DropCreateDatabaseIfModelChanges<NetSatisContext>());
                    break;
                case MigrationSecenek.SilveYenidenOlustur:
                    Database.SetInitializer<NetSatisContext>(new DropCreateDatabaseAlways<NetSatisContext>());
                    break;
                case MigrationSecenek.ModeliDegistir:
                    Database.SetInitializer<NetSatisContext>(new MigrateDatabaseToLatestVersion<NetSatisContext, Configuration>());
                    break;
            }
        
            
        }

        public DbSet<BSD_TBL_EFAppointment> BSD_TBL_EFAppointments { get; set; }
        public DbSet<BSD_TBL_EFResource> BSD_TBL_EFResources { get; set; }
        public DbSet<BSD_TBL_Kullanici> BSD_TBL_Kullanicilar { get; set; }
        public DbSet<BSD_TBL_KullaniciRol> BSD_TBL_KullaniciRolleri { get; set; }

        public DbSet<BSD_TBL_ODEME> BSD_TBL_ODEME { get; set; }
        public DbSet<BSD_TBL_ODEMETURU> BSD_TBL_ODEMETURU { get; set; }
        public DbSet<BSD_TBL_RAPORLAR_ANA> BSD_TBL_RAPORLAR_ANA { get; set; }
        public DbSet<BSD_TBL_RAPORLAR_VW> BSD_TBL_RAPORLAR_VW { get; set; }


        public DbSet<BSD_TBL_Dosyalar> BSD_TBL_Dosyalar { get; set; }

        /// <summary>
        ///  IS TAKIP
        /// </summary>
        /// <param name="modelBuilder"></param>
        /// 

        public DbSet<BSD_TBL_BIRIM> BSD_TBL_BIRIM { get; set; }
        public DbSet<BSD_TBL_ALTBIRIM> BSD_TBL_ALTBIRIM { get; set; }
        public DbSet<BSD_TBL_ALTTEKNIKOZELLIKLER> BSD_TBL_ALTTEKNIKOZELLIKLER { get; set; }
        public DbSet<BSD_TBL_OZELLIKLER> BSD_TBL_OZELLIKLER { get; set; }
        public DbSet<BSD_TBL_TOZELLIKSECENEK> BSD_TBL_TOZELLIKSECENEK { get; set; }
        public DbSet<BSD_TBL_ISTAKIBI> BSD_TBL_ISTAKIBI { get; set; }
       public DbSet<BSD_TBL_BELGEREVIZYON> BSD_TBL_BELGEREVIZYON { get; set; }
       public DbSet<BSD_TBL_BELGEHAREKET> BSD_TBL_BELGEHAREKET { get; set; }
      public DbSet<BSD_TBL_ISTAKIBI_ALTOZEL> BSD_TBL_ISTAKIBI_ALTOZEL { get; set; }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new KullaniciRolMap());
            modelBuilder.Configurations.Add(new DosyalarMap());

            modelBuilder.Configurations.Add(new BirimMap());
            modelBuilder.Configurations.Add(new AltBirimMap());

            modelBuilder.Configurations.Add(new AltTeknikOzelliklerMap());
            modelBuilder.Configurations.Add(new AltTeknikOzelliklSecenekMap());
            modelBuilder.Configurations.Add(new OzelliklerMap());






    //        modelBuilder
    //.Entity<bsd_ddee>()
    //.ToTable(nameof(bsd_ddee))
    //.HasKey(t => t.STOK_KODU);

            //   modelBuilder.Configurations.Add(new AyarMap());

            //Database.SetInitializer<NetSatisContext>(null);
            //base.OnModelCreating(modelBuilder);

        }
    }
}
