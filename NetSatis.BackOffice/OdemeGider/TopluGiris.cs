
using BSD.RAPOR.UI.SecimEkranlari;
using BSDPROJE.Entities.BaseUI;
using BSDPROJE.Entities.Data_Access.ODEMEGIDER;
using BSDPROJE.Entities.Dto;
using BSDPROJE.Entities.Tables.ODEMEGIDER;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
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

namespace BSD.RAPOR.UI.BANKA
{
    public partial class TopluGiris : BaseWinForms
    {
        public TopluGiris()
        {
            InitializeComponent();
            evrakBelgeTXT.LostFocus += EvrakBelgeTXT_LostFocus;
        }

        private void EvrakBelgeTXT_LostFocus(object sender, EventArgs e)
        {
            if (evrakBelgeTXT.Text.Length < 0)
            {
                evrakBelgeTXT.Focus();

            }
        }

        public List<TAKSITHESEPLAMA> odemeler;
        public TAKSITHESEPLAMA odeme;
        public string BankaAdi;
        public bool Evraktangeldi = false;
        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            string tag = e.Button.Properties.Caption;
            switch (tag)
            {
                case "OLUSTUR":
                    TaksitHesapla();
                    break;
                case "TEMIZLE":
                    Temizle();
                    break;
                case "Ad3":
                    /* Navigate to page C*/
                    break;
                case "Ad4":
                    /* Navigate to page D */
                    break;
                case "Ad5":
                    /* Navigate to page E */
                    break;
            }


        }

        public void TaksitHesapla()
        {
            var Mesaj = "";
            odemeler = new List<TAKSITHESEPLAMA>();
            var kactanbasla = Convert.ToInt32(BaslangicTakisitiTXT.Value);
            if (BankaEDIT.Text == "")
                Mesaj += "Banka Boş Geçilemez \n";
            if (evrakBelgeTXT.Text == "")
                Mesaj += "Belge No Boş Geçilemez \n";
            if (taksitCalc.Value <= 0)
                Mesaj += "Taksit 0 dan büyük olmalıdır \n";
            if (BaslangicTakisitiTXT.Value <= 0)
                Mesaj += "Baslangıc Taksiti 0 dan büyük olmalıdır \n";

            if (Mesaj.Length > 0)
            { MessageBox.Show(Mesaj);
                return;
            }

            for (int i = 1; i <= taksitCalc.Value; i++)
            {
                odeme = new TAKSITHESEPLAMA();
                odeme.id = kactanbasla;
                odeme.Tutar = TutarCALC.Value;
                odeme.Tarih = BaslangicTarihiDT.DateTime.AddMonths(i);
                odeme.BelgeNo = "$&" + evrakBelgeTXT.Text;
                odeme.Aciklama = odeme.id + " Taksiti Ödemesi " + AciklamaTXT.Text;
                odeme.BankaAdi = BankaAdi;
                odeme.BankaKod = BankaEDIT.Text;
                odeme.OdemeTuru = OdemeTuruCB.Text;
                odeme.OdemeTipi = DovizTipCB.Text;
                odemeler.Add(odeme);
                kactanbasla++;

            }
            Mesaj = "";
            gridControl1.DataSource = odemeler.ToList();



        }

        public void Temizle()
        {
            gridControl1.DataSource = null;
            gridControl1.RefreshDataSource();
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void taksitCalc_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TopluGiris_Load(object sender, EventArgs e)
        {

            BaslangicTarihiDT.DateTime = DateTime.Now;
            using (var context = new NetSatisContext())
            {
                var odemeTuleri = context.BSD_TBL_ODEMETURU.AsNoTracking().Select(c => c.OdemeTurAciklama);

                foreach (var item in odemeTuleri)
                {
                    OdemeTuruCB.Properties.Items.Add(item);
                }


            }
        }



        private void BankaEDIT_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_Banka_SecimEkrani frm = new frm_Banka_SecimEkrani();
            frm.ShowDialog();
            BankaEDIT.Text = frm.banka.NETHESKODU;
            BankaAdi = frm.banka.ACIKLAMA;
        }

        private void evrakBelgeTXT_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                Frm_EvrakBelgeSecim frm = new Frm_EvrakBelgeSecim();
                frm.ShowDialog();
                odemeler = frm.BankaODeme.ToList();
                gridControl1.DataSource = odemeler.ToList();
                Evraktangeldi = true;
                if (frm.EvrakNumarasi.Length > 0)
                {
                    evrakBelgeTXT.Text = frm.EvrakNumarasi;
                    evrakBelgeTXT.ReadOnly = false;
                }
                else
                {
                    evrakBelgeTXT.ReadOnly = true;
                }

            }
            catch (Exception)
            {


            }
        }


        private void crudiSlemler1_KaydetClick(object sender, EventArgs e)
        {
            using (var context = new NetSatisContext())
            {
                var odemeTuleri = context.BSD_TBL_ODEMETURU.AsNoTracking().Select(c => c.OdemeTurAciklama);

                OdemeDAL ode = new OdemeDAL();
                odemeler = (List<TAKSITHESEPLAMA>)gridControl1.DataSource;
                foreach (var item in odemeler)
                {
                    BSD_TBL_ODEME knt = new  BSD_TBL_ODEME();

                    if (Evraktangeldi)
                    {
                        knt.id = item.id;
                    }
                    knt.OdemeTipi = item.OdemeTipi;
                    knt.OdemeTuru = item.OdemeTuru;
                    knt.Tarih = item.Tarih;
                    knt.Tutar = item.Tutar;
                    knt.Aciklama = item.Aciklama;
                    knt.AyKodu = item.Tarih.Month;
                    knt.BankaAdi = item.BankaAdi;
                    knt.BankaKod = item.BankaKod;
                    knt.BelgeNo = item.BelgeNo;
                    if (item.OdemeTipi!="TL")
                    {
                        knt.DovizTutar = item.Tutar;
                    }

                    if (ode.AddOrUpdate(context, knt))
                    {
                        ode.Save(context);
                        
                    }

                }




            }

        }

        private void crudiSlemler1_SilClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıdı  Silmek istermisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var context = new NetSatisContext())
                {
                    var odemeTuleri = context.BSD_TBL_ODEMETURU.AsNoTracking().Select(c => c.OdemeTurAciklama);

                    OdemeDAL ode = new OdemeDAL();



                    if (Evraktangeldi)
                    {
                        foreach (var item in odemeler)
                        {
                            ode.Delete(context, c => c.id == item.id);
                        }
                        ode.Save(context);
                        evrakBelgeTXT.ReadOnly = true;

                    }




                }
            }

        }

        private void CheckAcikalam_CheckedChanged(object sender, EventArgs e)
        {

        
        }

        private void DovizTipCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
