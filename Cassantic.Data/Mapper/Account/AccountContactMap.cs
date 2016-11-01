using Cassantic.Core.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Data.Mapper
{
   public class AccountContactMap:EntityTypeConfiguration<AccountContact>
    {
       public AccountContactMap()
       {
           this.ToTable("AccountContact");
           this.HasKey(p => p.Id);
           this.HasRequired(p => p.Contact).WithMany(p => p.Accounts).WillCascadeOnDelete(true);
           this.HasRequired(p => p.Account).WithMany(p => p.Contacts).WillCascadeOnDelete(true);
           this.HasRequired(p => p.ContactRole).WithMany(p => p.Contacts).WillCascadeOnDelete(true);
        }
    }
}
