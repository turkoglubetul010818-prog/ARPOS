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
    public partial class FrmDoktorGecmis : Form
    {
        public FrmDoktorGecmis(DataTable dt)
        {
            InitializeComponent();
            dgvGecmis.DataSource = dt;

            if (dgvGecmis.Columns["RandevuID"] != null)
                dgvGecmis.Columns["RandevuID"].Visible = false;
        }
    }
    
}
