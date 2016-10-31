using Cassantic.Core.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Data
{
    public class CassanticRepository<T>:IRepository<T>  where T:IBaseEntity
    {
        private readonly IDbContext Context;
        private DbSet<T> _Entites;

        public DbSet<T> Entites
        {
            get {
                if (_Entites == null)
                    _Entites = Context.Set<T>();

                return _Entites; }
           
        }

        public IQueryable<T> Table
        {
            get
            {
               return    this.Entites;
            }
        }

        public IQueryable<T> TableNotTracking
        {
            get
            {
                return this.Entites.AsNoTracking<T>();
            }
        }

        public CassanticRepository(IDbContext _Context)
        {
            this.Context = _Context;

        }
        public void Insert(T item)
        {
            this.Entites.Add(item);
            this.Context.SaveChanges();
        }

        public void Update(T item)
        {
            this.Context.SaveChanges();
        }

        public void Delete(T item)
        {
            this.Entites.Remove(item);
            this.Context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var item = FindById(Id);
            this.Entites.Remove(item);
        }

        public T FindById(int Id)
        {
            return this.Entites.Find(Id);
        }
    }
}
