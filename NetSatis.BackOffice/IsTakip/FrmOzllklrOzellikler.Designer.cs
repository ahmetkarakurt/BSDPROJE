
namespace BSDPROJE.BackOffice.IsTakip
{
    partial class FrmOzllklrOzellikler
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
            this.panelUst = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Ozelliktxt = new DevExpress.XtraEditors.TextEdit();
            this.Aciklamatxt = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.crudiSlemler1 = new BSD.RAPOR.Utiles.UI.CrudiSlemler();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridTeknikOzellikAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTeknikOzellikAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ozelliktxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aciklamatxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.panelAlt.SuspendLayout();
            this.panelOrta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUst
            // 
            this.panelUst.Controls.Add(this.layoutControl1);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(0, 0);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(728, 122);
            this.panelUst.TabIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Ozelliktxt);
            this.layoutControl1.Controls.Add(this.Aciklamatxt);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1090, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(728, 122);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Ozelliktxt
            // 
            this.Ozelliktxt.Location = new System.Drawing.Point(151, 12);
            this.Ozelliktxt.Name = "Ozelliktxt";
            this.Ozelliktxt.Size = new System.Drawing.Size(565, 26);
            this.Ozelliktxt.StyleController = this.layoutControl1;
            this.Ozelliktxt.TabIndex = 4;
            // 
            // Aciklamatxt
            // 
            this.Aciklamatxt.Location = new System.Drawing.Point(151, 42);
            this.Aciklamatxt.Name = "Aciklamatxt";
            this.Aciklamatxt.Size = new System.Drawing.Size(565, 26);
            this.Aciklamatxt.StyleController = this.layoutControl1;
            this.Aciklamatxt.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(728, 122);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Ozelliktxt;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(708, 30);
            this.layoutControlItem1.Text = "Ozellikler";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(127, 19);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Aciklamatxt;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(708, 72);
            this.layoutControlItem2.Text = "Ozellik Açıklaması";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(127, 19);
            // 
            // panelAlt
            // 
            this.panelAlt.Controls.Add(this.crudiSlemler1);
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Location = new System.Drawing.Point(0, 492);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(728, 81);
            this.panelAlt.TabIndex = 3;
            // 
            // crudiSlemler1
            // 
            this.crudiSlemler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudiSlemler1.Location = new System.Drawing.Point(0, 0);
            this.crudiSlemler1.Margin = new System.Windows.Forms.Padding(2);
            this.crudiSlemler1.Name = "crudiSlemler1";
            this.crudiSlemler1.Size = new System.Drawing.Size(728, 81);
            this.crudiSlemler1.TabIndex = 0;
            this.crudiSlemler1.KaydetClick += new System.EventHandler(this.crudiSlemler1_KaydetClick);
            this.crudiSlemler1.SecClick += new System.EventHandler(this.crudiSlemler1_SecClick);
            this.crudiSlemler1.SilClick += new System.EventHandler(this.crudiSlemler1_SilClick);
            // 
            // panelOrta
            // 
            this.panelOrta.Controls.Add(this.gridControl1);
            this.panelOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrta.Location = new System.Drawing.Point(0, 122);
            this.panelOrta.Name = "panelOrta";
            this.panelOrta.Size = new System.Drawing.Size(728, 370);
            this.panelOrta.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(728, 370);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridTeknikOzellikAdi,
            this.gridTeknikOzellikAciklama,
            this.gridId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridTeknikOzellikAdi
            // 
            this.gridTeknikOzellikAdi.Caption = "Teknik Özellik Grubu";
            this.gridTeknikOzellikAdi.FieldName = "TeknikOzellikAdi";
            this.gridTeknikOzellikAdi.Name = "gridTeknikOzellikAdi";
            this.gridTeknikOzellikAdi.OptionsColumn.AllowEdit = false;
            this.gridTeknikOzellikAdi.OptionsColumn.AllowFocus = false;
            this.gridTeknikOzellikAdi.Visible = true;
            this.gridTeknikOzellikAdi.VisibleIndex = 0;
            this.gridTeknikOzellikAdi.Width = 322;
            // 
            // gridTeknikOzellikAciklama
            // 
            this.gridTeknikOzellikAciklama.Caption = "Grup Açıklaması";
            this.gridTeknikOzellikAciklama.FieldName = "TeknikOzellikAciklama";
            this.gridTeknikOzellikAciklama.Name = "gridTeknikOzellikAciklama";
            this.gridTeknikOzellikAciklama.OptionsColumn.AllowEdit = false;
            this.gridTeknikOzellikAciklama.OptionsColumn.AllowFocus = false;
            this.gridTeknikOzellikAciklama.Visible = true;
            this.gridTeknikOzellikAciklama.VisibleIndex = 1;
            // 
            // gridId
            // 
            this.gridId.Caption = "ID";
            this.gridId.FieldName = "Id";
            this.gridId.Name = "gridId";
            // 
            // FrmOzllklrOzellikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 573);
            this.Controls.Add(this.panelOrta);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.panelUst);
            this.Name = "FrmOzllklrOzellikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOzllklrOzellikler";
            this.panelUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ozelliktxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aciklamatxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.panelAlt.ResumeLayout(false);
            this.panelOrta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUst;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.Panel panelAlt;
        private BSD.RAPOR.Utiles.UI.CrudiSlemler crudiSlemler1;
        private System.Windows.Forms.Panel panelOrta;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridTeknikOzellikAdi;
        private DevExpress.XtraGrid.Columns.GridColumn gridTeknikOzellikAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn gridId;
        private DevExpress.XtraEditors.TextEdit Ozelliktxt;
        private DevExpress.XtraEditors.TextEdit Aciklamatxt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}