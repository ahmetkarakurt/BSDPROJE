using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class FrmRaporGoruntule : BSDPROJE.Entities.BaseUI.BaseXtraForms
    {
        public FrmRaporGoruntule(XtraReport rapor)
        {
            InitializeComponent();
            documentViewer1.DocumentSource = rapor;
        }

        private void FrmRaporGoruntule_Load(object sender, EventArgs e)
        {

        }
    }
}