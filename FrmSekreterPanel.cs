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
using System.Data.SqlTypes;

namespace ARPOS
{
    public partial class FrmSekreterPanel : Form
    {
        private int _kullaniciID;

        public FrmSekreterPanel(int kullaniciID)
        {
            InitializeComponent();
            _kullaniciID = kullaniciID;
        }

        private void FrmSekreterPanel_Load(object sender, EventArgs e)
        {
            try
            {
                SekreterBilgileriniYukle();
                BranslariYukle();
                HizmetleriGetir();
                RandevulariListele();

                dtTarih.MinDate = DateTime.Today;

                // Tarih kutusu başlangıçta boş görünsün
                dtTarih.CustomFormat = " ";
                dtTarih.Format = DateTimePickerFormat.Custom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sekreter paneli yüklenirken hata oluştu:\n" + ex.Message,"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            timer1.Start();
            lblTarihSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }
        // 1) SEKRETER BİLGİLERİNİ GETİR
        private void SekreterBilgileriniYukle()
        {
            string sql = "Select AdSoyad, KullaniciAdi from Kullanici where KullaniciID = @id";

            SqlParameter[] prm =
            {
                new SqlParameter("@id", _kullaniciID)
            };

            DataTable dt = DatabaseHelper.ExecuteSelect(sql, prm);

            if (dt.Rows.Count > 0)
            {
                txtSekreterAdSoyad.Text = dt.Rows[0]["AdSoyad"].ToString();
                txtSekreterKullaniciAdi.Text = dt.Rows[0]["KullaniciAdi"].ToString();
            }
        }
        // 2) BRANŞLARI YÜKLE   
        private void BranslariYukle()
        {
            cmbBrans.DataSource = null;
            string sql = "select BransID, BransAdi from DoktorBrans where Aktif = 1 order by BransAdi";

            DataTable dt = DatabaseHelper.ExecuteSelect(sql, null);

            cmbBrans.DataSource = dt;
            cmbBrans.DisplayMember = "BransAdi";
            cmbBrans.ValueMember = "BransID";
            cmbBrans.SelectedIndex = -1;

            cmbDoktor.DataSource = null;
            cmbSaat.Items.Clear();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSaat.Items.Clear();
            dtTarih.CustomFormat = " "; // tarih alanını da sıfırlayalım
            cmbDoktor.DataSource = null;

            if (cmbBrans.SelectedIndex < 0 || cmbBrans.SelectedValue == null)
                return;

            DoktorlariYukle();

            //Eğer bu branşta hiç doktor yoksa uyarı göster
            if (cmbDoktor.Items.Count == 0)
            {
                MessageBox.Show(
                    "Bu branşa ait aktif çalışan doktor bulunmamaktadır.", "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
        }


        // 3) DOKTORLARI BRANŞA GÖRE YÜKLE
        private void DoktorlariYukle()
        {
            if (cmbBrans.SelectedIndex < 0 || cmbBrans.SelectedValue == null)
            {
                cmbDoktor.DataSource = null;
                return;
            }

            string sql = @"SELECT DISTINCT  K.KullaniciID, K.AdSoyad FROM Kullanici K JOIN DoktorProgrami DP ON K.KullaniciID = DP.DoktorID
                WHERE DP.BransID = @brans AND DP.Aktif = 1 AND K.Aktif = 1 ORDER BY K.AdSoyad";

            SqlParameter[] prm =
            {
            new SqlParameter("@brans", cmbBrans.SelectedValue)
            };

            DataTable dt = DatabaseHelper.ExecuteSelect(sql, prm);

            cmbDoktor.DataSource = dt;
            cmbDoktor.DisplayMember = "AdSoyad";
            cmbDoktor.ValueMember = "KullaniciID";
            cmbDoktor.SelectedIndex = -1;
        }


        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbDoktor.Focused)
                return;

            SaatleriGetir();
        }

        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {
            dtTarih.CustomFormat = "dd.MM.yyyy";  
            SaatleriGetir();
        }


        // 4) SAATLERİ DOKTOR PROGRAMINA GÖRE GETİR
        private void SaatleriGetir()
        {
            // 1) Tarih seçilmemişse çalışmasın
            if (dtTarih.CustomFormat == " ")
                return;

            // 2) Branş ve doktor seçilmemişse çalışmasın
            if (cmbBrans.SelectedIndex < 0 || cmbBrans.SelectedValue == null) return;
            if (cmbDoktor.SelectedIndex < 0 || cmbDoktor.SelectedValue == null) return;

            cmbSaat.Items.Clear();

            int doktorID = Convert.ToInt32(cmbDoktor.SelectedValue);
            int bransID = Convert.ToInt32(cmbBrans.SelectedValue);
            DateTime tarih = dtTarih.Value.Date;
            string gun = GunAdi(tarih.DayOfWeek);

            // 3) Doktor programı sorgula
            string sqlPrg = @"SELECT BaslangicSaati, BitisSaati FROM DoktorProgrami
                            WHERE DoktorID = @doktor AND BransID = @brans AND Gun = @gun AND Aktif = 1";

            SqlParameter[] prmPrg =
            {
            new SqlParameter("@doktor", doktorID),
            new SqlParameter("@brans",  bransID),
            new SqlParameter("@gun",    gun)
            };  

            DataTable dtP = DatabaseHelper.ExecuteSelect(sqlPrg, prmPrg);

            if (dtP.Rows.Count == 0)
            {
                MessageBox.Show("Seçilen tarihte bu doktorun çalışma programı bulunmuyor.",
                                 "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TimeSpan baslangic = (TimeSpan)dtP.Rows[0]["BaslangicSaati"];
            TimeSpan bitis = (TimeSpan)dtP.Rows[0]["BitisSaati"];

            // 4) Dolu saatleri çek
            string sqlDolu = @"SELECT Saat FROM Randevular WHERE DoktorID = @doktor AND Tarih = @tarih AND Durum = N'Onaylandı'";

            SqlParameter[] prmDolu =
            {
            new SqlParameter("@doktor", doktorID),
            new SqlParameter("@tarih",  tarih)
            };

            DataTable dtD = DatabaseHelper.ExecuteSelect(sqlDolu, prmDolu);
            var doluSaatler = dtD.AsEnumerable()
                                 .Select(r => TimeSpan.Parse(r["Saat"].ToString()))
                                 .ToList();

            // 5) Boş saatleri listele
            TimeSpan slot = TimeSpan.FromMinutes(30);

            for (TimeSpan t = baslangic; t < bitis; t = t.Add(slot))
            {
                if (!doluSaatler.Contains(t))
                    cmbSaat.Items.Add(t.ToString(@"hh\:mm"));
            }
        }

        private string GunAdi(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday: return "Pazartesi";
                case DayOfWeek.Tuesday: return "Salı";
                case DayOfWeek.Wednesday: return "Çarşamba";
                case DayOfWeek.Thursday: return "Perşembe";
                case DayOfWeek.Friday: return "Cuma";
                case DayOfWeek.Saturday: return "Cumartesi";
                case DayOfWeek.Sunday: return "Pazar";
            }
            return "";
        }

        // 5) RANDEVU OLUŞTUR
        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            // --- 1) Zorunlu alan kontrolü ---
            if (mskTC.Text.Length < 11 ||
                cmbBrans.SelectedIndex == -1 ||
                cmbDoktor.SelectedIndex == -1 ||
                cmbSaat.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hizmet kontrolü ayrı yapılmalı
            if (cmbHizmet.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir hizmet seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Hasta var mı kontrol
            int hastaID = HastaBul(mskTC.Text.Trim());

            if (hastaID == -1)
            {
                MessageBox.Show("Bu TC numarasına ait hasta bulunamadı!", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int doktorID = Convert.ToInt32(cmbDoktor.SelectedValue);
            int bransID = Convert.ToInt32(cmbBrans.SelectedValue);
            int hizmetID = Convert.ToInt32(cmbHizmet.SelectedValue);
            DateTime tarih = dtTarih.Value.Date;
            string saat = cmbSaat.SelectedItem.ToString();

            // AYNI HASTA AYNI GÜN AYNI DOKTORA İKİ KEZ RANDEVU ALAMAZ
            string hastaKontrolSql = @"SELECT COUNT(*) FROM Randevular WHERE HastaID = @hasta AND DoktorID = @doktor AND Tarih = @tarih AND Durum= N'Onaylandı'";

            SqlParameter[] prmHastaKontrol =
            {
            new SqlParameter("@hasta", hastaID),
            new SqlParameter("@doktor", doktorID),
            new SqlParameter("@tarih", tarih)
            };

            int hastaAyniGun = Convert.ToInt32(DatabaseHelper.ExecuteScalar(hastaKontrolSql, prmHastaKontrol));

            if (hastaAyniGun > 0)
            {
                MessageBox.Show("Bu hasta, bu doktordan bugün zaten bir randevu almış!",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //4) Randevu saat çakışma kontrolü
            string kontrolSql = @"SELECT COUNT(*) FROM Randevular WHERE DoktorID=@doktor AND Tarih=@tarih AND Saat=@saat AND Durum= N'Onaylandı'";

            SqlParameter[] prmKontrol =
            {
            new SqlParameter("@doktor", doktorID),
            new SqlParameter("@tarih", tarih),
            new SqlParameter("@saat",  saat)
            };

            int adet = Convert.ToInt32(DatabaseHelper.ExecuteScalar(kontrolSql, prmKontrol));

            if (adet > 0)
            {
                MessageBox.Show("Bu saat dolu! Lütfen başka saat seçin.", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);

                SaatleriGetir();
                return;
            }

            // --- 5) Randevuyu kaydet ---
            string insertSql = @"INSERT INTO Randevular (HastaID, DoktorID, BransID, HizmetID, Tarih, Saat, Durum)
            VALUES (@hasta, @doktor, @brans, @hizmet, @tarih, @saat, N'Onaylandı')";

            SqlParameter[] prmIns =
            {
            new SqlParameter("@hasta", hastaID),
            new SqlParameter("@doktor", doktorID),
            new SqlParameter("@brans", bransID),
            new SqlParameter("@hizmet", hizmetID),
            new SqlParameter("@tarih", tarih),
            new SqlParameter("@saat",  saat)
            };

            int sonuc = DatabaseHelper.ExecuteNonQuery(insertSql, prmIns);

            if (sonuc > 0)
            {
                MessageBox.Show("Randevu başarıyla oluşturuldu!", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                RandevulariListele();
                SaatleriGetir();
            }
            else
            {
                MessageBox.Show("Randevu oluşturulamadı!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AlanlariTemizle();
        }



        private int HastaBul(string tc)
        {
            string sql = "select KullaniciID from Kullanici where TC=@tc and Rol='Hasta'";

            SqlParameter[] prm =
            {
                new SqlParameter("@tc", tc)
            };

            object sonuc = DatabaseHelper.ExecuteScalar(sql, prm);

            return sonuc == null ? -1 : Convert.ToInt32(sonuc);
        }
        // 6) TÜM RANDEVULARI LİSTELE
        private void RandevulariListele()
        {
            string sql = @"select R.RandevuID, H.AdSoyad as Hasta, D.AdSoyad as Doktor,B.BransAdi as Branş, R.Tarih, R.Saat, R.Durum from Randevular R
                join Kullanici H on R.HastaID = H.KullaniciID
                join Kullanici D on R.DoktorID = D.KullaniciID
                join DoktorBrans B on R.BransID = B.BransID
                order by R.RandevuID desc";

            DataTable dt = DatabaseHelper.ExecuteSelect(sql, null);

            dgvRandevular.DataSource = dt;

            dgvRandevular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRandevular.ReadOnly = true;
            dgvRandevular.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            RandevulariListele();
        }

        private void HizmetleriGetir()
        {
            string sql = @"SELECT HizmetID, HizmetAdi FROM Hizmet WHERE Aktif = 1 ORDER BY HizmetAdi";

            DataTable dt = DatabaseHelper.ExecuteSelect(sql, null);

            cmbHizmet.DataSource = dt;
            cmbHizmet.DisplayMember = "HizmetAdi";
            cmbHizmet.ValueMember = "HizmetID";
            cmbHizmet.SelectedIndex = -1;
        }

        private void btnRandevuIptal_Click(object sender, EventArgs e)
        {
            // 1) Seçim kontrolü
            if (dgvRandevular.CurrentRow == null)
            {
                MessageBox.Show("Lütfen iptal edilecek randevuyu seçin!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) ID güvenli şekilde alınır
            if (!int.TryParse(dgvRandevular.CurrentRow.Cells["RandevuID"].Value.ToString(), out int randevuID))
            {
                MessageBox.Show("Randevu seçilemedi!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3) Onay ekranı
            DialogResult dr = MessageBox.Show(
                "Bu randevuyu iptal etmek istiyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.No) return;

            // 4) Veri tabanında iptal et
            string sql = @"UPDATE Randevular 
                   SET Durum = N'İptal (Sekreter)' 
                   WHERE RandevuID = @id";

            SqlParameter[] prm =
            {
            new SqlParameter("@id", randevuID)
            };

            int sonuc = DatabaseHelper.ExecuteNonQuery(sql, prm);

            // 5) Sonuç
            if (sonuc > 0)
            {
                MessageBox.Show("Randevu sekreter tarafından iptal edildi.", "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

                RandevulariListele();

                // İptal edilen randevu saati yeniden boş gözüksün
                SaatleriGetir();
            }
            else
            {
                MessageBox.Show("Randevu iptal edilemedi!", "Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarihSaat.Text=DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }

        private void FrmSekreterPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
        }

        private void AlanlariTemizle()
        {
            mskTC.Clear();

            cmbBrans.SelectedIndex = -1;
            cmbDoktor.DataSource = null;

            cmbSaat.Items.Clear();
            cmbSaat.SelectedIndex = -1;
            cmbSaat.Text = "";

            cmbHizmet.SelectedIndex = -1;

            // Tarihi tamamen sıfırla
            dtTarih.CustomFormat = " ";
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }

        private void btnOtomatikPlanla_Click(object sender, EventArgs e)
        {
            // 1) Zorunlu alan kontrolleri
            if (mskTC.Text.Length < 11)
            {
                MessageBox.Show("Lütfen hasta TC girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbBrans.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen branş seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbHizmet.SelectedIndex < 0 || cmbHizmet.SelectedValue == null)
            {
                MessageBox.Show("Lütfen hizmet seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bransID = Convert.ToInt32(cmbBrans.SelectedValue);
            int hastaID = HastaBul(mskTC.Text.Trim());

            if (hastaID == -1)
            {
                MessageBox.Show("Bu TC numarasına ait hasta bulunamadı!",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Branştaki tüm doktorları çek
            string sqlDoktor = @"SELECT DISTINCT K.KullaniciID, K.AdSoyad FROM Kullanici K JOIN DoktorProgrami DP ON DP.DoktorID = K.KullaniciID 
                            WHERE DP.BransID = @b AND DP.Aktif = 1 AND K.Aktif = 1";

            DataTable doktorlar = DatabaseHelper.ExecuteSelect(
                sqlDoktor,
                new SqlParameter[] { new SqlParameter("@b", bransID) });

            if (doktorlar.Rows.Count == 0)
            {
                MessageBox.Show("Bu branşta aktif doktor bulunmuyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3) En uygun randevu adaylarını listele
            List<(int DoktorID, string DoktorAdi, DateTime Tarih, string Saat)> adaylar =
                new List<(int, string, DateTime, string)>();

            DateTime bugun = DateTime.Today;
            TimeSpan simdi = DateTime.Now.TimeOfDay;

            foreach (DataRow dr in doktorlar.Rows)
            {
                int doktorID = Convert.ToInt32(dr["KullaniciID"]);
                string doktorAdi = dr["AdSoyad"].ToString();

                // Önümüzdeki 14 günü tara
                for (int i = 0; i < 14; i++)
                {
                    DateTime gun = bugun.AddDays(i);
                    string gunAdi = GunAdi(gun.DayOfWeek);

                    // Doktor bu gün çalışıyor mu?
                    string sqlPrg = @"SELECT BaslangicSaati, BitisSaati FROM DoktorProgrami WHERE DoktorID = @d AND BransID = @b AND Gun = @g AND Aktif = 1";

                    DataTable dp = DatabaseHelper.ExecuteSelect(
                        sqlPrg,
                        new SqlParameter[]
                        {
                        new SqlParameter("@d", doktorID),
                        new SqlParameter("@b", bransID),
                        new SqlParameter("@g", gunAdi)
                        });

                    if (dp.Rows.Count == 0)
                        continue;

                    TimeSpan bas = (TimeSpan)dp.Rows[0]["BaslangicSaati"];
                    TimeSpan bit = (TimeSpan)dp.Rows[0]["BitisSaati"];

                    // Tüm potansiyel saatleri üret (yalnızca geçmiş olmayan)
                    List<string> tumSaatler = new List<string>();
                    TimeSpan t = bas;
                    TimeSpan slot = TimeSpan.FromMinutes(30);

                    while (t <= bit)
                    {
                        // BUGÜN ise şu andan sonraki saatleri al
                        if (gun.Date > bugun || (gun.Date == bugun && t > simdi))
                        {
                            tumSaatler.Add(t.ToString(@"hh\:mm"));
                        }

                        t = t.Add(slot);
                    }

                    if (tumSaatler.Count == 0)
                        continue;

                    // DOLU saatleri çek
                    string sqlDolu = @"SELECT Saat FROM Randevular WHERE DoktorID = @dok AND Tarih = @trh AND Durum = N'Onaylandı'";

                    DataTable dolu = DatabaseHelper.ExecuteSelect(
                        sqlDolu,
                        new SqlParameter[]
                        {
                        new SqlParameter("@dok", doktorID),
                        new SqlParameter("@trh", gun.Date)
                        });

                    List<string> doluSaatler = dolu.AsEnumerable()
                                                   .Select(r => r["Saat"].ToString())
                                                   .ToList();

                    // Boş saatleri bul (geçmiş saatler zaten listede yok)
                    var bosSaatler = tumSaatler.Except(doluSaatler).ToList();

                    if (bosSaatler.Count > 0)
                    {
                        // İlk bulunan en erken saat aday olarak eklenir
                        adaylar.Add((doktorID, doktorAdi, gun, bosSaatler.First()));
                        break; // Bu doktor için en erken uygun günü bulduk → diğer günlere bakma
                    }
                }
            }

            if (adaylar.Count == 0)
            {
                MessageBox.Show("Önümüzdeki 14 gün içinde uygun randevu saati bulunamadı.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 4) En erken randevuyu seç
            var enErken = adaylar
                .OrderBy(a => a.Tarih)
                .ThenBy(a => a.Saat)
                .First();

            // 5) Kullanıcıya sor (açıklama satırları olmadan)
            var sonuc = MessageBox.Show(
                $"Önerilen Randevu:\n\n" +
                $"Doktor: {enErken.DoktorAdi}\n" +
                $"Tarih: {enErken.Tarih:dd.MM.yyyy}\n" +
                $"Saat:  {enErken.Saat}\n\n" +
                "Randevuyu onaylıyor musunuz?",
                "Otomatik Randevu",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            // 6) İşlem sonucu
            if (sonuc == DialogResult.Yes)
            {
                // 1) Randevuyu kaydet ve yeni ID'yi al
                string insertSql = @"INSERT INTO Randevular (HastaID, DoktorID, BransID, HizmetID, Tarih, Saat, Durum)
                     OUTPUT INSERTED.RandevuID
                    VALUES(@hasta, @doktor, @brans, @hizmet, @tarih, @saat, N'Onaylandı')";

                object yeniIDobj = DatabaseHelper.ExecuteScalar(insertSql,
                    new SqlParameter[]
                    {
                    new SqlParameter("@hasta",  hastaID),
                    new SqlParameter("@doktor", enErken.DoktorID),
                    new SqlParameter("@brans",  bransID),
                    new SqlParameter("@hizmet", cmbHizmet.SelectedValue),
                    new SqlParameter("@tarih",  enErken.Tarih),
                    new SqlParameter("@saat",   enErken.Saat)
                    });

                int yeniRandevuID = Convert.ToInt32(yeniIDobj);

                // 2) LOG yaz
                LogOtomatikPlan(
                    yeniRandevuID,
                    enErken.DoktorID,
                    hastaID,
                    enErken.Tarih,
                    enErken.Saat,
                    "EnErkenSaat",
                    "Randevu Oluşturuldu");

                MessageBox.Show("Otomatik randevu başarıyla oluşturuldu!",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RandevulariListele();
                AlanlariTemizle();
                return;
            }

            else if (sonuc == DialogResult.No)
            {
                LogOtomatikPlan(
                    null,                     // RandevuID yok
                    enErken.DoktorID,
                    hastaID,
                    enErken.Tarih,
                    enErken.Saat,
                    "EnErkenSaat",
                    "Kullanıcı İptal Etti");

                MessageBox.Show("Otomatik planlama iptal edildi.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (sonuc == DialogResult.Cancel)
            {
                LogOtomatikPlan(
                    null,                    // Henüz randevu oluşmadı
                    enErken.DoktorID,
                    hastaID,
                    enErken.Tarih,
                    enErken.Saat,
                    "EnErkenSaat",
                    "Düzenlemeye Açıldı");

                // Düzenlemeye aç
                cmbDoktor.SelectedValue = enErken.DoktorID;
                dtTarih.Value = enErken.Tarih;
                SaatleriGetir();
                cmbSaat.SelectedItem = enErken.Saat;

                MessageBox.Show("Randevu bilgileri forma aktarıldı.\nDüzenleyip kaydedebilirsiniz.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void LogOtomatikPlan(
            int? randevuID,
            int doktorID,
            int hastaID,
            DateTime tarih,
            string saat,
            string secimKriteri,
            string islemSonucu,
            string algoritmaVersiyon = "v1.0")
        {
            string sql = @"INSERT INTO OtoPlanLog
            (RandevuID, DoktorID, HastaID, OlusturmaTarihi, SecimKriteri, IslemSonucu, AlgoritmaVersiyonu)
            VALUES(@randevu, @doktor, @hasta, @tarih, @kriter, @sonuc, @versiyon)";

            DatabaseHelper.ExecuteNonQuery(sql,
                new SqlParameter[]
                {
            new SqlParameter("@randevu", (object)randevuID ?? DBNull.Value),
            new SqlParameter("@doktor", doktorID),
            new SqlParameter("@hasta",  hastaID),
            new SqlParameter("@tarih",  DateTime.Now),
            new SqlParameter("@kriter", secimKriteri),
            new SqlParameter("@sonuc",  islemSonucu),
            new SqlParameter("@versiyon", algoritmaVersiyon)
                });
        }
    }
}

