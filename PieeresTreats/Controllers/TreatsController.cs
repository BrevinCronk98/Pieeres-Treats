using PieeresTreats.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
namespace PieeresTreats.Controllers
{
    public class TreatsController : Controller
    {
        private readonly PieeresTreatsContext _db;
       
        public TreatsController( PieeresTreatsContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Treat> model = _db.Treats.ToList();
            return View(model);
        }

        [Authorize]
        public ActionResult Create()
        {
            ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
            return View();
        }


        [HttpPost]
        public ActionResult Create(Treat treat, int FlavorId)
        {
            _db.Treats.Add(treat);
            if(FlavorId != 0)
            {
                _db.TreatFlavors.Add(new TreatFlavor() {FlavorId = FlavorId, TreatId = treat.TreatId});
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var thisTreat = _db.Treats
                .Include(treat => treat.Flavors)
                .ThenInclude(join => join.Flavor)
                .FirstOrDefault(treat => treat.TreatId == id);
            return View(thisTreat);
        }
        
        
        [Authorize]
        public ActionResult Edit(int id)
        {
            var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
            ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
            return View(thisTreat);
        }

        [HttpPost]
        public ActionResult Edit(Treat treat, int FlavorId)
        {
            if(FlavorId != 0)
            {
                _db.TreatFlavors.Add(new TreatFlavor() { FlavorId = FlavorId, TreatId = treat.TreatId});
            }
            _db.Entry(treat).State= EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        [Authorize]
        public ActionResult Delete(int id)
        {
            var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
            return View(thisTreat);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
            _db.Treats.Remove(thisTreat);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult AddFlavor(int id)
        {
            var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
            ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
            return View(thisTreat);
        }

        [HttpPost]
        public ActionResult AddFlavor(Treat treat, int FlavorId)
        {
            if(FlavorId != 0)
            {
                _db.TreatFlavors.Add(new TreatFlavor() {FlavorId = FlavorId, TreatId = treat.TreatId});
            }
            _db.Entry(treat).Collection(r => r.Flavors).IsModified = true;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}