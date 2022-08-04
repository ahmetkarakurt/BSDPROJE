using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSDPROJE.BackOffice.Ana_Menü
{
    public partial class FrmAnaEkran : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string xmlFile = Application.StartupPath + @"\FromDizayn\Anaekran.xml";
        public FrmAnaEkran()
        {
            InitializeComponent();

           

            try
            {
                dockManager1.RestoreLayoutFromXml(xmlFile);
            }
            catch (Exception)
            {

            }


            foreach (DockPanel pane in dockManager1.Panels.ToArray())
            {
                // MessageBox.Show(pane.Name);
                pane.Show();
                //  pane.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            }
        }

        private void FrmAnaEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            dockManager1.SaveLayoutToXml(xmlFile);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
        private void Item_ItemClick(object sender, ItemClickEventArgs e)
        {
            ((DockPanel)e.Item.Tag).Show();
            dockManager1.ActivePanel = ((DockPanel)e.Item.Tag);
        }

        private void barSubItem1_GetItemData(object sender, EventArgs e)
        {
            for (int i = barSubItem1.ItemLinks.Count - 1; i >= 0; i--)
            {
                BarItemLink link = barSubItem1.ItemLinks[i];
                link.Item.ItemClick -= Item_ItemClick;
               // dockManager1.Controller .Remove(link.Item);
            }
            barSubItem1.ItemLinks.Clear();

            var hiddenPanels = dockManager1.HiddenPanels;

            if (hiddenPanels.Count > 0)
            {
                foreach (DockPanel panel in hiddenPanels)
                {
                    BarButtonItem button = new BarButtonItem();
                    button.Caption = panel.Text;
                    button.Tag = panel;
                    button.ItemClick += Item_ItemClick;
                  //  barManager1.Items.Add(button);
                    barSubItem1.ItemLinks.Add(button);
                }
            }
            else
            {
                BarStaticItem staticItem = new BarStaticItem();
                staticItem.Caption = "No hidden Panels";
              //  barManager1.Items.Add(staticItem);
                barSubItem1.ItemLinks.Add(staticItem);
            }
        }
    }
}
