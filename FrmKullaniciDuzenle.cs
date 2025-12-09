using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARPOS
{
    public partial class FrmKullaniciDuzenle : Form
    {
        private int _id;
        private int _kullaniciID;

        public FrmKullaniciDuzenle(int kullaniciID)
        {
            InitializeComponent();

            _id = kullaniciID;
            _kullaniciID = kullaniciID;
        }

        private void FrmKullaniciDuzenle_Load(object sender, EventArgs e)
        {
            // Rol combobox doldur
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Hasta");
            cmbRol.Items.Add("Doktor");
            cmbRol.Items.Add("Sekreter");
            cmbRol.Items.Add("Yönetici");

            // Maskeler görünsün
            mskTC.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mskTel.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            string sql = @"SELECT KullaniciAdi, AdSoyad, TC, Email, Telefon, Rol 
                   FROM Kullanici 
                   WHERE KullaniciID = @id";

            SqlParameter[] prm = { new SqlParameter("@id", _kullaniciID) };
            DataTable dt = DatabaseHelper.ExecuteSelect(sql, prm);

            if (dt.Rows.Count > 0)
            {
                txtAdSoyad.Text = dt.Rows[0]["AdSoyad"].ToString();
                txtKullaniciAdi.Text = dt.Rows[0]["KullaniciAdi"].ToString();
                mskTC.Text = dt.Rows[0]["TC"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                mskTel.Text = dt.Rows[0]["Telefon"].ToString();

                cmbRol.SelectedItem = dt.Rows[0]["Rol"].ToString();
            }
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir rol seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = @"update Kullanici set KullaniciAdi=@KullaniciAdi, AdSoyad=@AdSoyad, Email=@Email,Telefon=@Telefon,TC=@TC, Rol=@Rol where KullaniciID=@id";

            SqlParameter[] prm =
            {
            new SqlParameter("@KullaniciAdi", txtKullaniciAdi.Text.Trim()),
            new SqlParameter("@AdSoyad", txtAdSoyad.Text.Trim()),
            new SqlParameter("@Email", txtEmail.Text.Trim()),
            new SqlParameter("@Telefon", mskTel.Text.Trim()),
            new SqlParameter("@TC", mskTC.Text.Trim()),
            new SqlParameter("@Rol", cmbRol.SelectedItem.ToString()),
            new SqlParameter("@id", _id)
            };

            int sonuc = DatabaseHelper.ExecuteNonQuery(sql, prm);

            if (sonuc > 0)
            {
                MessageBox.Show("Kullanıcı bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
