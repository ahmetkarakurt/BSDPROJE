using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Dto
{
 public   class KASA_GENEL_BORCALACAK
    {
        public string KSMAS_NAME { get; set; }
        public decimal GELIR { get; set; }
        public decimal GIDER { get; set; }
        public decimal KALAN { get; set; }
        public decimal DOVIZCIKIS { get; set; }
        public decimal DOVIZGIRIS { get; set; }
        public decimal DOVKALAN { get; set; }
        public string DOVIZLI { get; set; }
        public byte DOVIZTIPI { get; set; }
    }
}
