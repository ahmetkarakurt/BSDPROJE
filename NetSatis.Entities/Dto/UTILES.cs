using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Dto
{
    public static class UTILES
    {

        public static string TurkceKelime(string Veri)
        {
            return Veri.Replace("Ý", "I").Replace("Þ", "S").Replace("Ð", "G");
        }
    }
}
