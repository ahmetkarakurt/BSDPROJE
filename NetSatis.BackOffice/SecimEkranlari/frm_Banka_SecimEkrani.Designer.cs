
namespace BSD.RAPOR.UI.BANKA
{
    partial class frm_Banka_SecimEkrani
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
            this.grdNETHESKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdNETBANKAKODU = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Size = new System.Drawing.Size(1107, 601);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdNETHESKODU,
            this.grdACIKLAMA,
            this.grdNETBANKAKODU});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gridView1.OptionsFilter.ShowInHeaderSearchTextMode = DevExpress.XtraGrid.Views.Grid.ShowInHeaderSearchTextMode.Tooltip;
            this.gridView1.OptionsFind.SearchInPreview = true;
            // 
            // grdNETHESKODU
            // 
            this.grdNETHESKODU.Caption = "HESAP KODU";
            this.grdNETHESKODU.FieldName = "NETHESKODU";
            this.grdNETHESKODU.Name = "grdNETHESKODU";
            this.grdNETHESKODU.OptionsColumn.AllowEdit = false;
            this.grdNETHESKODU.OptionsColumn.AllowFocus = false;
            this.grdNETHESKODU.Visible = true;
            this.grdNETHESKODU.VisibleIndex = 0;
            this.grdNETHESKODU.Width = 123;
            // 
            // grdACIKLAMA
            // 
            this.grdACIKLAMA.Caption = "Banka Adı";
            this.grdACIKLAMA.FieldName = "ACIKLAMA";
            this.grdACIKLAMA.Name = "grdACIKLAMA";
            this.grdACIKLAMA.OptionsColumn.AllowEdit = false;
            this.grdACIKLAMA.OptionsColumn.AllowFocus = false;
            this.grdACIKLAMA.Visible = true;
            this.grdACIKLAMA.VisibleIndex = 1;
            this.grdACIKLAMA.Width = 390;
            // 
            // grdNETBANKAKODU
            // 
            this.grdNETBANKAKODU.Caption = "Banka Kodu";
            this.grdNETBANKAKODU.FieldName = "NETBANKAKODU";
            this.grdNETBANKAKODU.Name = "grdNETBANKAKODU";
            // 
            // frm_Banka_SecimEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 601);
            this.Controls.Add(this.gridControl1);
            this.Name = "frm_Banka_SecimEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Banka_SecimEkrani";
            this.Load += new System.EventHandler(this.frm_Banka_SecimEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grdNETHESKODU;
        private DevExpress.XtraGrid.Columns.GridColumn grdACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn grdNETBANKAKODU;
    }
}