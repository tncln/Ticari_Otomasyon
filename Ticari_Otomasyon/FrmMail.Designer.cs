namespace Ticari_Otomasyon
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMailAdresi = new DevExpress.XtraEditors.TextEdit();
            this.txtKonu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMesaj = new DevExpress.XtraEditors.MemoEdit();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailAdresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMesaj.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(28, 131);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mail Adresi :";
            // 
            // txtMailAdresi
            // 
            this.txtMailAdresi.Location = new System.Drawing.Point(118, 129);
            this.txtMailAdresi.Name = "txtMailAdresi";
            this.txtMailAdresi.Size = new System.Drawing.Size(198, 20);
            this.txtMailAdresi.TabIndex = 1;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(118, 155);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(198, 20);
            this.txtKonu.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(62, 157);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Konu :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(59, 182);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mesaj :";
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(118, 181);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(198, 71);
            this.txtMesaj.TabIndex = 3;
            // 
            // btnGonder
            // 
            this.btnGonder.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Appearance.Options.UseFont = true;
            this.btnGonder.Appearance.Options.UseTextOptions = true;
            this.btnGonder.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnGonder.Location = new System.Drawing.Point(118, 258);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(198, 38);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 123);
            this.panel1.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(0, 0);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "labelControl4";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(208, 41);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(108, 19);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "MAİL PANELİ";
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 310);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMailAdresi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtMesaj);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.Name = "FrmMail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Gönderme..";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMailAdresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMesaj.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMailAdresi;
        private DevExpress.XtraEditors.TextEdit txtKonu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txtMesaj;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}