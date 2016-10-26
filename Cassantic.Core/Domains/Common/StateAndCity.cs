using System;
using System.Collections.Generic;

namespace Cassantic.Core.Domains
{
    public class StateAndCity:IBaseEntity
    {
      
        public virtual string Abbreviation { get; set; }
        public virtual string TwoLetterIsoCode { get; set; }
        public virtual string Name { get; set; }
        public virtual int RegionID { get; set; }
        public virtual int ParentID { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual int UserID { get; set; }
        public virtual int Sort { get; set; }
        public virtual bool SubjectToVat { get; set; }
        public virtual bool AllowsBilling { get; set; }
        public virtual bool AllowsShipping { get; set; }
        public  StateAndCity Parent { get; set; }
        private ICollection<Account> _StoreList;
        public virtual ICollection<Account> StoreList
        {
            get { return _StoreList ?? (_StoreList = new List<Account>()); }
            protected set { _StoreList = value; }
        }
    }
}
