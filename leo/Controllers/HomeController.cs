using leo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Http.Results;



namespace leo.Controllers
{
    public class HomeController : Controller
    {
       

        airportdbEntities db = new airportdbEntities(); // Replace with your own DB context

        public ActionResult Index()
        {
            var cityNames = db.cityinfoes.Select(c => c.CITY).ToList();
            ViewBag.CityNames = cityNames;
            return View();
        }

    }


}

