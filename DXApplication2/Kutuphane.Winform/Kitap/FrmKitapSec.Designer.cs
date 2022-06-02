namespace Kutuphane.Winform.Kitap
{
    partial class FrmKitapSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitapSec));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControlKitap = new DevExpress.XtraGrid.GridControl();
            this.gridKitap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOduncVerilebilir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYayinEvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaskiSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBasimYili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCiltSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSayfaSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBasimYeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDemirbasNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControlBarkod = new DevExpress.XtraGrid.GridControl();
            this.gridBarkod = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKondisyon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRatingControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemRatingControl();
            this.colSalon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDolap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupMenu)).BeginInit();
            this.groupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).BeginInit();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBarkod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarkod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.Appearance.Image")));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseImage = true;
            this.lblBaslik.Appearance.Options.UseImageAlign = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1073, 54);
            this.lblBaslik.TabIndex = 5;
            this.lblBaslik.Text = "Lütfen Bir Kitap Seçin";
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
            this.groupMenu.Controls.Add(this.simpleButton1);
            this.groupMenu.Controls.Add(this.btnKaydet);
            this.groupMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupMenu.Location = new System.Drawing.Point(0, 596);
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.Size = new System.Drawing.Size(1073, 71);
            this.groupMenu.TabIndex = 6;
            this.groupMenu.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 4;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(960, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(104, 42);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageIndex = 2;
            this.simpleButton1.Location = new System.Drawing.Point(5, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 42);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Geri Dön";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.ImageOptions.ImageIndex = 2;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(850, 23);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(104, 42);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Seç";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 54);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationFrame1.SelectedPage = this.navigationPage1;
            this.navigationFrame1.Size = new System.Drawing.Size(1073, 542);
            this.navigationFrame1.TabIndex = 8;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.gridControlKitap);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1073, 542);
            // 
            // gridControlKitap
            // 
            this.gridControlKitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKitap.Location = new System.Drawing.Point(0, 0);
            this.gridControlKitap.MainView = this.gridKitap;
            this.gridControlKitap.Name = "gridControlKitap";
            this.gridControlKitap.Size = new System.Drawing.Size(1073, 542);
            this.gridControlKitap.TabIndex = 3;
            this.gridControlKitap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKitap});
            // 
            // gridKitap
            // 
            this.gridKitap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDurum,
            this.colOduncVerilebilir,
            this.colKitapKodu,
            this.colKitapAdi,
            this.colISBN,
            this.colYayinEvi,
            this.colBaskiSayisi,
            this.colBasimYili,
            this.colCiltSayisi,
            this.colSayfaSayisi,
            this.colBasimYeri,
            this.colDemirbasNo,
            this.colAciklama,
            this.colId});
            this.gridKitap.GridControl = this.gridControlKitap;
            this.gridKitap.Name = "gridKitap";
            // 
            // colDurum
            // 
            this.colDurum.Caption = "Durumu";
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.OptionsColumn.AllowEdit = false;
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 0;
            this.colDurum.Width = 57;
            // 
            // colOduncVerilebilir
            // 
            this.colOduncVerilebilir.Caption = "Ödünç Verilebilir";
            this.colOduncVerilebilir.FieldName = "OduncVerilebilir";
            this.colOduncVerilebilir.Name = "colOduncVerilebilir";
            this.colOduncVerilebilir.OptionsColumn.AllowEdit = false;
            this.colOduncVerilebilir.Visible = true;
            this.colOduncVerilebilir.VisibleIndex = 1;
            this.colOduncVerilebilir.Width = 81;
            // 
            // colKitapKodu
            // 
            this.colKitapKodu.Caption = "Kitap Kodu";
            this.colKitapKodu.FieldName = "KitapKodu";
            this.colKitapKodu.Name = "colKitapKodu";
            this.colKitapKodu.OptionsColumn.AllowEdit = false;
            this.colKitapKodu.Visible = true;
            this.colKitapKodu.VisibleIndex = 2;
            this.colKitapKodu.Width = 102;
            // 
            // colKitapAdi
            // 
            this.colKitapAdi.Caption = "Kitap Adı";
            this.colKitapAdi.FieldName = "KitapAdi";
            this.colKitapAdi.Name = "colKitapAdi";
            this.colKitapAdi.OptionsColumn.AllowEdit = false;
            this.colKitapAdi.Visible = true;
            this.colKitapAdi.VisibleIndex = 3;
            this.colKitapAdi.Width = 249;
            // 
            // colISBN
            // 
            this.colISBN.Caption = "ISBN";
            this.colISBN.FieldName = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.OptionsColumn.AllowEdit = false;
            this.colISBN.Visible = true;
            this.colISBN.VisibleIndex = 5;
            this.colISBN.Width = 154;
            // 
            // colYayinEvi
            // 
            this.colYayinEvi.Caption = "Yayın Evi";
            this.colYayinEvi.FieldName = "YayinEvi";
            this.colYayinEvi.Name = "colYayinEvi";
            this.colYayinEvi.OptionsColumn.AllowEdit = false;
            this.colYayinEvi.Visible = true;
            this.colYayinEvi.VisibleIndex = 4;
            this.colYayinEvi.Width = 152;
            // 
            // colBaskiSayisi
            // 
            this.colBaskiSayisi.Caption = "Baskı Sayısı";
            this.colBaskiSayisi.FieldName = "BaskiSayisi";
            this.colBaskiSayisi.Name = "colBaskiSayisi";
            this.colBaskiSayisi.OptionsColumn.AllowEdit = false;
            this.colBaskiSayisi.Visible = true;
            this.colBaskiSayisi.VisibleIndex = 7;
            this.colBaskiSayisi.Width = 58;
            // 
            // colBasimYili
            // 
            this.colBasimYili.Caption = "Basım Yılı";
            this.colBasimYili.FieldName = "BasimYili";
            this.colBasimYili.Name = "colBasimYili";
            this.colBasimYili.OptionsColumn.AllowEdit = false;
            this.colBasimYili.Visible = true;
            this.colBasimYili.VisibleIndex = 8;
            this.colBasimYili.Width = 55;
            // 
            // colCiltSayisi
            // 
            this.colCiltSayisi.Caption = "Cilt Sayısı";
            this.colCiltSayisi.FieldName = "CiltSayisi";
            this.colCiltSayisi.Name = "colCiltSayisi";
            this.colCiltSayisi.OptionsColumn.AllowEdit = false;
            this.colCiltSayisi.Visible = true;
            this.colCiltSayisi.VisibleIndex = 9;
            this.colCiltSayisi.Width = 56;
            // 
            // colSayfaSayisi
            // 
            this.colSayfaSayisi.Caption = "Sayfa Sayısı";
            this.colSayfaSayisi.FieldName = "SayfaSayisi";
            this.colSayfaSayisi.Name = "colSayfaSayisi";
            this.colSayfaSayisi.OptionsColumn.AllowEdit = false;
            this.colSayfaSayisi.Visible = true;
            this.colSayfaSayisi.VisibleIndex = 10;
            this.colSayfaSayisi.Width = 63;
            // 
            // colBasimYeri
            // 
            this.colBasimYeri.Caption = "Basım Yeri";
            this.colBasimYeri.FieldName = "BasimYeri";
            this.colBasimYeri.Name = "colBasimYeri";
            this.colBasimYeri.OptionsColumn.AllowEdit = false;
            this.colBasimYeri.Visible = true;
            this.colBasimYeri.VisibleIndex = 11;
            this.colBasimYeri.Width = 58;
            // 
            // colDemirbasNo
            // 
            this.colDemirbasNo.Caption = "Demirbaş No";
            this.colDemirbasNo.FieldName = "DemirbasNo";
            this.colDemirbasNo.Name = "colDemirbasNo";
            this.colDemirbasNo.OptionsColumn.AllowEdit = false;
            this.colDemirbasNo.Visible = true;
            this.colDemirbasNo.VisibleIndex = 6;
            this.colDemirbasNo.Width = 74;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 12;
            this.colAciklama.Width = 116;
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Controls.Add(this.gridControlBarkod);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(1073, 542);
            // 
            // gridControlBarkod
            // 
            this.gridControlBarkod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBarkod.Location = new System.Drawing.Point(0, 0);
            this.gridControlBarkod.MainView = this.gridBarkod;
            this.gridControlBarkod.Name = "gridControlBarkod";
            this.gridControlBarkod.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRatingControl1});
            this.gridControlBarkod.Size = new System.Drawing.Size(1073, 542);
            this.gridControlBarkod.TabIndex = 2;
            this.gridControlBarkod.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridBarkod});
            // 
            // gridBarkod
            // 
            this.gridBarkod.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBarkod,
            this.colKondisyon,
            this.colSalon,
            this.colDolap,
            this.colRaf,
            this.colSira,
            this.layoutViewColumn1});
            this.gridBarkod.GridControl = this.gridControlBarkod;
            this.gridBarkod.Name = "gridBarkod";
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "Barkodu";
            this.colBarkod.FieldName = "Barkodu";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 0;
            // 
            // colKondisyon
            // 
            this.colKondisyon.Caption = "Kondisyon";
            this.colKondisyon.ColumnEdit = this.repositoryItemRatingControl1;
            this.colKondisyon.FieldName = "Kondisyon";
            this.colKondisyon.Name = "colKondisyon";
            this.colKondisyon.OptionsColumn.AllowEdit = false;
            this.colKondisyon.Visible = true;
            this.colKondisyon.VisibleIndex = 1;
            // 
            // repositoryItemRatingControl1
            // 
            this.repositoryItemRatingControl1.AutoHeight = false;
            this.repositoryItemRatingControl1.Name = "repositoryItemRatingControl1";
            // 
            // colSalon
            // 
            this.colSalon.Caption = "Salon";
            this.colSalon.FieldName = "Salon";
            this.colSalon.Name = "colSalon";
            this.colSalon.OptionsColumn.AllowEdit = false;
            this.colSalon.Visible = true;
            this.colSalon.VisibleIndex = 2;
            // 
            // colDolap
            // 
            this.colDolap.Caption = "Dolap";
            this.colDolap.FieldName = "Dolap";
            this.colDolap.Name = "colDolap";
            this.colDolap.OptionsColumn.AllowEdit = false;
            this.colDolap.Visible = true;
            this.colDolap.VisibleIndex = 3;
            // 
            // colRaf
            // 
            this.colRaf.Caption = "Raf";
            this.colRaf.FieldName = "Raf";
            this.colRaf.Name = "colRaf";
            this.colRaf.OptionsColumn.AllowEdit = false;
            this.colRaf.Visible = true;
            this.colRaf.VisibleIndex = 4;
            // 
            // colSira
            // 
            this.colSira.Caption = "Sıra";
            this.colSira.FieldName = "Sira";
            this.colSira.Name = "colSira";
            this.colSira.OptionsColumn.AllowEdit = false;
            this.colSira.Visible = true;
            this.colSira.VisibleIndex = 5;
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.Caption = "Id";
            this.layoutViewColumn1.FieldName = "Id";
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            this.layoutViewColumn1.OptionsColumn.AllowEdit = false;
            this.layoutViewColumn1.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // FrmKitapSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 667);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.groupMenu);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKitapSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Seçim Formu";
            ((System.ComponentModel.ISupportInitialize)(this.groupMenu)).EndInit();
            this.groupMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBarkod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarkod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.GroupControl groupMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraGrid.GridControl gridControlKitap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKitap;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colOduncVerilebilir;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colISBN;
        private DevExpress.XtraGrid.Columns.GridColumn colYayinEvi;
        private DevExpress.XtraGrid.Columns.GridColumn colBaskiSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colBasimYili;
        private DevExpress.XtraGrid.Columns.GridColumn colCiltSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colSayfaSayisi;
        private DevExpress.XtraGrid.Columns.GridColumn colBasimYeri;
        private DevExpress.XtraGrid.Columns.GridColumn colDemirbasNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControlBarkod;
        private DevExpress.XtraGrid.Views.Grid.GridView gridBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colKondisyon;
        private DevExpress.XtraEditors.Repository.RepositoryItemRatingControl repositoryItemRatingControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colSalon;
        private DevExpress.XtraGrid.Columns.GridColumn colDolap;
        private DevExpress.XtraGrid.Columns.GridColumn colRaf;
        private DevExpress.XtraGrid.Columns.GridColumn colSira;
        private DevExpress.XtraGrid.Columns.GridColumn layoutViewColumn1;
    }
}