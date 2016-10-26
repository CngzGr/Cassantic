using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Domains
{
    public class Opportunity : IBaseEntity
    {

        public int OpportunityTypeID { get; set; }
        public int OpportunityStatusID { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int OpenUserID { get; set; }
        public Users OpenUser { get; set; }
        
        public int OwnerUserID { get; set; }
        public Users OwnerUser { get; set; }
      
        public int CloseUserID { get; set; }
        public Users CloseUser { get; set; }


        public int AccountID { get; set; }
        public Account Accoount { get; set; }

        public int ContactID { get; set; }
        public Contact Contact { get; set; }

        private ICollection<Contract> _Contracts;
        public ICollection<Contract> Contracts
        {
            get { return _Contracts??(_Contracts=new List<Contract>()); }
            protected set { _Contracts = value; }
        }
    }
}
