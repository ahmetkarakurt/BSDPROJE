using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Tables
{
  public  class BSD_TBL_Dosyalar : IEntity
    {
        public int Id { get; set; }
        public string DosyaAdi { get; set; }
        public byte[] DostaIcerik { get; set; }
        public string DosyaTipi { get; set; }
        public string Kod_1s { get; set; }
        public string Kod_2s { get; set; }
        public int? Kod_3i { get; set; }
        public int? Kod_4i { get; set; }
    }
}
