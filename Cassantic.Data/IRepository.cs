using Cassantic.Core.Domains;
using System.Linq;
using System.Threading.Tasks;

namespace Cassantic.Data
{
    public interface IRepository<T> where T:IBaseEntity
    {
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
        void Delete(int Id);
        T FindById(int Id);
        Task<T> FindByIdAsync(int Id);
        IQueryable<T> Table { get;}
        IQueryable<T> TableNotTracking { get; }
    }
}
