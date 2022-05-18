using PetRental.Data;
using PetRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRental.Service
{
    public class TemporaryAdoptService
    {
        private readonly Guid _userId;

        public TemporaryAdoptService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateTemporaryAdopt(TemporaryAdoptCreate model)
        {
            var entity =
                new TemporaryAdopt()
                {
                    OwnerId = _userId,
                    PetId = model.PetId,
                    CustomerId = model.CustomerId,
                    RentalDuration = model.RentalDuration,
                    RentalCost = model.RentalCost,
                    TransType = (TemporaryAdopt.TransactionType)model.TransType,
                    PetAvailability = model.PetAvailability,
                    TimeOfRental = model.TimeOfRental,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.TemporaryAdopts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<TemporaryAdoptListItem> GetTemporaryAdopts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .TemporaryAdopts
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new TemporaryAdoptListItem
                                {
                                    TransactionId = e.TransactionId,
                                    PetId = e.PetId,
                                    CustomerId = e.CustomerId,
                                    RentalDuration = e.RentalDuration,
                                    RentalCost = e.RentalCost,
                                    TransType = (TemporaryAdoptListItem.TransactionType)e.TransType,
                                    PetAvailability = e.PetAvailability,
                                    TimeOfRental = e.TimeOfRental,
                                    CreatedUtc = DateTimeOffset.Now
                                }
                        );

                return query.ToArray();
            }
        }
        public TemporaryAdoptDetail GetTemporaryAdoptById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .TemporaryAdopts
                    .Single(e => e.TransactionId == id && e.OwnerId == _userId);
                return
                    new TemporaryAdoptDetail
                    {
                        TransactionId = entity.TransactionId,
                        PetId = entity.PetId,
                        CustomerId = entity.CustomerId,
                        RentalDuration = entity.RentalDuration,
                        RentalCost = entity.RentalCost,
                        TransType = (TemporaryAdoptDetail.TransactionType)entity.TransType,
                        PetAvailability = entity.PetAvailability,
                        TimeOfRental = entity.TimeOfRental,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }
        public bool UpdateTemporaryAdopt(TemporaryAdoptEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .TemporaryAdopts
                        .Single(e => e.TransactionId == model.TransactionId && e.OwnerId == _userId);

                entity.PetId = model.PetId;
                entity.CustomerId = model.CustomerId;
                entity.RentalDuration = model.RentalDuration;
                entity.RentalCost = model.RentalCost;
                entity.TransType = (TemporaryAdopt.TransactionType)model.TransType;
                entity.PetAvailability = model.PetAvailability;
                entity.TimeOfRental = model.TimeOfRental;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteTemporaryAdopt(int temporaryAdoptId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .TemporaryAdopts
                        .Single(e => e.TransactionId == temporaryAdoptId && e.OwnerId == _userId);

                ctx.TemporaryAdopts.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}