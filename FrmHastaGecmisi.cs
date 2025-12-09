using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARPOS
{
    public partial class FrmHastaGecmisi : Form
    {
        public FrmHastaGecmisi(DataTable dt)
        {
            InitializeComponent();
            dgvGecmis.AutoGenerateColumns = true;
            dgvGecmis.DataSource = dt;
            AyarlarGecmisGrid();

        }
        private void AyarlarGecmisGrid()
        {
            if (dgvGecmis.Columns["RandevuID"] != null)
                dgvGecmis.Columns["RandevuID"].Visible = false;

            if (dgvGecmis.Columns["RandevuTarihi"] != null)
                dgvGecmis.Columns["RandevuTarihi"].HeaderText = "Tarih";

            if (dgvGecmis.Columns["RandevuSaati"] != null)
                dgvGecmis.Columns["RandevuSaati"].HeaderText = "Saat";

            if (dgvGecmis.Columns["HastaAd"] != null)
                dgvGecmis.Columns["HastaAd"].HeaderText = "Hasta";

            if (dgvGecmis.Columns["HastaTC"] != null)
                dgvGecmis.Columns["HastaTC"].HeaderText = "TC";

            if (dgvGecmis.Columns["HizmetAdi"] != null)
                dgvGecmis.Columns["HizmetAdi"].HeaderText = "Hizmet";

            if (dgvGecmis.Columns["Durum"] != null)
                dgvGecmis.Columns["Durum"].HeaderText = "Durum";
        }
    }
}
