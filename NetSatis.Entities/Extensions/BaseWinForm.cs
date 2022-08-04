using BSDPROJE.Entities.Aspect.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSDPROJE.Entities.Extensions
{
  
    public class BaseWinForm : Form 
    {
        [TryAspect]
        protected override void OnShown(EventArgs e)
        {
            ExtensionMethod.HandleException(() => {

                base.OnShown(e);


            });

        }

        protected override void OnClosed(EventArgs e)
        {

            base.OnClosed(e);
        }

   
    }
}
