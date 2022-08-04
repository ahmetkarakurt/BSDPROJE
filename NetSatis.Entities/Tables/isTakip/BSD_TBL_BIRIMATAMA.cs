using NetSatis.Entities.Interfaces;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Tables.isTakip
{
   public class BSD_TBL_BIRIMATAMA:IEntity
    {
        public int Id { get; set; }

        public int KullaniciId { get; set; }
        public int BirimId { get; set; }
        public int? AltBirimId { get; set; }

        public virtual BSD_TBL_Kullanici Kullanici { get; set; }
        public virtual BSD_TBL_BIRIM Birim { get; set; }
        public virtual BSD_TBL_ALTBIRIM AltBirim { get; set; }
    }
}
