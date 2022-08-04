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
    public partial class FrmOzllklrAltTeknikOzel   : BaseXtraForms
    {
        public FrmOzllklrAltTeknikOzel()
        {
            InitializeComponent();
            Getir();
        }
        OzelliklerDAL _ozelliklerDAL = new OzelliklerDAL();
        AltTeknikOzellikleriDAL _altTeknikOzellikleriDAL = new AltTeknikOzellikleriDAL();
        BSD_TBL_ALTTEKNIKOZELLIKLER _TBL_ALTTEKNIKOZELLIKLER;
        int SecimId = -1;

        private void Getir()
        {
            Temizle();
            using (var context = new NetSatisContext())
            {
                gridControl1.DataSource = _altTeknikOzellikleriDAL.GetAll(context).Select(c => new { c.Id, c.Ozellik.TeknikOzellikAdi, c.AltOzellikAdi, c.AltOzellikAciklamasi });
                _ozelliklerDAL.GetAll(context).ForEach(c => ustgrubcb.Properties.Items.Add(c.TeknikOzellikAdi));
            }
              
         
        }

        private void Temizle()
        {
            ustgrubcb.Properties.Items.Clear();
            altozellikaciklamasitxt.Text = "";
            altozelliktxt.Text = "";
            SecimId = -1;
        }

        private void crudiSlemler1_KaydetClick(object sender, EventArgs e)
        {

            using (var context = new NetSatisContext())
            {
                _TBL_ALTTEKNIKOZELLIKLER = new BSD_TBL_ALTTEKNIKOZELLIKLER();
                _TBL_ALTTEKNIKOZELLIKLER.Id = SecimId;
                _TBL_ALTTEKNIKOZELLIKLER.AltOzellikAdi = altozelliktxt.Text;
                _TBL_ALTTEKNIKOZELLIKLER.AltOzellikAciklamasi = altozellikaciklamasitxt.Text;
                _TBL_ALTTEKNIKOZELLIKLER.OzellikId = _ozelliklerDAL.GetByFilter(context, c => c.TeknikOzellikAdi == ustgrubcb.Text).Id;
                if (_altTeknikOzellikleriDAL.AddOrUpdate(context,_TBL_ALTTEKNIKOZELLIKLER))
                {
                    _altTeknikOzellikleriDAL.Save(context);
                }
                   

            }
            Temizle();
            Getir();
              

        }

        void Secimgetir(int id)
        {
            using (var context = new NetSatisContext())
            {
                var sec = _altTeknikOzellikleriDAL.GetByFilter(context, c => c.Id == id);
                ustgrubcb.Text = sec.Ozellik.TeknikOzellikAdi;
                altozellikaciklamasitxt.Text = sec.AltOzellikAciklamasi;
                altozelliktxt.Text = sec.AltOzellikAdi;
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

        private void crudiSlemler1_SecClick(object sender, EventArgs e)
        {
            Temizle();
        }

        private void crudiSlemler1_SilClick(object sender, EventArgs e)
        {
            using (var context = new NetSatisContext())
            {
                _altTeknikOzellikleriDAL.Delete(context, c => c.Id == SecimId);
                _altTeknikOzellikleriDAL.Save(context);
            }
            Temizle();
            Getir();

        }
       
    }
}
