using System.Collections.Generic;

namespace Cassantic.Core.Domains
{
    public class DefaultPermissionRecord
    {
        public DefaultPermissionRecord()
        {
            this.PermissionRecords = new List<PermissionRecord>();
        }
        public string CustomerRoleSystemName { get; set; }
        public IEnumerable<PermissionRecord> PermissionRecords { get; set; }
    }
}
