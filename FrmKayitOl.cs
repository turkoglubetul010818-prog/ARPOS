using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ARPOS
{
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();

            mskTC.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskTel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            //Zorunlu alan kontrolü
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                mskTC.Text.Length != 11 ||
                cmbRol.SelectedIndex <= 0)
            {
                MessageBox.Show("Lütfen tüm zorunlu alanları doldurunuz.",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Şifre minimum uzunluk kontrolü
            if (txtSifre.Text.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakter olmalıdır!",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Cinsiyet
            string cinsiyet = rbKadin.Checked ? "Kadın" :
                              rbErkek.Checked ? "Erkek" : "Belirtilmedi";

            //Doğum tarihi
            object dogumTarihi = DBNull.Value;
            if (DateTime.TryParse(mskDtarih.Text, out DateTime d))
            {
                //Gelecek tarih kontrolü
                if (d > DateTime.Today)
                {
                    MessageBox.Show("Doğum tarihi gelecekte olamaz!",
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dogumTarihi = d;
            }     

            //Kullanıcı adı kontrolü
            string checkQuery = "SELECT COUNT(*) FROM Kullanici WHERE KullaniciAdi = @kadi";
            SqlParameter[] prmCheck =
            {
                new SqlParameter("@kadi", txtKullaniciAdi.Text.Trim())
            };

            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery, prmCheck));
            if (count > 0)
            {
                MessageBox.Show("Bu kullanıcı adı zaten kullanımda!",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //SQL INSERT
            string insertQuery = @"INSERT INTO Kullanici (KullaniciAdi, Sifre, AdSoyad, TC, DogumTarihi, Cinsiyet, Rol, Email, Telefon, KayitTarihi, Aktif)
                VALUES (@KullaniciAdi, @Sifre, @AdSoyad, @TC, @DogumTarihi, @Cinsiyet, @Rol, @Email, @Telefon, GETDATE(), 1)";

            SqlParameter[] prm =
            {
                new SqlParameter("@KullaniciAdi", txtKullaniciAdi.Text.Trim()),
                new SqlParameter("@Sifre",        txtSifre.Text.Trim()),
                new SqlParameter("@AdSoyad",      txtAdSoyad.Text.Trim()),
                new SqlParameter("@TC",           mskTC.Text.Trim()),
                new SqlParameter("@DogumTarihi",  dogumTarihi),
                new SqlParameter("@Cinsiyet",     cinsiyet),
                new SqlParameter("@Rol",          cmbRol.SelectedItem.ToString()),
                new SqlParameter("@Email",        txtEmail.Text.Trim()),
                new SqlParameter("@Telefon",      mskTel.Text.Trim())
            };


            int sonuc = DatabaseHelper.ExecuteNonQuery(insertQuery, prm);

            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt başarıyla tamamlandı!",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Temizle();
                new FrmGiris().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kayıt gerçekleştirilemedi!",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            txtAdSoyad.Clear();
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            mskTC.Clear();
            mskDtarih.Clear();
            txtEmail.Clear();
            mskTel.Clear();
            rbKadin.Checked = false;
            rbErkek.Checked = false;
            cmbRol.SelectedIndex = 0;
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            new FrmGiris().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void FrmKayitOl_Load(object sender, EventArgs e)
        {
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Seçiniz");
            cmbRol.Items.Add("Hasta");
            cmbRol.Items.Add("Doktor");
            cmbRol.Items.Add("Sekreter");
            cmbRol.Items.Add("Yönetici");
            cmbRol.SelectedIndex = 0;
        }
    }
}