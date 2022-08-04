using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSDPROJE.Entities.BaseUI
{
    public class BaseRibbonForms: DevExpress.XtraBars.Ribbon.RibbonForm
    {

        protected override void OnShown(EventArgs e)
        {

            base.OnShown(e);
        }

        protected override void OnClosed(EventArgs e)
        {

            base.OnClosed(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            if (FormBorderStyle != FormBorderStyle.FixedSingle || FormBorderStyle != FormBorderStyle.FixedToolWindow)
            {
                Location = new Point(0, 0);
                Size = Screen.PrimaryScreen.WorkingArea.Size;
                Rectangle ClientCoz = new Rectangle();
                ClientCoz = Screen.GetBounds(ClientCoz);
                float OranW = ((float)ClientCoz.Width / (float)BaseWinDisplay.basewidth);
                float OranH = ((float)ClientCoz.Height / (float)BaseWinDisplay.baseheight);
                Scale(new SizeF(OranW, OranH));

            }
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            base.OnLoad(e);
        }
    }
}
