using Cassantic.Core.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Data.Mapper
{
    public class ActivityRateMap:EntityTypeConfiguration<ActivityRate>
    {
        public ActivityRateMap()
        {
            this.ToTable("ActivityRate");
            this.HasKey(p => p.Id);
        }
    }
}
