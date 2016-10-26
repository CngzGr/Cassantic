using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Domains
{
    public class AccountContact:IBaseEntity
    {
        public int ContactID { get; set; }
        public int AccountID { get; set; }
        public Contact Contact { get; set; }
        public Account Account { get; set; }
        public ContactRole ContactRole { get; set; }
        public int ContactRoleID { get; set; }
    }
}
