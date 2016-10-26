using System.Collections.Generic;


namespace Cassantic.Core.Domains
{
    public class PermissionRecord : IBaseEntity
    {
        private ICollection<PermissionRecord_Role_Mapping> _customerRoles;
        public  string Name { get; set; }
        public  string SystemName { get; set; }
        public  string Category { get; set; }
        public  bool   IsWebClient { get; set; }

        public virtual ICollection<PermissionRecord_Role_Mapping> CustomerRoles
        {
            get { return _customerRoles ?? ( _customerRoles = new List<PermissionRecord_Role_Mapping>() ); }
            protected set { _customerRoles = value; }
        }
    }
}
