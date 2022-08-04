using BSDPROJE.Entities.Data_Access.RAPORLAR;
using BSDPROJE.Entities.Tables.RAPORLAR;
using NetSatis.Entities.Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSDPROJE.BackOffice.Raporlar
{
    public partial class Frm_RaporlarVW_ekle : Entities.BaseUI.BaseWinForms
    {
        public Frm_RaporlarVW_ekle()
        {
            InitializeComponent();
            Listele();
            Menudoldur();
        }
        private BSD_TBL_RAPORLAR_VW Raporvw;
        RapolarvwDAL raporDAL = new RapolarvwDAL();
        private int Secilenid = -1;

        private void Listele()
        {
            using (var context = new NetSatisContext())
            {
                gridControl1.DataSource = context.BSD_TBL_RAPORLAR_VW.SqlQuery(@"SELECT        dbo.BSD_TBL_RAPORLAR_VW.id, dbo.BSD_TBL_RAPORLAR_ANA.KategoriAdi AS Aciklama, dbo.BSD_TBL_RAPORLAR_VW.VwAdi, dbo.BSD_TBL_RAPORLAR_VW.VwYolu, dbo.BSD_TBL_RAPORLAR_VW.Image, 
                         dbo.BSD_TBL_RAPORLAR_VW.Kategorid, dbo.BSD_TBL_RAPORLAR_VW.Kod
FROM            dbo.BSD_TBL_RAPORLAR_ANA RIGHT OUTER JOIN
                         dbo.BSD_TBL_RAPORLAR_VW ON dbo.BSD_TBL_RAPORLAR_ANA.id = dbo.BSD_TBL_RAPORLAR_VW.Kategorid").ToList();
            }
            Temizle();
        }

        private void Menudoldur()
        {
       using (var context = new NetSatisContext())
            {
                var Menuler = context.BSD_TBL_RAPORLAR_ANA.ToList().Select(c => new { c.id, c.KategoriAdi });
                cbKategori.Items.Add((new DictionaryEntry(" ", -1)));
                foreach (var item in Menuler)
                {             
                    cbKategori.Items.Add((new DictionaryEntry(item.KategoriAdi, item.id)));
                }
                cbKategori.DisplayMember = "Key";
                cbKategori.ValueMember = "Value";
                cbKategori.DataSource = cbKategori.Items;
            }
        }

        private void crudiSlemler1_KaydetClick(object sender, EventArgs e)
        {
            Raporvw = new BSD_TBL_RAPORLAR_VW();
            if (Secilenid > -1)
                Raporvw.id = Secilenid;

            Raporvw.Kategorid = Convert.ToInt32(cbKategori.SelectedValue.ToString());
            Raporvw.VwAdi = TXTmenuAdi.Text;
            Raporvw.VwYolu = TXTDizaynYolu.Text;
            Raporvw.Image = TXTResim.Text;
         
            using (var context = new NetSatisContext())
            {
                if (raporDAL.AddOrUpdate(context,Raporvw))
                {
                    raporDAL.Save(context);
                }
            }

            Listele();



        }

        private void Temizle()
        {
            //cbKategori.SelectedIndex = 0;
            TXTDizaynYolu.Text = "";
            TXTmenuAdi.Text = "";
            TXTResim.Text = "";
            Secilenid = -1;
            Raporvw = new BSD_TBL_RAPORLAR_VW();
        }

        private void TXTDizaynYolu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Dizayn Dosyası (*.xml)|*.xml";
            choofdlog.FilterIndex = 1;
            if (choofdlog.ShowDialog() == DialogResult.OK)

            {
                TXTDizaynYolu.Text = choofdlog.FileName;
            }
        }
        private void TXTResim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Dizayn Dosyası (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            if (choofdlog.ShowDialog() == DialogResult.OK)

            {
                TXTResim.Text = choofdlog.FileName;
            }
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Secilenid = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
            using (var context = new NetSatisContext())
            {
                var gelenMenu = context.BSD_TBL_RAPORLAR_VW.Where(c => c.id == Secilenid).FirstOrDefault();
                TXTmenuAdi.Text = gelenMenu.VwAdi;
                TXTDizaynYolu.Text = gelenMenu.VwYolu;
                TXTResim.Text = gelenMenu.Image;
                cbKategori.SelectedValue = gelenMenu.Kategorid;
            }
        }

        private void crudiSlemler1_SecClick(object sender, EventArgs e)
        {
            Temizle();
        }

        private void crudiSlemler1_SilClick(object sender, EventArgs e)
        {
            using (var context = new NetSatisContext())
            {
                if (MessageBox.Show("Seçili Kayıdı  Silmek istermisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes && Secilenid > -1)
                {
                    raporDAL.Delete(context, c => c.id == Secilenid);
                    raporDAL.Save(context);
                    Listele();


                }

            }
        }

        private void crudiSlemler1_VazgecClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
