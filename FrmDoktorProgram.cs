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
    public partial class FrmDoktorProgram : Form
    {
        private int _doktorID;
        private int _bransID;
        private string _doktorAd;
        private string _bransAd;

        public FrmDoktorProgram(int doktorID, int bransID, string doktorAd, string bransAd)
        {
            InitializeComponent();

            _doktorID = doktorID;
            _bransID = bransID;
            _doktorAd = doktorAd;
            _bransAd = bransAd;

            lblBaslik.Text = $"{doktorAd} - {bransAd} Çalışma Programı";
        }


        private void FrmDoktorProgram_Load(object sender, EventArgs e)
        {
            cmbGun.Items.Add("Pazartesi");
            cmbGun.Items.Add("Salı");
            cmbGun.Items.Add("Çarşamba");
            cmbGun.Items.Add("Perşembe");
            cmbGun.Items.Add("Cuma");
            cmbGun.Items.Add("Cumartesi");

            cmbGun.SelectedIndex = 0;

            dtBaslangic.CustomFormat = "HH:mm";
            dtBaslangic.Format = DateTimePickerFormat.Custom;
            dtBaslangic.ShowUpDown = true;

            dtBitis.CustomFormat = "HH:mm";
            dtBitis.Format = DateTimePickerFormat.Custom;
            dtBitis.ShowUpDown = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string gun = cmbGun.SelectedItem.ToString();
            TimeSpan bas = dtBaslangic.Value.TimeOfDay;
            TimeSpan bit = dtBitis.Value.TimeOfDay;

            if (bit <= bas)
            {
                MessageBox.Show("Bitiş saati, başlangıç saatinden büyük olmalıdır!",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1) Aynı gün var mı kontrol et
            string sqlKontrol = @"SELECT COUNT(*) FROM DoktorProgrami 
                          WHERE DoktorID=@doktor AND BransID=@brans AND Gun=@gun";

            SqlParameter[] prmKontrol =
            {
            new SqlParameter("@doktor", _doktorID),
            new SqlParameter("@brans", _bransID),
            new SqlParameter("@gun", gun)
            };

            int adet = Convert.ToInt32(DatabaseHelper.ExecuteScalar(sqlKontrol, prmKontrol));

            string sql;

            if (adet > 0)
            {
                // 2) Varsa UPDATE
                sql = @"UPDATE DoktorProgrami SET 
                    BaslangicSaati=@bas, 
                    BitisSaati=@bit 
                WHERE DoktorID=@doktor AND BransID=@brans AND Gun=@gun";
            }
            else
            {
                // 3) Yoksa INSERT
                sql = @"INSERT INTO DoktorProgrami 
                (DoktorID, BransID, Gun, BaslangicSaati, BitisSaati, Aktif)
                VALUES (@doktor, @brans, @gun, @bas, @bit, 1)";
            }

            SqlParameter[] prm =
            {
            new SqlParameter("@doktor", _doktorID),
            new SqlParameter("@brans", _bransID),
            new SqlParameter("@gun", gun),
            new SqlParameter("@bas", bas),
            new SqlParameter("@bit", bit)
            };

            int sonuc = DatabaseHelper.ExecuteNonQuery(sql, prm);

            if (sonuc > 0)
            {
                MessageBox.Show("Çalışma programı kaydedildi!", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Kayıt yapılamadı!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
