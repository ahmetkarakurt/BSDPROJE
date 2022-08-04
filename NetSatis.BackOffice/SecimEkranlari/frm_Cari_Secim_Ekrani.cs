
using BSDPROJE.Entities.Dto;
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

namespace BSD.RAPOR.UI.SecimEkranlari
{
    public partial class frm_Cari_Secim_Ekrani : Form
    {
        public frm_Cari_Secim_Ekrani()
        {
            InitializeComponent();
        }

        public CARILER Cari;
        private void frm_Cari_Secim_Ekrani_Load(object sender, EventArgs e)
        {
            Cari = new CARILER();
            using (var context = new NetSatisContext())
            {
                gridControl1.DataSource = context.Database.SqlQuery<CARILER>("select CARI_KOD,CARI_ISIM from TBLCASABIT where ACIK3='E'").ToList();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            Cari.CARI_KOD = gridView1.GetFocusedRowCellValue(grdCARI_KOD).ToString();
            Cari.CARI_ISIM = gridView1.GetFocusedRowCellValue(grdCARI_ISIM).ToString();
            if (Cari != null)
            {
                this.Close();
            }
        }
    }
}
