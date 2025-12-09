namespace ARPOS
{
    partial class FrmSifreUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSifreUnuttum));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.btnDevam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlKimlik = new System.Windows.Forms.Panel();
            this.pnlYeniSifre = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picSifreGoster = new System.Windows.Forms.PictureBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlKimlik.SuspendLayout();
            this.pnlYeniSifre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSifreGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC veya Email:";
            // 
            // txtBilgi
            // 
            this.txtBilgi.Location = new System.Drawing.Point(63, 78);
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.Size = new System.Drawing.Size(528, 38);
            this.txtBilgi.TabIndex = 1;
            // 
            // btnDevam
            // 
            this.btnDevam.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDevam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevam.ForeColor = System.Drawing.Color.White;
            this.btnDevam.Location = new System.Drawing.Point(452, 122);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(139, 44);
            this.btnDevam.TabIndex = 2;
            this.btnDevam.Text = "Devam Et";
            this.btnDevam.UseVisualStyleBackColor = false;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(212, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "ŞİFREMİ UNUTTUM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 100);
            this.panel1.TabIndex = 4;
            // 
            // pnlKimlik
            // 
            this.pnlKimlik.BackColor = System.Drawing.Color.White;
            this.pnlKimlik.Controls.Add(this.label1);
            this.pnlKimlik.Controls.Add(this.txtBilgi);
            this.pnlKimlik.Controls.Add(this.btnDevam);
            this.pnlKimlik.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKimlik.Location = new System.Drawing.Point(0, 100);
            this.pnlKimlik.Name = "pnlKimlik";
            this.pnlKimlik.Size = new System.Drawing.Size(663, 181);
            this.pnlKimlik.TabIndex = 5;
            // 
            // pnlYeniSifre
            // 
            this.pnlYeniSifre.BackColor = System.Drawing.Color.White;
            this.pnlYeniSifre.Controls.Add(this.pictureBox1);
            this.pnlYeniSifre.Controls.Add(this.picSifreGoster);
            this.pnlYeniSifre.Controls.Add(this.btnKaydet);
            this.pnlYeniSifre.Controls.Add(this.txtSifreTekrar);
            this.pnlYeniSifre.Controls.Add(this.txtSifre);
            this.pnlYeniSifre.Controls.Add(this.label4);
            this.pnlYeniSifre.Controls.Add(this.label3);
            this.pnlYeniSifre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlYeniSifre.Location = new System.Drawing.Point(0, 281);
            this.pnlYeniSifre.Name = "pnlYeniSifre";
            this.pnlYeniSifre.Size = new System.Drawing.Size(663, 220);
            this.pnlYeniSifre.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(564, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pbTekrarGoster_Click);
            // 
            // picSifreGoster
            // 
            this.picSifreGoster.BackColor = System.Drawing.Color.Gainsboro;
            this.picSifreGoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSifreGoster.Image = ((System.Drawing.Image)(resources.GetObject("picSifreGoster.Image")));
            this.picSifreGoster.Location = new System.Drawing.Point(564, 41);
            this.picSifreGoster.Name = "picSifreGoster";
            this.picSifreGoster.Size = new System.Drawing.Size(37, 38);
            this.picSifreGoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSifreGoster.TabIndex = 9;
            this.picSifreGoster.TabStop = false;
            this.picSifreGoster.Click += new System.EventHandler(this.pbSifreGoster_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(414, 140);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(190, 44);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Şifreyi Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(265, 96);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.PasswordChar = '*';
            this.txtSifreTekrar.Size = new System.Drawing.Size(336, 38);
            this.txtSifreTekrar.TabIndex = 4;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(265, 41);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(336, 38);
            this.txtSifre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Yeni Şifre(Tekrar):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yeni Şifre:";
            // 
            // FrmSifreUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 517);
            this.Controls.Add(this.pnlYeniSifre);
            this.Controls.Add(this.pnlKimlik);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSifreUnuttum";
            this.Text = "Şifremi Yenileme";
            this.Load += new System.EventHandler(this.FrmSifreUnuttum_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlKimlik.ResumeLayout(false);
            this.pnlKimlik.PerformLayout();
            this.pnlYeniSifre.ResumeLayout(false);
            this.pnlYeniSifre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSifreGoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBilgi;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlKimlik;
        private System.Windows.Forms.Panel pnlYeniSifre;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picSifreGoster;
    }
}