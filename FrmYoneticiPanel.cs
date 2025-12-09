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
using System.Windows.Markup;

namespace ARPOS
{
    public partial class FrmYoneticiPanel : Form
    {
        private int _kullaniciID;
        public FrmYoneticiPanel(int kullaniciID)
        {
            InitializeComponent();
            _kullaniciID = kullaniciID;
        }

        private void FrmYoneticiPanel_Load(object sender, EventArgs e)
        {
            //Form yüklendiğinde kullanıcı listesini getir
            KullaniciListesiGetir();
            //Branş tabı için
            DoktorlariYukle();
            BranslariYukle();
            DoktorBransListesiniGetir();

            BransListesiGetir();
            HizmetListesiGetir();
            YoneticiAdiniGetir();
        }

        private void YoneticiAdiniGetir()
        {
            string sql = "SELECT AdSoyad FROM Kullanici WHERE KullaniciID = @id";
            SqlParameter[] prm = { new SqlParameter("@id", _kullaniciID) };

            DataTable dt = DatabaseHelper.ExecuteSelect(sql, prm);

            if (dt.Rows.Count > 0)
            {
                lblHosgeldiniz.Text = "Hoş geldiniz, " + dt.Rows[0]["AdSoyad"].ToString();
            }
        }


        private void KullaniciListesiGetir(string filtre = "")
        {
            string sql = @"select KullaniciID,KullaniciAdi,AdSoyad,Rol,Email,Telefon,KayitTarihi,Aktif from Kullanici";

            SqlParameter[] prm = null;

            if (!string.IsNullOrWhiteSpace(filtre))
            {
                sql += @" where AdSoyad like @p or KullaniciAdi like @p or Email like @p or Telefon like @p or TC like @p";

                prm = new[]
                {
                new SqlParameter("@p", "%" + filtre + "%")
                };
            }

            sql += " ORDER BY KullaniciID DESC";

            DataTable dt = DatabaseHelper.ExecuteSelect(sql, prm);
            dgvKullanicilar.DataSource = dt;
        }


        private void DoktorlariYukle()
        {
            using(SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "Select KullaniciID,AdSoyad from Kullanici where ROl='Doktor'";
                SqlDataAdapter da=new SqlDataAdapter(query, conn);
                DataTable dt=new DataTable();
                da.Fill(dt);
                cmbDoktor.DataSource=dt;
                cmbDoktor.DisplayMember = "AdSoyad";
                cmbDoktor.ValueMember = "KullaniciID";
                cmbDoktor.SelectedIndex = -1; // ilk seçim boş olsun
            }
        }

        private void BranslariYukle()
        {
            using(SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "Select BransID, BransAdi from DoktorBrans where aktif=1";
                SqlDataAdapter da=new SqlDataAdapter(query,conn);
                DataTable dt=new DataTable();
                da.Fill(dt);
                cmbBrans.DataSource=dt;
                cmbBrans.DisplayMember = "BransAdi";
                cmbBrans.ValueMember = "BransID";
                cmbBrans.SelectedIndex = -1;
            }
        }
        private void DoktorBransListesiniGetir()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT DP.ProgramID, DP.DoktorID, DP.BransID, K.AdSoyad AS Doktor, DB.BransAdi AS Brans,DP.Gun, DP.BaslangicSaati,DP.BitisSaati,
                    CASE WHEN DP.Aktif = 1 THEN N'Aktif' ELSE N'Pasif' END AS Durum
                    FROM DoktorProgrami DP
                    JOIN Kullanici K ON DP.DoktorID = K.KullaniciID
                    JOIN DoktorBrans DB ON DP.BransID = DB.BransID WHERE 1=1";

                List<SqlParameter> prm = new List<SqlParameter>();

                // Doktor seçildiyse filtrele
                if (cmbDoktor.SelectedIndex > -1 && cmbDoktor.SelectedValue != null)
                {
                    query += " AND DP.DoktorID = @doktor";
                    prm.Add(new SqlParameter("@doktor", cmbDoktor.SelectedValue));
                }

                // Branş seçildiyse filtrele
                if (cmbBrans.SelectedIndex > -1 && cmbBrans.SelectedValue != null)
                {
                    query += " AND DP.BransID = @brans";
                    prm.Add(new SqlParameter("@brans", cmbBrans.SelectedValue));
                }

                query += " ORDER BY DB.BransAdi, K.AdSoyad";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddRange(prm.ToArray());

                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    dr["BaslangicSaati"] = ((TimeSpan)dr["BaslangicSaati"]).ToString(@"hh\:mm");
                    dr["BitisSaati"] = ((TimeSpan)dr["BitisSaati"]).ToString(@"hh\:mm");
                }

