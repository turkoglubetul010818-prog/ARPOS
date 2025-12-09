namespace ARPOS
{
    partial class FrmHastaPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTarihSaat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpHastaBilgi = new System.Windows.Forms.GroupBox();
            this.mskDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpRandevuOlustur = new System.Windows.Forms.GroupBox();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.btnRandevuIptal = new System.Windows.Forms.Button();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvRandevularım = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRandevularım = new System.Windows.Forms.TabPage();
            this.tabGecmisRandevular = new System.Windows.Forms.TabPage();
            this.dgvRandevuGecmis = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpHastaBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpRandevuOlustur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevularım)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabRandevularım.SuspendLayout();
            this.tabGecmisRandevular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuGecmis)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTarihSaat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 93);
            this.panel1.TabIndex = 0;
            // 
            // lblTarihSaat
            // 
            this.lblTarihSaat.AutoSize = true;
            this.lblTarihSaat.Location = new System.Drawing.Point(997, 9);
            this.lblTarihSaat.Name = "lblTarihSaat";
            this.lblTarihSaat.Size = new System.Drawing.Size(119, 32);
            this.lblTarihSaat.TabIndex = 2;
            this.lblTarihSaat.Text = "Tarih-Saat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(448, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(544, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Paneli";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpHastaBilgi
            // 
            this.grpHastaBilgi.BackColor = System.Drawing.Color.PowderBlue;
            this.grpHastaBilgi.Controls.Add(this.mskDogumTarihi);
            this.grpHastaBilgi.Controls.Add(this.mskTC);
            this.grpHastaBilgi.Controls.Add(this.pictureBox2);
            this.grpHastaBilgi.Controls.Add(this.txtAdSoyad);
            this.grpHastaBilgi.Controls.Add(this.label4);
            this.grpHastaBilgi.Controls.Add(this.label3);
            this.grpHastaBilgi.Controls.Add(this.label2);
            this.grpHastaBilgi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpHastaBilgi.ForeColor = System.Drawing.Color.Navy;
            this.grpHastaBilgi.Location = new System.Drawing.Point(12, 99);
            this.grpHastaBilgi.Name = "grpHastaBilgi";
            this.grpHastaBilgi.Size = new System.Drawing.Size(609, 267);
            this.grpHastaBilgi.TabIndex = 1;
            this.grpHastaBilgi.TabStop = false;
            this.grpHastaBilgi.Text = "Hasta Bilgileri";
            // 
            // mskDogumTarihi
            // 
            this.mskDogumTarihi.Location = new System.Drawing.Point(322, 190);
            this.mskDogumTarihi.Mask = "00/00/0000";
            this.mskDogumTarihi.Name = "mskDogumTarihi";
            this.mskDogumTarihi.ReadOnly = true;
            this.mskDogumTarihi.Size = new System.Drawing.Size(176, 38);
            this.mskDogumTarihi.TabIndex = 8;
            this.mskDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(322, 137);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.ReadOnly = true;
            this.mskTC.Size = new System.Drawing.Size(176, 38);
            this.mskTC.TabIndex = 7;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 186);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(322, 78);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.ReadOnly = true;
            this.txtAdSoyad.Size = new System.Drawing.Size(271, 38);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(157, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(157, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(157, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad:";
            // 
            // grpRandevuOlustur
            // 
            this.grpRandevuOlustur.Controls.Add(this.cmbSaat);
            this.grpRandevuOlustur.Controls.Add(this.btnRandevuIptal);
            this.grpRandevuOlustur.Controls.Add(this.btnRandevuAl);
            this.grpRandevuOlustur.Controls.Add(this.dtpTarih);
            this.grpRandevuOlustur.Controls.Add(this.cmbDoktor);
            this.grpRandevuOlustur.Controls.Add(this.cmbBrans);
            this.grpRandevuOlustur.Controls.Add(this.label8);
            this.grpRandevuOlustur.Controls.Add(this.label7);
            this.grpRandevuOlustur.Controls.Add(this.label6);
            this.grpRandevuOlustur.Controls.Add(this.label5);
            this.grpRandevuOlustur.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpRandevuOlustur.ForeColor = System.Drawing.Color.Navy;
            this.grpRandevuOlustur.Location = new System.Drawing.Point(12, 385);
            this.grpRandevuOlustur.Name = "grpRandevuOlustur";
            this.grpRandevuOlustur.Size = new System.Drawing.Size(609, 398);
            this.grpRandevuOlustur.TabIndex = 2;
            this.grpRandevuOlustur.TabStop = false;
            this.grpRandevuOlustur.Text = "Randevu Oluştur";
            // 
            // cmbSaat
            // 
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Location = new System.Drawing.Point(182, 209);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(121, 39);
            this.cmbSaat.TabIndex = 10;
            // 
            // btnRandevuIptal
            // 
            this.btnRandevuIptal.BackColor = System.Drawing.Color.IndianRed;
            this.btnRandevuIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandevuIptal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRandevuIptal.Location = new System.Drawing.Point(183, 323);
            this.btnRandevuIptal.Name = "btnRandevuIptal";
            this.btnRandevuIptal.Size = new System.Drawing.Size(199, 50);
            this.btnRandevuIptal.TabIndex = 9;
            this.btnRandevuIptal.Text = "Randevu İptal";
            this.btnRandevuIptal.UseVisualStyleBackColor = false;
            this.btnRandevuIptal.Click += new System.EventHandler(this.btnRandevuIptal_Click);
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRandevuAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandevuAl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRandevuAl.Location = new System.Drawing.Point(183, 265);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(199, 52);
            this.btnRandevuAl.TabIndex = 5;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = false;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(182, 159);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(187, 38);
            this.dtpTarih.TabIndex = 3;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(182, 104);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(322, 39);
            this.cmbDoktor.TabIndex = 2;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // cmbBrans
            // 
            this.cmbBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(182, 57);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(322, 39);
            this.cmbBrans.TabIndex = 1;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(74, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Saat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(74, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tarih:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(74, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Doktor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(74, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Branş:";
            // 
            // dgvRandevularım
            // 
            this.dgvRandevularım.AllowUserToAddRows = false;
            this.dgvRandevularım.AllowUserToDeleteRows = false;
            this.dgvRandevularım.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRandevularım.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRandevularım.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevularım.Location = new System.Drawing.Point(3, 3);
            this.dgvRandevularım.MultiSelect = false;
            this.dgvRandevularım.Name = "dgvRandevularım";
            this.dgvRandevularım.ReadOnly = true;
            this.dgvRandevularım.RowHeadersVisible = false;
            this.dgvRandevularım.RowHeadersWidth = 72;
            this.dgvRandevularım.RowTemplate.Height = 31;
            this.dgvRandevularım.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRandevularım.Size = new System.Drawing.Size(543, 631);
            this.dgvRandevularım.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRandevularım);
            this.tabControl1.Controls.Add(this.tabGecmisRandevular);
            this.tabControl1.Location = new System.Drawing.Point(627, 99);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 684);
            this.tabControl1.TabIndex = 3;
            // 
            // tabRandevularım
            // 
            this.tabRandevularım.Controls.Add(this.dgvRandevularım);
            this.tabRandevularım.Location = new System.Drawing.Point(4, 40);
            this.tabRandevularım.Name = "tabRandevularım";
            this.tabRandevularım.Padding = new System.Windows.Forms.Padding(3);
            this.tabRandevularım.Size = new System.Drawing.Size(519, 640);
            this.tabRandevularım.TabIndex = 0;
            this.tabRandevularım.Text = "Randevularım";
            this.tabRandevularım.UseVisualStyleBackColor = true;
            // 
            // tabGecmisRandevular
            // 
            this.tabGecmisRandevular.Controls.Add(this.dgvRandevuGecmis);
            this.tabGecmisRandevular.Location = new System.Drawing.Point(4, 40);
            this.tabGecmisRandevular.Name = "tabGecmisRandevular";
            this.tabGecmisRandevular.Padding = new System.Windows.Forms.Padding(3);
            this.tabGecmisRandevular.Size = new System.Drawing.Size(519, 640);
            this.tabGecmisRandevular.TabIndex = 1;
            this.tabGecmisRandevular.Text = "Gecmiş Randevular";
            this.tabGecmisRandevular.UseVisualStyleBackColor = true;
            // 
            // dgvRandevuGecmis
            // 
            this.dgvRandevuGecmis.AllowUserToAddRows = false;
            this.dgvRandevuGecmis.AllowUserToDeleteRows = false;
            this.dgvRandevuGecmis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRandevuGecmis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRandevuGecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevuGecmis.Location = new System.Drawing.Point(5, 5);
            this.dgvRandevuGecmis.MultiSelect = false;
            this.dgvRandevuGecmis.Name = "dgvRandevuGecmis";
            this.dgvRandevuGecmis.ReadOnly = true;
            this.dgvRandevuGecmis.RowHeadersVisible = false;
            this.dgvRandevuGecmis.RowHeadersWidth = 72;
            this.dgvRandevuGecmis.RowTemplate.Height = 31;
            this.dgvRandevuGecmis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRandevuGecmis.Size = new System.Drawing.Size(510, 631);
            this.dgvRandevuGecmis.TabIndex = 1;
            // 
            // FrmHastaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1159, 791);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpRandevuOlustur);
            this.Controls.Add(this.grpHastaBilgi);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmHastaPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHastaPanel_FormClosed);
            this.Load += new System.EventHandler(this.FrmHastaPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpHastaBilgi.ResumeLayout(false);
            this.grpHastaBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpRandevuOlustur.ResumeLayout(false);
            this.grpRandevuOlustur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevularım)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabRandevularım.ResumeLayout(false);
            this.tabGecmisRandevular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuGecmis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTarihSaat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpHastaBilgi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskDogumTarihi;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.GroupBox grpRandevuOlustur;
        private System.Windows.Forms.Button btnRandevuIptal;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvRandevularım;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRandevularım;
        private System.Windows.Forms.TabPage tabGecmisRandevular;
        private System.Windows.Forms.DataGridView dgvRandevuGecmis;
    }
}