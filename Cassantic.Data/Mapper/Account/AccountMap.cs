using Cassantic.Core.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Data.Mapper
{
    public class AccountMap:EntityTypeConfiguration<Account>
    {
        public AccountMap()
        {
            this.ToTable("Account");
            this.HasKey(p => p.Id);
            this.HasMany(p => p.Activities).WithRequired(a => a.Account).WillCascadeOnDelete(true);
        }
    }
}
