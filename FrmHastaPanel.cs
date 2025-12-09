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
    public partial class FrmHastaPanel : Form
    {
        private int _kullaniciID;
        public FrmHastaPanel(int kullaniciID)
        {
            InitializeComponent();
            _kullaniciID = kullaniciID;
        }

        private void FrmHastaPanel_Load(object sender, EventArgs e)
        {
            try
            {
                HastaBilgileriniGetir();
                BranslariGetir();
                RandevularimiGetir();
                RandevuGecmisiGetir();

                dtpTarih.MinDate = DateTime.Today;
                dtpTarih.Value = DateTime.Today;

                cmbSaat.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta paneli yüklenirken bir hata oluştu.\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void HastaBilgileriniGetir()
        {
            string sql = @"select AdSoyad, TC, DogumTarihi from Kullanici where KullaniciID = @id";

            SqlParameter[] prm = { new SqlParameter("@id", _kullaniciID) };
            DataTable dt = DatabaseHelper.ExecuteSelect(sql, prm);

            if (dt == null || dt.Rows.Count == 0)
                return;
            
            DataRow dr = dt.Rows[0];
                txtAdSoyad.Text = dt.Rows[0]["AdSoyad"].ToString();
                mskTC.Text = dt.Rows[0]["TC"].ToString();
                if (dr["DogumTarihi"] != DBNull.Value)
                {
                    DateTime dogum = Convert.ToDateTime(dr["DogumTarihi"]);
                    mskDogumTarihi.Text = dogum.ToString("ddMMyyyy");
                }
            
        }
        private void BranslariGetir()
        {
            string sql = "select BransID, BransAdi from DoktorBrans where Aktif = 1 order by BransAdi";

            DataTable dt = DatabaseHelper.ExecuteSelect(sql, null);
            if (dt == null)
            {
                MessageBox.Show("Branşlar yüklenemedi!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cmbBrans.DataSource = dt;
            cmbBrans.DisplayMember = "BransAdi";
            cmbBrans.ValueMember = "BransID";
            cmbBrans.SelectedIndex = -1;

            cmbDoktor.DataSource = null;
            cmbSaat.Items.Clear();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Focus kontrolünü KALDIRIYORUZ
            if (cmbBrans.SelectedIndex < 0)
            {
                cmbDoktor.DataSource = null;
                cmbSaat.Items.Clear();
                return;
            }

            DoktorlariGetir();
            cmbSaat.Items.Clear();
        }


        private void DoktorlariGetir()
        {
            // 1) HİÇ SEÇİM YOKSA DUR
            if (cmbBrans.SelectedIndex < 0 || cmbBrans.SelectedValue == null)
            {
                cmbDoktor.DataSource = null;
                cmbSaat.Items.Clear();
                return;
            }

            // 2) DataRowView ise doğru değeri al
            int bransID;
            if (cmbBrans.SelectedValue is DataRowView drv)
                bransID = Convert.ToInt32(drv["BransID"]);
            else
                bransID = Convert.ToInt32(cmbBrans.SelectedValue);

            string sql = @"select distinct K.KullaniciID, K.AdSoyad 
                   from DoktorProgrami DP
                   join Kullanici K on DP.DoktorID = K.KullaniciID
                   where DP.BransID = @bransID and DP.Aktif = 1 and K.Aktif = 1 order by K.AdSoyad";

            SqlParameter[] prm =
            {
            new SqlParameter("@bransID", bransID)
            };

            DataTable dt = DatabaseHelper.ExecuteSelect(sql, prm);
            if (dt == null)
            {
                MessageBox.Show("Doktor bilgileri alınamadı!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmbDoktor.DataSource = dt;
            cmbDoktor.DisplayMember = "AdSoyad";
            cmbDoktor.ValueMember = "KullaniciID";
            cmbDoktor.SelectedIndex = -1;

            cmbSaat.Items.Clear();
        }


        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbDoktor.Focused) return;

            cmbSaat.Items.Clear();

            // Doktor seçildiğinde tarihi yoklamaya zorla
            dtpTarih_ValueChanged(null, null);
        }




        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            if (cmbDoktor.SelectedIndex == -1)
            {
                cmbSaat.Items.Clear();
                return;
            }

            string secilenGun = GunAdi(dtpTarih.Value.DayOfWeek);

            if (!DoktorBuGunCalisiyorMu(secilenGun))
            {
                MessageBox.Show("Seçilen tarihte doktorun çalışma saati bulunmuyor.",
                                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbSaat.Items.Clear();
                return;
            }

            SaatleriGetir();
        }

        private bool DoktorBuGunCalisiyorMu(string gun)
        {
            try
            {
                if (cmbDoktor.SelectedIndex < 0 || cmbDoktor.SelectedValue == null)
                    return false;

                int doktorID;

                // 🔹 Hem int hem DataRowView durumunu destekle
                if (cmbDoktor.SelectedValue is DataRowView drv)
                    doktorID = Convert.ToInt32(drv["KullaniciID"]);
                else
                    doktorID = Convert.ToInt32(cmbDoktor.SelectedValue);

                string sql = @"SELECT COUNT(*)
                       FROM DoktorProgrami
                       WHERE DoktorID = @doktorID AND Gun = @gun AND Aktif    = 1";

                SqlParameter[] prm =
                {
                new SqlParameter("@doktorID", doktorID),
                new SqlParameter("@gun", gun)
                };

                object sonuc = DatabaseHelper.ExecuteScalar(sql, prm);
                int adet = (sonuc == null || sonuc == DBNull.Value) ? 0 : Convert.ToInt32(sonuc);

                return adet > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktor çalışma bilgisi alınamadı: " + ex.Message);
                return false;
            }
        }



        private void SaatleriGetir()
        {
            cmbSaat.Items.Clear();

            //if (cmbDoktor.SelectedValue == null)
            //    return;

            //if (cmbBrans.SelectedValue == null)
            //    return;

            if (cmbDoktor.SelectedIndex < 0 || cmbDoktor.SelectedValue == null)
                return;

            if (cmbBrans.SelectedIndex < 0 || cmbBrans.SelectedValue == null)
                return;



            int doktorID = Convert.ToInt32(cmbDoktor.SelectedValue);
            int bransID = Convert.ToInt32(cmbBrans.SelectedValue);
            DateTime tarih = dtpTarih.Value.Date;
            string gun = GunAdi(tarih.DayOfWeek);

            // 1) Doktorun o gün için programı
            string sqlProgram = @"select BaslangicSaati, BitisSaati from DoktorProgrami where DoktorID = @doktorID and BransID  = @bransID and Gun = @gun and Aktif = 1";

            SqlParameter[] prmProgram =
            {
                new SqlParameter("@doktorID", doktorID),
                new SqlParameter("@bransID",  bransID),
                new SqlParameter("@gun",      gun)
            };

            DataTable dtProgram = DatabaseHelper.ExecuteSelect(sqlProgram, prmProgram);
            if (dtProgram == null || dtProgram.Rows.Count == 0)
            {
                MessageBox.Show("Seçilen tarihte doktorun çalışma saati bulunmuyor.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TimeSpan baslangic = (TimeSpan)dtProgram.Rows[0]["BaslangicSaati"];
            TimeSpan bitis = (TimeSpan)dtProgram.Rows[0]["BitisSaati"];

            // 2) Doktorun o gün dolu randevu saatleri
            string sqlRandevu = @"select Saat from Randevular where DoktorID = @doktorID and Tarih    = @tarih and Durum = N'Onaylandı'";

            SqlParameter[] prmRandevu =
            {
                new SqlParameter("@doktorID", doktorID),
                new SqlParameter("@tarih",    tarih)
            };

            DataTable dtRandevu = DatabaseHelper.ExecuteSelect(sqlRandevu, prmRandevu);
            if (dtRandevu == null)
            {
                MessageBox.Show("Randevu bilgileri alınamadı!",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var doluSaatler = dtRandevu.AsEnumerable().Select(r => TimeSpan.Parse(r["Saat"].ToString())).ToList();

            // 3) Boş saatleri üret (30 dakikalık slot)
            TimeSpan slot = TimeSpan.FromMinutes(30);
            DateTime simdi = DateTime.Now;

            for (TimeSpan t = baslangic; t < bitis; t = t.Add(slot))
            {
                if (doluSaatler.Contains(t))               // o saat zaten dolu
                    continue;

                if (tarih == simdi.Date && t <= simdi.TimeOfDay) // geçmiş saatler
                    continue;

                cmbSaat.Items.Add(t.ToString(@"hh\:mm"));
            }

            if (cmbSaat.Items.Count == 0)
                MessageBox.Show("Seçilen gün için uygun randevu saati bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private string GunAdi(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday: return "Pazartesi";
                case DayOfWeek.Tuesday: return "Salı";
                case DayOfWeek.Wednesday: return "Çarşamba";
                case DayOfWeek.Thursday: return "Perşembe";
                case DayOfWeek.Friday: return "Cuma";
                case DayOfWeek.Saturday: return "Cumartesi";
                case DayOfWeek.Sunday: return "Pazar";
                default: return "";
            }
        }
        private void RandevuGecmisiGetir()
        {
            string sql = @"
        SELECT R.RandevuID, R.Tarih, R.Saat,
               D.AdSoyad AS Doktor,
               B.BransAdi AS Brans,
               R.Durum
        FROM Randevular R
        JOIN Kullanici   D ON R.DoktorID = D.KullaniciID
        JOIN DoktorBrans B ON R.BransID  = B.BransID
        WHERE R.HastaID = @hastaID
          AND (R.Tarih < CAST(GETDATE() AS date) 
               OR R.Durum LIKE N'İptal%')
        ORDER BY R.Tarih DESC, R.Saat DESC";

            SqlParameter[] prm =
            {
        new SqlParameter("@hastaID", _kullaniciID)
    };

            DataTable dt = DatabaseHelper.ExecuteSelect(sql, prm);
            dgvRandevuGecmis.DataSource = dt;

            if (dgvRandevuGecmis.Columns["RandevuID"] != null)
                dgvRandevuGecmis.Columns["RandevuID"].Visible = false;
        }


        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
             if (cmbBrans.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir branş seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbDoktor.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir doktor seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSaat.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir randevu saati seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bransID   = Convert.ToInt32(cmbBrans.SelectedValue);
            int doktorID  = Convert.ToInt32(cmbDoktor.SelectedValue);
            DateTime tarih = dtpTarih.Value.Date;
            string saat    = cmbSaat.SelectedItem.ToString();

            // Aynı saatte daha önce randevu alınmış mı son kontrol
            string kontrolSql = @"select COUNT(*) from Randevular where DoktorID = @doktor and Tarih = @tarih and Saat = @saat and Durum= N'Onaylandı'";

            SqlParameter[] prmKontrol =
            {
                new SqlParameter("@doktor", doktorID),
                new SqlParameter("@tarih",  tarih),
                new SqlParameter("@saat",   saat)
            };

            object sonucObj = DatabaseHelper.ExecuteScalar(kontrolSql, prmKontrol);
            int adet = 0;

            if (sonucObj != null && sonucObj != DBNull.Value)
                adet = Convert.ToInt32(sonucObj);

            if (adet > 0)
            {
                MessageBox.Show("Seçilen saatte zaten randevu bulunuyor, lütfen başka saat seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SaatleriGetir(); //listeyi güncelle
                return;
            }

            string insertSql = @"insert into Randevular(HastaID, DoktorID, BransID, Tarih, Saat, Durum)
                                values (@hasta, @doktor, @brans, @tarih, @saat, N'Onaylandı')";

            SqlParameter[] prmInsert =
            {
                new SqlParameter("@hasta",  _kullaniciID),
                new SqlParameter("@doktor", doktorID),
                new SqlParameter("@brans",  bransID),
                new SqlParameter("@tarih",  tarih),
                new SqlParameter("@saat",   saat)
            };

            int sonuc = DatabaseHelper.ExecuteNonQuery(insertSql, prmInsert);

            if (sonuc > 0)
            {
                MessageBox.Show("Randevunuz oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RandevularimiGetir();
                RandevuGecmisiGetir();
                SaatleriGetir(); // ilgili saat artık dolu
            }
            else
            {
                MessageBox.Show("Randevu oluşturulamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RandevularimiGetir()
        {
            string sql = @"
        SELECT R.RandevuID, R.Tarih, R.Saat,
               D.AdSoyad AS Doktor,
               B.BransAdi AS Brans,
               R.Durum
        FROM Randevular R
        JOIN Kullanici   D ON R.DoktorID = D.KullaniciID
        JOIN DoktorBrans B ON R.BransID  = B.BransID
        WHERE R.HastaID = @hastaID
          AND R.Tarih >= CAST(GETDATE() AS date)
        ORDER BY R.Tarih, R.Saat";

            SqlParameter[] prm =
            {
        new SqlParameter("@hastaID", _kullaniciID)
    };

            DataTable dt = DatabaseHelper.ExecuteSelect(sql, prm);
            dgvRandevularım.DataSource = dt;

            if (dgvRandevularım.Columns["RandevuID"] != null)
                dgvRandevularım.Columns["RandevuID"].Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarihSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }

        private void btnRandevuIptal_Click(object sender, EventArgs e)
        {
            if (dgvRandevularım.CurrentRow == null)
            {
                MessageBox.Show("Lütfen iptal edilecek randevuyu seçin!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tabControl1.SelectedTab == tabGecmisRandevular)
            {
                MessageBox.Show("Geçmiş randevular iptal edilemez!", "Uyarı");
                return;
            }


            int randevuID = Convert.ToInt32(dgvRandevularım.CurrentRow.Cells["RandevuID"].Value);

            DialogResult dr = MessageBox.Show("Bu randevuyu iptal etmek istiyor musunuz?",
                 "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No) return;

            string sql = @"update Randevular 
                   set Durum = N'İptal (Hasta)' 
                   where RandevuID = @id";

            SqlParameter[] prm =
            {
        new SqlParameter("@id", randevuID)
    };

            int sonuc = DatabaseHelper.ExecuteNonQuery(sql, prm);

            if (sonuc > 0)
            {
                MessageBox.Show("Randevu başarıyla iptal edildi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                RandevularimiGetir();
                RandevuGecmisiGetir();
                SaatleriGetir();
            }
            else
            {
                MessageBox.Show("Randevu iptal edilemedi!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmHastaPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
        }
    }
}
