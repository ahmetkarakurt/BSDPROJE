namespace NetSatis.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EKLEMELER : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BSD_TBL_ODEME",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Tarih = c.DateTime(nullable: false),
                        AyKodu = c.Int(),
                        OdemeTuru = c.String(),
                        BankaKod = c.String(),
                        BankaAdi = c.String(),
                        CariKod = c.String(),
                        CariAdi = c.String(),
                        BelgeNo = c.String(),
                        Tutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DovizTutar = c.Decimal(precision: 18, scale: 2),
                        OdemeTipi = c.String(),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.BSD_TBL_ODEMETURU",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        OdemeTurAciklama = c.String(),
                        OzelKod = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BSD_TBL_ODEMETURU");
            DropTable("dbo.BSD_TBL_ODEME");
        }
    }
}
