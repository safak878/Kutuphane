namespace Kutuphane.Winform.Sınıf
{
    partial class FrmSinif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinif));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlSinif = new DevExpress.XtraGrid.GridControl();
            this.gridSinif = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSinifId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOkulTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSinif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSube = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBolum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSinifAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnSinifGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSinifSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnSinifDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSinifEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlUye = new DevExpress.XtraGrid.GridControl();
            this.layoutUye = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutDurum = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn8 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutTcKimlikNo = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn9 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutOkulNo = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn8_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutAdi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn8_2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutSoyadi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn8_3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutKayitTarihi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn8_4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnUyeGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnUyeSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnUyeDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnUyeEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSinif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSinif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutUye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.labelControl1.Size = new System.Drawing.Size(1285, 54);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Sınıf Listesi";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 54);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlSinif);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlUye);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1285, 733);
            this.splitContainerControl1.SplitterPosition = 298;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControlSinif
            // 
            this.gridControlSinif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSinif.Location = new System.Drawing.Point(0, 0);
            this.gridControlSinif.MainView = this.gridSinif;
            this.gridControlSinif.Name = "gridControlSinif";
            this.gridControlSinif.Size = new System.Drawing.Size(1285, 227);
            this.gridControlSinif.TabIndex = 7;
            this.gridControlSinif.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSinif});
            // 
            // gridSinif
            // 
            this.gridSinif.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSinifId,
            this.colOkulTuru,
            this.colSinif,
            this.colSube,
            this.colBolum,
            this.colSinifAciklama});
            this.gridSinif.GridControl = this.gridControlSinif;
            this.gridSinif.Name = "gridSinif";
            this.gridSinif.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridSinif_FocusedRowChanged);
            // 
            // colSinifId
            // 
            this.colSinifId.Caption = "Id";
            this.colSinifId.FieldName = "Id";
            this.colSinifId.Name = "colSinifId";
            this.colSinifId.OptionsColumn.AllowEdit = false;
            this.colSinifId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOkulTuru
            // 
            this.colOkulTuru.Caption = "Okul Türü";
            this.colOkulTuru.FieldName = "OkulTuru";
            this.colOkulTuru.Name = "colOkulTuru";
            this.colOkulTuru.OptionsColumn.AllowEdit = false;
            this.colOkulTuru.Visible = true;
            this.colOkulTuru.VisibleIndex = 0;
            this.colOkulTuru.Width = 232;
            // 
            // colSinif
            // 
            this.colSinif.Caption = "Sınıf";
            this.colSinif.FieldName = "Sinifi";
            this.colSinif.Name = "colSinif";
            this.colSinif.OptionsColumn.AllowEdit = false;
            this.colSinif.Visible = true;
            this.colSinif.VisibleIndex = 1;
            // 
            // colSube
            // 
            this.colSube.Caption = "Şube";
            this.colSube.FieldName = "Sube";
            this.colSube.Name = "colSube";
            this.colSube.OptionsColumn.AllowEdit = false;
            this.colSube.Visible = true;
            this.colSube.VisibleIndex = 2;
            this.colSube.Width = 76;
            // 
            // colBolum
            // 
            this.colBolum.Caption = "Bölüm";
            this.colBolum.FieldName = "Bolum";
            this.colBolum.Name = "colBolum";
            this.colBolum.OptionsColumn.AllowEdit = false;
            this.colBolum.Visible = true;
            this.colBolum.VisibleIndex = 3;
            this.colBolum.Width = 239;
            // 
            // colSinifAciklama
            // 
            this.colSinifAciklama.Caption = "Açıklama";
            this.colSinifAciklama.FieldName = "Aciklama";
            this.colSinifAciklama.Name = "colSinifAciklama";
            this.colSinifAciklama.OptionsColumn.AllowEdit = false;
            this.colSinifAciklama.Visible = true;
            this.colSinifAciklama.VisibleIndex = 4;
            this.colSinifAciklama.Width = 653;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnSinifGuncelle);
            this.groupControl2.Controls.Add(this.btnSinifSil);
            this.groupControl2.Controls.Add(this.btnSinifDuzenle);
            this.groupControl2.Controls.Add(this.btnSinifEkle);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 227);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1285, 71);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Menü";
            // 
            // btnSinifGuncelle
            // 
            this.btnSinifGuncelle.ImageOptions.ImageIndex = 3;
            this.btnSinifGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnSinifGuncelle.Location = new System.Drawing.Point(335, 24);
            this.btnSinifGuncelle.Name = "btnSinifGuncelle";
            this.btnSinifGuncelle.Size = new System.Drawing.Size(104, 42);
            this.btnSinifGuncelle.TabIndex = 0;
            this.btnSinifGuncelle.Text = "Güncelle";
            this.btnSinifGuncelle.Click += new System.EventHandler(this.btnSinifGuncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "user_add.png");
            this.ımageList1.Images.SetKeyName(1, "user_delete.png");
            this.ımageList1.Images.SetKeyName(2, "user_edit.png");
            this.ımageList1.Images.SetKeyName(3, "refresh.png");
            this.ımageList1.Images.SetKeyName(4, "folder_out.png");
            // 
            // btnSinifSil
            // 
            this.btnSinifSil.ImageOptions.ImageIndex = 1;
            this.btnSinifSil.ImageOptions.ImageList = this.ımageList1;
            this.btnSinifSil.Location = new System.Drawing.Point(225, 23);
            this.btnSinifSil.Name = "btnSinifSil";
            this.btnSinifSil.Size = new System.Drawing.Size(104, 42);
            this.btnSinifSil.TabIndex = 0;
            this.btnSinifSil.Text = "Sil";
            this.btnSinifSil.Click += new System.EventHandler(this.btnSinifSil_Click);
            // 
            // btnSinifDuzenle
            // 
            this.btnSinifDuzenle.ImageOptions.ImageIndex = 2;
            this.btnSinifDuzenle.ImageOptions.ImageList = this.ımageList1;
            this.btnSinifDuzenle.Location = new System.Drawing.Point(115, 23);
            this.btnSinifDuzenle.Name = "btnSinifDuzenle";
            this.btnSinifDuzenle.Size = new System.Drawing.Size(104, 42);
            this.btnSinifDuzenle.TabIndex = 0;
            this.btnSinifDuzenle.Text = "Düzenle";
            this.btnSinifDuzenle.Click += new System.EventHandler(this.btnSinifDuzenle_Click);
            // 
            // btnSinifEkle
            // 
            this.btnSinifEkle.ImageOptions.ImageIndex = 0;
            this.btnSinifEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnSinifEkle.Location = new System.Drawing.Point(5, 23);
            this.btnSinifEkle.Name = "btnSinifEkle";
            this.btnSinifEkle.Size = new System.Drawing.Size(104, 42);
            this.btnSinifEkle.TabIndex = 0;
            this.btnSinifEkle.Text = "Ekle";
            this.btnSinifEkle.Click += new System.EventHandler(this.btnSinifEkle_Click);
            // 
            // gridControlUye
            // 
            this.gridControlUye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUye.Location = new System.Drawing.Point(0, 0);
            this.gridControlUye.MainView = this.layoutUye;
            this.gridControlUye.Name = "gridControlUye";
            this.gridControlUye.Size = new System.Drawing.Size(1285, 359);
            this.gridControlUye.TabIndex = 6;
            this.gridControlUye.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutUye});
            // 
            // layoutUye
            // 
            this.layoutUye.CardCaptionFormat = "Kayıt {0}/{1}";
            this.layoutUye.CardMinSize = new System.Drawing.Size(252, 177);
            this.layoutUye.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutDurum,
            this.layoutTcKimlikNo,
            this.layoutOkulNo,
            this.layoutAdi,
            this.layoutSoyadi,
            this.layoutKayitTarihi});
            this.layoutUye.GridControl = this.gridControlUye;
            this.layoutUye.Name = "layoutUye";
            this.layoutUye.OptionsItemText.TextToControlDistance = 3;
            this.layoutUye.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn;
            this.layoutUye.TemplateCard = this.layoutViewCard2;
            // 
            // layoutDurum
            // 
            this.layoutDurum.Caption = "Durumu";
            this.layoutDurum.FieldName = "Durum";
            this.layoutDurum.LayoutViewField = this.layoutViewField_layoutViewColumn8;
            this.layoutDurum.Name = "layoutDurum";
            // 
            // layoutViewField_layoutViewColumn8
            // 
            this.layoutViewField_layoutViewColumn8.EditorPreferredWidth = 164;
            this.layoutViewField_layoutViewColumn8.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn8.Name = "layoutViewField_layoutViewColumn8";
            this.layoutViewField_layoutViewColumn8.Size = new System.Drawing.Size(240, 24);
            this.layoutViewField_layoutViewColumn8.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutTcKimlikNo
            // 
            this.layoutTcKimlikNo.Caption = "T.C. Kimlik No";
            this.layoutTcKimlikNo.LayoutViewField = this.layoutViewField_layoutViewColumn9;
            this.layoutTcKimlikNo.Name = "layoutTcKimlikNo";
            // 
            // layoutViewField_layoutViewColumn9
            // 
            this.layoutViewField_layoutViewColumn9.EditorPreferredWidth = 164;
            this.layoutViewField_layoutViewColumn9.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_layoutViewColumn9.Name = "layoutViewField_layoutViewColumn9";
            this.layoutViewField_layoutViewColumn9.Size = new System.Drawing.Size(240, 24);
            this.layoutViewField_layoutViewColumn9.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutOkulNo
            // 
            this.layoutOkulNo.Caption = "Okul No";
            this.layoutOkulNo.FieldName = "OkulNo";
            this.layoutOkulNo.LayoutViewField = this.layoutViewField_layoutViewColumn8_1;
            this.layoutOkulNo.Name = "layoutOkulNo";
            // 
            // layoutViewField_layoutViewColumn8_1
            // 
            this.layoutViewField_layoutViewColumn8_1.EditorPreferredWidth = 164;
            this.layoutViewField_layoutViewColumn8_1.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_layoutViewColumn8_1.Name = "layoutViewField_layoutViewColumn8_1";
            this.layoutViewField_layoutViewColumn8_1.Size = new System.Drawing.Size(240, 24);
            this.layoutViewField_layoutViewColumn8_1.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutAdi
            // 
            this.layoutAdi.Caption = "Adı";
            this.layoutAdi.FieldName = "Adi";
            this.layoutAdi.LayoutViewField = this.layoutViewField_layoutViewColumn8_2;
            this.layoutAdi.Name = "layoutAdi";
            // 
            // layoutViewField_layoutViewColumn8_2
            // 
            this.layoutViewField_layoutViewColumn8_2.EditorPreferredWidth = 164;
            this.layoutViewField_layoutViewColumn8_2.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_layoutViewColumn8_2.Name = "layoutViewField_layoutViewColumn8_2";
            this.layoutViewField_layoutViewColumn8_2.Size = new System.Drawing.Size(240, 24);
            this.layoutViewField_layoutViewColumn8_2.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutSoyadi
            // 
            this.layoutSoyadi.Caption = "Soyadı";
            this.layoutSoyadi.FieldName = "Soyadi";
            this.layoutSoyadi.LayoutViewField = this.layoutViewField_layoutViewColumn8_3;
            this.layoutSoyadi.Name = "layoutSoyadi";
            // 
            // layoutViewField_layoutViewColumn8_3
            // 
            this.layoutViewField_layoutViewColumn8_3.EditorPreferredWidth = 164;
            this.layoutViewField_layoutViewColumn8_3.Location = new System.Drawing.Point(0, 96);
            this.layoutViewField_layoutViewColumn8_3.Name = "layoutViewField_layoutViewColumn8_3";
            this.layoutViewField_layoutViewColumn8_3.Size = new System.Drawing.Size(240, 24);
            this.layoutViewField_layoutViewColumn8_3.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutKayitTarihi
            // 
            this.layoutKayitTarihi.Caption = "Kayıt Tarihi";
            this.layoutKayitTarihi.FieldName = "KayitTarihi";
            this.layoutKayitTarihi.LayoutViewField = this.layoutViewField_layoutViewColumn8_4;
            this.layoutKayitTarihi.Name = "layoutKayitTarihi";
            // 
            // layoutViewField_layoutViewColumn8_4
            // 
            this.layoutViewField_layoutViewColumn8_4.EditorPreferredWidth = 164;
            this.layoutViewField_layoutViewColumn8_4.Location = new System.Drawing.Point(0, 120);
            this.layoutViewField_layoutViewColumn8_4.Name = "layoutViewField_layoutViewColumn8_4";
            this.layoutViewField_layoutViewColumn8_4.Size = new System.Drawing.Size(240, 27);
            this.layoutViewField_layoutViewColumn8_4.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutViewCard2
            // 
            this.layoutViewCard2.CustomizationFormText = "TemplateCard";
            this.layoutViewCard2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn8,
            this.layoutViewField_layoutViewColumn9,
            this.layoutViewField_layoutViewColumn8_1,
            this.layoutViewField_layoutViewColumn8_2,
            this.layoutViewField_layoutViewColumn8_3,
            this.layoutViewField_layoutViewColumn8_4});
            this.layoutViewCard2.Name = "layoutViewCard2";
            this.layoutViewCard2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutViewCard2.Text = "TemplateCard";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnUyeGuncelle);
            this.groupControl1.Controls.Add(this.btnUyeSil);
            this.groupControl1.Controls.Add(this.btnUyeDuzenle);
            this.groupControl1.Controls.Add(this.btnUyeEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 359);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1285, 71);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 4;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1176, 24);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(104, 42);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnUyeGuncelle
            // 
            this.btnUyeGuncelle.ImageOptions.ImageIndex = 3;
            this.btnUyeGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnUyeGuncelle.Location = new System.Drawing.Point(335, 24);
            this.btnUyeGuncelle.Name = "btnUyeGuncelle";
            this.btnUyeGuncelle.Size = new System.Drawing.Size(104, 42);
            this.btnUyeGuncelle.TabIndex = 0;
            this.btnUyeGuncelle.Text = "Güncelle";
            this.btnUyeGuncelle.Click += new System.EventHandler(this.btnUyeGuncelle_Click);
            // 
            // btnUyeSil
            // 
            this.btnUyeSil.ImageOptions.ImageIndex = 1;
            this.btnUyeSil.ImageOptions.ImageList = this.ımageList1;
            this.btnUyeSil.Location = new System.Drawing.Point(225, 23);
            this.btnUyeSil.Name = "btnUyeSil";
            this.btnUyeSil.Size = new System.Drawing.Size(104, 42);
            this.btnUyeSil.TabIndex = 0;
            this.btnUyeSil.Text = "Sil";
            this.btnUyeSil.Click += new System.EventHandler(this.btnUyeSil_Click);
            // 
            // btnUyeDuzenle
            // 
            this.btnUyeDuzenle.ImageOptions.ImageIndex = 2;
            this.btnUyeDuzenle.ImageOptions.ImageList = this.ımageList1;
            this.btnUyeDuzenle.Location = new System.Drawing.Point(115, 23);
            this.btnUyeDuzenle.Name = "btnUyeDuzenle";
            this.btnUyeDuzenle.Size = new System.Drawing.Size(104, 42);
            this.btnUyeDuzenle.TabIndex = 0;
            this.btnUyeDuzenle.Text = "Düzenle";
            this.btnUyeDuzenle.Click += new System.EventHandler(this.btnUyeDuzenle_Click);
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.ImageOptions.ImageIndex = 0;
            this.btnUyeEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnUyeEkle.Location = new System.Drawing.Point(5, 23);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(104, 42);
            this.btnUyeEkle.TabIndex = 0;
            this.btnUyeEkle.Text = "Ekle";
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // FrmSinif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 787);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmSinif";
            this.Text = "FrmSinif";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSinif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSinif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutUye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlSinif;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSinif;
        private DevExpress.XtraGrid.Columns.GridColumn colSinifId;
        private DevExpress.XtraGrid.Columns.GridColumn colOkulTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colSinif;
        private DevExpress.XtraGrid.Columns.GridColumn colSube;
        private DevExpress.XtraGrid.Columns.GridColumn colBolum;
        private DevExpress.XtraGrid.Columns.GridColumn colSinifAciklama;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnSinifGuncelle;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnSinifSil;
        private DevExpress.XtraEditors.SimpleButton btnSinifDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnSinifEkle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnUyeGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnUyeSil;
        private DevExpress.XtraEditors.SimpleButton btnUyeDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnUyeEkle;
        private DevExpress.XtraGrid.GridControl gridControlUye;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutUye;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutDurum;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn8;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutTcKimlikNo;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn9;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutOkulNo;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn8_1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutAdi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn8_2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutSoyadi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn8_3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutKayitTarihi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn8_4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard2;
    }
}