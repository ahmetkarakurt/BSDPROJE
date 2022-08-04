using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Tables.isTakip
{
   public class BSD_TBL_ALTBIRIM:IEntity
    {
        public int Id { get; set; }
        public int? BirimId { get; set; }

        public string AltBirim { get; set; }
        public string AltBirimAciklama { get; set; }
        public virtual BSD_TBL_BIRIM Birim { get; set; }
       public virtual ICollection<BSD_TBL_BIRIMATAMA> BirimAtama { get; set; }
    }
}
