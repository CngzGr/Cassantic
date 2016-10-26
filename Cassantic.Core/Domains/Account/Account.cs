using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Domains
{
    public class Account:IBaseEntity
    {
   
        public string Content { get; set; }


        private ICollection<Activity> _Activities;
        public ICollection<Activity> Activities
        {
            get { return _Activities??(_Activities=new List<Activity>()); }
           protected set { _Activities = value; }
        }

        private ICollection<Address> _Address;
        public ICollection<Address> Address
        {
            get { return _Address ?? (_Address = new List<Address>()); }
            protected set { _Address = value; }
        }

        private ICollection<AccountContact> _Contacts;
        public ICollection<AccountContact> Contacts
        {
            get { return _Contacts ?? (_Contacts = new List<AccountContact>()); }
            protected set { _Contacts = value; }
        }

        private ICollection<AccountPhone> _Phones;
        public ICollection<AccountPhone> Phones
        {
            get { return _Phones ?? (_Phones = new List<AccountPhone>()); }
            protected set { _Phones = value; }
        } 
    }
}
