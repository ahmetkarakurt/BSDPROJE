using BSDPROJE.Entities.Aspect.Attributes;
using BSDPROJE.Entities.BaseUI;
using BSDPROJE.Entities.Data_Access.IsTakip;
using BSDPROJE.Entities.Tables.isTakip;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
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
    public partial class FrmBirimAtama : BaseXtraForms
    {
        [TryAspect]
        public FrmBirimAtama()
        {
            InitializeComponent();
            Gridgetir();
        }

        BirimDAL _birimDAL = new BirimDAL();
        AltBirimDAL _altBirimDAL = new AltBirimDAL();
        BirimAtamaDAL _birimAtamaDAL = new BirimAtamaDAL();
        KullaniciDAL _kullaniciDAL = new KullaniciDAL();

        int SeciliBirimAtama = -1;

        BSD_TBL_BIRIM Birim;
        BSD_TBL_BIRIMATAMA BirimAtama;
        public void Gridgetir()
        {
            using (var context = new NetSatisContext())
            {
                gridControl1.DataSource = _birimAtamaDAL.GetAll(context).Select(c => new { c.Id, c.Kullanici.KullaniciAdi, c.Birim.Birim, c.AltBirim.AltBirim });
                _birimDAL.GetAll(context).ForEach(c => birimcb.Properties.Items.Add(c.Birim));
                _altBirimDAL.GetAll(context).ForEach(c => altBirimcb.Properties.Items.Add(c.AltBirim));
                _kullaniciDAL.GetAll(context).ForEach(c => kullanicicb.Properties.Items.Add(c.KullaniciAdi));

            }
        }

        void Temizele()
        {
            birimcb.Properties.Items.Clear();
            altBirimcb.Properties.Items.Clear();
            kullanicicb.Properties.Items.Clear();
        }
        private void crudiSlemler1_KaydetClick(object sender, EventArgs e)
        {
            using (var context = new NetSatisContext())
            {
                BirimAtama = new BSD_TBL_BIRIMATAMA();
                BirimAtama.Id = SeciliBirimAtama;
                BirimAtama.BirimId = _birimDAL.GetByFilter(context, c => c.Birim == birimcb.Text).Id;
                BirimAtama.KullaniciId = _kullaniciDAL.GetByFilter(context, c => c.KullaniciAdi == kullanicicb.Text).Id;
                BirimAtama.AltBirimId = _altBirimDAL.GetByFilter(context, c => c.AltBirim == altBirimcb.Text).Id;
                if (_birimAtamaDAL.AddOrUpdate(context,BirimAtama))
                {
                    _birimAtamaDAL.Save(context);
                }
            }
            Gridgetir();
            Temizele();              

        }
        void Secimgetir(int id)
        {
            using (var context = new NetSatisContext())
            {
                var sec = _birimAtamaDAL.GetByFilter(context, c => c.Id == id);

                birimcb.Text = sec.Birim.Birim;
                altBirimcb.Text = sec.AltBirim.AltBirim;
                kullanicicb.Text = sec.Kullanici.KullaniciAdi;
                SeciliBirimAtama = sec.Id;
            }



        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridView1.GetSelectedRows())
                {
                    //  MessageBox.Show(gridView1.GetRowCellValue(row, gridId).ToString());
                    Secimgetir((int)gridView1.GetFocusedRowCellValue(gridid));

                }


            }
        }

        private void crudiSlemler1_SecClick(object sender, EventArgs e)
        {
            Temizele();
        }

        private void crudiSlemler1_SilClick(object sender, EventArgs e)
        {
            using (var context = new NetSatisContext())
            {
                _birimAtamaDAL.Delete(context, c => c.Id == SeciliBirimAtama);
                _birimAtamaDAL.Save(context);
            }
              
            
        }

        private void crudiSlemler1_VazgecClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
