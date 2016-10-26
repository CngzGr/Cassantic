using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Domains
{
    public class AccountPhone:IBaseEntity
    {
        public int PhoneTypeID { get; set; }
        public string Number { get; set; }
        public string Internal { get; set; }
        public int Order { get; set; }
        public int AccountID { get; set; }
        public Account Account { get; set; }
     
    }
}
