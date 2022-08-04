using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using BSD.RAPOR.UI;
using BSD.RAPOR.UI.BANKA;
using BSDPROJE.BackOffice.Ana_Menü;
using BSDPROJE.BackOffice.Ayarlar;
using BSDPROJE.BackOffice.Extensions.ExtensionsClass;
using BSDPROJE.BackOffice.Raporlar;
using BSDPROJE.BackOffice.Raporlar.AraRapor;
using BSDPROJE.Entities.Aspect.Attributes;
using BSDPROJE.Entities.BaseUI;
using BSDPROJE.Entities.Extensions;
using DevExpress.Images;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using NetSatis.Admin;
using NetSatis.BackOffice.Ajanda;

using NetSatis.BackOffice.Ayarlar;
using NetSatis.BackOffice.Döviz_Kurları;
using NetSatis.BackOffice.Raporlar;
using NetSatis.Backup;
using NetSatis.Entities;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;
using NetSatis.Entities.Tools.LoadingTool;

namespace NetSatis.BackOffice
{
 
    [TryAspect]
    public partial class FrmAnaMenu : BaseRibbonForms
    {

       
        public FrmAnaMenu()
        {
            InitializeComponent();

            FrmKullaniciGiris girisForm = new FrmKullaniciGiris();
            girisForm.ShowDialog();



            try
            {
                barKullaniciAdi.Caption = $"Giriş Yapan Kullanıcı : {RoleTool.KullaniciEntity.KullaniciAdi}";
                barStaticItem4.Caption = $"Şirket :  { RoleTool.Sirket}";
            }
            catch (Exception e)
            {
            }


            if (SettingsTool.AyarOku(SettingsTool.Ayarlar.YedeklemeAyarlari_OtomatikYedekleme) == "true" && Convert.ToDateTime(SettingsTool.AyarOku(SettingsTool.Ayarlar.YedeklemeAyarlari_SonYedekleme)).Date.AddDays(15) == DateTime.Now.Date)
            {
                NetSatisContext context = new NetSatisContext();
                string sqlCumle =
                    $"USE {RoleTool.Sirket};BACKUP DATABASE {RoleTool.Sirket} TO DISK='{SettingsTool.AyarOku(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu) + "\\NetSatisYedek.nsy"}'";
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCumle);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.YedeklemeAyarlari_SonYedekleme, DateTime.Now.Date.ToString());
            }

            if (RoleTool.KullaniciEntity.SadeceRapor)
            {
                RaporMenuleriGroup1.Visible = !RoleTool.KullaniciEntity.SadeceRapor;
                ribbonislem.Visible = !RoleTool.KullaniciEntity.SadeceRapor;
            }
            else
            {
                RaporMenuleriGroup1.Visible = RoleTool.KullaniciEntity.SadeceRapor;
                ribbonislem.Visible = RoleTool.KullaniciEntity.SadeceRapor;
            }
            if (RoleTool.KullaniciEntity.Admin)
            {
                RaporMenuleriGroup1.Visible = true;
                ribbonislem.Visible = true;
            }

            DatabaseChange.dbSetet();
            RaporAnaMenuOlustur();


            if (SettingsTool.AyarOku(SettingsTool.Ayarlar.OzelRapor_AcilisSayfasi)=="FrmOzRapor" ||
                SettingsTool.AyarOku(SettingsTool.Ayarlar.OzelRapor_AcilisSayfasi)== "FrmAraRaporlar")
            {
                Type t = Type.GetType("BSDPROJE.BackOffice.Raporlar.AraRapor." + SettingsTool.AyarOku(SettingsTool.Ayarlar.OzelRapor_AcilisSayfasi));
                Form c = Activator.CreateInstance(t) as Form;
                c.MdiParent = this;
                c.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //FrmAnaMenuBilgi form = new FrmAnaMenuBilgi();
            //form.MdiParent = this;
            //form.Show();
            //   RoleTool.RolleriYukle(ribbonControl1);
        }


