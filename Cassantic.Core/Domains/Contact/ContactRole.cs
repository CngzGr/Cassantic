using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Domains
{
    public class ContactRole:IBaseEntity
    {
        private ICollection<AccountContact> _Contacts;
        public ICollection<AccountContact> Contacts
        {
            get { return _Contacts ?? (_Contacts = new List<AccountContact>()); }
            protected set { _Contacts = value; }
        }
    }
}
