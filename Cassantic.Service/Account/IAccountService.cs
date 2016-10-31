using Cassantic.Core;
using Cassantic.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Service
{
    public  interface IAccountService
    {
        void Insert(Account item);
        void Update(Account item);
        void Delete(Account item);
        Account GetByID(int Id);
        IPagedList<Account> Filter(int PageIndex, int PageSize);

    }
}
