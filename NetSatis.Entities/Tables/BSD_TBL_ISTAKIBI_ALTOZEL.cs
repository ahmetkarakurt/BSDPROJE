using BSDPROJE.Entities.Interfaces;
using BSDPROJE.Entities.Tables.isTakip.Ozellikler;
using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Tables
{
 public   class BSD_TBL_ISTAKIBI_ALTOZEL:Entity,IEntity
    {
        public string Cevap { get; set; }

        public int AnaOzellikId { get; set; }
        public virtual BSD_TBL_OZELLIKLER AnaOzellik { get; set; }

        public int? IsTakibiId { get; set; }
        public virtual BSD_TBL_ISTAKIBI IsTakibi { get; set; }
        public int? TeknikAltOzellikId { get; set; }
        public virtual BSD_TBL_ALTTEKNIKOZELLIKLER TeknikAltOzellik { get; set; }
    }
}
