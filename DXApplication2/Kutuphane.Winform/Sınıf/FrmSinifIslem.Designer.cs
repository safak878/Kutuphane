namespace Kutuphane.Winform.Sınıf
{
    partial class FrmSinifIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinifIslem));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSube = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSinif = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtBolum = new DevExpress.XtraEditors.ButtonEdit();
            this.txtOkulTuru = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtSinifAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupMenu)).BeginInit();
            this.groupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBolum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOkulTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinifAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseImage = true;
            this.labelControl1.Appearance.Options.UseImageAlign = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(702, 54);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Kitap Listesi";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "delete.png");
            this.ımageList1.Images.SetKeyName(2, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(3, "floppy_disk_delete.png");
            this.ımageList1.Images.SetKeyName(4, "folder_out.png");
            this.ımageList1.Images.SetKeyName(5, "pencil.png");
            // 
            // groupMenu
            // 
            this.groupMenu.Controls.Add(this.btnKapat);
            this.groupMenu.Controls.Add(this.btnKaydet);
            this.groupMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupMenu.Location = new System.Drawing.Point(0, 295);
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.Size = new System.Drawing.Size(702, 71);
            this.groupMenu.TabIndex = 3;
            this.groupMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 4;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(589, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(104, 42);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.ImageIndex = 2;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(479, 23);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(104, 42);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtSube);
            this.groupControl1.Controls.Add(this.txtSinif);
            this.groupControl1.Controls.Add(this.txtBolum);
            this.groupControl1.Controls.Add(this.txtOkulTuru);
            this.groupControl1.Controls.Add(this.labelControl17);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.txtSinifAciklama);
            this.groupControl1.Controls.Add(this.labelControl18);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 54);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(702, 241);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Sınıf Bilgileri";
            // 
            // txtSube
            // 
            this.txtSube.Location = new System.Drawing.Point(135, 75);
            this.txtSube.Name = "txtSube";
            this.txtSube.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSube.Properties.Items.AddRange(new object[] {
            "A Şubesi",
            "B Şubesi",
            "C Şubesi",
            "D Şubesi"});
            this.txtSube.Size = new System.Drawing.Size(365, 20);
            this.txtSube.TabIndex = 13;
            // 
            // txtSinif
            // 
            this.txtSinif.Location = new System.Drawing.Point(136, 49);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSinif.Properties.Items.AddRange(new object[] {
            "9. Sınıf",
            "10. Sınıf",
            "11. Sınıf",
            "12. Sınıf"});
            this.txtSinif.Size = new System.Drawing.Size(365, 20);
            this.txtSinif.TabIndex = 13;
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(135, 101);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtBolum.Size = new System.Drawing.Size(366, 20);
            this.txtBolum.TabIndex = 12;
            this.txtBolum.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtBolum_ButtonClick);
            // 
            // txtOkulTuru
            // 
            this.txtOkulTuru.Location = new System.Drawing.Point(136, 24);
            this.txtOkulTuru.Name = "txtOkulTuru";
            this.txtOkulTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtOkulTuru.Size = new System.Drawing.Size(365, 20);
            this.txtOkulTuru.TabIndex = 12;
            this.txtOkulTuru.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtOkulTuru_ButtonClick);
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Options.UseTextOptions = true;
            this.labelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl17.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl17.Location = new System.Drawing.Point(5, 75);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(124, 20);
            this.labelControl17.TabIndex = 3;
            this.labelControl17.Text = "Şubesi :";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Options.UseTextOptions = true;
            this.labelControl16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl16.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl16.Location = new System.Drawing.Point(5, 101);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(124, 20);
            this.labelControl16.TabIndex = 4;
            this.labelControl16.Text = "Bölümü :";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Options.UseTextOptions = true;
            this.labelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl15.Location = new System.Drawing.Point(5, 49);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(124, 20);
            this.labelControl15.TabIndex = 5;
            this.labelControl15.Text = "Sınıfı :";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Options.UseTextOptions = true;
            this.labelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl14.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl14.Location = new System.Drawing.Point(5, 23);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(124, 20);
            this.labelControl14.TabIndex = 6;
            this.labelControl14.Text = "Okul Türü :";
            // 
            // txtSinifAciklama
            // 
            this.txtSinifAciklama.Location = new System.Drawing.Point(135, 128);
            this.txtSinifAciklama.Name = "txtSinifAciklama";
            this.txtSinifAciklama.Size = new System.Drawing.Size(569, 102);
            this.txtSinifAciklama.TabIndex = 11;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Options.UseTextOptions = true;
            this.labelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl18.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl18.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl18.Location = new System.Drawing.Point(5, 127);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(124, 103);
            this.labelControl18.TabIndex = 7;
            this.labelControl18.Text = "Açıklama :";
            // 
            // FrmSinifIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 366);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupMenu);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSinifIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınıf İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.groupMenu)).EndInit();
            this.groupMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBolum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOkulTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinifAciklama.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.GroupControl groupMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ButtonEdit txtOkulTuru;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.MemoEdit txtSinifAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.ButtonEdit txtBolum;
        private DevExpress.XtraEditors.ComboBoxEdit txtSube;
        private DevExpress.XtraEditors.ComboBoxEdit txtSinif;
    }
}