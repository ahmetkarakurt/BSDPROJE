using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tools;
using BSDPROJE.Entities.Extensions;
using BSDPROJE.Entities.BaseUI;

namespace NetSatis.BackOffice.Ayarlar
{
    public partial class FrmAyarlar : BaseXtraForms
    {
        NetSatisContext context = new NetSatisContext();
      
        public FrmAyarlar()
        {
            InitializeComponent();
            //cmbFaturaYazici.Properties.Items.AddRange(YaziciListesi());
            //cmbBilgiFisiYazici.Properties.Items.AddRange(YaziciListesi());

            //lookUpKasa.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa);
            //cmbFaturaAyar.SelectedIndex =
            //    Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazdirmaAyari));
            //cmbFaturaYazici.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazici);
            //cmbBilgiFisiAyar.SelectedIndex =
            //    Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazdirmaAyari));
            //cmbBilgiFisiYazici.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazici);
            //toggleGuncelle.IsOn = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.GenelAyalar_GuncellemeKontrol));
            //txtFirmaAdi.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_FirmaAdi);
            cbSirket.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.OzelRapor_KasaSirketi);
            comboBoxEdit1.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.OzelRapor_AcilisSayfasi);
            cbTema.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.OzelRapor_KullaniciTema);


            ExtensionMethod.HandleException(() => {

              var  dbList = context.Database.SqlQuery<string>(
                   "select SIRKET from NETSIS..SIRKETLER30").ToList();
                //  "Select name From master.dbo.sysdatabases Where name like 'NetSatis%'").ToList();
                foreach (var item in dbList)
                {
                    cbSirket.Properties.Items.Add(item);
                }


            });


            var acilisSayfasi=context.BSD_TBL_KullaniciRolleri.Where(c => c.KullaniciAdi == RoleTool.KullaniciEntity.KullaniciAdi && c.Yetki == true).ToList();
         
            if (!RoleTool.KullaniciEntity.SadeceRapor)
            {
                comboBoxEdit1.Properties.Items.Add("FrmOzRapor");
                comboBoxEdit1.Properties.Items.Add("FrmAraRaporlar");
            }

             acilisSayfasi.ToList().ForEach(c => comboBoxEdit1.Properties.Items.Add(c.FormAdi.Trim() + c.RootId));

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_FisKodu, calcEdit1.Value.ToString());
            //SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazici, cmbFaturaYazici.Text);
            //SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazici, cmbBilgiFisiYazici.Text);
            //SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazdirmaAyari, cmbFaturaAyar.SelectedIndex.ToString());
            //SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazdirmaAyari, cmbBilgiFisiAyar.SelectedIndex.ToString());
            //SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo, lookupDepo.EditValue.ToString());
            //SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa, lookUpKasa.EditValue.ToString());
            //SettingsTool.AyarDegistir(SettingsTool.Ayarlar.GenelAyalar_GuncellemeKontrol, toggleGuncelle.IsOn.ToString());
            //SettingsTool.AyarDegistir(SettingsTool.Ayarlar.FirmaAyarlari_FirmaAdi, txtFirmaAdi.Text);
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.OzelRapor_KasaSirketi, cbSirket.Text);
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.OzelRapor_AcilisSayfasi, comboBoxEdit1.Text);
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.OzelRapor_KullaniciTema, cbTema.Text);


            SettingsTool.Save();
            this.Close();
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            DevExpress.Skins.SkinContainerCollection skins = DevExpress.Skins.SkinManager.Default.Skins;
            for (int i = 0; i < skins.Count; i++)
            {
                cbTema.Properties.Items.Add(skins[i].SkinName);//, Environment.NewLine);
            }

        }

        private List<string> YaziciListesi()
        {
            return new LocalPrintServer().GetPrintQueues().Select(c => c.Name).ToList();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}