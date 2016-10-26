using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassantic.Core.Infrastructure
{
    public class WebTypeFinder:TypeFinder
    {
        private bool _binFolderAssembliesLoaded = false;

        public override IList<System.Reflection.Assembly> GetAssembly()
        {
            if (!_binFolderAssembliesLoaded)
            {
                _binFolderAssembliesLoaded = true;
                string binPath = GetBinDirectory();
                //binPath = _webHelper.MapPath("~/bin");
                LoadMatchingAssemblies(binPath);
            }
            return base.GetAssembly();
        }
    }
}
