using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WirelessMediaZadatak.Models;

namespace WirelessMediaZadatak.Controllers
{
    public class HomeController : Controller
    {
        private WirelessMediaDbEntities db = new WirelessMediaDbEntities();

        public ActionResult Index()
        {
            return View(db.Proizvodi.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.DobavljacId = new SelectList(db.Dobavljaci, "DobavljacId", "NazivDobavljaca");
            ViewBag.KategorijaId = new SelectList(db.Kategorije, "KategorijaId", "NazivKategorije");
            ViewBag.ProizvodjacId = new SelectList(db.Proizvodjaci, "ProizvodjacId", "NazivProizvodjaca");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProizvodId,KategorijaId,ProizvodjacId,DobavljacId,Naziv,Opis,Cena")] Proizvod proizvod)
        {
            if (ModelState.IsValid)
            {
                db.Proizvodi.Add(proizvod);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DobavljacId = new SelectList(db.Dobavljaci, "DobavljacId", "NazivDobavljaca", proizvod.DobavljacId);
            ViewBag.KategorijaId = new SelectList(db.Kategorije, "KategorijaId", "NazivKategorije", proizvod.KategorijaId);
            ViewBag.ProizvodjacId = new SelectList(db.Proizvodjaci, "ProizvodjacId", "NazivProizvodjaca", proizvod.ProizvodjacId);
            return View(proizvod);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proizvod proizvod = db.Proizvodi.Find(id);
            if (proizvod == null)
            {
                return HttpNotFound();
            }
            ViewBag.DobavljacId = new SelectList(db.Dobavljaci, "DobavljacId", "NazivDobavljaca", proizvod.DobavljacId);
            ViewBag.KategorijaId = new SelectList(db.Kategorije, "KategorijaId", "NazivKategorije", proizvod.KategorijaId);
            ViewBag.ProizvodjacId = new SelectList(db.Proizvodjaci, "ProizvodjacId", "NazivProizvodjaca", proizvod.ProizvodjacId);
            return View(proizvod);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProizvodId,KategorijaId,ProizvodjacId,DobavljacId,Naziv,Opis,Cena")] Proizvod proizvod)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proizvod).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DobavljacId = new SelectList(db.Dobavljaci, "DobavljacId", "NazivDobavljaca", proizvod.DobavljacId);
            ViewBag.KategorijaId = new SelectList(db.Kategorije, "KategorijaId", "NazivKategorije", proizvod.KategorijaId);
            ViewBag.ProizvodjacId = new SelectList(db.Proizvodjaci, "ProizvodjacId", "NazivProizvodjaca", proizvod.ProizvodjacId);
            return View(proizvod);
        }
    }
}