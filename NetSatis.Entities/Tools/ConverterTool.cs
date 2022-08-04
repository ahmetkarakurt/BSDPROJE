using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Tools
{
    public static class ConverterTool
    {
    
        public static decimal StringToDecimal(string ifade,string ondalikAyrac)
        {
            string ondalikKarakter = System.Globalization.CultureInfo.CurrentCulture.NumberFormat
                .CurrencyDecimalSeparator.ToString();
            return Convert.ToDecimal(ifade.Replace(ondalikAyrac, ondalikKarakter));
        }
    }
}
