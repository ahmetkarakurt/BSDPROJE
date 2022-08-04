using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Tables.RAPORLAR
{
    public    class BSD_TBL_RAPORLAR_ANA : IEntity
    {
        public int id { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public int? Kod { get; set; }
        public string Image { get; set; }

    }
}
