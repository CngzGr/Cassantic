using Cassantic.Core.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Data.Mapper
{
   public class ActivityMap:EntityTypeConfiguration<Activity>
    {
       public ActivityMap()
       {
           this.ToTable("Activity");
           this.HasKey(p => p.Id);

       }
    }
}
