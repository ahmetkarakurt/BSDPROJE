
namespace BSDPROJE.BackOffice.Raporlar
{
    partial class Frm_RaporlarVW_ekle
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.TXTmenuAdi = new DevExpress.XtraEditors.TextEdit();
            this.TXTResim = new DevExpress.XtraEditors.ButtonEdit();
            this.TXTDizaynYolu = new DevExpress.XtraEditors.ButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.crudiSlemler1 = new BSD.RAPOR.Utiles.UI.CrudiSlemler();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VwAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VwYolu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Image = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXTmenuAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTResim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTDizaynYolu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(444, 518);
            this.panelControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbKategori);
            this.layoutControl1.Controls.Add(this.TXTmenuAdi);
            this.layoutControl1.Controls.Add(this.TXTResim);
            this.layoutControl1.Controls.Add(this.TXTDizaynYolu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(440, 514);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(108, 12);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(320, 27);
            this.cbKategori.TabIndex = 9;
            // 
            // TXTmenuAdi
            // 
            this.TXTmenuAdi.Location = new System.Drawing.Point(108, 37);
            this.TXTmenuAdi.Name = "TXTmenuAdi";
            this.TXTmenuAdi.Size = new System.Drawing.Size(320, 26);
            this.TXTmenuAdi.StyleController = this.layoutControl1;
            this.TXTmenuAdi.TabIndex = 5;
            // 
            // TXTResim
            // 
            this.TXTResim.Location = new System.Drawing.Point(108, 97);
            this.TXTResim.Name = "TXTResim";
            this.TXTResim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TXTResim.Size = new System.Drawing.Size(320, 26);
            this.TXTResim.StyleController = this.layoutControl1;
            this.TXTResim.TabIndex = 7;
            this.TXTResim.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TXTResim_ButtonClick);
            // 
            // TXTDizaynYolu
            // 
            this.TXTDizaynYolu.Location = new System.Drawing.Point(108, 67);
            this.TXTDizaynYolu.Name = "TXTDizaynYolu";
            this.TXTDizaynYolu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TXTDizaynYolu.Size = new System.Drawing.Size(320, 26);
            this.TXTDizaynYolu.StyleController = this.layoutControl1;
            this.TXTDizaynYolu.TabIndex = 6;
            this.TXTDizaynYolu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TXTDizaynYolu_ButtonClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(440, 514);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 115);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(420, 379);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TXTmenuAdi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(420, 30);
            this.layoutControlItem2.Text = "Menü Adı";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(84, 19);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.TXTDizaynYolu;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 55);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(420, 30);
            this.layoutControlItem3.Text = "Dizayn Yolu";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(84, 19);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.TXTResim;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 85);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(420, 30);
            this.layoutControlItem4.Text = "Resim";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(84, 19);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cbKategori;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(420, 25);
            this.layoutControlItem6.Text = "Kategori";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(84, 19);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.crudiSlemler1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 518);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1368, 100);
            this.panelControl2.TabIndex = 1;
            // 
            // crudiSlemler1
            // 
            this.crudiSlemler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudiSlemler1.Location = new System.Drawing.Point(2, 2);
            this.crudiSlemler1.Name = "crudiSlemler1";
            this.crudiSlemler1.Size = new System.Drawing.Size(1364, 96);
            this.crudiSlemler1.TabIndex = 0;
            this.crudiSlemler1.KaydetClick += new System.EventHandler(this.crudiSlemler1_KaydetClick);
            this.crudiSlemler1.SecClick += new System.EventHandler(this.crudiSlemler1_SecClick);
            this.crudiSlemler1.SilClick += new System.EventHandler(this.crudiSlemler1_SilClick);
            this.crudiSlemler1.VazgecClick += new System.EventHandler(this.crudiSlemler1_VazgecClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(444, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(924, 518);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.Aciklama,
            this.VwAdi,
            this.VwYolu,
            this.Image});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // Aciklama
            // 
            this.Aciklama.Caption = "Kategori Adı";
            this.Aciklama.FieldName = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.OptionsColumn.AllowEdit = false;
            this.Aciklama.OptionsColumn.AllowFocus = false;
            this.Aciklama.Visible = true;
            this.Aciklama.VisibleIndex = 0;
            // 
            // VwAdi
            // 
            this.VwAdi.Caption = "Menü Adı";
            this.VwAdi.FieldName = "VwAdi";
            this.VwAdi.Name = "VwAdi";
            this.VwAdi.OptionsColumn.AllowEdit = false;
            this.VwAdi.OptionsColumn.AllowFocus = false;
            this.VwAdi.Visible = true;
            this.VwAdi.VisibleIndex = 1;
            // 
            // VwYolu
            // 
            this.VwYolu.Caption = "Rapor Yolu";
            this.VwYolu.FieldName = "VwYolu";
            this.VwYolu.Name = "VwYolu";
            this.VwYolu.OptionsColumn.AllowEdit = false;
            this.VwYolu.OptionsColumn.AllowFocus = false;
            this.VwYolu.Visible = true;
            this.VwYolu.VisibleIndex = 2;
            // 
            // Image
            // 
            this.Image.Caption = "Resim Yolu";
            this.Image.FieldName = "Image";
            this.Image.Name = "Image";
            this.Image.OptionsColumn.AllowEdit = false;
            this.Image.OptionsColumn.AllowFocus = false;
            this.Image.Visible = true;
            this.Image.VisibleIndex = 3;
            // 
            // Frm_RaporlarVW_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 618);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "Frm_RaporlarVW_ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_RaporlarVW_ekle";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TXTmenuAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTResim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTDizaynYolu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit TXTmenuAdi;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private BSD.RAPOR.Utiles.UI.CrudiSlemler crudiSlemler1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox cbKategori;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn VwAdi;
        private DevExpress.XtraGrid.Columns.GridColumn VwYolu;
        private DevExpress.XtraGrid.Columns.GridColumn Image;
        private DevExpress.XtraEditors.ButtonEdit TXTResim;
        private DevExpress.XtraEditors.ButtonEdit TXTDizaynYolu;
    }
}