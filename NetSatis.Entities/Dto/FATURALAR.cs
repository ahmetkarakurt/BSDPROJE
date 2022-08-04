using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Dto
{
    public class FATURALAR
    {
        public DateTime TARIH { get; set; }
        public string FATIRS_NO { get; set; }
        public decimal GENELTOPLAM { get; set; }
        //   public int ODEMEGUNU { get; set; }
        public DateTime ODEMETARIHI { get; set; }
        public string DOVIZTIP { get; set; }
        public decimal DOVIZTUT { get; set; }
    }
}
