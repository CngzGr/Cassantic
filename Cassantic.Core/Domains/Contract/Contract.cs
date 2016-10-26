using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Domains
{
    public  class Contract:IBaseEntity
    {
        public int ContractStatusID { get; set; }
        public int CreateDate { get; set; }
        public decimal Price { get; set; }
        public int CurrencyID { get; set; }

        public int OpportunityID { get; set; }
        public Opportunity Opportunity { get; set; }
    }
}
