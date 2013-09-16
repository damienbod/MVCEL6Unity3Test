using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcUnity3Test.Controllers
{
    public class HomeController : Controller
    {          
        private readonly Business.IBusinessClass _businessClass;

        public HomeController(Business.IBusinessClass businessClass)
        {
            _businessClass = businessClass;
        }

        public ActionResult Index()
        {
            _businessClass.Hello();
            return View();
        }
    }
}
