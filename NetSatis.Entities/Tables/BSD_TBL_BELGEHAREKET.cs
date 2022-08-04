using BSDPROJE.Entities.Interfaces;
using NetSatis.Entities.Interfaces;
using System;

namespace BSDPROJE.Entities.Tables
{
    public class BSD_TBL_BELGEHAREKET:Entity,IEntity
    {
        public string BelgeDurumu  { get; set; }
        public DateTime Tarih { get; set; }
        public int IsTakibiId { get; set; }
        public virtual BSD_TBL_ISTAKIBI IsTakibi { get; set; }
    }

  
}