using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Tables.ODEMEGIDER
{
    public class BSD_TBL_ODEME : IEntity
    {
        public int id { get; set; }
        public DateTime Tarih { get; set; }
        public int? AyKodu { get; set; }
        public string OdemeTuru { get; set; }

        public string BankaKod { get; set; }
        public string BankaAdi { get; set; }
        public string CariKod { get; set; }
        public string CariAdi { get; set; }

        public string BelgeNo { get; set; }
        public decimal Tutar { get; set; } = 0;
        public decimal? DovizTutar { get; set; } = 0;
        public string OdemeTipi { get; set; } = "TL";

        public string Aciklama { get; set; }

    }
}
