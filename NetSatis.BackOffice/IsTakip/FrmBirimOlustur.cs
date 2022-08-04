using BSDPROJE.Entities.BaseUI;
using BSDPROJE.Entities.Data_Access.IsTakip;
using BSDPROJE.Entities.Tables.isTakip;
using DevExpress.XtraEditors;
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

namespace BSDPROJE.BackOffice.IsTakip
{
    public partial class FrmBirimOlustur : BaseXtraForms
    {
        public FrmBirimOlustur()
        {
            InitializeComponent();
            Gridgetir();
        }

        BirimDAL dAL = new BirimDAL();
        BSD_TBL_BIRIM Birim;
        int Secimid = -1;
        public void Gridgetir()
        {
            using (var context = new NetSatisContext())
            {

                gridControl1.DataSource = dAL.GetAll(context).Select(c=> new { c.Id,c.Birim,c.BirimAciklama});
            }
            Temizleme();
        }

        private void crudiSlemler1_KaydetClick(object sender, EventArgs e)
        {
            Birim = new BSD_TBL_BIRIM();
            Birim.Id = Secimid;
            Birim.Birim = Birimtxt.Text;
            Birim.BirimAciklama = Aciklamatxt.Text;

            using (var context = new NetSatisContext())
            {
                if (dAL.AddOrUpdate(context,Birim))
                {
                    dAL.Save(context);
                }
            }
            Gridgetir();
          



        }

        void Temizleme()
        {
            Aciklamatxt.Text = "";
            Birimtxt.Text = "";
            Secimid = -1;

        
            
        }

        private void crudiSlemler1_SecClick(object sender, EventArgs e)
        {
            Gridgetir();
        }

        void Secimgetir(int id)
        {
            using (var context = new NetSatisContext())
            {
                var sec = dAL.GetByFilter(context, c => c.Id == id);
             //   Birim = new BSD_TBL_BIRIM();
             //   Birim = sec;

                Birimtxt.Text = sec.Birim;
                Aciklamatxt.Text = sec.BirimAciklama;
                Secimid = sec.Id;
            }
              


        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {



            if (gridView1.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridView1.GetSelectedRows())
                {
                  //  MessageBox.Show(gridView1.GetRowCellValue(row, gridId).ToString());
                     Secimgetir((int)gridView1.GetFocusedRowCellValue(gridId));

                }


            }
        }

        private void crudiSlemler1_SilClick(object sender, EventArgs e)
        {
            using (var context = new NetSatisContext())
            {
                MessageBox.Show(Secimid.ToString());
                dAL.Delete(context, c => c.Id == Secimid);
                dAL.Save(context);
                Gridgetir();
            }
              
            
        }

        private void crudiSlemler1_VazgecClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
