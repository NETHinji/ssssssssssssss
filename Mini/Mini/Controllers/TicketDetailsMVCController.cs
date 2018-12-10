using Mini.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mini.Controllers
{
    public class TicketDetailsMVCController : Controller
    {
        // GET: TicketDetailsMVC
        public ActionResult Display()
        {
           
            return View();
            
        }
        public ActionResult Update()
        {

            return View();
        }

    }
}