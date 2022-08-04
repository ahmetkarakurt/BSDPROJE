using BSDPROJE.Entities.Aspect.Attributes;
using BSDPROJE.Entities.BaseUI;
using BSDPROJE.Entities.Data_Access.IsTakip;
using BSDPROJE.Entities.Tables.isTakip;
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
    [TryAspect]
    public partial class FrmBirimAltGrup : BaseXtraForms
    {

        public FrmBirimAltGrup()
        {
            InitializeComponent();
            Getir();
        }

        BirimDAL _birimDAL = new BirimDAL();
        AltBirimDAL _altBilimDAL = new AltBirimDAL();
     
        BSD_TBL_ALTBIRIM altbirim;
        int Secilialt = -1;
           
        void Getir()
        {
            Temizle();
            using (var context = new NetSatisContext())
            {
                //ComboBoxEdit1.DataBindings = _birimDAL.GetAll(context);

                gridControl1.DataSource = _altBilimDAL.GetAll(context).Select(c => new
                {c.Birim.Birim,c.AltBirim,c.AltBirimAciklama,c.Id });
                _birimDAL.GetAll(context).ForEach(c => UstGrubcb.Properties.Items.Add(c.Birim ));
              

            }

          
        }
        void Temizle()
        {
            UstGrubcb.Properties.Items.Clear();
            altbirimAciklamatxt.Text = "";
            altBirimtxt.Text = "";

        }

        private void crudiSlemler1_KaydetClick(object sender, EventArgs e)
        {
            using (var context = new NetSatisContext())
            {
                altbirim = new BSD_TBL_ALTBIRIM();
                altbirim.Id = Secilialt;
                altbirim.AltBirim = altBirimtxt.Text;
                altbirim.AltBirimAciklama = altbirimAciklamatxt.Text;
                altbirim.BirimId = _birimDAL.GetByFilter(context, c => c.Birim == UstGrubcb.Text).Id;
                if (_altBilimDAL.AddOrUpdate(context,altbirim))
                {
                    _altBilimDAL.Save(context);
                }
            }

            Getir();
  


        }

        private void crudiSlemler1_SecClick(object sender, EventArgs e)
        {
            Temizle();
        }

        void Secimgetir(int id)
        {
            using (var context = new NetSatisContext())
            {
                var sec = _altBilimDAL.GetByFilter(context, c => c.Id == id);
                //   Birim = new BSD_TBL_BIRIM();
                //   Birim = sec;

                UstGrubcb.Text = sec.Birim.Birim;
                altbirimAciklamatxt.Text = sec.AltBirimAciklama;
                altBirimtxt.Text = sec.AltBirim;
                Secilialt = sec.Id;
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
                _altBilimDAL.Delete(context,c=>c.Id==Secilialt);
                _altBilimDAL.Save(context);
            }
           
            Getir();
           
        }

        private void crudiSlemler1_VazgecClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