        private void isTakipFormulariniAc(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Type t = Type.GetType("BSDPROJE.BackOffice.IsTakip." + e.Item.Hint.ToString());
            Form c = Activator.CreateInstance(t) as Form;
            c.MdiParent = this;
            c.Ac();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start($"{Application.StartupPath}\\NetSatis.FrontOffice.exe");
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Application.OpenForms.OfType<FrmRaporListesi>().Any())
            {
                FrmRaporListesi form = new FrmRaporListesi();
                form.MdiParent = this;
                form.Show();
            }

        }
        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Application.OpenForms.OfType<FrmRaporDuzenle>().Any())
            {
                FrmRaporDuzenle form = new FrmRaporDuzenle();
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }

        }
        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOzgunRaporHazirla form = new FrmOzgunRaporHazirla();
            form.ShowDialog();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Application.OpenForms.OfType<FrmAjanda>().Any())
            {
                FrmAjanda form = new FrmAjanda();
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }


        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDovizKurlari form = new FrmDovizKurlari();
            form.ShowDialog();
        }
 
        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAyarlar form = new FrmAyarlar(); form.ShowDialog();
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBackup form = new FrmBackup();
            form.ShowDialog();
        }
        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //todo uzaktan güncelleme yapılmadı
            //WebClient indir = new WebClient();
            //string programVersion = Assembly.Load("NetSatis.BackOffice").GetName().Version.ToString();
            //string guncelVersion = indir.DownloadString("http://www.tesyazilim.com/downloads/version.txt").Replace("\n", "");

            //if (programVersion != guncelVersion)
            //{
            //    Process.Start($"{Application.StartupPath}\\NetSatis.Update.exe");
            //}
            //else
            //{
            //    MessageBox.Show("Programınız güncel.");
            //}
            MessageBox.Show("Uzak Sunucu Güncelleme Ayarları Yapılmamıştır");

        }

        private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Odeme_Turu frm = new Frm_Odeme_Turu();
            frm.MdiParent = this;
            frm.Ac();

        }

        private void barButtonItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            if (!Application.OpenForms.OfType<Giris>().Any())
            {
                Giris form = new Giris();

                form.MdiParent = this;


                form.Ac();

             
            }
        
        }

        private void barButtonItem44_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            TopluGiris frm = new TopluGiris();
            frm.MdiParent = this;
            frm.Ac();
        }



      //  [Auth(Yetki = "Product.Add,Admin")]
        void RaporAnaMenuOlustur()
        {
            BarSubItem SubItem = new BarSubItem();
            BarButtonItem BarBTN = new BarButtonItem();
            using (var context = new NetSatisContext())
            {

                var Anamenu = context.BSD_TBL_RAPORLAR_ANA.ToList();

                foreach (var Ana in Anamenu)
                {
                    string yetki = Ana.KategoriAdi.Trim();
                    RibbonPageGroup grp = new RibbonPageGroup();
                    grp.Name = Ana.KategoriAdi.Trim();
                    grp.Text = Ana.Aciklama;
                    grp.AllowTextClipping = false;
                    ribbonPage5.Groups.Add(grp);
                    var AltMenu = context.BSD_TBL_RAPORLAR_VW.Where(c => c.Kategorid == Ana.id).ToList();
                    SubItem = new BarSubItem();
                    SubItem.Name = "bar" + Ana.KategoriAdi.Trim();
                    SubItem.Caption = Ana.KategoriAdi;
                    SubItem.Id = Ana.id;
                    SubItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;

                    try
                    {
                        SubItem.ImageOptions.LargeImage = Image.FromFile(Application.StartupPath + Ana.Image);
                    }
                    catch (Exception)
                    {

                    }

                    grp.ItemLinks.Add(SubItem);
                    var RoluVarmi = context.BSD_TBL_KullaniciRolleri.Where(c => c.KullaniciAdi == RoleTool.KullaniciEntity.KullaniciAdi && c.Yetki==true).ToList();

                    foreach (var Alt in AltMenu)
                    {

                        try
                        {

                            BarBTN = new BarButtonItem();
                            BarBTN.Name = Alt.VwAdi.Trim() + Alt.id;
                            BarBTN.Caption = Alt.VwAdi;
                            BarBTN.Tag = Alt.VwYolu;
                            BarBTN.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
                            BarBTN.ImageOptions.AllowStubGlyph = DevExpress.Utils.DefaultBoolean.False;
                            BarBTN.ImageOptions.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + Alt.Image.ToString());
                            BarBTN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(BarBTN_ItemClick);

                            foreach (var item in RoluVarmi)
                            {
                                if (Alt.id == item.RootId)
                                {
                                    SubItem.AddItem(BarBTN);
                                    /// Başlangıç Sayfası
                                    if (BarBTN.Name == SettingsTool.AyarOku(SettingsTool.Ayarlar.OzelRapor_AcilisSayfasi))
                                    {
                                        RaporGoruntule frm = new RaporGoruntule(BarBTN.Tag.ToString(), BarBTN.Caption);
                                        frm.MdiParent = this;
                                        frm.Ac();
                                    }
                                }
                               
                                
                            }

                            

                        }
                        catch (Exception EX)
                        {
                            MessageBox.Show(EX.ToString());

                        }


                    }
                    if (IsSubItemLinkEmpty((BarSubItemLink)SubItem.Links[0]))
                        grp.Visible = false;


                }
                //var PlasiyerCheck = flowPersonel.Controls.OfType<CheckButton>().FirstOrDefault(c => c.Name == "YokYok");

               
            }

           

            //this.barSubItem2.Caption = "barSubItem2";
            //this.barSubItem2.Id = 104;
            //this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            //new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem58),
            //new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem59),
            //new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem60)});
            //this.barSubItem2.Name = "barSubItem2";
        }
        private bool IsSubItemLinkEmpty(BarSubItemLink link)
        {
            foreach (BarItemLink itemLink in ((BarSubItem)link.Item).ItemLinks)
                if (itemLink.Visible)
                    return false;
            return true;
        }




        private void BarBTN_ItemClick(object sender, ItemClickEventArgs e)
        {
             BarSubItem subMenu = e.Item as BarSubItem;
             if (subMenu != null) return;

           //MessageBox.Show("Item '" + e.Item.Caption + "' has been clicked" +  " tag " + e.Item.Tag);
            RaporGoruntule frm = new RaporGoruntule(e.Item.Tag.ToString(), e.Item.Caption);
            frm.MdiParent = this;
            frm.Ac();
            // MessageBox.Show(deneme.Tag.ToString());
        }

  
        private void barButtonItem61_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_RaporANA_Ekle form = new Frm_RaporANA_Ekle();
            form.Ac();
        }

        private void barButtonItem62_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_RaporlarVW_ekle form = new Frm_RaporlarVW_ekle();
            form.Ac();
        }

        private void barButtonItem63_ItemClick(object sender, ItemClickEventArgs e)
        {
            dizayn frm = new dizayn();
            frm.ShowDialog();
        }

        private void barButtonItem64_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmOzRapor frm = new FrmOzRapor();
            //FrmAraRaporlar frm = new FrmAraRaporlar();
            frm.ShowDialog();
            
        }

        private void barButtonItem65_ItemClick(object sender, ItemClickEventArgs e)
        {
            Saklama frm = new Saklama();
            frm.MdiParent = this;
            frm.Ac();

        }
    }
   
}
