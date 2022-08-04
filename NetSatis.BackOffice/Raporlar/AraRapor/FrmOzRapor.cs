using BSD.RAPOR.Utiles.UI;
using BSDPROJE.Entities.Dto;
using BSDPROJE.Entities.Extensions;
using BSDPROJE.Entities.Tools;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tables.OtherTables;
using NetSatis.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSDPROJE.Entities.BaseUI;

namespace BSDPROJE.BackOffice.Raporlar.AraRapor
{
    public partial class FrmOzRapor : BaseWinForms
    {
        public FrmOzRapor()
        {
            InitializeComponent();

            ExtensionMethod.HandleException(() =>
            {
                ExchangeTool doviz = new ExchangeTool();

                decimal? Euro = doviz.DovizKuruCek().Where(c => c.CurrencyCode == "EUR").Select(c => c.BanknoteBuying).FirstOrDefault();
                decimal? Dolar = doviz.DovizKuruCek().Where(c => c.CurrencyCode == "USD").Select(c => c.BanknoteBuying).FirstOrDefault();


                using (var context = new NetSatisContext())
                {
                    var CariOZBorcAlacakGenelDokumu = context.Database
                    .SqlQuery<OZCARI_BORCALACAK>(FixedSQLCode.CariOZBorcAlacakGenelDokumu).OrderBy(c => c.ISIM).ToList();

                    var GenelCokodemesiOz = context.Database
                            .SqlQuery<OZ_CEKSENET_BORCALACAK>(FixedSQLCode.GenelCokodemesiOz).ToList();

                    var OdemePlani = context.Database
                        .SqlQuery<ODEME_PLANI>(FixedSQLCode.GenelODemePlaniOz).ToList();


                    var StokGenelDurumBorcAlacak = context.Database
                      .SqlQuery<STOK_GENEL_DEPO>(FixedSQLCode.StokGenelDurumBorcAlacak).ToList();


                    var KasaGenelDurumOzel = context.Database
                      .SqlQuery<KASA_GENEL_BORCALACAK>(FixedSQLCode.KasaGenelDurumOzel).ToList();

                    var BankaGenelDurumBorcAlacak = context.Database
                        .SqlQuery<BANKA_GENE_BORCALACAK>(FixedSQLCode.BankaGenelDurumBorcAlacak).ToList();



                    var TLborc = CariOZBorcAlacakGenelDokumu.Sum(c => c.SBORC);
                    var TLalacak = CariOZBorcAlacakGenelDokumu.Sum(c => c.SALACAK);



                    //sağ cari
                    cardCari.Baslik = "TOPLAM AÇIK HESAP";
                    cardCari.Tip = "0";
                    cardCari.BorckBakiye = TLborc;
                    cardCari.AlacakBakiye = TLalacak;
                    cardCari.Bakiye = TLborc - TLalacak;
                    cardCari.Bakiyegizle = true;
                    //sağ çek senet 
                    cardCeksenet.Baslik = "TOPLAM CEK/SENET ÖDEMESİ";
                    cardCeksenet.Tip = "0";
                    cardCeksenet.Bakiye = GenelCokodemesiOz.Sum(c => c.TUTAR);
                    //sağ kasa
                    cardKasa.Baslik = SettingsTool.AyarOku(SettingsTool.Ayarlar.OzelRapor_KasaSirketi) + " Kasa ";
                    cardKasa.Tip = "0";
                    cardKasa.BorckBakiye = KasaGenelDurumOzel.Sum(c => c.GELIR);
                    cardKasa.AlacakBakiye = KasaGenelDurumOzel.Sum(c => c.GIDER);
                    cardKasa.Bakiye = KasaGenelDurumOzel.Sum(c => c.KALAN);
                    // SAĞ ODEMELER
                    var Odemeler = OdemePlani.Where(c => c.OdemeTuru!="CEK").ToList();
                    decimal? DigerODemelerTLToplam = Odemeler.Where(c=>c.KURISIM=="TL").ToList().Sum(c=>c.TUTAR);
                    DigerODemelerTLToplam += (Odemeler.Where(c => c.KURISIM == "EURO").ToList().Sum(c => c.TUTAR))* Euro;
                    DigerODemelerTLToplam += (Odemeler.Where(c => c.KURISIM == "USD").ToList().Sum(c => c.TUTAR))* Dolar;
                  

                    cardOdemeler.Baslik = "TOPLAM ODEMELER";
                    cardOdemeler.Tip = "0";
                    cardOdemeler.Bakiye = DigerODemelerTLToplam;

                    // sağ stok envaretri
                    cardStok.Baslik = "STOK ENVARTERİ";
                    cardStok.Tip = "0";
                    cardStok.Bakiye = StokGenelDurumBorcAlacak.Sum(c=>c.GENEL_ALIS);

                    //SAĞ banka durumu

                    cardBank.Baslik = "BANKA BAKİYE";
                    cardBank.Tip = "0";
                    cardBank.BorckBakiye = BankaGenelDurumBorcAlacak.Sum(c=>c.BORCBAKIYE);
                    cardBank.AlacakBakiye = BankaGenelDurumBorcAlacak.Sum(c=>c.ALACAKBAKIYE);
                    cardBank.Bakiye = cardBank.BorckBakiye - cardBank.AlacakBakiye;


                    cardGenelDurum.Baslik = "GENEL DURUM";
                    cardGenelDurum.Tip = "0";
                    cardGenelDurum.Bakiyegizle = true;
                    cardGenelDurum.BorckBakiye= cardCari.Bakiye + cardKasa.Bakiye + cardStok.Bakiye + cardBank.Bakiye;
                    cardGenelDurum.AlacakBakiye = cardOdemeler.Bakiye + cardCeksenet.Bakiye;
                    cardGenelDurum.Bakiye =  cardGenelDurum.BorckBakiye - cardGenelDurum.AlacakBakiye;







                    int i = 0;
                    foreach (var CA in CariOZBorcAlacakGenelDokumu)
                    {
                        CardComp aa = new CardComp();
                        aa.Name = "CA" + i;
                        aa.Baslik = " CARİ DURUM ";
                        aa.Tip = CA.SIRA == null ? "0" : CA.SIRA.ToString();
                        aa.BorckBakiye = CA.SIRA == null ? CA.SBORC : CA.SDBORC;
                        aa.AlacakBakiye = CA.SIRA == null ? CA.SALACAK : CA.SDALACAK;
                        aa.Bakiye = CA.SIRA == null ? CA.SBORC - CA.SALACAK : CA.SDBORC - CA.SDALACAK;
                        aa.tipler = CardComp.Tipler.CARI;
                        flowCari.Controls.Add(aa);
                        i++;
                    }

                    //CardComp aaa = new CardComp();
                    //aaa.Name = "CA" + i;
                    //aaa.Baslik = " GENEL DURUM ";
                    //aaa.Tip = "0";
                    //aaa.BorckBakiye = TLborc;
                    //aaa.AlacakBakiye = TLalacak;
                    //aaa.Bakiye = TLborc-TLalacak  ;
                    //aaa.tipler = CardComp.Tipler.CARI;
                    //flowCari.Controls.Add(aaa);
                    //i++;

                    /// cari borç alacak Sol Taraf
                    /// 





                    i = 0;
                    foreach (var CO in GenelCokodemesiOz)
                    {
                        CardComp aa = new CardComp();
                        aa.Name = "CO" + i;
                        aa.Baslik = " CEK ÖDEMESİ ";
                        aa.Tip = CO.DOVTIP.ToString();
                        aa.Bakiyegizle = false;
                        aa.Bakiye = CO.DOVTIP == Convert.ToByte("0") ? CO.TUTAR : CO.DOVTUT;
                        aa.tipler = CardComp.Tipler.CEKSENET;
                        flowCeksenet.Controls.Add(aa);
                        i++;
                    }


                    //CardComp CekODemesi = new CardComp();
                    //CekODemesi.Name = "CO" + i;
                    //CekODemesi.Baslik = "TOPLAM CEK ÖDEMESİ ";
                    //CekODemesi.Tip = "0";
                    //CekODemesi.Bakiyegizle = false;
                    //CekODemesi.Bakiye= GenelCokodemesiOz.Sum(c => c.TUTAR);
                    //CekODemesi.tipler = CardComp.Tipler.CEKSENET;
                    //flowCeksenet.Controls.Add(CekODemesi);
                    //i++;



                    i = 0;
                    foreach (var OP in OdemePlani.Where(c => c.OdemeTuru.Contains("DBS")))
                    {
                        CardComp aa = new CardComp();
                        aa.Name = "OP" + i;
                        aa.Baslik = OP.OdemeTuru + " ÖDEMESİ";
                        aa.Tip = OP.KURISIM.ToString();
                        aa.Bakiyegizle = false;
                        aa.Bakiye = OP.TUTAR;
                        aa.tipler = CardComp.Tipler.KASA;
                        flowDBS.Controls.Add(aa);
                        i++;
                    }
                    i = 0;
                    foreach (var OP in OdemePlani.Where(c => !c.OdemeTuru.Contains("DBS") && !c.OdemeTuru.Contains("CEK")))
                    {
                        CardComp aa = new CardComp();
                        aa.Name = "OP" + i;
                        aa.Baslik = OP.OdemeTuru + " ÖDEMESİ";
                        aa.Tip = OP.KURISIM.ToString();
                        aa.Bakiyegizle = false;
                        aa.Bakiye = OP.TUTAR;
                        aa.tipler = CardComp.Tipler.KASA;
                        flowDiger.Controls.Add(aa);
                        i++;
                    }
                    i = 0;
                    foreach (var ST in StokGenelDurumBorcAlacak)
                    {
                        CardComp aa = new CardComp();
                        aa.Name = "ST" + i;
                        aa.Baslik = "Alış Fiyatı 1";
                        aa.Tip = "0";
                        aa.BorckBakiye = ST.GENEL_ALIS;
                        aa.AlacakBakiye = ST.GENEL_ALIS;
                        aa.Bakiye = ST.GENEL_ALIS;
                        aa.tipler = CardComp.Tipler.STOK;
                        aa.Bakiyegizle = false;
                        flowStokEnvarteri.Controls.Add(aa);
                        i++;
                    }
                    i = 0;
                    foreach (var BA in BankaGenelDurumBorcAlacak.Where(c => c.BAKIYE > 0))
                    {
                        CardComp aa = new CardComp();
                        aa.Name = "bnk" + i;
                        aa.Baslik = BA.HESAPTIPLERI;
                        aa.Tip = BA.DOVIZTIPI.ToString();
                        aa.BorckBakiye = BA.DOVIZTIPI == 0 ? BA.BORCBAKIYE : BA.BORCBAKIYEDOVIZ;
                        aa.AlacakBakiye = BA.DOVIZTIPI == 0 ? BA.ALACAKBAKIYE : BA.ALACAKBAKIYEDOVIZ;
                        aa.Bakiye = BA.BAKIYE;
                        aa.Bakiyegizle = false;
                        flowBanka.Controls.Add(aa);
                        i++;
                    }









                }

            });


            //ExchangeTool doviz = new ExchangeTool();

            //foreach (var item in doviz.DovizKuruCek())
            //{
            //    MessageBox.Show($"smbol {item.CurrencyCode}");
            //}
        }
    }
}
