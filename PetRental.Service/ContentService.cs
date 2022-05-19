using PetRental.Data;
using PetRental.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PetRental.Service
{
    public class ContentService
    {
        private readonly Guid _userId;

        public ContentService()
        {

        }

        public ContentService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateContent(HttpPostedFileBase file, ContentCreate model)
        {
            model.Image = ConvertToBytes(file);

            var entity = new Content()
            {
                OwnerId = _userId,
                Title = model.Title,
                Description = model.Description,
                Image = model.Image

            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Contents.Add(entity);

                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ContentListSettingItem> ContentSelectList()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var content = ctx.Contents.Where(e => e.OwnerId == _userId).ToList();
                IEnumerable<ContentListSettingItem> mList = from s in content select new ContentListSettingItem { ID = s.ID, Description = s.Description };

                return mList;
            }
        }

        public byte[] GetImageFromDataBase(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var q = from temp in ctx.Contents where temp.ID == id select temp.Image;
                byte[] cover = q.First();
                return cover;
            }
        }

        public byte[] ConvertToBytes(HttpPostedFileBase image)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(image.InputStream);
            imageBytes = reader.ReadBytes((int)image.ContentLength);
            return imageBytes;
        }

        public ContentDetail GetContentById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var content = ctx.Contents.Single(e => e.OwnerId == _userId && e.ID == id);

                return new ContentDetail { ID = content.ID, Title = content.Title, Description = content.Description, Image = content.Image };
            }
        }

        public ContentDetail GetContentByIdSeed(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                byte[] bytes = new byte[16];
                BitConverter.GetBytes(00000000 - 0000 - 0000 - 0000 - 000000000000).CopyTo(bytes, 0);
                var nope = new Guid(bytes);



                var content = ctx.Contents.Single(e => e.OwnerId == nope && e.ID == id);

                return new ContentDetail { ID = content.ID, Title = content.Title, Description = content.Description, Image = content.Image };
            }
        }

        public IEnumerable<ContentListItem> GetContentsSeed()
        {
            using (var ctx = new ApplicationDbContext())
            {
                byte[] bytes = new byte[16];
                BitConverter.GetBytes(00000000 - 0000 - 0000 - 0000 - 000000000000).CopyTo(bytes, 0);
                var nope = new Guid(bytes);

                var quary = ctx.Contents.Where(e => e.OwnerId == nope).Select(e => new ContentListItem { ID = e.ID, Title = e.Title, Description = e.Description, Image = e.Image });

                return quary.ToArray();
            }
        }

        public IEnumerable<ContentListItem> GetContents()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var quary = ctx.Contents.Where(e => e.OwnerId == _userId).Select(e => new ContentListItem { ID = e.ID, Title = e.Title, Description = e.Description, Image = e.Image });

                return quary.ToArray();
            }
        }

        public bool UpdateContent(HttpPostedFileBase file, ContentEdit model)
        {
            model.Image = ConvertToBytes(file);
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Contents.Single(e => e.OwnerId == _userId && e.ID == model.ID);

                entity.Title = model.Title;
                entity.Description = model.Description;
                entity.Image = model.Image;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteContent(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Contents.Single(e => e.ID == id && e.OwnerId == _userId);
                ctx.Contents.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }

    }
}