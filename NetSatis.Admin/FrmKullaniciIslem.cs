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
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using DevExpress.XtraTreeList.Columns;
using BSDPROJE.Entities.Dto;
using BSDPROJE.Entities.Tools;
using BSDPROJE.Entities.BaseUI;

namespace NetSatis.Admin
{
    public partial class FrmKullaniciIslem : BaseXtraForms
    {
        NetSatisContext context = new NetSatisContext();
        KullaniciDAL kullaniciDal = new KullaniciDAL();
        KullaniciRolDAL kuldal = new KullaniciRolDAL();
        private BSD_TBL_Kullanici _entity;
        public bool saved = false;
        private string parola, cevap;
        public FrmKullaniciIslem(BSD_TBL_Kullanici entity)
        {
            InitializeComponent();
         //   treeList1.ExpandAll();
            if (entity != null)
            {
                parola = entity.Parola;
                cevap = entity.Cevap;
             //  entity.Cevap = null;
             //  entity.Parola = null;

            }
         
                _entity = entity;
            
          

            txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdi.DataBindings.Add("Text", _entity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSoyadi.DataBindings.Add("Text", _entity, "Soyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtGorevi.DataBindings.Add("Text", _entity, "Gorevi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtParola.DataBindings.Add("Text", _entity, "Parola", false, DataSourceUpdateMode.OnPropertyChanged);
            txtHatirlatma.DataBindings.Add("Text", _entity, "HatirlatmaSorusu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCevap.DataBindings.Add("Text", _entity, "Cevap", false, DataSourceUpdateMode.OnPropertyChanged);
            chcAdmin.DataBindings.Add("Checked",_entity, "Admin",false, DataSourceUpdateMode.OnPropertyChanged);
            chcRapor.DataBindings.Add("Checked",_entity, "SadeceRapor", false, DataSourceUpdateMode.OnPropertyChanged);
         


            // AyarYukle();


            MenuleriUlustur();
        }

        private void MenuleriUlustur()
        {
          List<FrmYetkileriDTO> TabloYetkileri = new List<FrmYetkileriDTO>();
          List<FrmYetkileriDTO> TabloYetkileri2 = new List<FrmYetkileriDTO>();
            #region MyRegion
            //var RoluVarmi = context.BSD_TBL_KullaniciRolleri.Where(c => c.KullaniciAdi == _entity.KullaniciAdi).ToList();
            //if (RoluVarmi.Count==0)
            //{

            //    TabloYetkileri = context.Database.SqlQuery<FrmYetkileriDTO>(FixedSQLCode.TabloYetkileriView).ToList();
            //}
            //else
            //{
            //    foreach (var r in RoluVarmi)
            //    {
            //        FrmYetkileriDTO yet = new FrmYetkileriDTO();
            //        yet.id = r.Id;
            //        yet.VwAdi = r.FormAdi;
            //        yet.Yetki = r.Yetki;
            //        yet.Kategorid = r.RootId;
            //        gridKategoriAdi.Visible = true;
            //        TabloYetkileri.Add(yet);
            //    }

            //} 
            #endregion

            //boş tablo
            TabloYetkileri2 = context.Database.SqlQuery<FrmYetkileriDTO>(FixedSQLCode.TabloYetkileriView).ToList();
            // dolu tablo
            var RoluVarmi = context.BSD_TBL_KullaniciRolleri.Where(c => c.KullaniciAdi == _entity.KullaniciAdi).ToList();
           
            
                foreach (var bostablo in TabloYetkileri2)
                {
                   
                    var KullaniciTablosu = RoluVarmi.Where(c => c.RootId == bostablo.Kategorid && c.KullaniciAdi== _entity.KullaniciAdi).FirstOrDefault();
                if (KullaniciTablosu!=null)
                {
                    bostablo.id = KullaniciTablosu.Id;
                    bostablo.Yetki = KullaniciTablosu.Yetki;
                  
                }
                TabloYetkileri.Add(bostablo);


            }

            






            gridControl1.DataSource = TabloYetkileri;

            //TabloYetkileriView
            //foreach (var Ane in Anamenu)
            //{

            //    TreeListColumn tre = new TreeListColumn();
            //    tre.Caption = Ane.KategoriAdi;
            //    tre.FieldName =Ane.KategoriAdi;
            //    tre.Name = Ane.id + Ane.KategoriAdi;
            //   // tre.OptionsColumn.AllowEdit = false;
            //   // tre.OptionsColumn.ShowInCustomizationForm = false;
            //    treeList1.Columns.Add(tre);
            //}

            // treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            // treeListColumn1,
            // treeListColumn2});
        }
        private void AyarYukle()
        {
            if (!string.IsNullOrEmpty(_entity.KullaniciAdi))
            {
                foreach (var item in context.BSD_TBL_KullaniciRolleri.Where(c => c.KullaniciAdi == _entity.KullaniciAdi).ToList())
                {
                    treeList1.SetNodeCheckState(treeList1.Nodes[item.RootId].Nodes[item.ParentId], item.Yetki == true ? CheckState.Checked : CheckState.Unchecked, true);
                }
            }
        }

        private void Kaydet()
        {

            List<FrmYetkileriDTO> Yetki = new List<FrmYetkileriDTO>();
            Yetki = (List<FrmYetkileriDTO>)gridControl1.DataSource;

            foreach (var y in Yetki)
            {
                BSD_TBL_KullaniciRol _kr = new BSD_TBL_KullaniciRol();
                _kr.Id = y.id;
                _kr.RootId = y.Kategorid;
                _kr.KullaniciAdi = txtAdi.Text;
                _kr.Kullaniciid = 1;
              
                if (y.Yetki == null)
                {
                    _kr.Yetki = false;
                }
                if (y.Yetki == true)
                {
                    _kr.Yetki = true;
                }
                if (y.Yetki == false)
                {
                    _kr.Yetki = false;
                }
                _kr.FormAdi = y.VwAdi;


                if (kuldal.AddOrUpdate(context, _kr))
                {
                    context.SaveChanges();
                }
                  //  context.BSD_TBL_KullaniciRolleri.Add(_kr);

            }

            //for (int i = 0; i < treeList1.Nodes.Count; i++)
            //{
            //    for (int j = 0; j < treeList1.Nodes[i].Nodes.Count; j++)
            //    {
            //        if (context.BSD_TBL_KullaniciRolleri.Count(c => c.KullaniciAdi == txtKullaniciAdi.Text && c.RootId == i && c.ParentId == j) == 0)
            //        {
            //            context.BSD_TBL_KullaniciRolleri.Add(new BSD_TBL_KullaniciRol
            //            {
            //                KullaniciAdi = txtKullaniciAdi.Text,
            //                FormAdi = treeList1.Nodes[i].GetDisplayText(treeListColumn2),
            //                KontrolAdi = treeList1.Nodes[i].Nodes[j].GetDisplayText(treeListColumn2),
            //                RootId = i,
            //                ParentId = j,
            //                Yetki = treeList1.Nodes[i].Nodes[j].Checked
            //            });
            //        }
            //        else
            //        {
            //            context.BSD_TBL_KullaniciRolleri.SingleOrDefault(c =>
            //                       c.KullaniciAdi == txtKullaniciAdi.Text && c.RootId == i && c.ParentId == j).Yetki =
            //                   treeList1.Nodes[i].Nodes[j].Checked;
            //        }
            //    }
            //}

            
        }

        private void FrmKullaniciIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_entity.Parola))
            {
                txtParola.Text = parola;
                txtParolaTekrar.Text = parola;
            }
            if (string.IsNullOrEmpty(_entity.Cevap))
            {
                txtCevap.Text = cevap;
            }
           // if (txtParola.Text != txtParolaTekrar.Text)
           // {
           //     MessageBox.Show("Parola ve Parola Tekrar alanlarına aynı parolayı girin.");
           // }
            else
            {

                if (_entity.KayitTarihi == null)
                {
                    _entity.KayitTarihi = DateTime.Now;
                }

                if (kullaniciDal.AddOrUpdate(context, _entity))
                {
                    Kaydet();
                    saved = true;
                    this.Close();
                }

            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}