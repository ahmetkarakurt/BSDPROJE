﻿
namespace BSD.RAPOR.UI.SecimEkranlari
{
    partial class frm_Cari_Secim_Ekrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdCARI_KOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCARI_ISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1092, 522);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdCARI_KOD,
            this.grdCARI_ISIM});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gridView1.OptionsFilter.ShowInHeaderSearchTextMode = DevExpress.XtraGrid.Views.Grid.ShowInHeaderSearchTextMode.Tooltip;
            this.gridView1.OptionsFind.SearchInPreview = true;
            // 
            // grdCARI_KOD
            // 
            this.grdCARI_KOD.Caption = "Cari Kodu";
            this.grdCARI_KOD.FieldName = "CARI_KOD";
            this.grdCARI_KOD.Name = "grdCARI_KOD";
            this.grdCARI_KOD.OptionsColumn.AllowEdit = false;
            this.grdCARI_KOD.OptionsColumn.AllowFocus = false;
            this.grdCARI_KOD.Visible = true;
            this.grdCARI_KOD.VisibleIndex = 0;
            this.grdCARI_KOD.Width = 120;
            // 
            // grdCARI_ISIM
            // 
            this.grdCARI_ISIM.Caption = "Cari ismi";
            this.grdCARI_ISIM.FieldName = "CARI_ISIM";
            this.grdCARI_ISIM.Name = "grdCARI_ISIM";
            this.grdCARI_ISIM.OptionsColumn.AllowEdit = false;
            this.grdCARI_ISIM.OptionsColumn.AllowFocus = false;
            this.grdCARI_ISIM.Visible = true;
            this.grdCARI_ISIM.VisibleIndex = 1;
            this.grdCARI_ISIM.Width = 747;
            // 
            // frm_Cari_Secim_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 522);
            this.Controls.Add(this.gridControl1);
            this.Name = "frm_Cari_Secim_Ekrani";
            this.Text = "frm_Cari_Secim_Ekrani";
            this.Load += new System.EventHandler(this.frm_Cari_Secim_Ekrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grdCARI_KOD;
        private DevExpress.XtraGrid.Columns.GridColumn grdCARI_ISIM;
    }
}