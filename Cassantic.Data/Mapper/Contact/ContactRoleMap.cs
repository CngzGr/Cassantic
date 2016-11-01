using Cassantic.Core.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Data.Mapper
{
   public class ContactRoleMap: EntityTypeConfiguration<ContactRole>
    {
        public ContactRoleMap()
        {
            this.ToTable("ContactRole");
            this.HasKey(p => p.Id);
        }
    }
}
