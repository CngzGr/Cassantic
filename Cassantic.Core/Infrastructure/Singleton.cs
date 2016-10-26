using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Infrastructure
{
    public class Singleton<T> : Singleton
    {
        static T instance;

        public static T Instance
        {
            get { return instance; }
            set { 
                
                instance = value;
                AllSingleton[typeof(T)] = value;
            }
        }
    }

    public class Singleton
    {
        static Singleton()
        {
            allSingleton = new Dictionary<Type, object>();
        }

        static readonly Dictionary<Type, object> allSingleton;
        public static Dictionary<Type, object> AllSingleton { get{ return allSingleton;}  }
    }
}
