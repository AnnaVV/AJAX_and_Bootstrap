using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapTestApp.Controllers
{
    public class CustomersController : Controller
    {
        //
        // GET: /Customers/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NikoCompany()
        {
            return View();
        }

        public ActionResult CocaColaCompany()
        {
            return View();
        }

        public ActionResult NestleCompany()
        {
            return View();
        }
	}
}