namespace Kutuphane.Winform.Kitap
{
    partial class FrmKitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitap));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).BeginInit();
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
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kitap Listesi";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 716);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1285, 71);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1176, 24);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(104, 42);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "düzenle.png");
            this.ımageList1.Images.SetKeyName(2, "Ekle.png");
            this.ımageList1.Images.SetKeyName(3, "sil.png");
            this.ımageList1.Images.SetKeyName(4, "refresh.png");
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 4;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(335, 24);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(104, 42);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.ImageIndex = 3;
            this.simpleButton3.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton3.Location = new System.Drawing.Point(225, 23);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(104, 42);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "Sil";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.ImageIndex = 1;
            this.simpleButton2.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton2.Location = new System.Drawing.Point(115, 23);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(104, 42);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Düzenle";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.ImageIndex = 2;
            this.simpleButton1.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton1.Location = new System.Drawing.Point(5, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 42);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControlKitap
            // 
            this.gridControlKitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKitap.Location = new System.Drawing.Point(0, 54);
            this.gridControlKitap.MainView = this.gridKitap;
            this.gridControlKitap.Name = "gridControlKitap";
            this.gridControlKitap.Size = new System.Drawing.Size(1285, 662);
            this.gridControlKitap.TabIndex = 2;
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
            // FrmKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 787);
            this.Controls.Add(this.gridControlKitap);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
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
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
    }
}