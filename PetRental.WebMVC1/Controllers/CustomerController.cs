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
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();
        public ActionResult Index()
        {
            List<Customer> customerList = _db.Customers.ToList();
            List<Customer> orderedList = customerList.OrderBy(prod => prod.LastName).ThenByDescending(cust => cust.FirstName).ToList();
            return View(orderedList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _db.Customers.Add(customer);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            Customer customer = _db.Customers.Find(id);
            if (customer == null) return HttpNotFound();
            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Customer customer = _db.Customers.Find(id);
            _db.Customers.Remove(customer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            Customer customer = _db.Customers.Find(id);
            if (customer == null) return HttpNotFound();
            return View(customer);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Customer customer = _db.Customers.Find(id);
            if (customer == null) return HttpNotFound();

            CustomerDetail details = new CustomerDetail()
            {
                CustomerId = customer.CustomerId,
                FullName = customer.FullName,
                PhoneNumber = customer.PhoneNumber,
                Address = customer.Address,
                TemporaryAdopts = customer.TemporaryAdopts.ToList()
            };
            return View(details);
        }
    }
}