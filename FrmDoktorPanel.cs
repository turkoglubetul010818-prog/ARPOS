using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARPOS
{
    public partial class FrmDoktorPanel : Form
    {
        private int _kullaniciID;

        public FrmDoktorPanel(int kullaniciID)
        {
            InitializeComponent();
            _kullaniciID = kullaniciID;
        }

        private void FrmDoktorPanel_Load(object sender, EventArgs e)
        {
            timerSaat.Start();

            DoktorBilgileriniYukle();
            DoktorGunlukRandevular();
        }

        private void DoktorBilgileriniYukle()
        {
            // Doktor adı soyadı
            string sql = "select AdSoyad from Kullanici where KullaniciID = @id";

            DataTable dt = DatabaseHelper.ExecuteSelect(
                sql,
                new SqlParameter[] { new SqlParameter("@id", _kullaniciID) }
            );

            if (dt != null && dt.Rows.Count > 0)
                txtAdSoyad.Text = dt.Rows[0]["AdSoyad"].ToString();

            // Doktor branşı
            string sql2 = @"select TOP 1 DB.BransAdi 
                    from DoktorProgrami DP
                    join DoktorBrans DB on DB.BransID = DP.BransID
                    where DP.DoktorID = @id and DP.Aktif = 1";

            DataTable dt2 = DatabaseHelper.ExecuteSelect(
                sql2,
                new SqlParameter[] { new SqlParameter("@id", _kullaniciID) }
            );

            if (dt2 != null && dt2.Rows.Count > 0)
                txtBrans.Text = dt2.Rows[0]["BransAdi"].ToString();
            else
                txtBrans.Text = "Tanımlı branş yok";
        }


        private void DoktorGunlukRandevular()
        {
            string query = @"select r.RandevuID, r.Tarih AS RandevuTarihi, r.Saat  AS RandevuSaati, k.AdSoyad AS Hasta
                from Randevular r join Kullanici k ON k.KullaniciID = r.HastaID
                where r.DoktorID = @id and r.Tarih = CONVERT(date, GETDATE()) and r.Durum= N'Onaylandı' order by r.Saat";

            SqlParameter[] prm = { new SqlParameter("@id", _kullaniciID) };
            DataTable dt = DatabaseHelper.ExecuteSelect(query, prm);

            if (dt == null)
            {
                MessageBox.Show("Randevular yüklenirken bir hata oluştu.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvRandevular.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                dgvRandevular.Columns["RandevuID"].HeaderText = "ID";
                dgvRandevular.Columns["RandevuTarihi"].HeaderText = "Tarih";
                dgvRandevular.Columns["RandevuSaati"].HeaderText = "Saat";
                dgvRandevular.Columns["Hasta"].HeaderText = "Hasta Adı";
            }
        }

        

        // --- RANDEVU DETAYI ---

        private void RandevuDetayiGoster(int randevuID)
        {
            string query = @"select r.RandevuID, r.Tarih as RandevuTarihi, r.Saat as RandevuSaati, h.AdSoyad as HastaAd, h.TC as HastaTC, r.HizmetID, hz.HizmetAdi, r.Aciklama, r.Durum
                from Randevular r join Kullanici h on h.KullaniciID = r.HastaID
                left join Hizmet hz on hz.HizmetID = r.HizmetID where r.RandevuID = @id";

            SqlParameter[] prm = { new SqlParameter("@id", randevuID) };
            DataTable dt = DatabaseHelper.ExecuteSelect(query, prm);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Randevu bilgisi bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow row = dt.Rows[0];

            string detay =
                $"Randevu ID: {row["RandevuID"]}\n" +
                $"Hasta Adı : {row["HastaAd"]}\n" +
                $"Hasta TC  : {row["HastaTC"]}\n" +
                $"Tarih     : {Convert.ToDateTime(row["RandevuTarihi"]):dd.MM.yyyy}\n" +
                $"Saat      : {row["RandevuSaati"]}\n" +
                $"Hizmet    : {row["HizmetAdi"]}\n" +
                $"Açıklama  : {row["Aciklama"]}\n"+
                $"Durum     : {row["Durum"]}\n";


            MessageBox.Show(detay, "Randevu Detayı",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRandevuDetay_Click(object sender, EventArgs e)
        {
            if (dgvRandevular.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir randevu seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int randevuID = Convert.ToInt32(
                dgvRandevular.SelectedRows[0].Cells["RandevuID"].Value
            );

            RandevuDetayiGoster(randevuID);
        }


        // --- DOKTOR RANDEVU GEÇMİŞİ ---

        private void btnRandevuGecmisi_Click(object sender, EventArgs e)
        {
            DoktorGecmisRandevulariniGoster();
        }

        private void DoktorGecmisRandevulariniGoster()
        {
            string sql = @"SELECT r.RandevuID, r.Tarih AS RandevuTarihi, r.Saat AS RandevuSaati, h.AdSoyad AS HastaAd, h.TC AS HastaTC, r.HizmetID, hz.HizmetAdi, r.Durum
            FROM Randevular r
            JOIN Kullanici h ON h.KullaniciID = r.HastaID
            LEFT JOIN Hizmet hz ON hz.HizmetID = r.HizmetID
            WHERE r.DoktorID = @id
            AND r.Tarih < CAST(GETDATE() AS date)   -- geçmiş randevular
            ORDER BY r.Tarih DESC, r.Saat DESC";

            SqlParameter[] prm =
            {
            new SqlParameter("@id", _kullaniciID)
            };

            DataTable dt = DatabaseHelper.ExecuteSelect(sql, prm);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Geçmiş randevu bulunamadı.",
                                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ayrı formda göster
            FrmDoktorGecmis frm = new FrmDoktorGecmis(dt);
            frm.ShowDialog();
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
            this.Close();
        }
        private void timerSaat_Tick(object sender, EventArgs e)
        {
            lblTarihSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }

        private void btnHastaRandevuGecmisi_Click(object sender, EventArgs e)
        {
            if (dgvRandevular.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen geçmişi görüntülemek için bir hasta seçin!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçili satırdaki hastayı al
            string hastaAd = dgvRandevular.SelectedRows[0].Cells["Hasta"].Value.ToString();

            // Hasta adından ID'yi bulalım
            int hastaID = HastaIDBul(hastaAd);

            if (hastaID == -1)
            {
                MessageBox.Show("Hasta bilgisi bulunamadı!", "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HastaGecmisiniGoster(hastaID);
        }

        private int HastaIDBul(string adSoyad)
        {
            string sql = "SELECT KullaniciID FROM Kullanici WHERE AdSoyad = @ad";

            DataTable dt = DatabaseHelper.ExecuteSelect(sql,
                new SqlParameter[] { new SqlParameter("@ad", adSoyad) });

            if (dt == null || dt.Rows.Count == 0)
                return -1;

            return Convert.ToInt32(dt.Rows[0]["KullaniciID"]);
        }

        private void HastaGecmisiniGoster(int hastaID)
        {
            string sql = @"SELECT r.RandevuID, r.Tarih AS RandevuTarihi, r.Saat AS RandevuSaati, d.AdSoyad AS DoktorAd, b.BransAdi AS Brans, r.Durum, r.HizmetID, hz.HizmetAdi
            FROM Randevular r
            JOIN Kullanici d	ON d.KullaniciID = r.DoktorID
            JOIN DoktorBrans b ON b.BransID = r.BransID
            LEFT JOIN Hizmet hz ON hz.HizmetID = r.HizmetID
            WHERE r.HastaID = @hid
            ORDER BY r.Tarih DESC, r.Saat DESC";

            DataTable dt = DatabaseHelper.ExecuteSelect(sql,
                new SqlParameter[] { new SqlParameter("@hid", hastaID) });

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Bu hastaya ait geçmiş randevu bulunamadı.",
                                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Daha önce yaptığın form açılıyor
            FrmHastaGecmisi frm = new FrmHastaGecmisi(dt);
            frm.ShowDialog();
        }

        private void FrmDoktorPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
        }
    }
}

