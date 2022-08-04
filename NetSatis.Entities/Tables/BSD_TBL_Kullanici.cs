using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Interfaces;

namespace NetSatis.Entities.Tables
{
    public class BSD_TBL_Kullanici : IEntity
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Gorevi { get; set; }
        public string Parola { get; set; }
        public string HatirlatmaSorusu { get; set; }
        public string Cevap { get; set; }

        public bool Admin { get; set; }
        public bool SadeceRapor { get; set; } = true;
        public Nullable<DateTime> KayitTarihi { get; set; }
        public Nullable<DateTime> SonGirisTarihi { get; set; }




    }
}
