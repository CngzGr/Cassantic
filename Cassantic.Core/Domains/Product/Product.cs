using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Domains
{
    public class Product
    {
        public int ProductTypeID { get; set; }
        public decimal  MinPrice { get; set; }
        public decimal  MaxPrice { get; set; }
    }
}
