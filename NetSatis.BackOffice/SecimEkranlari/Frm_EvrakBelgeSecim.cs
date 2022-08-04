
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
    public partial class Frm_EvrakBelgeSecim : Form
    {
        public Frm_EvrakBelgeSecim()
        {
            InitializeComponent();
        }

        public List<TAKSITHESEPLAMA> BankaODeme;
        public  string EvrakNumarasi ="";
        private void Frm_EvrakBelgeSecim_Load(object sender, EventArgs e)
        {
            using (var context = new NetSatisContext())
            {
                gridControl1.DataSource = context.Database.SqlQuery<BELGEEVRAK>(@"SELECT        REPLACE(BelgeNo, '$&', '') AS BelgeNo, OdemeTuru, BankaAdi, BankaKod, SUM(Tutar) AS Tutar, DovizTutar, OdemeTipi
                                                                                    FROM            dbo.BSD_TBL_ODEME
                                                                                    GROUP BY BelgeNo, OdemeTuru, BankaAdi, BankaKod, DovizTutar, OdemeTipi
                                                                                    HAVING        (BelgeNo LIKE N'$&%')").ToList();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
             var belgeNO = "$&"+gridView1.GetFocusedRowCellValue("BelgeNo").ToString();
             var OdemeTuru = gridView1.GetFocusedRowCellValue("OdemeTuru").ToString();
             var BankaKod = gridView1.GetFocusedRowCellValue("BankaKod").ToString();
            EvrakNumarasi = gridView1.GetFocusedRowCellValue("BelgeNo").ToString();
            using (var context = new NetSatisContext())
            {
                BankaODeme = new List<TAKSITHESEPLAMA>();
                BankaODeme = context.Database.SqlQuery<TAKSITHESEPLAMA>(@"sELECT     * from  dbo.BSD_TBL_ODEME
                                            where BelgeNo='"+ belgeNO + "' and OdemeTuru='"+ OdemeTuru + "' and BankaKod='"+ BankaKod + "' ").ToList();
              
                this.Close();
            }
        }
    }
}
