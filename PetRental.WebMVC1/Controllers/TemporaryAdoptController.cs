using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PetRental.WebMVC1.Models;

namespace PetRental.WebMVC1.Controllers
{
    [Authorize]
    public class TemporaryAdoptController : Controller
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();
        // GET: TemporaryAdopt
        public ActionResult Index()
        {
            return View(_db.TemporaryAdopts.OrderBy(t => t.TimeOfRental).ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            TemporaryAdopt temporaryAdopt = _db.TemporaryAdopts.Find(id);
            if (temporaryAdopt == null) return HttpNotFound();

            return View(temporaryAdopt);
        }

        public ActionResult Create()
        {
            ViewBag.CustomerId = new SelectList(_db.Customers, "CustomerId", "FullName");
            ViewBag.PetId = new SelectList(_db.Pets, "PetId", "PetName");
            return View();
        }
        public ActionResult Return()
        {
            ViewBag.CustomerId = new SelectList(_db.Customers, "CustomerId", "FullName");
            ViewBag.PetId = new SelectList(_db.Pets, "PetId", "PetName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(TemporaryAdopt temporaryAdopt)
        {
            temporaryAdopt.TimeOfRental = DateTime.Now;
            if (ModelState.IsValid)
            {
                if (_db.Customers.Find(temporaryAdopt.CustomerId) == null)
                    return HttpNotFound("Customer Name Was Not Entered.");
                var pet = _db.Pets.Find(temporaryAdopt.PetId);
                if (pet == null)
                    return HttpNotFound("Pet Name Was Not Entered.");
                if (temporaryAdopt.PetAvailability = !pet.PetCount)
                    return HttpNotFound("That Pet Is Currently Unavailable.");

                _db.TemporaryAdopts.Add(temporaryAdopt);
                pet.PetCount = temporaryAdopt.PetAvailability;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerId = new SelectList(_db.Customers, "CustomerId", "FullName");
            ViewBag.PetId = new SelectList(_db.Pets, "PetId", "PetName");
            return View(temporaryAdopt);
        }
        [HttpPost]
        public ActionResult Return(TemporaryAdopt temporaryAdopt)
        {
            temporaryAdopt.TimeOfRental = DateTime.Now;
            if (ModelState.IsValid)
            {
                if (_db.Customers.Find(temporaryAdopt.CustomerId) == null)
                    return HttpNotFound("Customer Name Was Not Entered.");
                var pet = _db.Pets.Find(temporaryAdopt.PetId);
                if (pet == null)
                    return HttpNotFound("Pet Name Was Not Entered.");
                if (temporaryAdopt.PetAvailability = pet.PetCount)
                    return HttpNotFound("That Pet Is Currently Unavailable.");

                _db.TemporaryAdopts.Add(temporaryAdopt);
                pet.PetCount = !temporaryAdopt.PetAvailability;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerId = new SelectList(_db.Customers, "CustomerId", "FullName");
            ViewBag.PetId = new SelectList(_db.Pets, "PetId", "PetName");
            return View(temporaryAdopt);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Customer Name Was Not Entered.");

            var temporaryAdopt = _db.TemporaryAdopts.Find(id);
            if (temporaryAdopt == null) return HttpNotFound("No Transaction Was Found By That ID.");

            return View(temporaryAdopt);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            TemporaryAdopt temporaryAdopt = _db.TemporaryAdopts.Find(id);
            var pet = _db.Pets.Find(temporaryAdopt.PetId);
            pet.PetCount = temporaryAdopt.PetAvailability;
            _db.TemporaryAdopts.Remove(temporaryAdopt);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Pet Name Was Not Entered.");
            TemporaryAdopt temporaryAdopt = _db.TemporaryAdopts.Find(id);

            if (temporaryAdopt == null) return HttpNotFound("No Transaction Was Found By That ID.");
            ViewBag.CustomerId = new SelectList(_db.Customers, "CustomerId", "FullName");
            ViewBag.PetId = new SelectList(_db.Pets, "PetId", "PetName");
            return View(temporaryAdopt);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TemporaryAdopt temporaryAdopt)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(temporaryAdopt).State = System.Data.Entity.EntityState.Modified;
                var oldTemporaryAdopt = _db.TemporaryAdopts.Find(temporaryAdopt.TransactionId);
                var oldPet = _db.Pets.Find(oldTemporaryAdopt.PetId);
                oldPet.PetCount = oldTemporaryAdopt.PetAvailability;


                var newPet = _db.Pets.Find(temporaryAdopt.PetId);
                if (temporaryAdopt.PetAvailability = !newPet.PetCount)
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "This Pet Is Not Available, Nothing Was Adjusted.");

                newPet.PetCount = temporaryAdopt.PetAvailability;


                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            ViewBag.CustomerId = new SelectList(_db.Customers, "CustomerId", "FullName");
            ViewBag.PetId = new SelectList(_db.Pets, "PetId", "PetName");
            return View(temporaryAdopt);
        }
    }
}