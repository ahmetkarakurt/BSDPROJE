
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

namespace BSD.RAPOR.UI.BANKA
{
    public partial class frm_Banka_SecimEkrani : Form
    {
        public frm_Banka_SecimEkrani()
        {
            InitializeComponent();
        }

        public string SeliciBankaKodu ="";

        public BANKALAR banka;

        private void frm_Banka_SecimEkrani_Load(object sender, EventArgs e)
        {
            using (var context = new NetSatisContext())
            {
                gridControl1.DataSource = context.Database.SqlQuery<BANKALAR>("SELECT NETHESKODU,ACIKLAMA,NETBANKAKODU FROM TBLBNKHESSABIT").ToList();
            }
            banka = new BANKALAR();
           
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            banka.NETHESKODU = gridView1.GetFocusedRowCellValue("NETHESKODU").ToString();
            banka.ACIKLAMA = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
            if (banka!=null)
            {
                this.Close();
            }
        }
    }
}
