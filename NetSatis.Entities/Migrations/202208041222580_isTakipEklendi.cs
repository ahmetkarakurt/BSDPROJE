namespace NetSatis.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isTakipEklendi : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BSD_TBL_BIRIM", "BSD_TBL_ALTBIRIM_Id", "dbo.BSD_TBL_ALTBIRIM");
            DropForeignKey("dbo.BSD_TBL_ALTBIRIM", "BSD_TBL_BIRIMATAMA_Id", "dbo.BSD_TBL_BIRIMATAMA");
            DropForeignKey("dbo.BSD_TBL_BIRIM", "BSD_TBL_BIRIMATAMA_Id", "dbo.BSD_TBL_BIRIMATAMA");
            DropForeignKey("dbo.BSD_TBL_Kullanicilar", "BSD_TBL_BIRIMATAMA_Id", "dbo.BSD_TBL_BIRIMATAMA");
            DropIndex("dbo.BSD_TBL_ALTBIRIM", new[] { "BSD_TBL_BIRIMATAMA_Id" });
            DropIndex("dbo.BSD_TBL_BIRIM", new[] { "BSD_TBL_ALTBIRIM_Id" });
            DropIndex("dbo.BSD_TBL_BIRIM", new[] { "BSD_TBL_BIRIMATAMA_Id" });
            DropIndex("dbo.BSD_TBL_Kullanicilar", new[] { "BSD_TBL_BIRIMATAMA_Id" });
            AddColumn("dbo.BSD_TBL_ALTBIRIM", "BirimId", c => c.Int(nullable: false));
            AddColumn("dbo.BSD_TBL_BIRIMATAMA", "KullaniciId", c => c.Int(nullable: false));
            AddColumn("dbo.BSD_TBL_BIRIMATAMA", "BirimId", c => c.Int(nullable: false));
            AddColumn("dbo.BSD_TBL_BIRIMATAMA", "AltBirimId", c => c.Int(nullable: false));
            AlterColumn("dbo.BSD_TBL_BIRIM", "Birim", c => c.String(maxLength: 50));
            AlterColumn("dbo.BSD_TBL_BIRIM", "BirimAciklama", c => c.String(maxLength: 100));
            AlterColumn("dbo.BSD_TBL_Dosyalar", "DosyaAdi", c => c.String(maxLength: 200));
            AlterColumn("dbo.BSD_TBL_Dosyalar", "DosyaTipi", c => c.String(maxLength: 200));
            AlterColumn("dbo.BSD_TBL_Dosyalar", "Kod_1s", c => c.String(maxLength: 20));
            CreateIndex("dbo.BSD_TBL_ALTBIRIM", "BirimId");
            CreateIndex("dbo.BSD_TBL_BIRIMATAMA", "KullaniciId");
            CreateIndex("dbo.BSD_TBL_BIRIMATAMA", "BirimId");
            CreateIndex("dbo.BSD_TBL_BIRIMATAMA", "AltBirimId");
            AddForeignKey("dbo.BSD_TBL_ALTBIRIM", "BirimId", "dbo.BSD_TBL_BIRIM", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BSD_TBL_BIRIMATAMA", "AltBirimId", "dbo.BSD_TBL_ALTBIRIM", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BSD_TBL_BIRIMATAMA", "BirimId", "dbo.BSD_TBL_BIRIM", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BSD_TBL_BIRIMATAMA", "KullaniciId", "dbo.BSD_TBL_Kullanicilar", "Id", cascadeDelete: true);
            DropColumn("dbo.BSD_TBL_ALTBIRIM", "BSD_TBL_BIRIMATAMA_Id");
            DropColumn("dbo.BSD_TBL_BIRIM", "BSD_TBL_ALTBIRIM_Id");
            DropColumn("dbo.BSD_TBL_BIRIM", "BSD_TBL_BIRIMATAMA_Id");
            DropColumn("dbo.BSD_TBL_Kullanicilar", "BSD_TBL_BIRIMATAMA_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BSD_TBL_Kullanicilar", "BSD_TBL_BIRIMATAMA_Id", c => c.Int());
            AddColumn("dbo.BSD_TBL_BIRIM", "BSD_TBL_BIRIMATAMA_Id", c => c.Int());
            AddColumn("dbo.BSD_TBL_BIRIM", "BSD_TBL_ALTBIRIM_Id", c => c.Int());
            AddColumn("dbo.BSD_TBL_ALTBIRIM", "BSD_TBL_BIRIMATAMA_Id", c => c.Int());
            DropForeignKey("dbo.BSD_TBL_BIRIMATAMA", "KullaniciId", "dbo.BSD_TBL_Kullanicilar");
            DropForeignKey("dbo.BSD_TBL_BIRIMATAMA", "BirimId", "dbo.BSD_TBL_BIRIM");
            DropForeignKey("dbo.BSD_TBL_BIRIMATAMA", "AltBirimId", "dbo.BSD_TBL_ALTBIRIM");
            DropForeignKey("dbo.BSD_TBL_ALTBIRIM", "BirimId", "dbo.BSD_TBL_BIRIM");
            DropIndex("dbo.BSD_TBL_BIRIMATAMA", new[] { "AltBirimId" });
            DropIndex("dbo.BSD_TBL_BIRIMATAMA", new[] { "BirimId" });
            DropIndex("dbo.BSD_TBL_BIRIMATAMA", new[] { "KullaniciId" });
            DropIndex("dbo.BSD_TBL_ALTBIRIM", new[] { "BirimId" });
            AlterColumn("dbo.BSD_TBL_Dosyalar", "Kod_1s", c => c.String());
            AlterColumn("dbo.BSD_TBL_Dosyalar", "DosyaTipi", c => c.String());
            AlterColumn("dbo.BSD_TBL_Dosyalar", "DosyaAdi", c => c.String());
            AlterColumn("dbo.BSD_TBL_BIRIM", "BirimAciklama", c => c.String());
            AlterColumn("dbo.BSD_TBL_BIRIM", "Birim", c => c.String());
            DropColumn("dbo.BSD_TBL_BIRIMATAMA", "AltBirimId");
            DropColumn("dbo.BSD_TBL_BIRIMATAMA", "BirimId");
            DropColumn("dbo.BSD_TBL_BIRIMATAMA", "KullaniciId");
            DropColumn("dbo.BSD_TBL_ALTBIRIM", "BirimId");
            CreateIndex("dbo.BSD_TBL_Kullanicilar", "BSD_TBL_BIRIMATAMA_Id");
            CreateIndex("dbo.BSD_TBL_BIRIM", "BSD_TBL_BIRIMATAMA_Id");
            CreateIndex("dbo.BSD_TBL_BIRIM", "BSD_TBL_ALTBIRIM_Id");
            CreateIndex("dbo.BSD_TBL_ALTBIRIM", "BSD_TBL_BIRIMATAMA_Id");
            AddForeignKey("dbo.BSD_TBL_Kullanicilar", "BSD_TBL_BIRIMATAMA_Id", "dbo.BSD_TBL_BIRIMATAMA", "Id");
            AddForeignKey("dbo.BSD_TBL_BIRIM", "BSD_TBL_BIRIMATAMA_Id", "dbo.BSD_TBL_BIRIMATAMA", "Id");
            AddForeignKey("dbo.BSD_TBL_ALTBIRIM", "BSD_TBL_BIRIMATAMA_Id", "dbo.BSD_TBL_BIRIMATAMA", "Id");
            AddForeignKey("dbo.BSD_TBL_BIRIM", "BSD_TBL_ALTBIRIM_Id", "dbo.BSD_TBL_ALTBIRIM", "Id");
        }
    }
}
