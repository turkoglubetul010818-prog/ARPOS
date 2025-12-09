namespace ARPOS
{
    partial class FrmDoktorProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorProgram));
            this.lblGun = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.cmbGun = new System.Windows.Forms.ComboBox();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Location = new System.Drawing.Point(74, 149);
            this.lblGun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(65, 32);
            this.lblGun.TabIndex = 0;
            this.lblGun.Text = "Gün:";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(74, 213);
            this.lblBaslangic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(183, 32);
            this.lblBaslangic.TabIndex = 1;
            this.lblBaslangic.Text = "Başlangıç Saati:";
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(74, 267);
            this.lblBitis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(127, 32);
            this.lblBitis.TabIndex = 2;
            this.lblBitis.Text = "Bitiş Saati:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(112, 345);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(145, 51);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(300, 345);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(159, 51);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // cmbGun
            // 
            this.cmbGun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGun.FormattingEnabled = true;
            this.cmbGun.Location = new System.Drawing.Point(274, 142);
            this.cmbGun.Name = "cmbGun";
            this.cmbGun.Size = new System.Drawing.Size(200, 39);
            this.cmbGun.TabIndex = 5;
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.CustomFormat = "\"HH:mm\"";
            this.dtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBaslangic.Location = new System.Drawing.Point(274, 207);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.ShowUpDown = true;
            this.dtBaslangic.Size = new System.Drawing.Size(121, 38);
            this.dtBaslangic.TabIndex = 6;
            // 
            // dtBitis
            // 
            this.dtBitis.CustomFormat = "\"HH:mm\"";
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBitis.Location = new System.Drawing.Point(274, 261);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.ShowUpDown = true;
            this.dtBitis.Size = new System.Drawing.Size(121, 38);
            this.dtBitis.TabIndex = 7;
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.ForeColor = System.Drawing.Color.Navy;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(811, 89);
            this.lblBaslik.TabIndex = 8;
            this.lblBaslik.Text = "Doktor Çalışma Programı Ayarı";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmDoktorProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 547);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslangic);
            this.Controls.Add(this.cmbGun);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.lblBaslangic);
            this.Controls.Add(this.lblGun);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoktorProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doktor programı";
            this.Load += new System.EventHandler(this.FrmDoktorProgram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.ComboBox cmbGun;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.Label lblBaslik;
    }
}