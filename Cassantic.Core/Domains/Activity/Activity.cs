using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Domains
{
    public class Activity:IBaseEntity
    {
        public int AccountID { get; set; }
        public Account Account { get; set; }
        public int UserId { get; set; }
        public Users Users { get; set; }
        public int  ActivityTypeID { get; set; }
        public int  ActivityRateID { get; set; }
        public ActivityType ActivityType { get; set; }
        public ActivityRate ActivityRate { get; set; }
        public int ContactID { get; set; }
        public Contact Contact { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DurationMinutes { get; set; }
        public bool IsClosed { get; set; }
        public bool IsDalyActivity { get; set; }
     

    }
}
