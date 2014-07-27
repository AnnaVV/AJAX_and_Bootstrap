using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapTestApp.Controllers
{
    public class ServicesController : Controller
    {
        //
        // GET: /Services/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RoadTransportation()
        {
            return View();
        }

        public ActionResult AirTransportation()
        {
            return View();
        }

        public ActionResult SeaTransportation()
        {
            return View();
        }
	}
}