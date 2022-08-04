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
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "ALIS", Aciklama = "ALIÞ RAPORLARI", Image =  @"\ico\forklift.png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "SATIS", Aciklama = "SATIÞ RAPORLARI",  Image = @"\ico\management (2).png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "BANKA", Aciklama = "BANKA RAPORLARI",  Image = @"\ico\OdemeKontrol.png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "CARI", Aciklama = "CARÝ RAPORLARI",  Image = @"\ico\Talep.png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "GIDER", Aciklama = "GiDER RAPORLARI",  Image = @"\ico\product (1).png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "KASA", Aciklama = "KASA RAPORLARI",  Image = @"\ico\Satici_Sip.png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "M_SIPARISLERI", Aciklama = "MUSTERÝ SÝPARÝÞÝ RAPORLARI", Image = @"\ico\consumption.png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "ODEMELER", Aciklama = "ÖDEMELE RAPORLARI",  Image = @"\ico\assembly.png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "PLASIYER", Aciklama = "PLASIYER RAPORLARI",  Image = @"\ico\barcode.png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "SATICISIPARIS", Aciklama = "SATICI SÝPARÝÞ RAPORLARI",  Image = @"\ico\backlog.png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "STOK", Aciklama = "STOK RAPORLARI", Image = @"\ico\conveyor (1).png" },
                      new BSD_TBL_RAPORLAR_ANA { KategoriAdi = "URETIM", Aciklama = "URETIM RAPORLARI", Image = @"\ico\products (1).png" }
                     };



                context.BSD_TBL_RAPORLAR_ANA.AddRange(raporana);
                context.SaveChanges();
                var anamnu = context.BSD_TBL_RAPORLAR_ANA.ToList();
                List<BSD_TBL_RAPORLAR_VW> raporvw = new List<BSD_TBL_RAPORLAR_VW> {
                new BSD_TBL_RAPORLAR_VW {VwAdi="Stok Alýþlarý",VwYolu= @"\DizaynRapor\Alis\StokAlis.xml",Image= @"\ico\assembly.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="ALIS").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Grup Bazýnda Satýslar",VwYolu= @"\DizaynRapor\Satis\SatislarGrupBazýnda.xml",Image= @"\ico\assembly-line.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="SATIS").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="KDV Satýþlarý",VwYolu= @"\DizaynRapor\Satis\SatislarKumune_kdvli.xml",Image= @"\ico\automation.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="SATIS").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Ýl Bazýnda Genel Satýþlar",VwYolu= @"\DizaynRapor\Satis\ilBazindaGenelSatislar.xml",Image= @"\ico\backlog.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="SATIS").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Banka Durumlarý",VwYolu= @"\DizaynRapor\Banka\BankaDurumu.xml",Image= @"\ico\consumption.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="BANKA").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Cari Bakiye Listesi AY",VwYolu= @"\DizaynRapor\Cari\CariBakiyeListesiAylikBazda.xml",Image= @"\ico\continuous.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="CARI").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Cari Yüzde Rapor",VwYolu= @"\DizaynRapor\Cari\CariRaporOransal.xml",Image= @"\ico\control.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="CARI").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Genel Giderler Yüzde",VwYolu= @"\DizaynRapor\Gider\GenelGiderOran.xml",Image= @"\ico\control-lever.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="GIDER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Genel Gider Aylýk",VwYolu= @"\DizaynRapor\Gider\GiderlerAylikBazda.xml",Image= @"\ico\control-panel.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="GIDER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Genel Gider Toplam Detaylý",VwYolu= @"\DizaynRapor\Gider\GiderlerToplamDetayli.xml",Image= @"\ico\conveyor (1).png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="GIDER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Muhassebe Bazýnda Gider",VwYolu= @"\DizaynRapor\Gider\MuhassebeGider.xml",Image= @"\ico\design.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="GIDER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Kasa Durumu Harteketleri",VwYolu= @"\DizaynRapor\Kasa\KasaHareketleri.xml",Image= @"\ico\warehouse.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="KASA").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Müþteri Sipariþleri",VwYolu= @"\DizaynRapor\M_Siparisleri\MusteriSiparisleri.xml",Image= @"\ico\energy.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="M_SIPARISLERI").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Satýþ Teklifleri Sipariþ",VwYolu= @"\DizaynRapor\M_Siparisleri\SatisTeklifSiparis.xml",Image= @"\ico\worker.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="M_SIPARISLERI").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Sipariþ Durumlarý",VwYolu= @"\DizaynRapor\M_Siparisleri\SiparisDurumlari.xml",Image= @"\ico\worker (2).png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="M_SIPARISLERI").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Çek Senet Ödeme",VwYolu= @"\DizaynRapor\Odeme\CekSenetRaporu.xml",Image= @"\ico\worker (1).png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="ODEMELER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Ödemeler Genel",VwYolu= @"\DizaynRapor\Odeme\OdemeKontrol.xml",Image= @"\ico\worker (1).png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="ODEMELER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Plasiyer Raporu",VwYolu= @"\DizaynRapor\Plasiyer\Plasiyer.xml",Image= @"\ico\warehouse.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="PLASIYER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Plasiyer Karþýlaþtýrma",VwYolu= @"\DizaynRapor\Plasiyer\PlasiyerKarsilastirma.xml",Image= @"\ico\value.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="PLASIYER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Plasiyer Ay-Yýl Bazýnda",VwYolu= @"\DizaynRapor\Plasiyer\PlasiyerYillikAylik.xml",Image= @"\ico\UretimdeKullanilanUrunler.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="PLASIYER").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Satýcý Acýk Talepler",VwYolu= @"\DizaynRapor\S_Siparisleri\AcikTalepStoklar.xml",Image= @"\ico\StokDepoluBakiye.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="SATICISIPARIS").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Satýcý Siparisleri",VwYolu= @"\DizaynRapor\S_Siparisleri\SaticiSiparisleri.xml",Image= @"\ico\shipment.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="SATICISIPARIS").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Satýs iade",VwYolu= @"\DizaynRapor\Stok\AdetliSatisiade.xml",Image= @"\ico\research-and-development.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="URETIM").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Satýlan Stok Listesi",VwYolu= @"\DizaynRapor\Stok\AdetliSatisStokListe.xml",Image= @"\ico\products.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="URETIM").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="En Cok Alýnan Stok",VwYolu= @"\DizaynRapor\Stok\EncokStokAlislari.xml",Image= @"\ico\frustrated.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="STOK").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Depo Durumu Stok",VwYolu= @"\DizaynRapor\Stok\StokDepoluBakiye.xml",Image= @"\ico\products.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="STOK").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="iþ Emri Durumlarý",VwYolu= @"\DizaynRapor\Uretim\IsEmriDurumlari.xml",Image= @"\ico\assembly.png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="STOK").Select(c=>c.id).FirstOrDefault()},
                new BSD_TBL_RAPORLAR_VW {VwAdi="Üretimde Kullanýlan Ürünler",VwYolu= @"\DizaynRapor\Uretim\UretimdeKullanilanUrunler.xml",Image= @"\ico\products (1).png",Kategorid=anamnu.Where(c=>c.KategoriAdi=="STOK").Select(c=>c.id).FirstOrDefault()}};
                context.BSD_TBL_RAPORLAR_VW.AddRange(raporvw);
                context.SaveChanges();



            }


            // animasyon.AnimasyonBitir();
        }
    }
}
