using BSDPROJE.Entities.Interfaces;
using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Tables.isTakip.Ozellikler
{
    public class BSD_TBL_OZELLIKLER : Entity, IEntity
    {
        public string TeknikOzellikAdi { get; set; }
        public string TeknikOzellikAciklama { get; set; }
        public virtual ICollection<BSD_TBL_ALTTEKNIKOZELLIKLER> AltOzellik{ get; set; }
    }
}
