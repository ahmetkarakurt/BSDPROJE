using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace NetSatis.Entities.Tools.LoadingTool
{
   public class LoadingTool
   {
       private SplashScreenManager manager;

       public LoadingTool()
       {
            using (var form = new Form()) {
                manager = new SplashScreenManager(form, typeof(FrmLoading), true, true);
            }
                // Form ali = new Form();
              
       }

       public void AnimasyonBaslat()
       {
           manager.ShowWaitForm();
       }

       public void AnimasyonBitir()
       {
           manager.CloseWaitForm();
       }
   }
}
