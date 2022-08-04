using BSDPROJE.Entities.Interfaces;
using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Tables.isTakip.Ozellikler
{
  public   class BSD_TBL_TOZELLIKSECENEK: Entity,IEntity
    {
        public string TeknikOzellikAdi { get; set; }

        public int IsTakibiId { get; set; }
        public string Durum { get; set; }
        public int TeknikOzellikleriGrurubId { get; set; }
        public virtual BSD_TBL_ALTTEKNIKOZELLIKLER TeknikOzellikleriGrurub{ get; set; }
        public virtual BSD_TBL_ISTAKIBI IsTakibi { get; set; }

    }
}
