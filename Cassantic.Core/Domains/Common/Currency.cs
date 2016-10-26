using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Domains
{
    public class Currency:IBaseEntity
    {
        public string Name { get; set; }
        public string PriceIcon { get; set; }
        public string DecimalStr { get; set; }
        public string ThundreStr { get; set; }
        public decimal Rate { get; set; }
        public string DisplayLocale { get; set; }
        public string CustomFormatting { get; set; }
        public bool   Published { get; set; }
    }
}
