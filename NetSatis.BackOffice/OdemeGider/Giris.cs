
using BSD.RAPOR.UI.SecimEkranlari;
using BSDPROJE.Entities.BaseUI;
using BSDPROJE.Entities.Data_Access.ODEMEGIDER;
using BSDPROJE.Entities.Tables.ODEMEGIDER;
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
    public partial class Giris : BaseWinForms
    {
        public Giris()
        {
            InitializeComponent();
            dttarih.LostFocus += Dttarih_LostFocus; ;
        }

        private void Dttarih_LostFocus(object sender, EventArgs e)
        {
            Dolur();
        }

        BSD_TBL_ODEME Odeme = new BSD_TBL_ODEME();
         OdemeDAL odemeDAL = new OdemeDAL();
        decimal DovizTutari = 0;
        private void Giris_Load(object sender, EventArgs e)
        {

            Listele();
            Dolur();
        }
        private void Dolur()
        {
            using (var context = new NetSatisContext())
            {
                gridControl1.DataSource = context.BSD_TBL_ODEME.Where(c=>c.AyKodu == dttarih.DateTime.Month).ToList();
                gridControl1.DataBindings.Clear();
                  gridView1.ClearSelection();
                //  gridView1.SelectRow(-1);
                //  gridView1.FocusedRowHandle = -1;
                //  gridView1.UnselectRow(0);
                //   gridView1.MoveLastVisible();
                // gridView1.FocusedRowHandle = 900000000;
                //gridView1.GetSelectionModel().ClearSelection();

            }
        }

        void Listele()
        {
            using (var context = new NetSatisContext())
            {
                var odemeTuleri = context.BSD_TBL_ODEMETURU.AsNoTracking().Where(c=>c.OdemeTurAciklama!="").Select(c => c.OdemeTurAciklama);
                foreach (var item in odemeTuleri)
                {
                    cbtur.Properties.Items.Add(item);
                }

               
            }
        }

        private void txtbanka_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            frm_Banka_SecimEkrani frm = new frm_Banka_SecimEkrani();
            frm.ShowDialog();
            txtbanka.Text = frm.banka.NETHESKODU;
            Odeme.BankaAdi = frm.banka.ACIKLAMA;
        }

        private void txtcari_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_Cari_Secim_Ekrani frm = new frm_Cari_Secim_Ekrani();
            frm.ShowDialog();
            txtcari.Text = frm.Cari.CARI_KOD;
            Odeme.CariAdi = frm.Cari.CARI_ISIM;

        }

        private void txtcari_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcari.Text))
            {
                txtfatura.ReadOnly = false;
            }
            else
            {
                txtfatura.ReadOnly = true;
            }
        }

        private void txtfatura_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Frm_Fatura_SecimEkrani frm = new Frm_Fatura_SecimEkrani(txtcari.Text);
            frm.ShowDialog();
            txtfatura.Text = frm.Secim;
            txttutar.Value = frm.DovizTipi == "TL" ? frm.GenelToplam : frm.DovizTutar;
            txttip.Text = frm.DovizTipi.ToString();
            DovizTutari = frm.DovizTipi != "TL" ? frm.GenelToplam : frm.DovizTutar;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            

        }

        void Temizle()
        {
            Odeme = new BSD_TBL_ODEME();
            txttutar.Value = 0;
            txttip.Text = "";
            txtaciklama.Text = "";
            txtbanka.Text = "";
            txtcari.Text = "";
            txtfatura.Text = "";
            dttarih.DateTime = DateTime.Now;
            cbtur.Text = "";
            gridView1.SelectRow(-1);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
                Odeme = new BSD_TBL_ODEME();


                using (var context = new NetSatisContext())
                {
                    Odeme = context.BSD_TBL_ODEME.Where(c => c.id == id).FirstOrDefault();
                    txttutar.Value = Odeme.Tutar;
                    txttip.Text = Odeme.OdemeTipi.ToString();
                    txtaciklama.Text = Odeme.Aciklama;
                    txtbanka.Text = Odeme.BankaKod;
                    txtcari.Text = Odeme.CariKod;
                    txtfatura.Text = Odeme.BelgeNo;
                    dttarih.DateTime = Odeme.Tarih;
                    cbtur.Text = Odeme.OdemeTuru;


                }
            }
            catch (Exception)
            {

             
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridView1.ClearSelection();



        }

   

        private void crudiSlemler1_KaydetClick_1(object sender, EventArgs e)
        {
            Odeme.BelgeNo = txtfatura.Text;
            Odeme.OdemeTipi = txttip.Text == "" ? "TL" : txttip.Text;
            Odeme.OdemeTuru = cbtur.Text;
            Odeme.Tarih = dttarih.DateTime;
            Odeme.Tutar = txttutar.Value;
            Odeme.Aciklama = txtaciklama.Text;
            Odeme.BankaKod = txtbanka.Text;
            Odeme.CariKod = txtcari.Text;
            Odeme.DovizTutar = DovizTutari;
            Odeme.AyKodu = dttarih.DateTime.Month;

            using (var context = new NetSatisContext())
            {
                if (odemeDAL.AddOrUpdate(context, Odeme))
                {
                    odemeDAL.Save(context);
                    txttutar.Value = 0;
                    Odeme = new BSD_TBL_ODEME();
                }

            }
            Dolur();
            
            gridView1.ClearSelection();
        }



        private void crudiSlemler1_VazgecClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crudiSlemler1_SilClick(object sender, EventArgs e)
        {

            using (var context = new NetSatisContext())
            {
                if (MessageBox.Show("Seçili Kayıdı  Silmek istermisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes && Odeme.id!=null )
                {
                    odemeDAL.Delete(context, c => c.id == Odeme.id);
                    odemeDAL.Save(context);
                    Dolur();
                  
                   



                }

            }


            }

        private void crudiSlemler1_SecClick(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
