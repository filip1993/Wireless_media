using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WirelessMediaZadatak.Models;

namespace WirelessMediaZadatak.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            WirelessMediaDbEntities entities = new WirelessMediaDbEntities();
            IEnumerable<Proizvod> listaProizvoda = entities.Proizvodi;
            return View(listaProizvoda.ToList());
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