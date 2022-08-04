using BSDPROJE.Entities.Tables;
using BSDPROJE.Entities.Tables.isTakip.Ozellikler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Dto.IsTakibiDTO
{
  public  class IsTakibiSelectDTO
    {

        public int Id { get; set; }
        public string AltOZellik { get; set; }
        public string ustozellik { get; set; }
        public int AltozelID { get; set; }
        public int UstOzelID { get; set; }
        public string Cevap { get; set; }


    }
}
