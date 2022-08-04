using BSDPROJE.Entities.Interfaces;
using BSDPROJE.Entities.Tables.isTakip.Ozellikler;
using NetSatis.Entities.Interfaces;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;

namespace BSDPROJE.Entities.Tables
{
 public   class BSD_TBL_ISTAKIBI:Entity,IEntity
    {
        public string BelgeNo { get; set; }
        public string FirmaAdi { get; set; }
        public string UrurunAdi { get; set; }
        public DateTime AcilisTarihi { get; set; }
        public string Durum { get; set; }

       // public int BelgeHaraketId { get; set; }
        public int RevizyonId { get; set; }

        public int KullaniciId { get; set; }
        public string Not { get; set; }


        public virtual ICollection<BSD_TBL_BELGEREVIZYON> Revizyonlar { get; set; }
        public virtual BSD_TBL_Kullanici Kullanici { get; set; }

        public virtual ICollection<BSD_TBL_BELGEHAREKET> BelgeHareketleri { get; set; }

        public  virtual ICollection<BSD_TBL_TOZELLIKSECENEK> AltOzellikleri { get; set; }





    }
}
