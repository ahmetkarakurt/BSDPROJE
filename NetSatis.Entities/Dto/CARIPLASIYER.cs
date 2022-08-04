using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Dto
{
    public class CARIPLASIYER
    {
        private string _PLASIYER_ACIKLAMA;
    public string PLASIYER_KODU { get; set; }
    public string PLASIYER_ACIKLAMA
    {
        get { return _PLASIYER_ACIKLAMA; }

        set { _PLASIYER_ACIKLAMA = UTILES.TurkceKelime(value); }
    }
}
}
