namespace ARPOS
{
    partial class FrmSekreterPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterPanel));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpSekreterBilgi = new System.Windows.Forms.GroupBox();
            this.picSekreter = new System.Windows.Forms.PictureBox();
            this.txtSekreterKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSekreterAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpRandevuYonetim = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnRandevuIptal = new System.Windows.Forms.Button();
            this.cmbHizmet = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.btnOtomatikPlanla = new System.Windows.Forms.Button();
            this.btnRandevuOlustur = new System.Windows.Forms.Button();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabRandevular = new System.Windows.Forms.TabPage();
            this.btnYenile = new System.Windows.Forms.Button();
            this.dgvRandevular = new System.Windows.Forms.DataGridView();
            this.tabSekreter = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTarihSaat = new System.Windows.Forms.Label();
            this.grpSekreterBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSekreter)).BeginInit();
            this.grpRandevuYonetim.SuspendLayout();
            this.tabRandevular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).BeginInit();
            this.tabSekreter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpSekreterBilgi
            // 
            this.grpSekreterBilgi.BackColor = System.Drawing.Color.PowderBlue;
            this.grpSekreterBilgi.Controls.Add(this.picSekreter);
            this.grpSekreterBilgi.Controls.Add(this.txtSekreterKullaniciAdi);
            this.grpSekreterBilgi.Controls.Add(this.txtSekreterAdSoyad);
            this.grpSekreterBilgi.Controls.Add(this.label3);
            this.grpSekreterBilgi.Controls.Add(this.label2);
            this.grpSekreterBilgi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpSekreterBilgi.ForeColor = System.Drawing.Color.Navy;
            this.grpSekreterBilgi.Location = new System.Drawing.Point(12, 110);
            this.grpSekreterBilgi.Name = "grpSekreterBilgi";
            this.grpSekreterBilgi.Size = new System.Drawing.Size(674, 193);
            this.grpSekreterBilgi.TabIndex = 3;
            this.grpSekreterBilgi.TabStop = false;
            this.grpSekreterBilgi.Text = "Sekreter Bilgileri";
            // 
            // picSekreter
            // 
            this.picSekreter.Image = ((System.Drawing.Image)(resources.GetObject("picSekreter.Image")));
            this.picSekreter.Location = new System.Drawing.Point(28, 37);
            this.picSekreter.Name = "picSekreter";
            this.picSekreter.Size = new System.Drawing.Size(146, 132);
            this.picSekreter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSekreter.TabIndex = 4;
            this.picSekreter.TabStop = false;
            // 
            // txtSekreterKullaniciAdi
            // 
            this.txtSekreterKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSekreterKullaniciAdi.Location = new System.Drawing.Point(388, 127);
            this.txtSekreterKullaniciAdi.Name = "txtSekreterKullaniciAdi";
            this.txtSekreterKullaniciAdi.ReadOnly = true;
            this.txtSekreterKullaniciAdi.Size = new System.Drawing.Size(229, 38);
            this.txtSekreterKullaniciAdi.TabIndex = 3;
            // 
            // txtSekreterAdSoyad
            // 
            this.txtSekreterAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSekreterAdSoyad.Location = new System.Drawing.Point(388, 74);
            this.txtSekreterAdSoyad.Name = "txtSekreterAdSoyad";
            this.txtSekreterAdSoyad.ReadOnly = true;
            this.txtSekreterAdSoyad.Size = new System.Drawing.Size(229, 38);
            this.txtSekreterAdSoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(219, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(219, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad:";
            // 
            // grpRandevuYonetim
            // 
            this.grpRandevuYonetim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpRandevuYonetim.Controls.Add(this.btnTemizle);
            this.grpRandevuYonetim.Controls.Add(this.btnRandevuIptal);
            this.grpRandevuYonetim.Controls.Add(this.cmbHizmet);
            this.grpRandevuYonetim.Controls.Add(this.label9);
            this.grpRandevuYonetim.Controls.Add(this.cmbSaat);
            this.grpRandevuYonetim.Controls.Add(this.dtTarih);
            this.grpRandevuYonetim.Controls.Add(this.btnOtomatikPlanla);
            this.grpRandevuYonetim.Controls.Add(this.btnRandevuOlustur);
            this.grpRandevuYonetim.Controls.Add(this.cmbDoktor);
            this.grpRandevuYonetim.Controls.Add(this.cmbBrans);
            this.grpRandevuYonetim.Controls.Add(this.label4);
            this.grpRandevuYonetim.Controls.Add(this.mskTC);
            this.grpRandevuYonetim.Controls.Add(this.label5);
            this.grpRandevuYonetim.Controls.Add(this.label8);
            this.grpRandevuYonetim.Controls.Add(this.label6);
            this.grpRandevuYonetim.Controls.Add(this.label7);
            this.grpRandevuYonetim.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpRandevuYonetim.ForeColor = System.Drawing.Color.Navy;
            this.grpRandevuYonetim.Location = new System.Drawing.Point(12, 319);
            this.grpRandevuYonetim.Name = "grpRandevuYonetim";
            this.grpRandevuYonetim.Size = new System.Drawing.Size(674, 519);
            this.grpRandevuYonetim.TabIndex = 4;
            this.grpRandevuYonetim.TabStop = false;
            this.grpRandevuYonetim.Text = "Randevu Yönetimi";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTemizle.Location = new System.Drawing.Point(431, 393);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(208, 47);
            this.btnTemizle.TabIndex = 22;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnRandevuIptal
            // 
            this.btnRandevuIptal.BackColor = System.Drawing.Color.IndianRed;
            this.btnRandevuIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandevuIptal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRandevuIptal.Location = new System.Drawing.Point(205, 446);
            this.btnRandevuIptal.Name = "btnRandevuIptal";
            this.btnRandevuIptal.Size = new System.Drawing.Size(219, 50);
            this.btnRandevuIptal.TabIndex = 21;
            this.btnRandevuIptal.Text = "Randevu İptal";
            this.btnRandevuIptal.UseVisualStyleBackColor = false;
            this.btnRandevuIptal.Click += new System.EventHandler(this.btnRandevuIptal_Click);
            // 
            // cmbHizmet
            // 
            this.cmbHizmet.FormattingEnabled = true;
            this.cmbHizmet.Location = new System.Drawing.Point(205, 329);
            this.cmbHizmet.Name = "cmbHizmet";
            this.cmbHizmet.Size = new System.Drawing.Size(306, 39);
            this.cmbHizmet.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(22, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 32);
            this.label9.TabIndex = 20;
            this.label9.Text = "Hizmet";
            // 
            // cmbSaat
            // 
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Location = new System.Drawing.Point(205, 282);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(200, 39);
            this.cmbSaat.TabIndex = 5;
            // 
            // dtTarih
            // 
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTarih.Location = new System.Drawing.Point(205, 236);
            this.dtTarih.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(200, 38);
            this.dtTarih.TabIndex = 4;
            this.dtTarih.Value = new System.DateTime(2025, 12, 5, 0, 0, 0, 0);
            this.dtTarih.ValueChanged += new System.EventHandler(this.dtTarih_ValueChanged);
            // 
            // btnOtomatikPlanla
            // 
            this.btnOtomatikPlanla.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOtomatikPlanla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtomatikPlanla.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOtomatikPlanla.ForeColor = System.Drawing.Color.White;
            this.btnOtomatikPlanla.Location = new System.Drawing.Point(430, 446);
            this.btnOtomatikPlanla.Name = "btnOtomatikPlanla";
            this.btnOtomatikPlanla.Size = new System.Drawing.Size(209, 50);
            this.btnOtomatikPlanla.TabIndex = 17;
            this.btnOtomatikPlanla.Text = "Otomatik Planla";
            this.btnOtomatikPlanla.UseVisualStyleBackColor = false;
            this.btnOtomatikPlanla.Click += new System.EventHandler(this.btnOtomatikPlanla_Click);
            // 
            // btnRandevuOlustur
            // 
            this.btnRandevuOlustur.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRandevuOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandevuOlustur.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuOlustur.ForeColor = System.Drawing.Color.White;
            this.btnRandevuOlustur.Location = new System.Drawing.Point(205, 393);
            this.btnRandevuOlustur.Name = "btnRandevuOlustur";
            this.btnRandevuOlustur.Size = new System.Drawing.Size(219, 47);
            this.btnRandevuOlustur.TabIndex = 16;
            this.btnRandevuOlustur.Text = "Randevu Oluştur";
            this.btnRandevuOlustur.UseVisualStyleBackColor = false;
            this.btnRandevuOlustur.Click += new System.EventHandler(this.btnRandevuOlustur_Click);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(205, 182);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(306, 39);
            this.cmbDoktor.TabIndex = 3;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // cmbBrans
            // 
            this.cmbBrans.DisplayMember = "BransAdi";
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(205, 128);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(306, 39);
            this.cmbBrans.TabIndex = 2;
            this.cmbBrans.ValueMember = "BransID";
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(22, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Randevu Tarih:";
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(205, 72);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(150, 38);
            this.mskTC.TabIndex = 1;
            this.mskTC.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(22, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Randevu Saat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(22, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 32);
            this.label8.TabIndex = 9;
            this.label8.Text = "Hasta TC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(22, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Branş:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(22, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = "Doktor";
            // 
            // tabRandevular
            // 
            this.tabRandevular.Controls.Add(this.btnYenile);
            this.tabRandevular.Controls.Add(this.dgvRandevular);
            this.tabRandevular.Location = new System.Drawing.Point(4, 40);
            this.tabRandevular.Name = "tabRandevular";
            this.tabRandevular.Padding = new System.Windows.Forms.Padding(3);
            this.tabRandevular.Size = new System.Drawing.Size(774, 696);
            this.tabRandevular.TabIndex = 0;
            this.tabRandevular.Text = "Tüm Randevular";
            this.tabRandevular.UseVisualStyleBackColor = true;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYenile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnYenile.Location = new System.Drawing.Point(3, 646);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(768, 47);
            this.btnYenile.TabIndex = 18;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            // 
            // dgvRandevular
            // 
            this.dgvRandevular.AllowUserToAddRows = false;
            this.dgvRandevular.AllowUserToDeleteRows = false;
            this.dgvRandevular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRandevular.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRandevular.Location = new System.Drawing.Point(3, 3);
            this.dgvRandevular.Name = "dgvRandevular";
            this.dgvRandevular.ReadOnly = true;
            this.dgvRandevular.RowHeadersWidth = 72;
            this.dgvRandevular.RowTemplate.Height = 31;
            this.dgvRandevular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRandevular.Size = new System.Drawing.Size(768, 690);
            this.dgvRandevular.TabIndex = 0;
            // 
            // tabSekreter
            // 
            this.tabSekreter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSekreter.Controls.Add(this.tabRandevular);
            this.tabSekreter.Location = new System.Drawing.Point(692, 97);
            this.tabSekreter.Name = "tabSekreter";
            this.tabSekreter.SelectedIndex = 0;
            this.tabSekreter.Size = new System.Drawing.Size(782, 740);
            this.tabSekreter.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTarihSaat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1474, 104);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(572, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(656, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sekreter Paneli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTarihSaat
            // 
            this.lblTarihSaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarihSaat.AutoSize = true;
            this.lblTarihSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblTarihSaat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihSaat.ForeColor = System.Drawing.Color.DimGray;
            this.lblTarihSaat.Location = new System.Drawing.Point(1287, 9);
            this.lblTarihSaat.Name = "lblTarihSaat";
            this.lblTarihSaat.Size = new System.Drawing.Size(106, 30);
            this.lblTarihSaat.TabIndex = 2;
            this.lblTarihSaat.Text = "Tarih Saat";
            this.lblTarihSaat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmSekreterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1474, 844);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabSekreter);
            this.Controls.Add(this.grpRandevuYonetim);
            this.Controls.Add(this.grpSekreterBilgi);
            this.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSekreterPanel_FormClosed);
            this.Load += new System.EventHandler(this.FrmSekreterPanel_Load);
            this.grpSekreterBilgi.ResumeLayout(false);
            this.grpSekreterBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSekreter)).EndInit();
            this.grpRandevuYonetim.ResumeLayout(false);
            this.grpRandevuYonetim.PerformLayout();
            this.tabRandevular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).EndInit();
            this.tabSekreter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpSekreterBilgi;
        private System.Windows.Forms.TextBox txtSekreterKullaniciAdi;
        private System.Windows.Forms.TextBox txtSekreterAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpRandevuYonetim;
        private System.Windows.Forms.PictureBox picSekreter;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOtomatikPlanla;
        private System.Windows.Forms.Button btnRandevuOlustur;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.ComboBox cmbHizmet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRandevuIptal;
        private System.Windows.Forms.TabPage tabRandevular;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridView dgvRandevular;
        private System.Windows.Forms.TabControl tabSekreter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTarihSaat;
        private System.Windows.Forms.Button btnTemizle;
    }
}