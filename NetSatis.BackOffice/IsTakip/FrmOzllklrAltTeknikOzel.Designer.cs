
namespace BSDPROJE.BackOffice.IsTakip
{
    partial class FrmOzllklrAltTeknikOzel
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
            this.ustgrubcb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.altozelliktxt = new DevExpress.XtraEditors.TextEdit();
            this.altozellikaciklamasitxt = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.crudiSlemler1 = new BSD.RAPOR.Utiles.UI.CrudiSlemler();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridTeknikOzellikAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAltOzellikAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAltOzellikAciklamasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ustgrubcb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altozelliktxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altozellikaciklamasitxt.Properties)).BeginInit();
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
            this.panelUst.TabIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ustgrubcb);
            this.layoutControl1.Controls.Add(this.altozelliktxt);
            this.layoutControl1.Controls.Add(this.altozellikaciklamasitxt);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1090, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(728, 122);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ustgrubcb
            // 
            this.ustgrubcb.Location = new System.Drawing.Point(151, 12);
            this.ustgrubcb.Name = "ustgrubcb";
            this.ustgrubcb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ustgrubcb.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ustgrubcb.Size = new System.Drawing.Size(565, 26);
            this.ustgrubcb.StyleController = this.layoutControl1;
            this.ustgrubcb.TabIndex = 4;
            // 
            // altozelliktxt
            // 
            this.altozelliktxt.Location = new System.Drawing.Point(151, 42);
            this.altozelliktxt.Name = "altozelliktxt";
            this.altozelliktxt.Size = new System.Drawing.Size(565, 26);
            this.altozelliktxt.StyleController = this.layoutControl1;
            this.altozelliktxt.TabIndex = 5;
            // 
            // altozellikaciklamasitxt
            // 
            this.altozellikaciklamasitxt.Location = new System.Drawing.Point(151, 72);
            this.altozellikaciklamasitxt.Name = "altozellikaciklamasitxt";
            this.altozellikaciklamasitxt.Size = new System.Drawing.Size(565, 26);
            this.altozellikaciklamasitxt.StyleController = this.layoutControl1;
            this.altozellikaciklamasitxt.TabIndex = 6;
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
            this.layoutControlItem1.Control = this.ustgrubcb;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(708, 30);
            this.layoutControlItem1.Text = "Bağlı Grubu";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(127, 19);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.altozelliktxt;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(708, 30);
            this.layoutControlItem2.Text = "Alt Özellikleri";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(127, 19);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.altozellikaciklamasitxt;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(708, 42);
            this.layoutControlItem3.Text = "Özellik Açıklaması";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(127, 19);
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
            this.gridAltOzellikAdi,
            this.gridId,
            this.gridAltOzellikAciklamasi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridTeknikOzellikAdi
            // 
            this.gridTeknikOzellikAdi.Caption = "Bağlı ÜSt Grubu";
            this.gridTeknikOzellikAdi.FieldName = "TeknikOzellikAdi";
            this.gridTeknikOzellikAdi.Name = "gridTeknikOzellikAdi";
            this.gridTeknikOzellikAdi.OptionsColumn.AllowEdit = false;
            this.gridTeknikOzellikAdi.OptionsColumn.AllowFocus = false;
            this.gridTeknikOzellikAdi.Visible = true;
            this.gridTeknikOzellikAdi.VisibleIndex = 0;
            // 
            // gridAltOzellikAdi
            // 
            this.gridAltOzellikAdi.Caption = "Alt Özelliği adı";
            this.gridAltOzellikAdi.FieldName = "AltOzellikAdi";
            this.gridAltOzellikAdi.Name = "gridAltOzellikAdi";
            this.gridAltOzellikAdi.OptionsColumn.AllowEdit = false;
            this.gridAltOzellikAdi.OptionsColumn.AllowFocus = false;
            this.gridAltOzellikAdi.Visible = true;
            this.gridAltOzellikAdi.VisibleIndex = 1;
            // 
            // gridId
            // 
            this.gridId.Caption = "ID";
            this.gridId.FieldName = "Id";
            this.gridId.Name = "gridId";
            // 
            // gridAltOzellikAciklamasi
            // 
            this.gridAltOzellikAciklamasi.Caption = "Açıklama";
            this.gridAltOzellikAciklamasi.FieldName = "AltOzellikAciklamasi";
            this.gridAltOzellikAciklamasi.Name = "gridAltOzellikAciklamasi";
            this.gridAltOzellikAciklamasi.Visible = true;
            this.gridAltOzellikAciklamasi.VisibleIndex = 2;
            // 
            // FrmOzllklrAltTeknikOzel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 573);
            this.Controls.Add(this.panelOrta);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.panelUst);
            this.Name = "FrmOzllklrAltTeknikOzel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOzllklrAltTeknikOzel";
            this.panelUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ustgrubcb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altozelliktxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altozellikaciklamasitxt.Properties)).EndInit();
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
        private System.Windows.Forms.Panel panelOrta;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridTeknikOzellikAdi;
        private DevExpress.XtraGrid.Columns.GridColumn gridAltOzellikAdi;
        private DevExpress.XtraGrid.Columns.GridColumn gridId;
        private DevExpress.XtraEditors.ComboBoxEdit ustgrubcb;
        private DevExpress.XtraEditors.TextEdit altozelliktxt;
        private DevExpress.XtraEditors.TextEdit altozellikaciklamasitxt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn gridAltOzellikAciklamasi;
    }
}