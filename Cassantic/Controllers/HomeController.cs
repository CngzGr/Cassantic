using Cassantic.Core.Caching;
using Cassantic.Core.Domains;
using Cassantic.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cassantic.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly ICacheManager _cacheManager;
        public HomeController(ICacheManager cacheManager)
        {
            
            this._cacheManager = cacheManager;
        }
        public ActionResult Index()
        {

           
            return View();
        }
    }
}
