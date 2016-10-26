using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Domains
{
    public class Note:IBaseEntity
    {
        public int EntityID { get; set; }
        public string EntityName { get; set; }
        public string Content { get; set; }
        public int UserID { get; set; }
    }
}
