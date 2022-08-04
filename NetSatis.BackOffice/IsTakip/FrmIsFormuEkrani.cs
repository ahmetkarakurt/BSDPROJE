using BSDPROJE.Entities.Aspect.Attributes;
using BSDPROJE.Entities.BaseUI;
using BSDPROJE.Entities.Data_Access;
using BSDPROJE.Entities.Data_Access.IsTakip.Ozellikler;
using BSDPROJE.Entities.Dto.IsTakibiDTO;
using BSDPROJE.Entities.Tables;
using BSDPROJE.Entities.Tables.isTakip.Ozellikler;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSDPROJE.BackOffice.IsTakip
{
    //[TryAspect]
    public partial class FrmIsFormuEkrani : BaseXtraForms

    {
        public FrmIsFormuEkrani()
        {
            InitializeComponent();
          


        



            GridGetir();
        }

  
        AltTeknikOzellikleriDAL _TeknikOZellikler = new AltTeknikOzellikleriDAL();
        IS_IsTakibiDAL _IsTakibiDAL = new IS_IsTakibiDAL();
        IS_BelgeHareket _BelgeHareket = new IS_BelgeHareket();



IsTakibiSelectDTO _istakibiDTO;
        IS_IsTakibiAltOzel _IsTakibiAltOzel = new IS_IsTakibiAltOzel();

        BSD_TBL_ISTAKIBI _TBL_ISTAKIBI;
        BSD_TBL_BELGEHAREKET _TBL_BELGEHAREKET;

        private void GridGetir()
        {
            using (var context = new NetSatisContext())
            {
                var a = _TeknikOZellikler.GetAll(context);
                // //.GetAll(context).Select(c => new { c.Id, c.Ozellik.TeknikOzellikAdi, c.AltOzellikAdi, c.AltOzellikAciklamasi });
                // //    _istakibiDTO.TeknikOzellikler = a;
                // gridControl1.DataSource = _TeknikOZellikler.GetAll(context).Select(c => new { c.Id, c.Ozellik.TeknikOzellikAdi, c.AltOzellikAdi, c.AltOzellikAciklamasi,c.OzellikId });

  
                List<IsTakibiSelectDTO> GEnelListe = new List<IsTakibiSelectDTO>();
                foreach (var item in a)
                {
                    _istakibiDTO = new IsTakibiSelectDTO();
                    _istakibiDTO.AltozelID = item.Id;
                    _istakibiDTO.Id = item.Id;
                    _istakibiDTO.UstOzelID = item.OzellikId;
                    _istakibiDTO.ustozellik = item.Ozellik.TeknikOzellikAdi;
                    _istakibiDTO.AltOZellik = item.AltOzellikAdi;

                   
                    //   _IsTakibiAltOzel.GetAll(context, c => c.TeknikAltOzellikId == item.Id).ForEach(c => repositoryItemComboBox1.Items.Add(c.Cevap));


                    //  var list = _IsTakibiAltOzel.GetAll(context, c => c.TeknikAltOzellikId == item.Id).Select(c => c.Cevap);
                    // _istakibiDTO.Cevap = //repositoryItemComboBox1.AppearanceItemSelected.ToString();
                    GEnelListe.Add(_istakibiDTO);
                    //  repositoryItemComboBox1.Items.Clear();


                }






             
                gridControl1.DataSource = GEnelListe.ToList();
               

            }
          //  hes();



        }

        BSD_TBL_ISTAKIBI_ALTOZEL _TBL_ISTAKIBI_ALTOZEL;
    
        private void crudiSlemler1_KaydetClick(object sender, EventArgs e)
        {
          //  List<IsTakibiSelectDTO> GEnelListe = new List<IsTakibiSelectDTO>();
          var  a = (List<IsTakibiSelectDTO>)gridControl1.DataSource;
            using (var context = new NetSatisContext())
            {
                foreach (var item in a)
                {
                    _TBL_ISTAKIBI_ALTOZEL = new BSD_TBL_ISTAKIBI_ALTOZEL();
                    _TBL_ISTAKIBI_ALTOZEL.Cevap = item.Cevap;
                    _TBL_ISTAKIBI_ALTOZEL.AnaOzellikId = item.UstOzelID;
                    _TBL_ISTAKIBI_ALTOZEL.TeknikAltOzellikId = item.AltozelID;
                    if (_IsTakibiAltOzel.AddOrUpdate(context, _TBL_ISTAKIBI_ALTOZEL))
                    {

                    }

                }

             //   _TBL_BELGEHAREKET = new BSD_TBL_BELGEHAREKET();
             //   _TBL_BELGEHAREKET.



                _TBL_ISTAKIBI = new BSD_TBL_ISTAKIBI();
                _TBL_ISTAKIBI.BelgeNo = Belgenotxt.Text.ToUpper();
                _TBL_ISTAKIBI.FirmaAdi = Firmaaditxt.Text.ToUpper();
                _TBL_ISTAKIBI.UrurunAdi = urunaditxt.Text.ToUpper();
                _TBL_ISTAKIBI.AcilisTarihi = DateTime.Now;
                _TBL_ISTAKIBI.Durum = Is_Enum_is_takibi_durum.Acik.ToString();
                _TBL_ISTAKIBI.KullaniciId = RoleTool.KullaniciEntity.Id;
                _TBL_ISTAKIBI.Not = nottxt.Text;

                _IsTakibiAltOzel.Save(context);



            }
              

        }

        void hes()
        {
     
                for (int i = 0; i <gridView1.RowCount; i++)
                {
                    var a = (int)gridView1.GetRowCellValue(i, gridId);

                    //   MessageBox.Show(a.ToString());
                    using (var context = new NetSatisContext())
                    {
                        RepositoryItemComboBox riCombo = new RepositoryItemComboBox();
                        var al = _IsTakibiAltOzel.GetAll(context, c => c.TeknikAltOzellikId == a && c.Cevap != null && c.Cevap != "").Select(c => c.Cevap).ToList();
                        riCombo.Name =  "yazilar"+i;
                        riCombo.Items.AddRange(al);
                        gridControl1.RepositoryItems.Add(riCombo);
                        gridCevap.ColumnEdit = riCombo;
                        //   _IsTakibiAltOzel.GetAll(context, c => c.TeknikAltOzellikId ==a && c.Cevap!=null ).ForEach(c => repositoryItemComboBox1.Items.Add(c.Cevap));
                    }
                }

        

        }

        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
           
        }

        private void repositoryItemComboBox1_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
        {
          
        }

        private void repositoryItemComboBox1_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
         
        }

        private void repositoryItemComboBox1_Click(object sender, EventArgs e)
        {
           
        }

      

        void calsitir()
        {
           repositoryItemComboBox1.Items.Clear();
            try
            {
                if (gridView1.GetSelectedRows().Length != 0)
                {
                    foreach (var row in gridView1.GetSelectedRows())
                    {

                        if (!String.IsNullOrEmpty(gridView1?.GetFocusedRowCellValue(gridId)?.ToString()))
                        {
                            var a = (int)gridView1.GetFocusedRowCellValue(gridId);



                            using (var context = new NetSatisContext())
                            {
                                var dist = _IsTakibiAltOzel.GetAll(context, c => c.TeknikAltOzellikId == a && c.Cevap != null && c.Cevap != "").Select(c => c.Cevap).Distinct().ToList();
                                dist.ForEach(c => repositoryItemComboBox1.Items.Add(c));

                            }
                        }
                     
                     



                    }


                }
            }
            catch (Exception)
            {


            }
        }

     
        private void gridView1_Click(object sender, EventArgs e)
        {
            calsitir();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void crudiSlemler1_SecClick(object sender, EventArgs e)
        {
            gridView1.AddNewRow();

          // gridView1.SetFocusedRowCellValue(gridId, 1);
          // gridView1.SetFocusedRowCellValue(gridustozellik, "2");
          // gridView1.SetFocusedRowCellValue(gridAltOZellik, "3");
          // gridView1.SetFocusedRowCellValue(gridCevap, "4");

        }
    }






}


