using BSDPROJE.Entities.BaseUI;
using BSDPROJE.Entities.Data_Access.RAPORLAR;
using BSDPROJE.Entities.Tables.RAPORLAR;
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

namespace BSDPROJE.BackOffice.Raporlar
{
    public partial class Frm_RaporANA_Ekle : BaseWinForms
    {
        public Frm_RaporANA_Ekle()
        {
            InitializeComponent();
            Listele();
        }

        private BSD_TBL_RAPORLAR_ANA RaporAna;
        RaporlaranaDAL raporAnaDAL = new RaporlaranaDAL();
        int Secilenid = -1;
        private void textEdit3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            if (choofdlog.ShowDialog() == DialogResult.OK)

            {
                ResimyoluTXT.Text = choofdlog.FileName;  
            }
        }

        private void crudiSlemler1_KaydetClick(object sender, EventArgs e)
        {
            RaporAna = new BSD_TBL_RAPORLAR_ANA();
            if (Secilenid > -1)
                RaporAna.id = Secilenid;

            RaporAna.Aciklama = MenuAciklamaTXT.Text;
            RaporAna.KategoriAdi = MunuadiTXT.Text.Trim().ToUpper().Replace("İ","I").Replace("Ö","O").Replace("Ü","U").Replace("Ş","S")
                .Replace("Ç","C");
            RaporAna.Image = ResimyoluTXT.Text;
       using (var context = new NetSatisContext())
            {
                if (raporAnaDAL.AddOrUpdate(context,RaporAna))
                {
                    context.SaveChanges();
                }
                Listele();
            }
        }


        public void Listele()
        {       using (var context = new NetSatisContext())
            {
                gridControl1.DataSource = context.BSD_TBL_RAPORLAR_ANA.ToList();
            }
            Temizle();
        }
        public  void Temizle()
        {
            MenuAciklamaTXT.Text = "";
            MunuadiTXT.Text = "";
            ResimyoluTXT.Text = "";
            Secilenid = -1;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Secilenid = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
            using (var context = new NetSatisContext())
            {
                var gelenMenu = context.BSD_TBL_RAPORLAR_ANA.Where(c => c.id == Secilenid).FirstOrDefault();
                MenuAciklamaTXT.Text = gelenMenu.Aciklama;
                MunuadiTXT.Text = gelenMenu.KategoriAdi;
                ResimyoluTXT.Text = gelenMenu.Image;
            }

        }

        private void crudiSlemler1_SecClick(object sender, EventArgs e)
        {
            RaporAna = new BSD_TBL_RAPORLAR_ANA();
            Listele();

        }

        private void crudiSlemler1_SilClick(object sender, EventArgs e)
        {
            using (var context = new NetSatisContext())
            {
                if (MessageBox.Show("Seçili Kayıdı  Silmek istermisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes && Secilenid>-1)
                {
                    raporAnaDAL.Delete(context, c => c.id == Secilenid);
                    raporAnaDAL.Save(context);
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
