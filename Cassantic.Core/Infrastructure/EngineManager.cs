using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Infrastructure
{
    public class EngineManager
    {
        public static IEngine Initialize() {

            if (Singleton<IEngine>.Instance == null)
            {
                Singleton<IEngine>.Instance = new CassanticEngine();
                Singleton<IEngine>.Instance.Initialize();
            }
            return Singleton<IEngine>.Instance;
        }
        public static IEngine Current {
            get {
                if (Singleton<IEngine>.Instance == null)
                {
                    Singleton<IEngine>.Instance = Initialize();
                }
                return Singleton<IEngine>.Instance;
            }
        }
    }
}
