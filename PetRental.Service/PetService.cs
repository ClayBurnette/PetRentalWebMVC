using PetRental.Data;
using PetRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRental.Service
{
    public class PetService
    {
        private readonly Guid _userId;

        public PetService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreatePet(PetCreate model)
        {

            var entity =
                new Pet()
                {
                    OwnerId = _userId,
                    PetName = model.PetName,
                    PetCount = model.PetCount,
                    Gender = (Pet.AnimalGender)model.Gender,
                    PetHistory = model.PetHistory,
                    AnimalBreed = model.AnimalBreed,
                    EstimatedCost = model.EstimatedCost,
                    Type = (Pet.AnimalType)model.Type,
                    Vaccination = (Pet.VaccinationRecords)model.Vaccination,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Pets.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<PetListItem> GetPets()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Pets
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new PetListItem
                                {
                                    PetId = e.PetId,
                                    PetName = e.PetName,
                                    PetCount = e.PetCount,
                                    Gender = (PetListItem.AnimalGender)e.Gender,
                                    PetHistory = e.PetHistory,
                                    AnimalBreed = e.AnimalBreed,
                                    EstimatedCost = e.EstimatedCost,
                                    Type = (PetListItem.AnimalType)e.Type,
                                    Vaccination = (PetListItem.VaccinationRecords)e.Vaccination,
                                    CreatedUtc = DateTimeOffset.Now
                                }
                        );

                return query.ToArray();
            }
        }

        public PetDetail GetPetById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Pets
                    .Single(e => e.PetId == id && e.OwnerId == _userId);
                return
                    new PetDetail
                    {
                        PetName = entity.PetName,
                        PetCount = entity.PetCount,
                        Gender = (PetDetail.AnimalGender)entity.Gender,
                        PetHistory = entity.PetHistory,
                        AnimalBreed = entity.AnimalBreed,
                        EstimatedCost = entity.EstimatedCost,
                        Type = (PetDetail.AnimalType)entity.Type,
                        Vaccination = (PetDetail.VaccinationRecords)entity.Vaccination,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }
        public bool UpdatePet(PetEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Pets
                        .Single(e => e.PetId == model.PetId && e.OwnerId == _userId);

                entity.PetName = model.PetName;
                entity.PetCount = model.PetCount;
                entity.Gender = (Pet.AnimalGender)model.Gender;
                entity.PetHistory = model.PetHistory;
                entity.AnimalBreed = model.AnimalBreed;
                entity.EstimatedCost = model.EstimatedCost;
                entity.Type = (Pet.AnimalType)model.Type;
                entity.Vaccination = (Pet.VaccinationRecords)model.Vaccination;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeletePet(int petId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Pets
                        .Single(e => e.PetId == petId && e.OwnerId == _userId);

                ctx.Pets.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}