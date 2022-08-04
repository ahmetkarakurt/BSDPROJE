
namespace BSDPROJE.BackOffice.Raporlar
{
    partial class Frm_RaporANA_Ekle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.MenuAciklamaTXT = new DevExpress.XtraEditors.TextEdit();
            this.MunuadiTXT = new DevExpress.XtraEditors.TextEdit();
            this.ResimyoluTXT = new DevExpress.XtraEditors.ButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KategoriAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Image = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crudiSlemler1 = new BSD.RAPOR.Utiles.UI.CrudiSlemler();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuAciklamaTXT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MunuadiTXT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResimyoluTXT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.layoutControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 585);
            this.panel1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.MenuAciklamaTXT);
            this.layoutControl1.Controls.Add(this.MunuadiTXT);
            this.layoutControl1.Controls.Add(this.ResimyoluTXT);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(469, 585);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // MenuAciklamaTXT
            // 
            this.MenuAciklamaTXT.Location = new System.Drawing.Point(139, 42);
            this.MenuAciklamaTXT.Name = "MenuAciklamaTXT";
            this.MenuAciklamaTXT.Size = new System.Drawing.Size(318, 26);
            this.MenuAciklamaTXT.StyleController = this.layoutControl1;
            this.MenuAciklamaTXT.TabIndex = 5;
            // 
            // MunuadiTXT
            // 
            this.MunuadiTXT.Location = new System.Drawing.Point(139, 12);
            this.MunuadiTXT.Name = "MunuadiTXT";
            this.MunuadiTXT.Size = new System.Drawing.Size(318, 26);
            this.MunuadiTXT.StyleController = this.layoutControl1;
            this.MunuadiTXT.TabIndex = 4;
            // 
            // ResimyoluTXT
            // 
            this.ResimyoluTXT.Location = new System.Drawing.Point(139, 72);
            this.ResimyoluTXT.Name = "ResimyoluTXT";
            this.ResimyoluTXT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ResimyoluTXT.Size = new System.Drawing.Size(318, 26);
            this.ResimyoluTXT.StyleController = this.layoutControl1;
            this.ResimyoluTXT.TabIndex = 6;
            this.ResimyoluTXT.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.textEdit3_ButtonClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(469, 585);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.MunuadiTXT;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(449, 30);
            this.layoutControlItem1.Text = "Menü Adı";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(115, 19);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 90);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(449, 475);
            this.emptySpaceItem1.Text = "Resim";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.MenuAciklamaTXT;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(449, 30);
            this.layoutControlItem2.Text = "Menü Açikalama";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(115, 19);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ResimyoluTXT;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(449, 30);
            this.layoutControlItem3.Text = "Resim Yolu";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(115, 19);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(469, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(915, 585);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.KategoriAdi,
            this.Aciklama,
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
            // KategoriAdi
            // 
            this.KategoriAdi.Caption = "Ana Menü Adı";
            this.KategoriAdi.FieldName = "KategoriAdi";
            this.KategoriAdi.Name = "KategoriAdi";
            this.KategoriAdi.OptionsColumn.AllowEdit = false;
            this.KategoriAdi.OptionsColumn.AllowFocus = false;
            this.KategoriAdi.Visible = true;
            this.KategoriAdi.VisibleIndex = 0;
            // 
            // Aciklama
            // 
            this.Aciklama.Caption = "Menü Açıklama";
            this.Aciklama.FieldName = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.OptionsColumn.AllowEdit = false;
            this.Aciklama.OptionsColumn.AllowFocus = false;
            this.Aciklama.Visible = true;
            this.Aciklama.VisibleIndex = 1;
            // 
            // Image
            // 
            this.Image.Caption = "Resim Yolu";
            this.Image.FieldName = "Image";
            this.Image.Name = "Image";
            this.Image.OptionsColumn.AllowEdit = false;
            this.Image.OptionsColumn.AllowFocus = false;
            this.Image.Visible = true;
            this.Image.VisibleIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.crudiSlemler1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 585);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1384, 95);
            this.panel2.TabIndex = 2;
            // 
            // crudiSlemler1
            // 
            this.crudiSlemler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crudiSlemler1.Location = new System.Drawing.Point(0, 0);
            this.crudiSlemler1.Name = "crudiSlemler1";
            this.crudiSlemler1.Size = new System.Drawing.Size(1384, 95);
            this.crudiSlemler1.TabIndex = 0;
            this.crudiSlemler1.KaydetClick += new System.EventHandler(this.crudiSlemler1_KaydetClick);
            this.crudiSlemler1.SecClick += new System.EventHandler(this.crudiSlemler1_SecClick);
            this.crudiSlemler1.SilClick += new System.EventHandler(this.crudiSlemler1_SilClick);
            this.crudiSlemler1.VazgecClick += new System.EventHandler(this.crudiSlemler1_VazgecClick);
            // 
            // Frm_RaporANA_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 680);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_RaporANA_Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_RaporANA_Ekle";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuAciklamaTXT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MunuadiTXT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResimyoluTXT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit MunuadiTXT;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private BSD.RAPOR.Utiles.UI.CrudiSlemler crudiSlemler1;
        private DevExpress.XtraEditors.TextEdit MenuAciklamaTXT;
        private DevExpress.XtraEditors.ButtonEdit ResimyoluTXT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn KategoriAdi;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn Image;
    }
}