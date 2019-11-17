using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tims.WebApp.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Users()
        {
            return View();
        }

        public ActionResult Suppliers()
        {
            return View();
        }

        public ActionResult Commerce()
        {
            return View(); 
        }

        public ActionResult Subscribers()
        {
            return View(); 
        }

        public ActionResult Accounts()
        {
            return View(); 
        }

        public ActionResult Reports()
        {
            return View();
        }
    }
}