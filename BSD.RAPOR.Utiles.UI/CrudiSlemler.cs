using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSD.RAPOR.Utiles.UI
{
    public partial class CrudiSlemler : UserControl
    {
   
        [Category("İşlem Butonu")]
        public event EventHandler KaydetClick;
        [Category("İşlem Butonu")]
        public event EventHandler SecClick;
        [Category("İşlem Butonu")]
        public event EventHandler SilClick;
        [Category("İşlem Butonu")]
        public event EventHandler VazgecClick;
        public CrudiSlemler()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KaydetClick?.Invoke(this, e);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            SecClick?.Invoke(this, e);
        }

        private void BtcSil_Click(object sender, EventArgs e)
        {
            SilClick?.Invoke(this, e);
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            VazgecClick?.Invoke(this, e);
        }
    }
}
