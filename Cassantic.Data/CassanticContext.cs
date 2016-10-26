using Cassantic.Core.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Data
{
    public class CassanticContext:DbContext,IDbContext
    {
        public CassanticContext()
        {
          
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var mappingTypes = Assembly.GetExecutingAssembly().GetTypes().Where(p => !string.IsNullOrEmpty(p.Namespace)).Where(p => p.BaseType !=null && p.BaseType.IsGenericType).Where(p => p.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var item in mappingTypes)
            {
                dynamic mapType = Activator.CreateInstance(item);
                modelBuilder.Configurations.Add(mapType);
            }

            base.OnModelCreating(modelBuilder);
        }

        public new  DbSet<T> Set<T>() where T:IBaseEntity
        {
           return  base.Set<T>();
        }
    }
}
