using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Tables.isTakip
{
   public   class BSD_TBL_BIRIM:IEntity
    {
        public int Id { get; set; }
        public string Birim { get; set; }
        public string  BirimAciklama { get; set; }
       public virtual ICollection<BSD_TBL_ALTBIRIM> AltBirim { get; set; }
       public virtual ICollection<BSD_TBL_BIRIMATAMA> BirimAtama { get; set; }
      
    }
}
