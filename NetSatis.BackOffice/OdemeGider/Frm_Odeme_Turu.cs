
using BSDPROJE.Entities.BaseUI;
using BSDPROJE.Entities.Data_Access.ODEMEGIDER;
using BSDPROJE.Entities.Tables.ODEMEGIDER;
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

namespace BSD.RAPOR.UI.BANKA
{
    public partial class Frm_Odeme_Turu : BaseXtraForms
    {
        public Frm_Odeme_Turu()
        {
            InitializeComponent();
       
        }

        private BSD_TBL_ODEMETURU SecilenODemeTuru;
        OdemeTuruDAL odemeDAL =  new OdemeTuruDAL();
        int SeciliODeme = -1;
        private void Frm_Odeme_Turu_Load(object sender, EventArgs e)
        {
            Listele();
            SecilenODemeTuru = new BSD_TBL_ODEMETURU();
            databinds();
        }

        void databinds()
        {
            databindsBosalt();
            textEdit1.DataBindings.Add("Text", SecilenODemeTuru, "OdemeTurAciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            textEdit2.DataBindings.Add("Text", SecilenODemeTuru, "OzelKod", false, DataSourceUpdateMode.OnPropertyChanged);
            label1.DataBindings.Add("Text", SecilenODemeTuru, "id", false, DataSourceUpdateMode.OnPropertyChanged);

        }
        void databindsBosalt()
        {
            textEdit1.DataBindings.Clear();
            textEdit2.DataBindings.Clear();
            label1.DataBindings.Clear();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (var context = new NetSatisContext())
            {
                odemeDAL.AddOrUpdate(context, SecilenODemeTuru);
                odemeDAL.Save(context);
               
            }
            Listele();
            Temizle();
            SecilenODemeTuru = new BSD_TBL_ODEMETURU();
            databinds();
        }

        void Temizle()
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            label1.Text = "";
        }
        void Listele()
        {
            using (var context = new NetSatisContext())
            {
                gridControl1.DataSource = context.BSD_TBL_ODEMETURU.ToList();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
          

            if (gridView1.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridView1.GetSelectedRows())
                {
                    using (var context = new NetSatisContext())
                    {
                        SeciliODeme = (int)gridView1.GetFocusedRowCellValue("id");
                        SecilenODemeTuru = context.BSD_TBL_ODEMETURU.FirstOrDefault(o => o.id == SeciliODeme);
                        databinds();


                    }
                }


            }

            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            using (var context = new NetSatisContext())
            {
             
                if (SeciliODeme != -1)
                {
                    odemeDAL.Delete(context, c => c.id == SeciliODeme);
                    odemeDAL.Save(context);
                    Listele();
                    Temizle();
                }
               
               
            }
        }
    }
    }

