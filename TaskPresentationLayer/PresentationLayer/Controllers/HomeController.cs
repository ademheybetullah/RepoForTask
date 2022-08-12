using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Concrete;

namespace TaskPresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Home()
        {
            return View();
        }

    }
}