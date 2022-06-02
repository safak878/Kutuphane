namespace Kutuphane.Winform.KitapHareket
{
    partial class FrmKitapHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitapHareket));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUyeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerilisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerilisSuresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeslimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOkulNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUyeBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUyeAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUyeSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeslimEdilmesiGerekenTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKacGunGecikti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitapBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeslimEdildi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 54);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1293, 662);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKitapId,
            this.colUyeId,
            this.colVerilisTarihi,
            this.colVerilisSuresi,
            this.colTeslimTarihi,
            this.colAciklama,
            this.colKitapKodu,
            this.colKitapAdi,
            this.colOkulNo,
            this.colUyeBarkod,
            this.colUyeAdi,
            this.colUyeSoyadi,
            this.colTeslimEdilmesiGerekenTarih,
            this.colKacGunGecikti,
            this.colDurumu,
            this.colKitapBarkod,
            this.colTeslimEdildi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colKitapId
            // 
            this.colKitapId.Caption = "KitapId";
            this.colKitapId.FieldName = "KitapId";
            this.colKitapId.Name = "colKitapId";
            this.colKitapId.OptionsColumn.AllowEdit = false;
            // 
            // colUyeId
            // 
            this.colUyeId.Caption = "Üye Id";
            this.colUyeId.FieldName = "UyeId";
            this.colUyeId.Name = "colUyeId";
            this.colUyeId.OptionsColumn.AllowEdit = false;
            // 
            // colVerilisTarihi
            // 
            this.colVerilisTarihi.Caption = "Veriliş Tarihi";
            this.colVerilisTarihi.FieldName = "VerilisTarihi";
            this.colVerilisTarihi.Name = "colVerilisTarihi";
            this.colVerilisTarihi.OptionsColumn.AllowEdit = false;
            this.colVerilisTarihi.Visible = true;
            this.colVerilisTarihi.VisibleIndex = 8;
            // 
            // colVerilisSuresi
            // 
            this.colVerilisSuresi.Caption = "Veriliş Süresi";
            this.colVerilisSuresi.FieldName = "VerilisSuresi";
            this.colVerilisSuresi.Name = "colVerilisSuresi";
            this.colVerilisSuresi.OptionsColumn.AllowEdit = false;
            this.colVerilisSuresi.Visible = true;
            this.colVerilisSuresi.VisibleIndex = 9;
            // 
            // colTeslimTarihi
            // 
            this.colTeslimTarihi.Caption = "Teslim Tarihi";
            this.colTeslimTarihi.FieldName = "TeslimTarihi";
            this.colTeslimTarihi.Name = "colTeslimTarihi";
            this.colTeslimTarihi.OptionsColumn.AllowEdit = false;
            this.colTeslimTarihi.Visible = true;
            this.colTeslimTarihi.VisibleIndex = 11;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 12;
            // 
            // colKitapKodu
            // 
            this.colKitapKodu.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colKitapKodu.AppearanceCell.Options.UseBackColor = true;
            this.colKitapKodu.Caption = "Kitap Kodu";
            this.colKitapKodu.FieldName = "Kitap.KitapKodu";
            this.colKitapKodu.Name = "colKitapKodu";
            this.colKitapKodu.OptionsColumn.AllowEdit = false;
            this.colKitapKodu.Visible = true;
            this.colKitapKodu.VisibleIndex = 2;
            // 
            // colKitapAdi
            // 
            this.colKitapAdi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colKitapAdi.AppearanceCell.Options.UseBackColor = true;
            this.colKitapAdi.Caption = "Kitap Adı";
            this.colKitapAdi.FieldName = "Kitap.KitapAdi";
            this.colKitapAdi.Name = "colKitapAdi";
            this.colKitapAdi.OptionsColumn.AllowEdit = false;
            this.colKitapAdi.Visible = true;
            this.colKitapAdi.VisibleIndex = 3;
            // 
            // colOkulNo
            // 
            this.colOkulNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colOkulNo.AppearanceCell.Options.UseBackColor = true;
            this.colOkulNo.Caption = "Okul No";
            this.colOkulNo.FieldName = "Uye.OkulNo";
            this.colOkulNo.Name = "colOkulNo";
            this.colOkulNo.OptionsColumn.AllowEdit = false;
            this.colOkulNo.Visible = true;
            this.colOkulNo.VisibleIndex = 4;
            // 
            // colUyeBarkod
            // 
            this.colUyeBarkod.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colUyeBarkod.AppearanceCell.Options.UseBackColor = true;
            this.colUyeBarkod.Caption = "Üye Barkodu";
            this.colUyeBarkod.FieldName = "Uye.Barkod";
            this.colUyeBarkod.Name = "colUyeBarkod";
            this.colUyeBarkod.OptionsColumn.AllowEdit = false;
            this.colUyeBarkod.Visible = true;
            this.colUyeBarkod.VisibleIndex = 5;
            // 
            // colUyeAdi
            // 
            this.colUyeAdi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colUyeAdi.AppearanceCell.Options.UseBackColor = true;
            this.colUyeAdi.Caption = "Adı";
            this.colUyeAdi.FieldName = "Uye.Adi";
            this.colUyeAdi.Name = "colUyeAdi";
            this.colUyeAdi.OptionsColumn.AllowEdit = false;
            this.colUyeAdi.Visible = true;
            this.colUyeAdi.VisibleIndex = 6;
            // 
            // colUyeSoyadi
            // 
            this.colUyeSoyadi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colUyeSoyadi.AppearanceCell.Options.UseBackColor = true;
            this.colUyeSoyadi.Caption = "Soyadı";
            this.colUyeSoyadi.FieldName = "Uye.Soyadi";
            this.colUyeSoyadi.Name = "colUyeSoyadi";
            this.colUyeSoyadi.OptionsColumn.AllowEdit = false;
            this.colUyeSoyadi.Visible = true;
            this.colUyeSoyadi.VisibleIndex = 7;
            // 
            // colTeslimEdilmesiGerekenTarih
            // 
            this.colTeslimEdilmesiGerekenTarih.Caption = "Teslim Edilmesi Gereken Tarih";
            this.colTeslimEdilmesiGerekenTarih.FieldName = "colTeslimEdilmesiGerekenTarih";
            this.colTeslimEdilmesiGerekenTarih.Name = "colTeslimEdilmesiGerekenTarih";
            this.colTeslimEdilmesiGerekenTarih.OptionsColumn.AllowEdit = false;
            this.colTeslimEdilmesiGerekenTarih.UnboundExpression = "AddDays([VerilisTarihi], [VerilisSuresi])";
            this.colTeslimEdilmesiGerekenTarih.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.colTeslimEdilmesiGerekenTarih.Visible = true;
            this.colTeslimEdilmesiGerekenTarih.VisibleIndex = 10;
            // 
            // colKacGunGecikti
            // 
            this.colKacGunGecikti.Caption = "Kaç Gün Gecikti";
            this.colKacGunGecikti.FieldName = "colKacGunGecikti";
            this.colKacGunGecikti.Name = "colKacGunGecikti";
            this.colKacGunGecikti.OptionsColumn.AllowEdit = false;
            this.colKacGunGecikti.UnboundExpression = "DateDiffDay([colTeslimEdilmesiGerekenTarih], Today())";
            this.colKacGunGecikti.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // colDurumu
            // 
            this.colDurumu.Caption = "Durumu";
            this.colDurumu.FieldName = "colDurumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.OptionsColumn.AllowEdit = false;
            this.colDurumu.UnboundExpression = resources.GetString("colDurumu.UnboundExpression");
            this.colDurumu.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 0;
            // 
            // colKitapBarkod
            // 
            this.colKitapBarkod.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colKitapBarkod.AppearanceCell.Options.UseBackColor = true;
            this.colKitapBarkod.Caption = "Kitap Barkodu";
            this.colKitapBarkod.FieldName = "Barkod.Barkodu";
            this.colKitapBarkod.Name = "colKitapBarkod";
            this.colKitapBarkod.OptionsColumn.AllowEdit = false;
            this.colKitapBarkod.Visible = true;
            this.colKitapBarkod.VisibleIndex = 1;
            // 
            // colTeslimEdildi
            // 
            this.colTeslimEdildi.Caption = "Teslim Edildi Mi?";
            this.colTeslimEdildi.FieldName = "TeslimEdildi";
            this.colTeslimEdildi.Name = "colTeslimEdildi";
            this.colTeslimEdildi.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 716);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1293, 71);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Menü";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 4;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(1184, 24);
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
            this.ımageList1.Images.SetKeyName(0, "user_add.png");
            this.ımageList1.Images.SetKeyName(1, "user_delete.png");
            this.ımageList1.Images.SetKeyName(2, "user_edit.png");
            this.ımageList1.Images.SetKeyName(3, "refresh.png");
            this.ımageList1.Images.SetKeyName(4, "folder_out.png");
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 3;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(225, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(104, 42);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.ImageIndex = 1;
            this.simpleButton3.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton3.Location = new System.Drawing.Point(115, 23);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(104, 42);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "Sil";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.ImageIndex = 0;
            this.simpleButton1.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton1.Location = new System.Drawing.Point(5, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 42);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Teslim\r\nDurumu\r\nDeğiştir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.labelControl1.Size = new System.Drawing.Size(1293, 54);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Kitap Hareketleri";
            // 
            // FrmKitapHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 787);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmKitapHareket";
            this.Text = "FrmKitapHareket";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapId;
        private DevExpress.XtraGrid.Columns.GridColumn colUyeId;
        private DevExpress.XtraGrid.Columns.GridColumn colVerilisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colVerilisSuresi;
        private DevExpress.XtraGrid.Columns.GridColumn colTeslimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colOkulNo;
        private DevExpress.XtraGrid.Columns.GridColumn colUyeBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colUyeAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colUyeSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colTeslimEdilmesiGerekenTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colKacGunGecikti;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapBarkod;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colTeslimEdildi;
    }
}