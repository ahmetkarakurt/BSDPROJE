using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Tables.ODEMEGIDER
{
    public class BSD_TBL_ODEMETURU : IEntity
    {
        public int id { get; set; }
        public string OdemeTurAciklama { get; set; }
        public string OzelKod { get; set; }
    }
}
