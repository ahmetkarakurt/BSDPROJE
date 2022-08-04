namespace NetSatis.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EkleKategoriTablosuDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EFAppointments",
                c => new
                    {
                        UniqueID = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        AllDay = c.Boolean(nullable: false),
                        Subject = c.String(),
                        Location = c.String(),
                        Description = c.String(),
                        Status = c.Int(nullable: false),
                        Label = c.Int(nullable: false),
                        ResourceIDs = c.String(),
                        ReminderInfo = c.String(),
                        RecurrenceInfo = c.String(),
                    })
                .PrimaryKey(t => t.UniqueID);
            
            CreateTable(
                "dbo.EFResources",
                c => new
                    {
                        UniqueID = c.Int(nullable: false, identity: true),
                        ResourceID = c.Int(nullable: false),
                        ResourceName = c.String(),
                        Color = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UniqueID);
            
            CreateTable(
                "dbo.Kullanicilar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(maxLength: 20),
                        Adi = c.String(maxLength: 20),
                        Soyadi = c.String(maxLength: 20),
                        Gorevi = c.String(maxLength: 20),
                        Parola = c.String(maxLength: 32),
                        HatirlatmaSorusu = c.String(maxLength: 50),
                        Cevap = c.String(maxLength: 20),
                        KayitTarihi = c.DateTime(),
                        SonGirisTarihi = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KullaniciRolleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RootId = c.Int(nullable: false),
                        ParentId = c.Int(nullable: false),
                        KullaniciAdi = c.String(maxLength: 20),
                        FormAdi = c.String(maxLength: 30),
                        KontrolAdi = c.String(maxLength: 30),
                        Yetki = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KullaniciRolleri");
            DropTable("dbo.Kullanicilar");
            DropTable("dbo.EFResources");
            DropTable("dbo.EFAppointments");
        }
    }
}
