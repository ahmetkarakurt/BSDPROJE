
namespace BSDPROJE.BackOffice.IsTakip
{
    partial class FrmBirimAltGrup
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
            this.panelAlt = new System.Windows.Forms.Panel();
            this.crudiSlemler1 = new BSD.RAPOR.Utiles.UI.CrudiSlemler();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAltBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAltBirimAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.altBirimtxt = new DevExpress.XtraEditors.TextEdit();
            this.UstGrubcb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.altbirimAciklamatxt = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelUst = new System.Windows.Forms.Panel();
            this.panelAlt.SuspendLayout();
            this.panelOrta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altBirimtxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UstGrubcb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altbirimAciklamatxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.panelUst.SuspendLayout();
            this.SuspendLayout();
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
            this.crudiSlemler1.VazgecClick += new System.EventHandler(this.crudiSlemler1_VazgecClick);
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
            this.gridId,
            this.gridBirim,
            this.gridAltBirim,
            this.gridAltBirimAciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridId
            // 
            this.gridId.Caption = "Id";
            this.gridId.FieldName = "Id";
            this.gridId.Name = "gridId";
            // 
            // gridBirim
            // 
            this.gridBirim.Caption = "Bağlı Birim";
            this.gridBirim.FieldName = "Birim";
            this.gridBirim.Name = "gridBirim";
            this.gridBirim.OptionsColumn.AllowEdit = false;
            this.gridBirim.OptionsColumn.AllowFocus = false;
            this.gridBirim.Visible = true;
            this.gridBirim.VisibleIndex = 0;
            // 
            // gridAltBirim
            // 
            this.gridAltBirim.Caption = "AltBirim";
            this.gridAltBirim.FieldName = "AltBirim";
            this.gridAltBirim.Name = "gridAltBirim";
            this.gridAltBirim.OptionsColumn.AllowEdit = false;
            this.gridAltBirim.OptionsColumn.AllowFocus = false;
            this.gridAltBirim.Visible = true;
            this.gridAltBirim.VisibleIndex = 1;
            // 
            // gridAltBirimAciklama
            // 
            this.gridAltBirimAciklama.Caption = "Birim Açıklaması";
            this.gridAltBirimAciklama.FieldName = "AltBirimAciklama";
            this.gridAltBirimAciklama.Name = "gridAltBirimAciklama";
            this.gridAltBirimAciklama.OptionsColumn.AllowEdit = false;
            this.gridAltBirimAciklama.OptionsColumn.AllowFocus = false;
            this.gridAltBirimAciklama.Visible = true;
            this.gridAltBirimAciklama.VisibleIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.altBirimtxt);
            this.layoutControl1.Controls.Add(this.UstGrubcb);
            this.layoutControl1.Controls.Add(this.altbirimAciklamatxt);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1090, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(728, 122);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // altBirimtxt
            // 
            this.altBirimtxt.Location = new System.Drawing.Point(149, 42);
            this.altBirimtxt.Name = "altBirimtxt";
            this.altBirimtxt.Size = new System.Drawing.Size(567, 26);
            this.altBirimtxt.StyleController = this.layoutControl1;
            this.altBirimtxt.TabIndex = 5;
            // 
            // UstGrubcb
            // 
            this.UstGrubcb.Location = new System.Drawing.Point(149, 12);
            this.UstGrubcb.Name = "UstGrubcb";
            this.UstGrubcb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UstGrubcb.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.UstGrubcb.Size = new System.Drawing.Size(567, 26);
            this.UstGrubcb.StyleController = this.layoutControl1;
            this.UstGrubcb.TabIndex = 4;
            // 
            // altbirimAciklamatxt
            // 
            this.altbirimAciklamatxt.Location = new System.Drawing.Point(149, 72);
            this.altbirimAciklamatxt.Name = "altbirimAciklamatxt";
            this.altbirimAciklamatxt.Size = new System.Drawing.Size(567, 26);
            this.altbirimAciklamatxt.StyleController = this.layoutControl1;
            this.altbirimAciklamatxt.TabIndex = 6;
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
            this.layoutControlItem1.Control = this.UstGrubcb;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(708, 30);
            this.layoutControlItem1.Text = "Üst Birim Grubu :";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(125, 19);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.altBirimtxt;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(708, 30);
            this.layoutControlItem2.Text = "Alt Birim :";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(125, 19);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.altbirimAciklamatxt;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(708, 42);
            this.layoutControlItem3.Text = "Birim Açıklama :";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(125, 19);
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
            // FrmBirimAltGrup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 573);
            this.Controls.Add(this.panelOrta);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.panelUst);
            this.KeyPreview = true;
            this.Name = "FrmBirimAltGrup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBirimAltGrup";
            this.panelAlt.ResumeLayout(false);
            this.panelOrta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.altBirimtxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UstGrubcb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altbirimAciklamatxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.panelUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAlt;
        private BSD.RAPOR.Utiles.UI.CrudiSlemler crudiSlemler1;
        private System.Windows.Forms.Panel panelOrta;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit altBirimtxt;
        private DevExpress.XtraEditors.ComboBoxEdit UstGrubcb;
        private DevExpress.XtraEditors.TextEdit altbirimAciklamatxt;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.Panel panelUst;
        private DevExpress.XtraGrid.Columns.GridColumn gridId;
        private DevExpress.XtraGrid.Columns.GridColumn gridBirim;
        private DevExpress.XtraGrid.Columns.GridColumn gridAltBirim;
        private DevExpress.XtraGrid.Columns.GridColumn gridAltBirimAciklama;
    }
}