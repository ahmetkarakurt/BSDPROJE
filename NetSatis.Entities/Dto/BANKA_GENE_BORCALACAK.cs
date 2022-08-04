using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Dto
{
   public class BANKA_GENE_BORCALACAK
    {
        public byte HESAPTIPI { get; set; }
        public string HESAPTIPLERI { get; set; }
        public byte DOVIZTIPI { get; set; }
        public decimal BORCBAKIYEDOVIZ { get; set; }
        public decimal ALACAKBAKIYEDOVIZ { get; set; }
        public decimal BORCBAKIYE { get; set; }
        public decimal ALACAKBAKIYE { get; set; }
        public decimal BAKIYE { get; set; }
    }
}
