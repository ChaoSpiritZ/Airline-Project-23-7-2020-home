using AirlineProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirlineProjectWebAPI.Controllers
{
    public class PageController : Controller
    {
        public AnonymousUserFacade anonymousFacade = new AnonymousUserFacade(); //should i do it in a different way?

        // GET: Page
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DepartingFlights()
        {
            IList<FullFlightData> flights = anonymousFacade.GetDepartingFlightsFullData();
            ViewBag.Flights = flights;
            return View();
        }

        public ActionResult LandingFlights()
        {
            IList<FullFlightData> flights = anonymousFacade.GetLandingFlightsFullData();
            ViewBag.Flights = flights;
            return View();
        }

        public ActionResult SearchFlights()
        {
            return View();
        }

        public ActionResult SearchFlightsResults()
        {
            string searchBy = Request.Form["SearchBy"];
            string searchText = Request.Form["SearchText"];
            string searchFlights = Request.Form["SearchFlights"];
            IList<FullFlightData> flights = anonymousFacade.SearchFlights(searchBy, searchText, searchFlights);
            ViewBag.Flights = flights;
            return View();
        }
    }
}