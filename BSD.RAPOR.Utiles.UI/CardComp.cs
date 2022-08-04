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
    public partial class CardComp : UserControl
    {



        public CardComp()
        {
            InitializeComponent();

        }

        public string Baslik { get; set; }
        public string Tip { get; set; }
        public decimal? Bakiye { get; set; }
        public decimal? BorckBakiye { get; set; }
        public decimal? AlacakBakiye { get; set; }
        public Color Renk { get; set; } = Color.Salmon;
        public Color YaziRengi { get; set; } = Color.White;

        public Tipler tipler { get; set; } = Tipler.BANKA;

        public Color ArkaPlanRengi { get; set; } = Color.Snow;

        public bool Bakiyegizle
        {
            get
            {
                return lbBorcBak.Visible;
            }
            set
            {
                lbBorcBak.Visible = value;
                lbAlacakBak.Visible = value;
            }
        }
     


        private void CardComp_Load(object sender, EventArgs e)
        {

            if (Tip == "0")
                Tip = "TL";
            if (Tip == "1")
                Tip = "$";
            if (Tip == "2")
                Tip = "€";

            if (tipler==Tipler.BANKA)
                pictureBox1.Image = Properties.Resources.bank;
            if (tipler == Tipler.KASA)
                pictureBox1.Image = Properties.Resources.safebox;
            if (tipler == Tipler.CEKSENET)
                pictureBox1.Image = Properties.Resources.cheque;
            if (tipler == Tipler.CARI)
                pictureBox1.Image = Properties.Resources.money;
            if (tipler == Tipler.STOK)
                pictureBox1.Image = Properties.Resources.house;
            if (tipler == Tipler.DIGER)
                pictureBox1.Image = Properties.Resources.atm;

            lbBaslik.Text = Baslik + " "+Tip;
            lbFiyat.Text = String.Format("{0:N}", Bakiye)    +" "+Tip;          
            lbAlacakBak.Text = "Alacak Bakiyesi : "+ String.Format(" {0:N}", AlacakBakiye) +   " " + Tip;
            lbBorcBak.Text = "Borç Bakiyesi : " +String.Format("{0:N}", BorckBakiye)   + " " + Tip;

            this.BackColor = ArkaPlanRengi;

        }

        public enum  Tipler
        {
            KASA,
            STOK,
            BANKA,
            CARI,
            CEKSENET,
            DIGER
        }
    }


}
