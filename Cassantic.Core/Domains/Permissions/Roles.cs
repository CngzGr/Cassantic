using System.Collections.Generic;



namespace Cassantic.Core.Domains
{
    public class Roles:IBaseEntity
    {
        private ICollection<PermissionRecord_Role_Mapping> _permissionRecords;

        public string Name { get; set; }
        public bool Active { get; set; }
        public string SystemName { get; set; }
        public bool TaxExempt { get; set; }
        public bool FreeShipping { get; set; }
        public bool isSystem { get; set; }
        public bool IsWebClient { get; set; }
        public int  StoriesDomainId { get; set; }
        public virtual ICollection<PermissionRecord_Role_Mapping> PermissionRecords
        {
            get { return _permissionRecords ?? ( _permissionRecords = new List<PermissionRecord_Role_Mapping>() ); }
            protected set { _permissionRecords = value; }
        }
    }

    public static partial class SystemCustomerRoleNames
    {
        public static string Administrators { get { return "Administrators"; } }
        public static string ForumModerators { get { return "ForumModerators"; } }
        public static string Registered { get { return "Registered"; } }
        public static string Guests { get { return "Guest"; } }
        public static string Editor { get { return "Editor"; } }
        public static string Stories { get { return "Stories"; } }

    }

}
