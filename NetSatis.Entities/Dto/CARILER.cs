using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Dto
{
    public class CARILER
    {
        private string _CARI_ISIM;
        public string CARI_KOD { get; set; }
        public string CARI_ISIM
        {
            get { return _CARI_ISIM; }

            set { _CARI_ISIM = UTILES.TurkceKelime(value); }
        }
    }
}
