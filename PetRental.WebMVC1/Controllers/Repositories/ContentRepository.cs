using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using PetRental.WebMVC1.Models;
using PetRental.WebMVC1.ViewModel;


namespace PetRental.WebMVC1.Repositories
{
    public class ContentRepository
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();
        public int UploadImageInDataBase(HttpPostedFileBase file, ContentViewModels contentViewModel)
        {
            contentViewModel.Image = ConvertToBytes(file);
            var Content = new Content
            {
                Title = contentViewModel.Title,
                Description = contentViewModel.Description,
                Image = contentViewModel.Image
            };
            db.Contents.Add(Content);
            int i = db.SaveChanges();
            if (i == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public byte[] ConvertToBytes(HttpPostedFileBase image)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(image.InputStream);
            imageBytes = reader.ReadBytes((int)image.ContentLength);
            return imageBytes;
        }
    }
}