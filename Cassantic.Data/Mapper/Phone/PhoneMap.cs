using Cassantic.Core.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Data.Mapper
{
    public   class AccountPhoneMap:EntityTypeConfiguration<AccountPhone>
    {
        public AccountPhoneMap()
        {
            this.ToTable("AccountPhone");
            this.HasKey(p => p.Id);
            this.HasRequired(p => p.Account).WithMany(p => p.Phones).WillCascadeOnDelete(true);
        }

    }
    public   class ContactPhoneMap: EntityTypeConfiguration<ContactPhone>
    {
        public ContactPhoneMap()
        {
            this.ToTable("ContactPhone");
            this.HasKey(p => p.Id);
            this.HasRequired(p => p.Contact).WithMany(p => p.Phones).WillCascadeOnDelete(true);
        }

    }

}
