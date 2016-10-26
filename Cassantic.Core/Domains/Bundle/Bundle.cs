using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Domains
{
    public class Bundle:IBaseEntity
    {
        private ICollection<BundleProductPrice> _Products;
        public ICollection<BundleProductPrice> Products
        {
            get { return _Products ?? (_Products = new List<BundleProductPrice>()); }
           protected set { _Products = value; }
        }
    }
}
