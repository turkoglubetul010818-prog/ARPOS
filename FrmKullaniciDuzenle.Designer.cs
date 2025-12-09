namespace ARPOS
{
    partial class FrmKullaniciDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciDuzenle));
            this.grpKayitBilgileri = new System.Windows.Forms.GroupBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picKullanici = new System.Windows.Forms.PictureBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btVazgec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.grpKayitBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // grpKayitBilgileri
            // 
            this.grpKayitBilgileri.Controls.Add(this.mskTel);
            this.grpKayitBilgileri.Controls.Add(this.label9);
            this.grpKayitBilgileri.Controls.Add(this.txtEmail);
            this.grpKayitBilgileri.Controls.Add(this.label8);
            this.grpKayitBilgileri.Controls.Add(this.mskTC);
            this.grpKayitBilgileri.Controls.Add(this.label1);
            this.grpKayitBilgileri.Controls.Add(this.picKullanici);
            this.grpKayitBilgileri.Controls.Add(this.lblBaslik);
            this.grpKayitBilgileri.Controls.Add(this.label2);
            this.grpKayitBilgileri.Controls.Add(this.btVazgec);
            this.grpKayitBilgileri.Controls.Add(this.label3);
            this.grpKayitBilgileri.Controls.Add(this.btnKaydet);
            this.grpKayitBilgileri.Controls.Add(this.cmbRol);
            this.grpKayitBilgileri.Controls.Add(this.label5);
            this.grpKayitBilgileri.Controls.Add(this.txtAdSoyad);
            this.grpKayitBilgileri.Controls.Add(this.txtKullaniciAdi);
            this.grpKayitBilgileri.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKayitBilgileri.Location = new System.Drawing.Point(40, 37);
            this.grpKayitBilgileri.Name = "grpKayitBilgileri";
            this.grpKayitBilgileri.Size = new System.Drawing.Size(720, 662);
            this.grpKayitBilgileri.TabIndex = 14;
            this.grpKayitBilgileri.TabStop = false;
            this.grpKayitBilgileri.Text = "Kayıt Bilgileri";
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTel.Location = new System.Drawing.Point(254, 418);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(210, 38);
            this.mskTel.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(62, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 32);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tel No:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(254, 365);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(316, 38);
            this.txtEmail.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(62, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "Email:";
            // 
            // mskTC
            // 
            this.mskTC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTC.Location = new System.Drawing.Point(254, 309);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(210, 38);
            this.mskTC.TabIndex = 4;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "TC No:";
            // 
            // picKullanici
            // 
            this.picKullanici.Image = ((System.Drawing.Image)(resources.GetObject("picKullanici.Image")));
            this.picKullanici.Location = new System.Drawing.Point(68, 78);
            this.picKullanici.Name = "picKullanici";
            this.picKullanici.Size = new System.Drawing.Size(114, 91);
            this.picKullanici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picKullanici.TabIndex = 12;
            this.picKullanici.TabStop = false;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.Navy;
            this.lblBaslik.Location = new System.Drawing.Point(246, 99);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(248, 46);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Kayıt Güncelle";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // btVazgec
            // 
            this.btVazgec.BackColor = System.Drawing.Color.IndianRed;
            this.btVazgec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVazgec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btVazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVazgec.ForeColor = System.Drawing.Color.White;
            this.btVazgec.Location = new System.Drawing.Point(417, 529);
            this.btVazgec.Name = "btVazgec";
            this.btVazgec.Size = new System.Drawing.Size(131, 50);
            this.btVazgec.TabIndex = 10;
            this.btVazgec.Text = "Vazgeç";
            this.btVazgec.UseVisualStyleBackColor = false;
            this.btVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(62, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(254, 529);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(140, 50);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Seçiniz...",
            "Yönetici",
            "Sekreter",
            "Doktor",
            "Hasta"});
            this.cmbRol.Location = new System.Drawing.Point(254, 469);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(222, 39);
            this.cmbRol.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(62, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rol(Görev):";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(254, 195);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(316, 38);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(254, 252);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(316, 38);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // FrmKullaniciDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 716);
            this.Controls.Add(this.grpKayitBilgileri);
            this.Name = "FrmKullaniciDuzenle";
            this.Text = "FrmKullaniciDuzenle";
            this.Load += new System.EventHandler(this.FrmKullaniciDuzenle_Load);
            this.grpKayitBilgileri.ResumeLayout(false);
            this.grpKayitBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKayitBilgileri;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picKullanici;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btVazgec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
    }
}