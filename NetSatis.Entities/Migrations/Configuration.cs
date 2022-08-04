namespace NetSatis.Entities.Migrations
{
    using NetSatis.Entities.Tables;
    using BSDPROJE.Entities.Tables.RAPORLAR;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using static System.Net.Mime.MediaTypeNames;

    internal sealed class Configuration : DbMigrationsConfiguration<NetSatis.Entities.Context.NetSatisContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "NetSatis.Entities.Context.NetSatisContext";
            
          
        }
      
        protected override void Seed(NetSatis.Entities.Context.NetSatisContext context)
        {
            //LoadingTool.LoadingTool animasyon = new LoadingTool.LoadingTool(_form);
            //animasyon.AnimasyonBaslat();
            //_context.Database.CreateIfNotExists();

            if (!context.BSD_TBL_Kullanicilar.Any(c => c.KullaniciAdi == "1"))
            {
                context.BSD_TBL_Kullanicilar.Add(new BSD_TBL_Kullanici
                {
                    KullaniciAdi = "1",
                    Parola = "1"
                });

                List<BSD_TBL_RAPORLAR_ANA> raporana = new List<BSD_TBL_RAPORLAR_ANA> { 
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "ALIS", Aciklama = "ALI� RAPORLARI", Image =  @"\ico\forklift.png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "SATIS", Aciklama = "SATI� RAPORLARI",  Image = @"\ico\management (2).png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "BANKA", Aciklama = "BANKA RAPORLARI",  Image = @"\ico\OdemeKontrol.png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "CARI", Aciklama = "CAR� RAPORLARI",  Image = @"\ico\Talep.png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "GIDER", Aciklama = "GiDER RAPORLARI",  Image = @"\ico\product (1).png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "KASA", Aciklama = "KASA RAPORLARI",  Image = @"\ico\Satici_Sip.png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "M_SIPARISLERI", Aciklama = "MUSTER� S�PAR��� RAPORLARI", Image = @"\ico\consumption.png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "ODEMELER", Aciklama = "�DEMELE RAPORLARI",  Image = @"\ico\assembly.png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "PLASIYER", Aciklama = "PLASIYER RAPORLARI",  Image = @"\ico\barcode.png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "SATICISIPARIS", Aciklama = "SATICI S�PAR�� RAPORLARI",  Image = @"\ico\backlog.png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "STOK", Aciklama = "STOK RAPORLARI", Image = @"\ico\conveyor (1).png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "URETIM", Aciklama = "URETIM RAPORLARI", Image = @"\ico\products (1).png" }
                     };



                context.BSD_TBL_RAPORLAR_ANA.AddRange(raporana);
                context.SaveChanges();
                var anamnu = context.BSD_TBL_RAPORLAR_ANA.ToList();
                List<BSD_TBL_RAPORLAR_VW> raporvw = new List<BSD_TBL_RAPORLAR_VW> {
                new BSD_TBL_RAPORLAR_VW {VwAdi="Stok Al��lar�",VwYolu= @"\DizaynRapor\Alis\StokAlis.xml",Image= @"\ico\assembly.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="ALIS").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Grup Baz�nda Sat�slar",VwYolu= @"\DizaynRapor\Satis\SatislarGrupBaz�nda.xml",Image= @"\ico\assembly-line.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="SATIS").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="KDV Sat��lar�",VwYolu= @"\DizaynRapor\Satis\SatislarKumune_kdvli.xml",Image= @"\ico\automation.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="SATIS").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="�l Baz�nda Genel Sat��lar",VwYolu= @"\DizaynRapor\Satis\ilBazindaGenelSatislar.xml",Image= @"\ico\backlog.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="SATIS").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Banka Durumlar�",VwYolu= @"\DizaynRapor\Banka\BankaDurumu.xml",Image= @"\ico\consumption.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="BANKA").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Cari Bakiye Listesi AY",VwYolu= @"\DizaynRapor\Cari\CariBakiyeListesiAylikBazda.xml",Image= @"\ico\continuous.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="CARI").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Cari Y�zde Rapor",VwYolu= @"\DizaynRapor\Cari\CariRaporOransal.xml",Image= @"\ico\control.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="CARI").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Genel Giderler Y�zde",VwYolu= @"\DizaynRapor\Gider\GenelGiderOran.xml",Image= @"\ico\control-lever.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="GIDER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Genel Gider Ayl�k",VwYolu= @"\DizaynRapor\Gider\GiderlerAylikBazda.xml",Image= @"\ico\control-panel.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="GIDER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Genel Gider Toplam Detayl�",VwYolu= @"\DizaynRapor\Gider\GiderlerToplamDetayli.xml",Image= @"\ico\conveyor (1).png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="GIDER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Muhassebe Baz�nda Gider",VwYolu= @"\DizaynRapor\Gider\MuhassebeGider.xml",Image= @"\ico\design.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="GIDER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Kasa Durumu Harteketleri",VwYolu= @"\DizaynRapor\Kasa\KasaHareketleri.xml",Image= @"\ico\warehouse.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="KASA").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="M��teri Sipari�leri",VwYolu= @"\DizaynRapor\M_Siparisleri\MusteriSiparisleri.xml",Image= @"\ico\energy.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="M_SIPARISLERI").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Sat�� Teklifleri Sipari�",VwYolu= @"\DizaynRapor\M_Siparisleri\SatisTeklifSiparis.xml",Image= @"\ico\worker.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="M_SIPARISLERI").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Sipari� Durumlar�",VwYolu= @"\DizaynRapor\M_Siparisleri\SiparisDurumlari.xml",Image= @"\ico\worker (2).png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="M_SIPARISLERI").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="�ek Senet �deme",VwYolu= @"\DizaynRapor\Odeme\CekSenetRaporu.xml",Image= @"\ico\worker (1).png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="ODEMELER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="�demeler Genel",VwYolu= @"\DizaynRapor\Odeme\OdemeKontrol.xml",Image= @"\ico\worker (1).png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="ODEMELER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Plasiyer Raporu",VwYolu= @"\DizaynRapor\Plasiyer\Plasiyer.xml",Image= @"\ico\warehouse.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="PLASIYER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Plasiyer Kar��la�t�rma",VwYolu= @"\DizaynRapor\Plasiyer\PlasiyerKarsilastirma.xml",Image= @"\ico\value.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="PLASIYER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Plasiyer Ay-Y�l Baz�nda",VwYolu= @"\DizaynRapor\Plasiyer\PlasiyerYillikAylik.xml",Image= @"\ico\UretimdeKullanilanUrunler.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="PLASIYER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Sat�c� Ac�k Talepler",VwYolu= @"\DizaynRapor\S_Siparisleri\AcikTalepStoklar.xml",Image= @"\ico\StokDepoluBakiye.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="SATICISIPARIS").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Sat�c� Siparisleri",VwYolu= @"\DizaynRapor\S_Siparisleri\SaticiSiparisleri.xml",Image= @"\ico\shipment.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="SATICISIPARIS").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Sat�s iade",VwYolu= @"\DizaynRapor\Stok\AdetliSatisiade.xml",Image= @"\ico\research-and-development.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="URETIM").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Sat�lan Stok Listesi",VwYolu= @"\DizaynRapor\Stok\AdetliSatisStokListe.xml",Image= @"\ico\products.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="URETIM").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="En Cok Al�nan Stok",VwYolu= @"\DizaynRapor\Stok\EncokStokAlislari.xml",Image= @"\ico\frustrated.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="STOK").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Depo Durumu Stok",VwYolu= @"\DizaynRapor\Stok\StokDepoluBakiye.xml",Image= @"\ico\products.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="STOK").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="i� Emri Durumlar�",VwYolu= @"\DizaynRapor\Uretim\IsEmriDurumlari.xml",Image= @"\ico\assembly.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="STOK").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="�retimde Kullan�lan �r�nler",VwYolu= @"\DizaynRapor\Uretim\UretimdeKullanilanUrunler.xml",Image= @"\ico\products (1).png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="STOK").Select(c=>c.id).FirstOrDefault()}};
                context.BSD_TBL_RAPORLAR_VW.AddRange(raporvw);
                context.SaveChanges();



            }


            // animasyon.AnimasyonBitir();
        }
    }
}
