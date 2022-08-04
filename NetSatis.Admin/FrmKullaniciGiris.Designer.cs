namespace NetSatis.Admin
{
    partial class FrmKullaniciGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciGiris));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.cmbDonem = new DevExpress.XtraEditors.ComboBoxEdit();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.cmbSube = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ckHatirla = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDonem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckHatirla.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.Appearance.Image")));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseImage = true;
            this.lblBaslik.Appearance.Options.UseImageAlign = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(717, 85);
            this.lblBaslik.TabIndex = 8;
            this.lblBaslik.Text = "Kullanıcılar";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(249, 155);
            this.txtParola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Properties.Appearance.Options.UseFont = true;
            this.txtParola.Properties.Appearance.Options.UseImage = true;
            this.txtParola.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtParola.Properties.ContextImageOptions.Image")));
            this.txtParola.Properties.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(430, 36);
            this.txtParola.TabIndex = 1;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "key_warning.png");
            this.ımageList1.Images.SetKeyName(1, "key_ok.png");
            this.ımageList1.Images.SetKeyName(2, "folder_out.png");
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(249, 94);
            this.txtKullanici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanici.Properties.Appearance.Options.UseFont = true;
            this.txtKullanici.Properties.Appearance.Options.UseImage = true;
            this.txtKullanici.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtKullanici.Properties.ContextImageOptions.Image")));
            this.txtKullanici.Size = new System.Drawing.Size(430, 36);
            this.txtKullanici.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.ImageIndex = 1;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(32, 34);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(138, 63);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Giriş";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.ImageIndex = 0;
            this.simpleButton1.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton1.Location = new System.Drawing.Point(178, 35);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(138, 63);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Parolamı\r\nUnuttum";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.ImageOptions.ImageIndex = 2;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(326, 35);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(138, 63);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.simpleButton1);
            this.grpMenu.Controls.Add(this.btnKaydet);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(240, 384);
            this.grpMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(477, 105);
            this.grpMenu.TabIndex = 9;
            this.grpMenu.Text = "Menü";
            // 
            // cmbDonem
            // 
            this.cmbDonem.Location = new System.Drawing.Point(249, 216);
            this.cmbDonem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDonem.Name = "cmbDonem";
            this.cmbDonem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDonem.Properties.Appearance.Options.UseFont = true;
            this.cmbDonem.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDonem.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbDonem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDonem.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmbDonem.Properties.ContextImageOptions.Image")));
            this.cmbDonem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbDonem.Size = new System.Drawing.Size(430, 36);
            this.cmbDonem.TabIndex = 2;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // cmbSube
            // 
            this.cmbSube.EditValue = "Şube Seç";
            this.cmbSube.Location = new System.Drawing.Point(249, 342);
            this.cmbSube.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSube.Name = "cmbSube";
            this.cmbSube.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.75F, System.Drawing.FontStyle.Bold);
            this.cmbSube.Properties.Appearance.Options.UseFont = true;
            this.cmbSube.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSube.Properties.NullText = "[EditValue is null]";
            this.cmbSube.Properties.PopupSizeable = true;
            this.cmbSube.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbSube.Size = new System.Drawing.Size(430, 34);
            this.cmbSube.TabIndex = 4;
            this.cmbSube.Visible = false;
            // 
            // ckHatirla
            // 
            this.ckHatirla.Location = new System.Drawing.Point(249, 279);
            this.ckHatirla.Name = "ckHatirla";
            this.ckHatirla.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.ckHatirla.Properties.Appearance.Options.UseFont = true;
            this.ckHatirla.Properties.Caption = "Beni Hatırla";
            this.ckHatirla.Size = new System.Drawing.Size(430, 29);
            this.ckHatirla.TabIndex = 3;
            this.ckHatirla.CheckedChanged += new System.EventHandler(this.ckHatirla_CheckedChanged);
            // 
            // FrmKullaniciGiris
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(717, 489);
            this.Controls.Add(this.ckHatirla);
            this.Controls.Add(this.cmbDonem);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.cmbSube);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmKullaniciGiris_FormClosed);
            this.Load += new System.EventHandler(this.FrmKullaniciGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbDonem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckHatirla.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.TextEdit txtKullanici;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDonem;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSube;
        private DevExpress.XtraEditors.CheckEdit ckHatirla;
    }
}