                dgvDoktorBrans.DataSource = dt;
                dgvDoktorBrans.Columns["ProgramID"].Visible = false;
                dgvDoktorBrans.Columns["DoktorID"].Visible = false;
                dgvDoktorBrans.Columns["BransID"].Visible = false;
            }
        }




        private void btnAktifYap_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kullaniciID = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells["KullaniciID"].Value);

            string query = "update Kullanici set Aktif = 1 where KullaniciID = @id";
            SqlParameter[] prm = { new SqlParameter("@id", kullaniciID) };

            int sonuc = DatabaseHelper.ExecuteNonQuery(query, prm);

            if (sonuc > 0)
                MessageBox.Show("Kullanıcı aktifleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KullaniciListesiGetir();
        }

        private void btnPasifYap_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kullaniciID = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells["KullaniciID"].Value);

            string query = "update Kullanici set Aktif = 0 where KullaniciID = @id";
            SqlParameter[] prm = { new SqlParameter("@id", kullaniciID) };

            int sonuc = DatabaseHelper.ExecuteNonQuery(query, prm);

            if (sonuc > 0)
                MessageBox.Show("Kullanıcı pasifleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KullaniciListesiGetir();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            KullaniciListesiGetir(txtAra.Text.Trim());
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kullaniciID = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells["KullaniciID"].Value);

            DialogResult result = MessageBox.Show("Seçili kullanıcıyı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            string query = "delete from Kullanici where KullaniciID = @id";

            SqlParameter[] prm =
            {
            new SqlParameter("@id", kullaniciID)
            };

            int sonuc = DatabaseHelper.ExecuteNonQuery(query, prm);

            if (sonuc > 0)
            {
                MessageBox.Show("Kullanıcı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                KullaniciListesiGetir(); // listeyi yenile
            }
            else
            {
                MessageBox.Show("Kullanıcı silinemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnYeni_Click(object sender, EventArgs e)
        {
            FrmKayitOl frm = new FrmKayitOl();
            frm.ShowDialog();
            KullaniciListesiGetir(); 
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kullanıcıyı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kullaniciID = Convert.ToInt32(
                dgvKullanicilar.CurrentRow.Cells["KullaniciID"].Value
            );

            FrmKullaniciDuzenle frm = new FrmKullaniciDuzenle(kullaniciID);
            frm.ShowDialog();

            KullaniciListesiGetir(); // Güncellemeden sonra liste yenile
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbDoktor.SelectedValue == null || cmbBrans.SelectedValue == null)
            {
                MessageBox.Show("Lütfen doktor ve branş seçiniz!",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int doktorID = Convert.ToInt32(cmbDoktor.SelectedValue);
            int bransID = Convert.ToInt32(cmbBrans.SelectedValue);

            // Aynı doktor–branş tekrar eklenemez
            string checkSql = @"SELECT COUNT(*) FROM DoktorProgrami
                    WHERE DoktorID = @doktor AND BransID = @brans";

            SqlParameter[] prmCheck =
            {
            new SqlParameter("@doktor", doktorID),
            new SqlParameter("@brans", bransID)
            };

            int adet = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkSql, prmCheck));

            if (adet > 0)
            {
                MessageBox.Show("Bu doktor bu branşa zaten kayıtlı!",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🟢 Yeni doğru çağrı (4 parametre gönderiliyor)
            string doktorAd = cmbDoktor.Text;
            string bransAd = cmbBrans.Text;

            FrmDoktorProgram frm = new FrmDoktorProgram(doktorID, bransID, doktorAd, bransAd);

            if (frm.ShowDialog() == DialogResult.OK)
                DoktorBransListesiniGetir();

        }

        private void btnBransSil_Click_1(object sender, EventArgs e)
        {
            if (dgvDoktorBrans.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek satırı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string doktor = dgvDoktorBrans.CurrentRow.Cells["Doktor"].Value.ToString();
            string brans = dgvDoktorBrans.CurrentRow.Cells["Brans"].Value.ToString();

            DialogResult cevap = MessageBox.Show($"{doktor} adlı doktoru '{brans}' branşından silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.No) return;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string deleteQuery = @"delete DP from DoktorProgrami DP
                                    join Kullanici K ON DP.DoktorID = K.KullaniciID
                                    join DoktorBrans DB ON DP.BransID = DB.BransID
                                    where K.AdSoyad = @doktor AND DB.BransAdi = @brans";

                SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@doktor", doktor);
                cmd.Parameters.AddWithValue("@brans", brans);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Kayıt silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DoktorBransListesiniGetir();
        }

        private void btnAktif_Click(object sender, EventArgs e)
        {
            int programID = Convert.ToInt32(dgvDoktorBrans.CurrentRow.Cells["ProgramID"].Value);

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string sql = "UPDATE DoktorProgrami SET Aktif = 1 WHERE ProgramID = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", programID);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Seçili gün aktif yapıldı.");
            DoktorBransListesiniGetir();

        }

        private void btnPasif_Click(object sender, EventArgs e)
        {
            int programID = Convert.ToInt32(dgvDoktorBrans.CurrentRow.Cells["ProgramID"].Value);

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string sql = "UPDATE DoktorProgrami SET Aktif = 0 WHERE ProgramID = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", programID);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Seçili gün pasif yapıldı.");
            DoktorBransListesiniGetir();
        }

        private void BransListesiGetir()
        {
            string sql = "SELECT BransID, BransKodu, BransAdi, Aciklama, Aktif FROM DoktorBrans ORDER BY BransID";

            DataTable dt = DatabaseHelper.ExecuteSelect(sql, null);
            dgvBranslar.DataSource = dt;
        }

        private void btnBransYeni_Click(object sender, EventArgs e)
        {
            txtBransKodu.Clear();
            txtBransAdi.Clear();
            txtAciklama.Clear();
            chkBransAktif.Checked = true;

            txtBransAdi.Focus();
        }

        private void btnBransKaydet_Click(object sender, EventArgs e)
        {
            if (txtBransAdi.Text.Trim() == "")
            {
                MessageBox.Show("Branş adı boş bırakılamaz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = @"INSERT INTO DoktorBrans (BransKodu, BransAdi, Aciklama, Aktif)
                   VALUES (@kod, @adi, @aciklama, @aktif)";

            SqlParameter[] prm =
            {
            new SqlParameter("@kod", txtBransKodu.Text.Trim()),
            new SqlParameter("@adi", txtBransAdi.Text.Trim()),
            new SqlParameter("@aciklama", txtAciklama.Text.Trim()),  // 🔥 ÖNEMLİ
            new SqlParameter("@aktif", chkBransAktif.Checked ? 1 : 0)
            };

            int sonuc = DatabaseHelper.ExecuteNonQuery(sql, prm);

            if (sonuc > 0)
            {
                MessageBox.Show("Branş başarıyla eklendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                BransListesiGetir();
                btnBransYeni.PerformClick();

            }
        }


        private void dgvBranslar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtBransKodu.Text = dgvBranslar.CurrentRow.Cells["BransKodu"].Value?.ToString();
            txtBransAdi.Text = dgvBranslar.CurrentRow.Cells["BransAdi"].Value?.ToString();
            txtAciklama.Text = dgvBranslar.CurrentRow.Cells["Aciklama"].Value?.ToString();

            object val = dgvBranslar.CurrentRow.Cells["Aktif"].Value;
            chkBransAktif.Checked = val != null && val != DBNull.Value && Convert.ToBoolean(val);
        }


        private void btnBransGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvBranslar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek branşı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvBranslar.CurrentRow.Cells["BransID"].Value);

            string sql = @"update DoktorBrans set BransKodu = @kod, BransAdi = @adi, Aciklama = @aciklama, Aktif = @aktif where BransID = @id";

            SqlParameter[] prm =
            {
            new SqlParameter("@kod", txtBransKodu.Text.Trim()),
            new SqlParameter("@adi", txtBransAdi.Text.Trim()),
            new SqlParameter("@aciklama", txtAciklama.Text.Trim()),
            new SqlParameter("@aktif", chkBransAktif.Checked ? 1 : 0),
            new SqlParameter("@id", id)
            };

            DatabaseHelper.ExecuteNonQuery(sql, prm);

            MessageBox.Show("Branş güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BransListesiGetir();
        }

        private void btnBransSil2_Click(object sender, EventArgs e)
        {
            if (dgvBranslar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek branşı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvBranslar.CurrentRow.Cells["BransID"].Value);

            DialogResult cevap = MessageBox.Show("Bu branş silinsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.No) return;

            string sql = "delete from DoktorBrans where BransID = @id";

            SqlParameter[] prm = { new SqlParameter("@id", id) };
            DatabaseHelper.ExecuteNonQuery(sql, prm);
            MessageBox.Show("Branş silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BransListesiGetir();
        }

        private void btnBransYenile_Click(object sender, EventArgs e)
        {
            BransListesiGetir();
        }

        private void HizmetListesiGetir()
        {
            string sql = @"select HizmetID, HizmetAdi, Ucret, Aciklama, Aktif from Hizmet order by HizmetAdi";

            DataTable dt = DatabaseHelper.ExecuteSelect(sql, null);
            dgvHizmetler.DataSource = dt;
        }

        private void btnHizmetYeni_Click(object sender, EventArgs e)
        {
            txtHizmetAdi.Clear();
            numUcret.Value = 0;
            rtxtAciklama.Clear();
            chkHizmetAktif.Checked = true;

            txtHizmetAdi.Focus();
        }

        private void btnHizmetKaydet_Click(object sender, EventArgs e)
        {
            if (txtHizmetAdi.Text.Trim() == "")
            {
                MessageBox.Show("Hizmet adı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = @"insert into Hizmet (HizmetAdi, Ucret, Aciklama, Aktif)
                        values (@adi, @ucret, @aciklama, @aktif)";

            SqlParameter[] prm =
            {
            new SqlParameter("@adi", txtHizmetAdi.Text.Trim()),
            new SqlParameter("@ucret", numUcret.Value),
            new SqlParameter("@aciklama", rtxtAciklama.Text),
            new SqlParameter("@aktif", chkHizmetAktif.Checked ? 1 : 0)
            };

            int sonuc = DatabaseHelper.ExecuteNonQuery(sql, prm);

            if (sonuc > 0)
            {
                MessageBox.Show("Hizmet başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HizmetListesiGetir();
                btnHizmetYeni.PerformClick();
            }
        }

        private void dgvHizmetler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtHizmetAdi.Text = dgvHizmetler.CurrentRow.Cells["HizmetAdi"].Value.ToString();
            numUcret.Value = Convert.ToDecimal(dgvHizmetler.CurrentRow.Cells["Ucret"].Value);
            rtxtAciklama.Text = dgvHizmetler.CurrentRow.Cells["Aciklama"].Value.ToString();
            chkHizmetAktif.Checked = Convert.ToBoolean(dgvHizmetler.CurrentRow.Cells["Aktif"].Value);
        }

        private void btnHizmetGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvHizmetler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek hizmeti seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvHizmetler.CurrentRow.Cells["HizmetID"].Value);

            string sql = @"update Hizmet set HizmetAdi = @adi, Ucret = @ucret, Aciklama = @aciklama, Aktif = @aktif where HizmetID = @id";

            SqlParameter[] prm =
            {
            new SqlParameter("@adi", txtHizmetAdi.Text.Trim()),
            new SqlParameter("@ucret", numUcret.Value),
            new SqlParameter("@aciklama", rtxtAciklama.Text),
            new SqlParameter("@aktif", chkHizmetAktif.Checked ? 1 : 0),
            new SqlParameter("@id", id)
            };

            DatabaseHelper.ExecuteNonQuery(sql, prm);
            MessageBox.Show("Hizmet güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HizmetListesiGetir();
        }

        private void btnHizmetSil_Click(object sender, EventArgs e)
        {
            if (dgvHizmetler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek hizmeti seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvHizmetler.CurrentRow.Cells["HizmetID"].Value);

            DialogResult cevap = MessageBox.Show("Bu hizmet silinsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.No) return;

            string sql = "delete from Hizmet where HizmetID = @id";

            SqlParameter[] prm = { new SqlParameter("@id", id) };
            DatabaseHelper.ExecuteNonQuery(sql, prm);
            MessageBox.Show("Hizmet silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HizmetListesiGetir();
        }

        private void btnHizmetYenile_Click(object sender, EventArgs e)
        {
            HizmetListesiGetir();
        }

       
        private void btnCalismaSaatiAyarla_Click(object sender, EventArgs e)
        {
            if (dgvDoktorBrans.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir satır seçiniz!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int doktorID = Convert.ToInt32(dgvDoktorBrans.CurrentRow.Cells["DoktorID"].Value);
            int bransID = Convert.ToInt32(dgvDoktorBrans.CurrentRow.Cells["BransID"].Value);

            string doktorAd = dgvDoktorBrans.CurrentRow.Cells["Doktor"].Value.ToString();
            string bransAd = dgvDoktorBrans.CurrentRow.Cells["Brans"].Value.ToString();

            FrmDoktorProgram frm = new FrmDoktorProgram(doktorID, bransID, doktorAd, bransAd);
            frm.ShowDialog();

            DoktorBransListesiniGetir();
        }

        private void FrmYoneticiPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
        }
        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoktor.Focused)      // tasarım/doldurma sırasında gereksiz çalışmasın diye
                DoktorBransListesiniGetir();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBrans.Focused)
                DoktorBransListesiniGetir();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            cmbDoktor.SelectedIndex = -1;
            cmbBrans.SelectedIndex = -1;

            // Tüm listeyi getir
            DoktorBransListesiniGetir();
        }
    }
}

