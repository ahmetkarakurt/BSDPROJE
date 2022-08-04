using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Tables.RAPORLAR
{
  public  class BSD_TBL_RAPORLAR_VW : IEntity
    {
        public int id { get; set; }
        public int Kategorid { get; set; }
        public string VwAdi { get; set; }
        public string VwYolu { get; set; }
        public string Aciklama { get; set; }
        public int? Kod { get; set; }
        public string Image { get; set; }

    }
}
