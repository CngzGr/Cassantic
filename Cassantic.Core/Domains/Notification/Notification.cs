using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Domains
{
    public class Notification:IBaseEntity
    {
        public int ActivityTypeID { get; set; }
        public ActivityType ActivityType { get; set; }
        public int NotifyStatusID { get; set; }
        public int NotifySendTypeID { get; set; }
        public int EnityID { get; set; }
        public string EntityType { get; set; }
        public int NotifyContentTemplateID { get; set; }
    }

    public class NotifiyContentTemplate : IBaseEntity
    {
        public string Content { get; set; }
    }
}
