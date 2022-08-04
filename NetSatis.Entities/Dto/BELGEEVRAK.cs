using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Dto
{
    public class BELGEEVRAK
    {
        public string BelgeNo { get; set; }
        public string OdemeTuru { get; set; }
        public string BankaAdi { get; set; }
        public string BankaKod { get; set; }
        public decimal Tutar { get; set; }
        public decimal DovizTutar { get; set; }
        public string OdemeTipi { get; set; }

    }
}
