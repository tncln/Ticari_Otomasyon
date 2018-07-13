namespace Ticari_Otomasyon
{
    partial class FrmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RchDetay = new System.Windows.Forms.RichTextBox();
            this.NudAdet = new System.Windows.Forms.NumericUpDown();
            this.mskYil = new System.Windows.Forms.MaskedTextBox();
            this.txtMarka = new DevExpress.XtraEditors.TextEdit();
            this.txtSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtAlisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(739, 439);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.PaleTurquoise;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.MediumTurquoise;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.RchDetay);
            this.groupControl1.Controls.Add(this.NudAdet);
            this.groupControl1.Controls.Add(this.mskYil);
            this.groupControl1.Controls.Add(this.txtMarka);
            this.groupControl1.Controls.Add(this.txtSatisFiyat);
            this.groupControl1.Controls.Add(this.txtAlisFiyat);
            this.groupControl1.Controls.Add(this.txtModel);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(743, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(351, 461);
            this.groupControl1.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(248, 354);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(56, 36);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(156, 354);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(86, 36);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(68, 354);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(83, 36);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // RchDetay
            // 
            this.RchDetay.Location = new System.Drawing.Point(97, 252);
            this.RchDetay.Name = "RchDetay";
            this.RchDetay.Size = new System.Drawing.Size(207, 96);
            this.RchDetay.TabIndex = 8;
            this.RchDetay.Text = "";
            // 
            // NudAdet
            // 
            this.NudAdet.Location = new System.Drawing.Point(97, 173);
            this.NudAdet.Name = "NudAdet";
            this.NudAdet.Size = new System.Drawing.Size(207, 21);
            this.NudAdet.TabIndex = 5;
            // 
            // mskYil
            // 
            this.mskYil.Location = new System.Drawing.Point(97, 146);
            this.mskYil.Mask = "0000";
            this.mskYil.Name = "mskYil";
            this.mskYil.Size = new System.Drawing.Size(207, 21);
            this.mskYil.TabIndex = 4;
            this.mskYil.ValidatingType = typeof(int);
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(97, 94);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(207, 20);
            this.txtMarka.TabIndex = 2;
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(97, 226);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(207, 20);
            this.txtSatisFiyat.TabIndex = 7;
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Location = new System.Drawing.Point(97, 200);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(207, 20);
            this.txtAlisFiyat.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(97, 120);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(207, 20);
            this.txtModel.TabIndex = 3;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(68, 149);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(17, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Yıl :";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(48, 255);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(36, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Detay :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(55, 175);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Adet :";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(26, 229);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Satış Fiyatı :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(49, 97);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Marka :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(35, 203);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Alış Fiyat :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(97, 64);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(207, 20);
            this.txtAd.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(49, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Model :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(97, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(207, 20);
            this.txtID.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(65, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ad :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(67, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(743, 461);
            this.groupControl2.TabIndex = 2;
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 461);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmUrunler";
            this.ShowInTaskbar = false;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.RichTextBox RchDetay;
        private System.Windows.Forms.NumericUpDown NudAdet;
        private System.Windows.Forms.MaskedTextBox mskYil;
        private DevExpress.XtraEditors.TextEdit txtMarka;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyat;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyat;
        private DevExpress.XtraEditors.TextEdit txtModel;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
    }
}