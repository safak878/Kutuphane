namespace Kutuphane.Winform.KitapHareket
{
    partial class FrmEnler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnler));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
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
            this.colKitapOkunmaSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKimlikNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOkulNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYabanciDil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUyeOkumaSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            this.SuspendLayout();
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
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Kitap Hareketleri";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 54);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1285, 733);
            this.splitContainerControl1.SplitterPosition = 332;
            this.splitContainerControl1.TabIndex = 14;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.gridControlKitap);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.chartControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1285, 332);
            this.splitContainerControl2.SplitterPosition = 698;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // gridControlKitap
            // 
            this.gridControlKitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKitap.Location = new System.Drawing.Point(0, 0);
            this.gridControlKitap.MainView = this.gridKitap;
            this.gridControlKitap.Name = "gridControlKitap";
            this.gridControlKitap.Size = new System.Drawing.Size(698, 332);
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
            this.colId,
            this.colKitapOkunmaSayisi});
            this.gridKitap.GridControl = this.gridControlKitap;
            this.gridKitap.Name = "gridKitap";
            // 
            // colDurum
            // 
            this.colDurum.Caption = "Durumu";
            this.colDurum.FieldName = "kitap.Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.OptionsColumn.AllowEdit = false;
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 0;
            this.colDurum.Width = 57;
            // 
            // colOduncVerilebilir
            // 
            this.colOduncVerilebilir.Caption = "Ödünç Verilebilir";
            this.colOduncVerilebilir.FieldName = "kitap.OduncVerilebilir";
            this.colOduncVerilebilir.Name = "colOduncVerilebilir";
            this.colOduncVerilebilir.OptionsColumn.AllowEdit = false;
            this.colOduncVerilebilir.Visible = true;
            this.colOduncVerilebilir.VisibleIndex = 1;
            this.colOduncVerilebilir.Width = 81;
            // 
            // colKitapKodu
            // 
            this.colKitapKodu.Caption = "Kitap Kodu";
            this.colKitapKodu.FieldName = "kitap.KitapKodu";
            this.colKitapKodu.Name = "colKitapKodu";
            this.colKitapKodu.OptionsColumn.AllowEdit = false;
            this.colKitapKodu.Visible = true;
            this.colKitapKodu.VisibleIndex = 2;
            this.colKitapKodu.Width = 102;
            // 
            // colKitapAdi
            // 
            this.colKitapAdi.Caption = "Kitap Adı";
            this.colKitapAdi.FieldName = "kitap.KitapAdi";
            this.colKitapAdi.Name = "colKitapAdi";
            this.colKitapAdi.OptionsColumn.AllowEdit = false;
            this.colKitapAdi.Visible = true;
            this.colKitapAdi.VisibleIndex = 3;
            this.colKitapAdi.Width = 249;
            // 
            // colISBN
            // 
            this.colISBN.Caption = "ISBN";
            this.colISBN.FieldName = "kitap.ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.OptionsColumn.AllowEdit = false;
            this.colISBN.Visible = true;
            this.colISBN.VisibleIndex = 5;
            this.colISBN.Width = 154;
            // 
            // colYayinEvi
            // 
            this.colYayinEvi.Caption = "Yayın Evi";
            this.colYayinEvi.FieldName = "kitap.YayinEvi";
            this.colYayinEvi.Name = "colYayinEvi";
            this.colYayinEvi.OptionsColumn.AllowEdit = false;
            this.colYayinEvi.Visible = true;
            this.colYayinEvi.VisibleIndex = 4;
            this.colYayinEvi.Width = 152;
            // 
            // colBaskiSayisi
            // 
            this.colBaskiSayisi.Caption = "Baskı Sayısı";
            this.colBaskiSayisi.FieldName = "kitap.BaskiSayisi";
            this.colBaskiSayisi.Name = "colBaskiSayisi";
            this.colBaskiSayisi.OptionsColumn.AllowEdit = false;
            this.colBaskiSayisi.Visible = true;
            this.colBaskiSayisi.VisibleIndex = 7;
            this.colBaskiSayisi.Width = 58;
            // 
            // colBasimYili
            // 
            this.colBasimYili.Caption = "Basım Yılı";
            this.colBasimYili.FieldName = "kitap.BasimYili";
            this.colBasimYili.Name = "colBasimYili";
            this.colBasimYili.OptionsColumn.AllowEdit = false;
            this.colBasimYili.Visible = true;
            this.colBasimYili.VisibleIndex = 8;
            this.colBasimYili.Width = 55;
            // 
            // colCiltSayisi
            // 
            this.colCiltSayisi.Caption = "Cilt Sayısı";
            this.colCiltSayisi.FieldName = "kitap.CiltSayisi";
            this.colCiltSayisi.Name = "colCiltSayisi";
            this.colCiltSayisi.OptionsColumn.AllowEdit = false;
            this.colCiltSayisi.Visible = true;
            this.colCiltSayisi.VisibleIndex = 9;
            this.colCiltSayisi.Width = 56;
            // 
            // colSayfaSayisi
            // 
            this.colSayfaSayisi.Caption = "Sayfa Sayısı";
            this.colSayfaSayisi.FieldName = "kitap.SayfaSayisi";
            this.colSayfaSayisi.Name = "colSayfaSayisi";
            this.colSayfaSayisi.OptionsColumn.AllowEdit = false;
            this.colSayfaSayisi.Visible = true;
            this.colSayfaSayisi.VisibleIndex = 10;
            this.colSayfaSayisi.Width = 63;
            // 
            // colBasimYeri
            // 
            this.colBasimYeri.Caption = "Basım Yeri";
            this.colBasimYeri.FieldName = "kitap.BasimYeri";
            this.colBasimYeri.Name = "colBasimYeri";
            this.colBasimYeri.OptionsColumn.AllowEdit = false;
            this.colBasimYeri.Visible = true;
            this.colBasimYeri.VisibleIndex = 11;
            this.colBasimYeri.Width = 58;
            // 
            // colDemirbasNo
            // 
            this.colDemirbasNo.Caption = "Demirbaş No";
            this.colDemirbasNo.FieldName = "kitap.DemirbasNo";
            this.colDemirbasNo.Name = "colDemirbasNo";
            this.colDemirbasNo.OptionsColumn.AllowEdit = false;
            this.colDemirbasNo.Visible = true;
            this.colDemirbasNo.VisibleIndex = 6;
            this.colDemirbasNo.Width = 74;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "kitap.Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 12;
            this.colAciklama.Width = 116;
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "kitap.Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colKitapOkunmaSayisi
            // 
            this.colKitapOkunmaSayisi.Caption = "OkunmaSayisi";
            this.colKitapOkunmaSayisi.FieldName = "OkunmaSayisi";
            this.colKitapOkunmaSayisi.Name = "colKitapOkunmaSayisi";
            this.colKitapOkunmaSayisi.Visible = true;
            this.colKitapOkunmaSayisi.VisibleIndex = 13;
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(582, 332);
            this.chartControl1.TabIndex = 14;
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.Controls.Add(this.chartControl2);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(1285, 396);
            this.splitContainerControl3.SplitterPosition = 699;
            this.splitContainerControl3.TabIndex = 0;
            this.splitContainerControl3.Text = "splitContainerControl3";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(699, 396);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colKimlikNo,
            this.colOkulNo,
            this.colBarkod,
            this.colAdi,
            this.colSoyadi,
            this.colYabanciDil,
            this.colKayitTarihi,
            this.gridColumn3,
            this.colUyeOkumaSayisi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "uye.Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Durum";
            this.gridColumn2.FieldName = "uye.Durum";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // colKimlikNo
            // 
            this.colKimlikNo.Caption = "T.C. Kimlik No";
            this.colKimlikNo.FieldName = "uye.TcKimlikNo";
            this.colKimlikNo.Name = "colKimlikNo";
            this.colKimlikNo.Visible = true;
            this.colKimlikNo.VisibleIndex = 1;
            // 
            // colOkulNo
            // 
            this.colOkulNo.Caption = "Okul No";
            this.colOkulNo.FieldName = "uye.OkulNo";
            this.colOkulNo.Name = "colOkulNo";
            this.colOkulNo.Visible = true;
            this.colOkulNo.VisibleIndex = 2;
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "Barkodu";
            this.colBarkod.FieldName = "uye.Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 3;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "uye.Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 4;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "uye.Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 5;
            // 
            // colYabanciDil
            // 
            this.colYabanciDil.Caption = "Yabancı Dil";
            this.colYabanciDil.FieldName = "uye.YabanciDil";
            this.colYabanciDil.Name = "colYabanciDil";
            this.colYabanciDil.Visible = true;
            this.colYabanciDil.VisibleIndex = 6;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.Caption = "Kayıt Tarihi";
            this.colKayitTarihi.FieldName = "uye.KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.VisibleIndex = 7;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Açıklama";
            this.gridColumn3.FieldName = "uye.Aciklama";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            // 
            // colUyeOkumaSayisi
            // 
            this.colUyeOkumaSayisi.Caption = "Okuduğu Kitap Sayısı";
            this.colUyeOkumaSayisi.FieldName = "OkunmaSayisi";
            this.colUyeOkumaSayisi.Name = "colUyeOkumaSayisi";
            this.colUyeOkumaSayisi.Visible = true;
            this.colUyeOkumaSayisi.VisibleIndex = 9;
            // 
            // chartControl2
            // 
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(0, 0);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl2.Size = new System.Drawing.Size(581, 396);
            this.chartControl2.TabIndex = 13;
            // 
            // FrmEnler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 787);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmEnler";
            this.Text = "FrmEnler";
            this.Load += new System.EventHandler(this.FrmEnler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colKitapOkunmaSayisi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colKimlikNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOkulNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colYabanciDil;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colUyeOkumaSayisi;
    }
}