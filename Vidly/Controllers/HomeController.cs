using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    [AllowAnonymous]// to allow the allowing the home aacessible to every one
    //[OutputCache(Duration =50, Location = System.Web.UI.OutputCacheLocation.Server, VaryByParam ="*")]
    [OutputCache(Duration =0, VaryByParam ="*", NoStore =true)]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}