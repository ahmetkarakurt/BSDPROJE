using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using NetSatis.Entities.Tools;

namespace NetSatis.BackOffice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture =
                Thread.CurrentThread.CurrentUICulture =new System.Globalization.CultureInfo("tr-TR");
           Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle(SettingsTool.AyarOku(SettingsTool.Ayarlar.OzelRapor_KullaniciTema));
            
            Application.Run(new FrmAnaMenu());
        }
    }
}
