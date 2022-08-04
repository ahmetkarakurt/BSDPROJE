
namespace BSD.RAPOR.UI.SecimEkranlari
{
    partial class Frm_EvrakBelgeSecim
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
            this.gridBelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOdemeTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridBankaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridBankaKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDovizTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOdemeTipi = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Size = new System.Drawing.Size(1082, 482);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridBelgeNo,
            this.gridOdemeTuru,
            this.gridBankaAdi,
            this.gridBankaKod,
            this.gridTutar,
            this.gridDovizTutar,
            this.gridOdemeTipi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridBelgeNo
            // 
            this.gridBelgeNo.Caption = "BelgeNo";
            this.gridBelgeNo.FieldName = "BelgeNo";
            this.gridBelgeNo.Name = "gridBelgeNo";
            this.gridBelgeNo.OptionsColumn.AllowEdit = false;
            this.gridBelgeNo.OptionsColumn.AllowFocus = false;
            this.gridBelgeNo.Visible = true;
            this.gridBelgeNo.VisibleIndex = 6;
            // 
            // gridOdemeTuru
            // 
            this.gridOdemeTuru.Caption = "OdemeTuru";
            this.gridOdemeTuru.FieldName = "OdemeTuru";
            this.gridOdemeTuru.Name = "gridOdemeTuru";
            this.gridOdemeTuru.OptionsColumn.AllowEdit = false;
            this.gridOdemeTuru.OptionsColumn.AllowFocus = false;
            this.gridOdemeTuru.Visible = true;
            this.gridOdemeTuru.VisibleIndex = 5;
            // 
            // gridBankaAdi
            // 
            this.gridBankaAdi.Caption = "BankaAdi";
            this.gridBankaAdi.FieldName = "BankaAdi";
            this.gridBankaAdi.Name = "gridBankaAdi";
            this.gridBankaAdi.OptionsColumn.AllowEdit = false;
            this.gridBankaAdi.OptionsColumn.AllowFocus = false;
            this.gridBankaAdi.Visible = true;
            this.gridBankaAdi.VisibleIndex = 4;
            // 
            // gridBankaKod
            // 
            this.gridBankaKod.Caption = "BankaKod";
            this.gridBankaKod.FieldName = "BankaKod";
            this.gridBankaKod.Name = "gridBankaKod";
            this.gridBankaKod.OptionsColumn.AllowEdit = false;
            this.gridBankaKod.OptionsColumn.AllowFocus = false;
            this.gridBankaKod.Visible = true;
            this.gridBankaKod.VisibleIndex = 3;
            // 
            // gridTutar
            // 
            this.gridTutar.Caption = "Tutar";
            this.gridTutar.DisplayFormat.FormatString = "N";
            this.gridTutar.FieldName = "Tutar";
            this.gridTutar.Name = "gridTutar";
            this.gridTutar.OptionsColumn.AllowEdit = false;
            this.gridTutar.OptionsColumn.AllowFocus = false;
            this.gridTutar.Visible = true;
            this.gridTutar.VisibleIndex = 2;
            // 
            // gridDovizTutar
            // 
            this.gridDovizTutar.Caption = "DovizTutar";
            this.gridDovizTutar.DisplayFormat.FormatString = "N";
            this.gridDovizTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridDovizTutar.FieldName = "DovizTutar";
            this.gridDovizTutar.Name = "gridDovizTutar";
            this.gridDovizTutar.OptionsColumn.AllowEdit = false;
            this.gridDovizTutar.OptionsColumn.AllowFocus = false;
            this.gridDovizTutar.Visible = true;
            this.gridDovizTutar.VisibleIndex = 1;
            // 
            // gridOdemeTipi
            // 
            this.gridOdemeTipi.Caption = "OdemeTipi";
            this.gridOdemeTipi.FieldName = "OdemeTipi";
            this.gridOdemeTipi.Name = "gridOdemeTipi";
            this.gridOdemeTipi.OptionsColumn.AllowEdit = false;
            this.gridOdemeTipi.OptionsColumn.AllowFocus = false;
            this.gridOdemeTipi.Visible = true;
            this.gridOdemeTipi.VisibleIndex = 0;
            // 
            // Frm_EvrakBelgeSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 482);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_EvrakBelgeSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_EvrakBelgeSecim";
            this.Load += new System.EventHandler(this.Frm_EvrakBelgeSecim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridBelgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridOdemeTuru;
        private DevExpress.XtraGrid.Columns.GridColumn gridBankaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn gridBankaKod;
        private DevExpress.XtraGrid.Columns.GridColumn gridTutar;
        private DevExpress.XtraGrid.Columns.GridColumn gridDovizTutar;
        private DevExpress.XtraGrid.Columns.GridColumn gridOdemeTipi;
    }
}