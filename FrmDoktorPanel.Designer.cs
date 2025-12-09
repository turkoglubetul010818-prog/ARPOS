namespace ARPOS
{
    partial class FrmDoktorPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDoktorBilgi = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBrans = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTarihSaat = new System.Windows.Forms.Label();
            this.grpRandevular = new System.Windows.Forms.GroupBox();
            this.dgvRandevular = new System.Windows.Forms.DataGridView();
            this.grpIslemler = new System.Windows.Forms.GroupBox();
            this.btnHastaRandevuGecmisi = new System.Windows.Forms.Button();
            this.btnRandevuGecmisi = new System.Windows.Forms.Button();
            this.btnRandevuDetay = new System.Windows.Forms.Button();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpDoktorBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpRandevular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).BeginInit();
            this.grpIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(475, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doktor Paneli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpDoktorBilgi
            // 
            this.grpDoktorBilgi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grpDoktorBilgi.Controls.Add(this.pictureBox2);
            this.grpDoktorBilgi.Controls.Add(this.txtBrans);
            this.grpDoktorBilgi.Controls.Add(this.txtAdSoyad);
            this.grpDoktorBilgi.Controls.Add(this.label3);
            this.grpDoktorBilgi.Controls.Add(this.label2);
            this.grpDoktorBilgi.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpDoktorBilgi.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpDoktorBilgi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpDoktorBilgi.Location = new System.Drawing.Point(0, 85);
            this.grpDoktorBilgi.Name = "grpDoktorBilgi";
            this.grpDoktorBilgi.Size = new System.Drawing.Size(454, 374);
            this.grpDoktorBilgi.TabIndex = 2;
            this.grpDoktorBilgi.TabStop = false;
            this.grpDoktorBilgi.Text = "Doktor Bilgileri";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(101, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // txtBrans
            // 
            this.txtBrans.Enabled = false;
            this.txtBrans.Location = new System.Drawing.Point(161, 305);
            this.txtBrans.Name = "txtBrans";
            this.txtBrans.ReadOnly = true;
            this.txtBrans.Size = new System.Drawing.Size(245, 38);
            this.txtBrans.TabIndex = 5;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Enabled = false;
            this.txtAdSoyad.Location = new System.Drawing.Point(161, 254);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.ReadOnly = true;
            this.txtAdSoyad.Size = new System.Drawing.Size(245, 38);
            this.txtAdSoyad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Branş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad:";
            // 
            // lblTarihSaat
            // 
            this.lblTarihSaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarihSaat.AutoSize = true;
            this.lblTarihSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblTarihSaat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihSaat.ForeColor = System.Drawing.Color.DimGray;
            this.lblTarihSaat.Location = new System.Drawing.Point(886, 12);
            this.lblTarihSaat.Name = "lblTarihSaat";
            this.lblTarihSaat.Size = new System.Drawing.Size(106, 30);
            this.lblTarihSaat.TabIndex = 2;
            this.lblTarihSaat.Text = "Tarih Saat";
            this.lblTarihSaat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpRandevular
            // 
            this.grpRandevular.BackColor = System.Drawing.Color.AliceBlue;
            this.grpRandevular.Controls.Add(this.dgvRandevular);
            this.grpRandevular.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpRandevular.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpRandevular.Location = new System.Drawing.Point(460, 85);
            this.grpRandevular.Name = "grpRandevular";
            this.grpRandevular.Size = new System.Drawing.Size(587, 629);
            this.grpRandevular.TabIndex = 3;
            this.grpRandevular.TabStop = false;
            this.grpRandevular.Text = "Günlük Randevular";
            // 
            // dgvRandevular
            // 
            this.dgvRandevular.AllowUserToAddRows = false;
            this.dgvRandevular.AllowUserToDeleteRows = false;
            this.dgvRandevular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRandevular.BackgroundColor = System.Drawing.Color.White;
            this.dgvRandevular.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRandevular.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevular.EnableHeadersVisualStyles = false;
            this.dgvRandevular.GridColor = System.Drawing.Color.LightGray;
            this.dgvRandevular.Location = new System.Drawing.Point(0, 44);
            this.dgvRandevular.MultiSelect = false;
            this.dgvRandevular.Name = "dgvRandevular";
            this.dgvRandevular.ReadOnly = true;
            this.dgvRandevular.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRandevular.RowHeadersVisible = false;
            this.dgvRandevular.RowHeadersWidth = 72;
            this.dgvRandevular.RowTemplate.Height = 31;
            this.dgvRandevular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRandevular.Size = new System.Drawing.Size(572, 579);
            this.dgvRandevular.TabIndex = 0;
            // 
            // grpIslemler
            // 
            this.grpIslemler.BackColor = System.Drawing.Color.AliceBlue;
            this.grpIslemler.Controls.Add(this.btnHastaRandevuGecmisi);
            this.grpIslemler.Controls.Add(this.btnRandevuGecmisi);
            this.grpIslemler.Controls.Add(this.btnRandevuDetay);
            this.grpIslemler.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpIslemler.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpIslemler.Location = new System.Drawing.Point(0, 465);
            this.grpIslemler.Name = "grpIslemler";
            this.grpIslemler.Size = new System.Drawing.Size(454, 249);
            this.grpIslemler.TabIndex = 4;
            this.grpIslemler.TabStop = false;
            this.grpIslemler.Text = "İşlemler";
            // 
            // btnHastaRandevuGecmisi
            // 
            this.btnHastaRandevuGecmisi.BackColor = System.Drawing.Color.Gray;
            this.btnHastaRandevuGecmisi.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHastaRandevuGecmisi.Location = new System.Drawing.Point(28, 105);
            this.btnHastaRandevuGecmisi.Name = "btnHastaRandevuGecmisi";
            this.btnHastaRandevuGecmisi.Size = new System.Drawing.Size(392, 50);
            this.btnHastaRandevuGecmisi.TabIndex = 3;
            this.btnHastaRandevuGecmisi.Text = "Hasta Randevu Geçmişi";
            this.btnHastaRandevuGecmisi.UseVisualStyleBackColor = false;
            this.btnHastaRandevuGecmisi.Click += new System.EventHandler(this.btnHastaRandevuGecmisi_Click);
            // 
            // btnRandevuGecmisi
            // 
            this.btnRandevuGecmisi.BackColor = System.Drawing.Color.Gray;
            this.btnRandevuGecmisi.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRandevuGecmisi.Location = new System.Drawing.Point(28, 49);
            this.btnRandevuGecmisi.Name = "btnRandevuGecmisi";
            this.btnRandevuGecmisi.Size = new System.Drawing.Size(392, 50);
            this.btnRandevuGecmisi.TabIndex = 1;
            this.btnRandevuGecmisi.Text = "Randevu Geçmişi";
            this.btnRandevuGecmisi.UseVisualStyleBackColor = false;
            this.btnRandevuGecmisi.Click += new System.EventHandler(this.btnRandevuGecmisi_Click);
            // 
            // btnRandevuDetay
            // 
            this.btnRandevuDetay.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRandevuDetay.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRandevuDetay.Location = new System.Drawing.Point(28, 161);
            this.btnRandevuDetay.Name = "btnRandevuDetay";
            this.btnRandevuDetay.Size = new System.Drawing.Size(392, 54);
            this.btnRandevuDetay.TabIndex = 0;
            this.btnRandevuDetay.Text = "Randevu Detayını Gör";
            this.btnRandevuDetay.UseVisualStyleBackColor = false;
            this.btnRandevuDetay.Click += new System.EventHandler(this.btnRandevuDetay_Click);
            // 
            // timerSaat
            // 
            this.timerSaat.Enabled = true;
            this.timerSaat.Interval = 1000;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(391, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTarihSaat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 79);
            this.panel1.TabIndex = 1;
            // 
            // FrmDoktorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1053, 718);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpIslemler);
            this.Controls.Add(this.grpRandevular);
            this.Controls.Add(this.grpDoktorBilgi);
            this.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDoktorPanel_FormClosed);
            this.Load += new System.EventHandler(this.FrmDoktorPanel_Load);
            this.grpDoktorBilgi.ResumeLayout(false);
            this.grpDoktorBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpRandevular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).EndInit();
            this.grpIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDoktorBilgi;
        private System.Windows.Forms.Label lblTarihSaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrans;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grpRandevular;
        private System.Windows.Forms.DataGridView dgvRandevular;
        private System.Windows.Forms.GroupBox grpIslemler;
        private System.Windows.Forms.Button btnRandevuGecmisi;
        private System.Windows.Forms.Button btnRandevuDetay;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHastaRandevuGecmisi;
    }
}