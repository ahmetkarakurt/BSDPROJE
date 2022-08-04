using BSDPROJE.Entities.Interfaces;
using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Tables.isTakip.Ozellikler
{
   public class BSD_TBL_ALTTEKNIKOZELLIKLER : Entity, IEntity
    {


        public string AltOzellikAdi { get; set; }
        public string AltOzellikAciklamasi { get; set; }
        public int OzellikId { get; set; }
        public virtual BSD_TBL_OZELLIKLER Ozellik { get; set; }
        public virtual ICollection<BSD_TBL_ISTAKIBI_ALTOZEL> OzeliikSecenekleri { get; set; }

    }
}
