
namespace BSD.RAPOR.UI.SecimEkranlari
{
    partial class Frm_Fatura_SecimEkrani
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
            this.grdTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdFATIRS_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdGENELTOPLAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdODEMETARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdDOVIZTIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdDOVIZTUT = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Size = new System.Drawing.Size(1081, 521);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdTARIH,
            this.grdFATIRS_NO,
            this.grdGENELTOPLAM,
            this.grdODEMETARIHI,
            this.grdDOVIZTIP,
            this.grdDOVIZTUT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gridView1.OptionsFilter.ShowInHeaderSearchTextMode = DevExpress.XtraGrid.Views.Grid.ShowInHeaderSearchTextMode.Tooltip;
            this.gridView1.OptionsFind.SearchInPreview = true;
            // 
            // grdTARIH
            // 
            this.grdTARIH.Caption = "TARIH";
            this.grdTARIH.DisplayFormat.FormatString = "d";
            this.grdTARIH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.grdTARIH.FieldName = "TARIH";
            this.grdTARIH.Name = "grdTARIH";
            this.grdTARIH.OptionsColumn.AllowEdit = false;
            this.grdTARIH.OptionsColumn.AllowFocus = false;
            this.grdTARIH.Visible = true;
            this.grdTARIH.VisibleIndex = 0;
            // 
            // grdFATIRS_NO
            // 
            this.grdFATIRS_NO.Caption = "Fatura NO";
            this.grdFATIRS_NO.FieldName = "FATIRS_NO";
            this.grdFATIRS_NO.Name = "grdFATIRS_NO";
            this.grdFATIRS_NO.OptionsColumn.AllowEdit = false;
            this.grdFATIRS_NO.OptionsColumn.AllowFocus = false;
            this.grdFATIRS_NO.Visible = true;
            this.grdFATIRS_NO.VisibleIndex = 1;
            // 
            // grdGENELTOPLAM
            // 
            this.grdGENELTOPLAM.Caption = "Fatura Toplamı";
            this.grdGENELTOPLAM.FieldName = "GENELTOPLAM";
            this.grdGENELTOPLAM.Name = "grdGENELTOPLAM";
            this.grdGENELTOPLAM.OptionsColumn.AllowEdit = false;
            this.grdGENELTOPLAM.OptionsColumn.AllowFocus = false;
            this.grdGENELTOPLAM.Visible = true;
            this.grdGENELTOPLAM.VisibleIndex = 2;
            // 
            // grdODEMETARIHI
            // 
            this.grdODEMETARIHI.Caption = "Ödeme Tarihi";
            this.grdODEMETARIHI.DisplayFormat.FormatString = "d";
            this.grdODEMETARIHI.FieldName = "ODEMETARIHI";
            this.grdODEMETARIHI.Name = "grdODEMETARIHI";
            this.grdODEMETARIHI.OptionsColumn.AllowEdit = false;
            this.grdODEMETARIHI.OptionsColumn.AllowFocus = false;
            this.grdODEMETARIHI.Visible = true;
            this.grdODEMETARIHI.VisibleIndex = 3;
            // 
            // grdDOVIZTIP
            // 
            this.grdDOVIZTIP.Caption = "DOVIZTIP";
            this.grdDOVIZTIP.FieldName = "DOVIZTIP";
            this.grdDOVIZTIP.Name = "grdDOVIZTIP";
            this.grdDOVIZTIP.OptionsColumn.AllowEdit = false;
            this.grdDOVIZTIP.OptionsColumn.AllowFocus = false;
            this.grdDOVIZTIP.Visible = true;
            this.grdDOVIZTIP.VisibleIndex = 4;
            // 
            // grdDOVIZTUT
            // 
            this.grdDOVIZTUT.Caption = "Döviz Tutarı";
            this.grdDOVIZTUT.FieldName = "DOVIZTUT";
            this.grdDOVIZTUT.Name = "grdDOVIZTUT";
            this.grdDOVIZTUT.OptionsColumn.AllowEdit = false;
            this.grdDOVIZTUT.OptionsColumn.AllowFocus = false;
            this.grdDOVIZTUT.Visible = true;
            this.grdDOVIZTUT.VisibleIndex = 5;
            // 
            // Frm_Fatura_SecimEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 521);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_Fatura_SecimEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Fatura_SecimEkrani";
            this.Load += new System.EventHandler(this.Frm_Fatura_SecimEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grdTARIH;
        private DevExpress.XtraGrid.Columns.GridColumn grdFATIRS_NO;
        private DevExpress.XtraGrid.Columns.GridColumn grdGENELTOPLAM;
        private DevExpress.XtraGrid.Columns.GridColumn grdODEMETARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn grdDOVIZTIP;
        private DevExpress.XtraGrid.Columns.GridColumn grdDOVIZTUT;
    }
}