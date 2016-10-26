using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Domains
{
    public class PermissionRecord_Role_Mapping:IBaseEntity
    {
        public int PermissionRecord_Id { get; set; }
        public int roles_Id { get; set; }
        public int StoriesDomain_Id { get; set; }

        public virtual PermissionRecord PermissionRecord { get; set; }
        public virtual Roles roles { get; set; }
   
        
    }
}
