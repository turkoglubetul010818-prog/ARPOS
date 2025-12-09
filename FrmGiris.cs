using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARPOS
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
            linkSifremiUnuttum.Text = "Şifremi Unuttum?";
        }


        bool sifreGorunur = false;
        private void picSifreGoster_Click(object sender, EventArgs e)
        {
            if (sifreGorunur)
            {
                //Şifre Gizle
                txtSifre.PasswordChar = '•';
                picSifreGoster.Image = Properties.Resources.eye;
                sifreGorunur = false;
            }
            else
            {
                txtSifre.PasswordChar = '\0';
                picSifreGoster.Image = Properties.Resources.eye_hide;
                sifreGorunur = true;
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"select KullaniciID, Rol, AdSoyad from Kullanici where KullaniciAdi = @adi and Sifre = @sifre and Aktif = 1";

            SqlParameter[] prm =
            {
            new SqlParameter("@adi",   kullaniciAdi),
            new SqlParameter("@sifre", sifre)
            };

            DataTable dt = DatabaseHelper.ExecuteSelect(query, prm);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string rol = dt.Rows[0]["Rol"].ToString();
            string adSoyad = dt.Rows[0]["AdSoyad"].ToString();
            int kullaniciID = Convert.ToInt32(dt.Rows[0]["KullaniciID"]);

            MessageBox.Show($"Giriş başarılı!\nHoş geldiniz {adSoyad}.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            switch (rol)
            {
                case "Doktor":
                    new FrmDoktorPanel(kullaniciID).Show();
                    break;
                case "Hasta":
                    new FrmHastaPanel(kullaniciID).Show();
                    break;
                case "Sekreter":
                    new FrmSekreterPanel(kullaniciID).Show();
                    break;
                case "Yönetici":
                    new FrmYoneticiPanel(kullaniciID).Show();
                    break;
                default:
                    MessageBox.Show("Geçersiz rol türü!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            this.Hide();
        }


        private void FrmGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            FrmKayitOl kayitForm=new FrmKayitOl();
            kayitForm.ShowDialog();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            //tarih-saat güncellemesi
            lblTarihSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarihSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGiris.PerformClick();
        }

        private void linkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifreUnuttum frm = new FrmSifreUnuttum();
            frm.ShowDialog();
        }
    }
}

