using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetRental.WebMVC1.Models;
using PetRental.WebMVC1.Repositories;
using PetRental.WebMVC1.ViewModel;

namespace PetRental.WebMVC1.Controllers
{
    [RoutePrefix("Content")]
    [ValidateInput(false)]
    public class ContentController : Controller
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        [Route("Index")]
        [HttpGet]
        public ActionResult Index()
        {
            var content = _db.Contents.Select(s => new
            {
                s.ID,
                s.Title,
                s.Image,
                s.Description
            });

            List<ContentViewModels> contentModel = content.Select(item => new ContentViewModels()
            {
                ID = item.ID,
                Title = item.Title,
                Image = item.Image,
                Description = item.Description,
            }).ToList();
            return View(contentModel);
        }
        public ActionResult RetrieveImage(int id)
        {
            byte[] cover = GetImageFromDataBase(id);
            if (cover != null)
            {
                return File(cover, "image/jpg");
            }
            else
            {
                return null;
            }
        }
        public byte[] GetImageFromDataBase(int Id)
        {
            var q = from temp in _db.Contents where temp.ID == Id select temp.Image;
            byte[] cover = q.First();
            return cover;
        }
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [Route("Create")]
        [HttpPost]
        public ActionResult Create(ContentViewModels model)
        {
            HttpPostedFileBase file = Request.Files["ImageData"];
            ContentRepository service = new ContentRepository();
            int i = service.UploadImageInDataBase(file, model);
            if (i == 1)
            {
                return RedirectToAction("/Index");
            }
            return View(model);
        }
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            Content content = _db.Contents.Find(id);
            if (content == null) return HttpNotFound();
            return View(content);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Content content = _db.Contents.Find(id);
            _db.Contents.Remove(content);
            _db.SaveChanges();
            return RedirectToAction("/Index");
        }
    }
}