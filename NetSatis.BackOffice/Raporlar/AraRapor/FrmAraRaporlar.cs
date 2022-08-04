using BSD.RAPOR.Utiles.UI;
using BSDPROJE.Entities.BaseUI;
using BSDPROJE.Entities.Dto;
using BSDPROJE.Entities.Tools;
using NetSatis.Entities.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSDPROJE.BackOffice.Raporlar.AraRapor
{
    public partial class FrmAraRaporlar : BaseWinForms
    {
        public FrmAraRaporlar()
        {
            InitializeComponent();

            using (var context = new NetSatisContext())
            {

            
              
                var BankaGenelDurumBorcAlacak = context.Database
                    .SqlQuery<BANKA_GENE_BORCALACAK>(FixedSQLCode.BankaGenelDurumBorcAlacak).ToList();

                var KasaGenelDurum = context.Database
                    .SqlQuery<KASA_GENEL_BORCALACAK>(FixedSQLCode.KasaGenelDurum).ToList();

                var CariGenelBorcAlacak = context.Database
                    .SqlQuery<CARI_GENEL_BORCALACAK>(FixedSQLCode.CariGenelBorcAlacak).ToList();
                var StokGenelDurumBorcAlacak = context.Database
                    .SqlQuery<STOK_GENEL_DEPO>(FixedSQLCode.StokGenelDurumBorcAlacak).ToList();

                var CeksenetGenel = context.Database
                    .SqlQuery<CEKSENET_GENEL>(FixedSQLCode.CeksenetGenel).ToList();

                var vadesiGelenCek = context.Database
                    .SqlQuery<VADESIGELEN_CEK_SENET>(FixedSQLCode.vadesiGelenCek).ToList();

                var vadesiGelensenet = context.Database
                    .SqlQuery<VADESIGELEN_CEK_SENET>(FixedSQLCode.vadesiGelensenet).ToList();
                
                var MusteriCekleriPortfoy = context.Database
                    .SqlQuery<VADESIGELEN_CEK_SENET>(FixedSQLCode.MusteriCekleriPortfoy).ToList();

                var MusteriCekleriTahsil = context.Database
                    .SqlQuery<VADESIGELEN_CEK_SENET>(FixedSQLCode.MusteriCekleriTahsil).ToList();

                var MusteriSenetleriPortfoy = context.Database
            .SqlQuery<VADESIGELEN_CEK_SENET>(FixedSQLCode.MusteriSenetleriPortfoy).ToList();


                var MusteriSenetleriTahsil = context.Database
            .SqlQuery<VADESIGELEN_CEK_SENET>(FixedSQLCode.MusteriSenetleriTahsil).ToList();


                int i = 0;
                foreach (var BA in BankaGenelDurumBorcAlacak.Where(c=>c.BAKIYE>0))
                {
                    CardComp aa = new CardComp();
                    aa.Name = "bnk" + i;
                    aa.Baslik = BA.HESAPTIPLERI ;
                    aa.Tip = BA.DOVIZTIPI.ToString();
                    aa.BorckBakiye = BA.DOVIZTIPI==0? BA.BORCBAKIYE:BA.BORCBAKIYEDOVIZ;
                    aa.AlacakBakiye =  BA.DOVIZTIPI == 0 ? BA.ALACAKBAKIYE : BA.ALACAKBAKIYEDOVIZ;
                    aa.Bakiye = BA.BAKIYE;
                    flowLayoutPanel1.Controls.Add(aa);
                    i++;
                }
                #region MyRegion
                //i = 0;
                //foreach (var BA in BankaGenelDurumBorcAlacak.Where(c => c.BAKIYE > 0 && c.DOVIZTIPI == 1))
                //{
                //    CardComp aa = new CardComp();
                //    aa.Name = "bnk" + i;
                //    aa.Baslik = BA.HESAPTIPLERI;
                //    aa.Tip = BA.DOVIZTIPI.ToString();
                //    aa.BorckBakiye = BA.BORCBAKIYEDOVIZ;
                //    aa.AlacakBakiye = BA.ALACAKBAKIYEDOVIZ;
                //    aa.Bakiye = BA.BAKIYE;
                //    flowLayoutPanel2.Controls.Add(aa);
                //    i++;
                //}
                //i = 0;
                //foreach (var BA in BankaGenelDurumBorcAlacak.Where(c => c.BAKIYE > 0 && c.DOVIZTIPI == 2))
                //{
                //    CardComp aa = new CardComp();
                //    aa.Name = "bnk" + i;
                //    aa.Baslik = BA.HESAPTIPLERI;
                //    aa.Tip = BA.DOVIZTIPI.ToString();
                //    aa.BorckBakiye = BA.BORCBAKIYEDOVIZ;
                //    aa.AlacakBakiye = BA.ALACAKBAKIYEDOVIZ;
                //    aa.Bakiye = BA.BAKIYE;
                //    //aa.tipler = CardComp.Tipler.KASA;
                //    flowLayoutPanel3.Controls.Add(aa);
                //    i++;
                //} 
                #endregion
                i = 0;
                foreach (var KA in KasaGenelDurum.Where(c => c.KALAN > 0 && c.DOVIZTIPI == 0))
                {
                    CardComp aa = new CardComp();
                    aa.Name = "KSA" + i;
                    aa.Baslik =KA.KSMAS_NAME;
                    aa.Tip = KA.DOVIZTIPI.ToString();
                    aa.BorckBakiye = KA.GIDER;
                    aa.AlacakBakiye = KA.GELIR;
                    aa.Bakiye =KA.KALAN;
                    aa.tipler = CardComp.Tipler.KASA;
                    flowLayoutPanel4.Controls.Add(aa);
                    i++;
                }
                foreach (var KA in KasaGenelDurum.Where(c => c.KALAN > 0 && c.DOVIZTIPI == 1))
                {
                    CardComp aa = new CardComp();
                    aa.Name = "KSA" + i;
                    aa.Baslik = KA.KSMAS_NAME;
                    aa.Tip = KA.DOVIZTIPI.ToString();
                    aa.BorckBakiye = KA.DOVIZCIKIS;
                    aa.AlacakBakiye = KA.DOVIZGIRIS;
                    aa.Bakiye = KA.DOVKALAN;
                    aa.tipler = CardComp.Tipler.KASA;
                    flowLayoutPanel4.Controls.Add(aa);
                    i++;
                }
                foreach (var KA in KasaGenelDurum.Where(c => c.KALAN > 0 && c.DOVIZTIPI == 2))
                {
                    CardComp aa = new CardComp();
                    aa.Name = "KSA" + i;
                    aa.Baslik = KA.KSMAS_NAME;
                    aa.Tip = KA.DOVIZTIPI.ToString();
                    aa.BorckBakiye = KA.DOVIZCIKIS;
                    aa.AlacakBakiye = KA.DOVIZGIRIS;
                    aa.Bakiye = KA.DOVKALAN;
                    aa.tipler = CardComp.Tipler.KASA;
                    flowLayoutPanel4.Controls.Add(aa);
                    i++;
                }
                i = 0;
                foreach (var CA in CariGenelBorcAlacak.Where(c => c.SIRA == null))
                {
                    CardComp aa = new CardComp();
                    aa.Name = "CA" + i;
                    aa.Baslik = CA.CARI_TIP+ " BORC/ALACAK" ;
                    aa.Tip = "0";
                    aa.BorckBakiye = CA.SBORC;
                    aa.AlacakBakiye = CA.SALACAK;
                    aa.Bakiye = CA.SALACAK - CA.SBORC;
                    aa.tipler = CardComp.Tipler.CARI;
                    flowLayoutPanel5.Controls.Add(aa);
                    i++;
                }
                foreach (var CA in CariGenelBorcAlacak.Where(c => c.SIRA == 1))
                {
                    CardComp aa = new CardComp();
                    aa.Name = "CA" + i;
                    aa.Baslik = CA.CARI_TIP + " BORC/ALACAK";
                    aa.Tip = "1";
                    aa.BorckBakiye = CA.SDBORC;
                    aa.AlacakBakiye = CA.SDALACAK;
                    aa.Bakiye = CA.SDALACAK- CA.SDBORC;
                    aa.tipler = CardComp.Tipler.CARI;
                    flowLayoutPanel5.Controls.Add(aa);
                    i++;
                }
                foreach (var CA in CariGenelBorcAlacak.Where(c => c.SIRA == 2))
                {
                    CardComp aa = new CardComp();
                    aa.Name = "CA" + i;
                    aa.Baslik = CA.CARI_TIP + " BORC/ALACAK";
                    aa.Tip = "2";
                    aa.BorckBakiye = CA.SDBORC;
                    aa.AlacakBakiye = CA.SDALACAK;
                    aa.Bakiye = CA.SDALACAK- CA.SDBORC;
                    aa.tipler = CardComp.Tipler.CARI;
                    flowLayoutPanel5.Controls.Add(aa);
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
                    flowLayoutPanel6.Controls.Add(aa);
                    i++;
                }
                foreach (var ST in StokGenelDurumBorcAlacak)
                {
                    CardComp aa = new CardComp();
                    aa.Name = "ST" + i;
                    aa.Baslik = "Son Giriş Fiyatı";
                    aa.Tip = "0";
                    aa.BorckBakiye = ST.GENEL_SON_SATINAL;
                    aa.AlacakBakiye = ST.GENEL_SON_SATINAL;
                    aa.Bakiye = ST.GENEL_SON_SATINAL;
                    aa.tipler = CardComp.Tipler.STOK;
                    aa.Bakiyegizle = false;
                    flowLayoutPanel6.Controls.Add(aa);
                    i++;
                }
                i = 0;
                foreach (var CS in vadesiGelenCek)
                {
                    CardComp aa = new CardComp();
                    aa.Name = "CS" + i;
                    aa.Baslik = "Ödenencek Borç Çekleri";
                    aa.Tip =CS.DOVTIP.ToString();
                    //aa.BorckBakiye = ST.GENEL_ALIS;
                    //aa.AlacakBakiye = ST.GENEL_ALIS;
                    aa.Bakiye = CS.DOVTIP==0 ? CS.TUTAR:CS.DOVTUT ;
                    aa.tipler = CardComp.Tipler.CEKSENET;
                    aa.Bakiyegizle = false;
                    flowLayoutPanel7.Controls.Add(aa);
                    i++;
                }
                foreach (var CS in MusteriCekleriPortfoy)
                {
                    CardComp aa = new CardComp();
                    aa.Name = "CS" + i;
                    aa.Baslik = "Müşteri Çekleri Pörtföy";
                    aa.Tip = CS.DOVTIP.ToString();
                    //aa.BorckBakiye = ST.GENEL_ALIS;
                    //aa.AlacakBakiye = ST.GENEL_ALIS;
                    aa.Bakiye = CS.DOVTIP == 0 ? CS.TUTAR : CS.DOVTUT;
                    aa.tipler = CardComp.Tipler.CEKSENET;
                    aa.Bakiyegizle = false;
                    flowLayoutPanel7.Controls.Add(aa);
                    i++;
                }
                foreach (var CS in MusteriCekleriTahsil)
                {
                    CardComp aa = new CardComp();
                    aa.Name = "CS" + i;
                    aa.Baslik = "Müşteri Çekleri Tahsil";
                    aa.Tip = CS.DOVTIP.ToString();
                    //aa.BorckBakiye = ST.GENEL_ALIS;
                    //aa.AlacakBakiye = ST.GENEL_ALIS;
                    aa.Bakiye = CS.DOVTIP == 0 ? CS.TUTAR : CS.DOVTUT;
                    aa.tipler = CardComp.Tipler.CEKSENET;
                    aa.Bakiyegizle = false;
                    flowLayoutPanel7.Controls.Add(aa);
                    i++;
                }

                foreach (var CS in vadesiGelensenet)
                {
                    CardComp aa = new CardComp();
                    aa.Name = "CS" + i;
                    aa.Baslik = "Ödenecek Borç Çekleri";
                    aa.Tip = CS.DOVTIP.ToString();
                    //aa.BorckBakiye = ST.GENEL_ALIS;
                    //aa.AlacakBakiye = ST.GENEL_ALIS;
                    aa.Bakiye = CS.DOVTIP == 0 ? CS.TUTAR : CS.DOVTUT;
                    aa.tipler = CardComp.Tipler.CEKSENET;
                    aa.Bakiyegizle = false;
                    flowLayoutPanel7.Controls.Add(aa);
                    i++;
                }
                foreach (var CS in MusteriSenetleriPortfoy)
                {
                    CardComp aa = new CardComp();
                    aa.Name = "CS" + i;
                    aa.Baslik = "Müşteri Senetleri Pörtföy";
                    aa.Tip = CS.DOVTIP.ToString();
                    //aa.BorckBakiye = ST.GENEL_ALIS;
                    //aa.AlacakBakiye = ST.GENEL_ALIS;
                    aa.Bakiye = CS.DOVTIP == 0 ? CS.TUTAR : CS.DOVTUT;
                    aa.tipler = CardComp.Tipler.CEKSENET;
                    aa.Bakiyegizle = false;
                    flowLayoutPanel7.Controls.Add(aa);
                    i++;
                }
                foreach (var CS in MusteriSenetleriTahsil)
                {
                    CardComp aa = new CardComp();
                    aa.Name = "CS" + i;
                    aa.Baslik = "Müşteri Senetleri Tahsil";
                    aa.Tip = CS.DOVTIP.ToString();
                    //aa.BorckBakiye = ST.GENEL_ALIS;
                    //aa.AlacakBakiye = ST.GENEL_ALIS;
                    aa.Bakiye = CS.DOVTIP == 0 ? CS.TUTAR : CS.DOVTUT;
                    aa.tipler = CardComp.Tipler.CEKSENET;
                    aa.Bakiyegizle = false;
                    flowLayoutPanel7.Controls.Add(aa);
                    i++;
                }
            }


            //for (int i = 0; i < 5; i++)
            //{
            //    CardComp aa = new CardComp();
            //    aa.Name = "aaaa" + i;
            //    aa.Fiyat = 88;
            //    aa.Baslik = i.ToString();
            //   

            //}
        }
    }
}
