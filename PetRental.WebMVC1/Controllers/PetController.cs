using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PetRental.WebMVC1.Models;

namespace PetRental.WebMVC1.Controllers
{
    public class PetController : Controller
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        public ActionResult Index()
        {
            List<Pet> petList = _db.Pets.ToList();
            List<Pet> orderedList = petList.OrderBy(prod => prod.PetId).ToList();
            return View(orderedList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Pet pet)
        {
            if (ModelState.IsValid)
            {
                _db.Pets.Add(pet);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pet);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            Pet pet = _db.Pets.Find(id);
            if (pet == null) return HttpNotFound();
            return View(pet);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Pet pet = _db.Pets.Find(id);
            _db.Pets.Remove(pet);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            Pet pet = _db.Pets.Find(id);
            if (pet == null) return HttpNotFound();
            return View(pet);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pet pet)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(pet).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pet);
        }

        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Pet pet = _db.Pets.Find(id);

            if (pet == null) return HttpNotFound();

            PetDetail detail = new PetDetail()
            {
                PetId = pet.PetId,
                TemporaryAdopts = pet.TemporaryAdopts.OrderBy(x => x.TimeOfRental).ToList(),
                PetName = pet.PetName,
                Type = (PetDetail.AnimalType)pet.Type,
                AnimalBreed = pet.AnimalBreed,
                Gender = (PetDetail.AnimalGender)pet.Gender,
                Vaccination = (PetDetail.VaccinationRecords)pet.Vaccination,
                PetHistory = pet.PetHistory,
                PetCount = pet.PetCount,
                EstimatedCost = pet.EstimatedCost,
            };
            return View(detail);
        }
    }
}