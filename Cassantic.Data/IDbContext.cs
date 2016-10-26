using Cassantic.Core.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Data
{
    public interface IDbContext
    {
        int  SaveChanges();
        DbSet<T> Set<T>() where T : IBaseEntity;


    }
}
