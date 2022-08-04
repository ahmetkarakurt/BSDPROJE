using BSDPROJE.Entities.Tables.RAPORLAR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Dto
{
 public   class FrmYetkileriDTO
    {
        //public BSD_TBL_RAPORLAR_VW Kategoriler { get; set; }
        public int id { get; set; }
        public int Kategorid { get; set; }
        public string VwAdi { get; set; }
        public string KullaniciAdi { get; set; }
        public bool? Yetki { get; set; } = false;
        public string KategoriAdi { get; set; }
    }
}
