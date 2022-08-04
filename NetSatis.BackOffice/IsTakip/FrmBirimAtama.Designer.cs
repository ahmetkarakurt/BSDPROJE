
namespace BSDPROJE.BackOffice.IsTakip
{
    partial class FrmBirimAtama
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
            this.kullanicicb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.birimcb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.altBirimcb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.crudiSlemler1 = new BSD.RAPOR.Utiles.UI.CrudiSlemler();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAltBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicicb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimcb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altBirimcb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this.panelUst.TabIndex = 3;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.kullanicicb);
            this.layoutControl1.Controls.Add(this.birimcb);
            this.layoutControl1.Controls.Add(this.altBirimcb);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1090, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(728, 122);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // kullanicicb
            // 
            this.kullanicicb.Location = new System.Drawing.Point(139, 12);
            this.kullanicicb.Name = "kullanicicb";
            this.kullanicicb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.kullanicicb.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.kullanicicb.Size = new System.Drawing.Size(577, 26);
            this.kullanicicb.StyleController = this.layoutControl1;
            this.kullanicicb.TabIndex = 4;
            // 
            // birimcb
            // 
            this.birimcb.Location = new System.Drawing.Point(139, 42);
            this.birimcb.Name = "birimcb";
            this.birimcb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birimcb.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.birimcb.Size = new System.Drawing.Size(577, 26);
            this.birimcb.StyleController = this.layoutControl1;
            this.birimcb.TabIndex = 5;
            // 
            // altBirimcb
            // 
            this.altBirimcb.Location = new System.Drawing.Point(139, 72);
            this.altBirimcb.Name = "altBirimcb";
            this.altBirimcb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.altBirimcb.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.altBirimcb.Size = new System.Drawing.Size(577, 26);
            this.altBirimcb.StyleController = this.layoutControl1;
            this.altBirimcb.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(728, 122);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.kullanicicb;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(708, 30);
            this.layoutControlItem1.Text = "Kullanıcı Seciniz";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(115, 19);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.birimcb;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(708, 30);
            this.layoutControlItem2.Text = "Birim Seçiniz";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(115, 19);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.altBirimcb;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(708, 42);
            this.layoutControlItem3.Text = "Alt Birim Seçiniz";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(115, 19);
            // 
            // panelAlt
            // 
            this.panelAlt.Controls.Add(this.crudiSlemler1);
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Location = new System.Drawing.Point(0, 492);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(728, 81);
            this.panelAlt.TabIndex = 4;
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
            this.crudiSlemler1.VazgecClick += new System.EventHandler(this.crudiSlemler1_VazgecClick);
            // 
            // panelOrta
            // 
            this.panelOrta.Controls.Add(this.gridControl1);
            this.panelOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrta.Location = new System.Drawing.Point(0, 122);
            this.panelOrta.Name = "panelOrta";
            this.panelOrta.Size = new System.Drawing.Size(728, 370);
            this.panelOrta.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
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
            this.gridid,
            this.gridKullaniciAdi,
            this.gridBirim,
            this.gridAltBirim});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridid
            // 
            this.gridid.Caption = "id";
            this.gridid.FieldName = "Id";
            this.gridid.Name = "gridid";
            // 
            // gridKullaniciAdi
            // 
            this.gridKullaniciAdi.Caption = "Kullanıcı Adı";
            this.gridKullaniciAdi.FieldName = "KullaniciAdi";
            this.gridKullaniciAdi.Name = "gridKullaniciAdi";
            this.gridKullaniciAdi.OptionsColumn.AllowEdit = false;
            this.gridKullaniciAdi.OptionsColumn.AllowFocus = false;
            this.gridKullaniciAdi.Visible = true;
            this.gridKullaniciAdi.VisibleIndex = 0;
            // 
            // gridBirim
            // 
            this.gridBirim.Caption = "Bağlı Birimi";
            this.gridBirim.FieldName = "Birim";
            this.gridBirim.Name = "gridBirim";
            this.gridBirim.OptionsColumn.AllowEdit = false;
            this.gridBirim.OptionsColumn.AllowFocus = false;
            this.gridBirim.Visible = true;
            this.gridBirim.VisibleIndex = 1;
            // 
            // gridAltBirim
            // 
            this.gridAltBirim.Caption = "Bağlı Alt Birimi";
            this.gridAltBirim.FieldName = "AltBirim";
            this.gridAltBirim.Name = "gridAltBirim";
            this.gridAltBirim.OptionsColumn.AllowEdit = false;
            this.gridAltBirim.OptionsColumn.AllowFocus = false;
            this.gridAltBirim.Visible = true;
            this.gridAltBirim.VisibleIndex = 2;
            // 
            // FrmBirimAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 573);
            this.Controls.Add(this.panelOrta);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.panelUst);
            this.Name = "FrmBirimAtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBirimAtama";
            this.panelUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kullanicicb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimcb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altBirimcb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
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
        private DevExpress.XtraEditors.ComboBoxEdit kullanicicb;
        private DevExpress.XtraEditors.ComboBoxEdit birimcb;
        private DevExpress.XtraEditors.ComboBoxEdit altBirimcb;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.Panel panelOrta;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridid;
        private DevExpress.XtraGrid.Columns.GridColumn gridKullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn gridBirim;
        private DevExpress.XtraGrid.Columns.GridColumn gridAltBirim;
    }
}