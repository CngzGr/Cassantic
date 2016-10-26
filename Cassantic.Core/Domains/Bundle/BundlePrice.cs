using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Domains
{
    public class BundleProductPrice:IBaseEntity
    {
        public int BundleProductID { get; set; }
        public int PriceTypeID { get; set; }
        public int PriceEntiyID { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDefault { get; set; }
        public int Order { get; set; }
    }
}
