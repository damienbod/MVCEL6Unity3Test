using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcUnity3Test.Business
{
    public class BusinessClass : IBusinessClass
    {
        public string Hello()
        {
            return "Hello from Business class";
        }
    }
}