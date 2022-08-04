using BSDPROJE.Entities.BaseUI;
using BSDPROJE.Entities.Data_Access.IsTakip.Ozellikler;
using BSDPROJE.Entities.Tables.isTakip.Ozellikler;
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
    public partial class FrmOzllklrOzellikler : BaseXtraForms
    {
        OzelliklerDAL _ozellikDAL = new OzelliklerDAL();
        BSD_TBL_OZELLIKLER _TBL_OZELLIKLER;
        int SecimId = -1;

        public FrmOzllklrOzellikler()
        {
            InitializeComponent();
            Getir();
        }
        void Getir()
        {
            using (var context = new NetSatisContext())
            {

                gridControl1.DataSource = _ozellikDAL.GetAll(context).Select(c => new { c.Id, c.TeknikOzellikAdi, c.TeknikOzellikAciklama });
            }
     

        }

        private void Temizleme()
        {
            Aciklamatxt.Text = "";
            Ozelliktxt.Text = "";
            SecimId = -1;
        }

        private void crudiSlemler1_KaydetClick(object sender, EventArgs e)
        {
            using (var context = new NetSatisContext())
            {
                _TBL_OZELLIKLER = new BSD_TBL_OZELLIKLER();
                _TBL_OZELLIKLER.TeknikOzellikAciklama = Aciklamatxt.Text;
                _TBL_OZELLIKLER.TeknikOzellikAdi = Ozelliktxt.Text;
                _TBL_OZELLIKLER.Id = SecimId;
                if (_ozellikDAL.AddOrUpdate(context,_TBL_OZELLIKLER))
                {
                    _ozellikDAL.Save(context);
                }
            }
            Getir();
            Temizleme();

        }

        private void crudiSlemler1_SecClick(object sender, EventArgs e)
        {
            Temizleme();
        }

        void Secimgetir(int id)
        {
            using (var context = new NetSatisContext())
            {
                var sec = _ozellikDAL.GetByFilter(context, c => c.Id == id);
                //   Birim = new BSD_TBL_BIRIM();
                //   Birim = sec;

                Aciklamatxt.Text = sec.TeknikOzellikAciklama;
                Ozelliktxt.Text = sec.TeknikOzellikAdi;
                SecimId = sec.Id;
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
                _ozellikDAL.Delete(context, c => c.Id == SecimId);
                _ozellikDAL.Save(context);
            }
              
           
        }
    }
}
