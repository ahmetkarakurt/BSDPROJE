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
    public partial class Frm_Fatura_SecimEkrani : Form
    {
        private string CariKOD = "";
        public string Secim = "";
        public decimal GenelToplam, DovizTutar = 0;
        public string DovizTipi = "";
        public Frm_Fatura_SecimEkrani(string _CariKOD)
        {
            InitializeComponent();
            CariKOD = _CariKOD;
        }

        private void Frm_Fatura_SecimEkrani_Load(object sender, EventArgs e)
        {
            using (var context = new NetSatisContext())
            {
                gridControl1.DataSource = context.Database.SqlQuery<FATURALAR>(@"select TARIH,FATIRS_NO,GENELTOPLAM,ODEMETARIHI,DOVIZTUT ,
                                                                                    CASE DOVIZTIP
                                                                                    WHEN 0 THEN 'TL'
                                                                                    WHEN 1 THEN 'USD'
	                                                                                WHEN 2 THEN 'EURO'
	                                                                                ELSE 'DIGER' END AS   DOVIZTIP
	                                                                                from TBLFATUIRS where FTIRSIP='2' and CARI_KODU='" + CariKOD+"'").ToList();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            Secim = gridView1.GetFocusedRowCellValue("FATIRS_NO").ToString();
            GenelToplam = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("GENELTOPLAM"));
            DovizTutar = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("DOVIZTUT"));
            DovizTipi = gridView1.GetFocusedRowCellValue("DOVIZTIP").ToString();

            if (!string.IsNullOrEmpty(Secim))
            {
                this.Close();
            }
        }
    }
}
