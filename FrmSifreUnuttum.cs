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
    public partial class FrmSifreUnuttum : Form
    {
        public FrmSifreUnuttum()
        {
            InitializeComponent();
        }
        private void FrmSifreUnuttum_Load(object sender, EventArgs e)
        {
            pnlYeniSifre.Visible = false;
        }
        private int _kullaniciID = -1;

        private void btnDevam_Click(object sender, EventArgs e)
        {
            _kullaniciID = -1; // reset

            if (txtBilgi.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen TC veya Email giriniz!");
                return;
            }

            string sql = @"SELECT KullaniciID 
                   FROM Kullanici 
                   WHERE TC=@p OR Email=@p";

            SqlParameter[] prm =
            {
        new SqlParameter("@p", txtBilgi.Text.Trim())
    };

            DataTable dt = DatabaseHelper.ExecuteSelect(sql, prm);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Bu bilgilerle eşleşen bir kullanıcı bulunamadı!",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _kullaniciID = Convert.ToInt32(dt.Rows[0]["KullaniciID"]);

            txtSifre.Clear();
            txtSifreTekrar.Clear();

            pnlYeniSifre.Visible = true;
            pnlKimlik.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_kullaniciID == -1)
            {
                MessageBox.Show("Lütfen önce TC veya Email doğrulayın!");
                return;
            }

            string s1 = txtSifre.Text.Trim();
            string s2 = txtSifreTekrar.Text.Trim();

            if (s1.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakter olmalıdır!");
                return;
            }

            if (s1 != s2)
            {
                MessageBox.Show("Şifreler uyuşmuyor!");
                return;
            }

            string sql = "UPDATE Kullanici SET Sifre=@s WHERE KullaniciID=@id";

            SqlParameter[] prm =
            {
        new SqlParameter("@s", s1),
        new SqlParameter("@id", _kullaniciID)
            };

            DatabaseHelper.ExecuteNonQuery(sql, prm);

            MessageBox.Show("Şifre başarıyla güncellendi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private bool sifreGorunur = false;

        private void pbSifreGoster_Click(object sender, EventArgs e)
        {
            if (!sifreGorunur)
            {
                txtSifre.PasswordChar = '\0';   // Şifreyi göster
                picSifreGoster.Image = Properties.Resources.eye;
                sifreGorunur = true;
            }
            else
            {
                txtSifre.PasswordChar = '*';    // Şifreyi gizle
                picSifreGoster.Image = Properties.Resources.eye_hide;
                sifreGorunur = false;
            }
        }


        private bool sifreTekrarGorunur = false;
        private void pbTekrarGoster_Click(object sender, EventArgs e)
        {
            if (!sifreTekrarGorunur)
            {
                txtSifreTekrar.PasswordChar = '\0';
                sifreTekrarGorunur = true;
            }
            else
            {
                txtSifreTekrar.PasswordChar = '*';
                sifreTekrarGorunur = false;
            }
        }
    }
}
