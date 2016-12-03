using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassantic.Core;
using Cassantic.Core.Domains;
using Cassantic.Data;
using Autofac.Extras.DynamicProxy;

namespace Cassantic.Service
{
    public class AccountService : IAccountService
    {
        private readonly IRepository<Account> _accountRepository;
        public AccountService(IRepository<Account> accountRepository)
        {
            this._accountRepository = accountRepository;
        }
        public void Delete(Account item)
        {
            this._accountRepository.Delete(item);
        }

        public IPagedList<Account> Filter(int PageIndex, int PageSize)
        {
            var query = from p in _accountRepository.Table
                        select p;

            return new PagedList<Account>(query, PageIndex, PageSize);
        }

        public Account GetByID(int Id)
        {
            return this._accountRepository.FindById(Id);
        }

     
        public void Insert(Account item)
        {
            this._accountRepository.Insert(item);
        }

        public void Update(Account item)
        {
            this._accountRepository.Update(item);
        }
    }
}
