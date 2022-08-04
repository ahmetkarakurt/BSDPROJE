using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Dto
{
    public class BANKALAR
    {
        private string _ACIKLAMA;
        public string NETHESKODU { get; set; }
        public string NETBANKAKODU { get; set; }

        public string ACIKLAMA
        {

            get { return _ACIKLAMA; }

            set { _ACIKLAMA = UTILES.TurkceKelime(value); }
        }

    }
}
