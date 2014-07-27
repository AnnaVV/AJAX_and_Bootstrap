using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapTestApp.Controllers
{
    public class CareerController : Controller
    {
        //
        // GET: /Career/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MarketingOpenPositions()
        {
            return View();
        }

        public ActionResult SalesOpenPositions()
        {
            return View();
        }

        public ActionResult AccountingOpenPositions()
        {
            return View();
        }
	}
}