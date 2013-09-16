using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;


namespace MvcUnity3Test.Controllers
{
    public class PropertyDependencyController : Controller
    {
        [Dependency]
        public Business.IDoSomething _doSomethingUtil { get; set; }

        public ActionResult Index()
        {
            return View();
        }

    }
}
