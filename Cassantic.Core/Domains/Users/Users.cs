using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Domains
{
    public  class Users:IBaseEntity
    {
        public string Email { get; set; }

        private ICollection<Note> _Notes;
        public ICollection<Note> Notes
        {
            get { return _Notes ?? (_Notes = new List<Note>()); }
            protected  set { _Notes = value; }
        }

        private ICollection<Account> _Account;
        public ICollection<Account> Account
        {
            get { return _Account??(_Account=new List<Account>()); }
            protected set { _Account = value; }
        }

        private ICollection<Activity> _Avtivities;
        public ICollection<Activity> Avtivities
        {
            get { return _Avtivities ?? (_Avtivities = new List<Activity>()); }
            protected set { _Avtivities = value; }
        }

    }
}
