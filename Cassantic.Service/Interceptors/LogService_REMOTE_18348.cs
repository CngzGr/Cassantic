using Cassantic.Core.Domains;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Cassantic.Service.Interceptors
{
    public class LogService : IInterceptor
    {
       
        public void Intercept(IInvocation invocation)
        {

            using (var scope = new TransactionScope()) {

                foreach (var item in invocation.Arguments)
                {
                    var entity = item as IBaseEntity;
                    var arg = invocation.Arguments.FirstOrDefault();
                }
                scope.Complete();

            }

         
        }
    }
}
