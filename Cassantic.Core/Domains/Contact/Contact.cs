using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Domains
{
    public class Contact:IBaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<ContactPhone> Phones { get; set; }
        public int Gender { get; set; }
        public int BirthDay { get; set; }

        private ICollection<AccountContact> _Accounts;
        public ICollection<AccountContact> Accounts
        {
            get { return _Accounts??(_Accounts=new List<AccountContact>()); }
            protected set { _Accounts = value; }
        }

    }
}
