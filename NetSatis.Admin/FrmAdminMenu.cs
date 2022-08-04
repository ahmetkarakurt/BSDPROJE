using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;
using NetSatis.Entities.Tools.LoadingTool;
using BSDPROJE.Entities.BaseUI;

namespace NetSatis.Admin
{

    public partial class FrmAdminMenu : BaseXtraForms
    {
        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
        public FrmAdminMenu()
        {
            InitializeComponent();
            FrmKullaniciGiris form=new FrmKullaniciGiris();       
            form.ShowDialog();
            if (!RoleTool.KullaniciEntity.Admin)
            {
                MessageBox.Show("Admin Yöneticisi ile Giriş Yapınız");
                this.Close();
            }
           


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            FrmKullanicilar form = new FrmKullanicilar();
            form.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FrmDevir form=new FrmDevir();
            form.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmDonemSec form=new FrmDonemSec();
            LoadingTool animasyon=new LoadingTool();
            form.ShowDialog();
            if (!String.IsNullOrEmpty(form.donem))
            {
                connectionStringBuilder.ConnectionString =
                    SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi);
                connectionStringBuilder.InitialCatalog = "NetSatis" + form.donem;
                NetSatisContext context=new NetSatisContext(connectionStringBuilder.ConnectionString);
                animasyon.AnimasyonBaslat();
                context.Database.CreateIfNotExists();
                if (!context.BSD_TBL_Kullanicilar.Any(c => c.KullaniciAdi == "Yönetici"))
                {
                    context.BSD_TBL_Kullanicilar.Add(new BSD_TBL_Kullanici
                    {
                        KullaniciAdi = "Yönetici",
                        Parola = "123456"
                    });
                    context.SaveChanges();
                }
                animasyon.AnimasyonBitir();}
        }
    }
}