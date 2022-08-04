
using BSDPROJE.Entities.Aspect.Attributes;
using BSDPROJE.Entities.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSDPROJE.BackOffice.Raporlar
{
    public partial class RaporGoruntule : BaseWinForm
    {
        private string Yol;
        private string RaporAdi;

        [TryAspect]
        public RaporGoruntule(string _Yol,string _RaporAdı ="")
        {

            InitializeComponent();

        //    ExtensionMethod.HandleException(() => {

                Yol = _Yol;
                RaporAdi = _RaporAdı;

                dashboardViewer1.LoadDashboard(Application.StartupPath + Yol);
                this.Text = RaporAdi;
                //  dashboardViewer1.LoadDashboard(@"C:\Users\BSD-YAZILIM\source\repos\BSD.RAPOR\BSD.RAPOR.UI\dizaynRapor\Satis\eee.xml");



         //   });

        }
    }
}
