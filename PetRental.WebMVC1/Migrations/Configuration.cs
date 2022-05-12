using PetRental.WebMVC1.Models;

namespace PetRental.WebMVC1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PetRental.WebMVC1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PetRental.WebMVC1.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            // ``````````Seed Data For Pets`````````` //
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 1,
                PetName = "Apollo",
                Type = Pet.AnimalType.Dog,
                AnimalBreed = "Bully Breed Mix",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Apollo Is Good With Cats, Great With Children, and He Is House Trained! He Is 3 Years / 10 Months Old.",
                PetCount = true,
                EstimatedCost = 29.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 2,
                PetName = "Cierra",
                Type = Pet.AnimalType.Dog,
                AnimalBreed = "Bully Breed Mix",
                Gender = Pet.AnimalGender.Female,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Cierra Is Not Good With Cats, Great With Children, and She Is House Trained! She Is 3 Years / 2 Months Old.",
                PetCount = true,
                EstimatedCost = 29.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 3,
                PetName = "Curtis",
                Type = Pet.AnimalType.Dog,
                AnimalBreed = "Coonhound",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Curtis Is Good With Cats, Great With Children, and He Is House Trained! However, When Curtis Gets Scared, He Has Accidents Inside The House. He Is 4 Years / 0 Months Old.",
                PetCount = true,
                EstimatedCost = 29.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 4,
                PetName = "Daphne",
                Type = Pet.AnimalType.Dog,
                AnimalBreed = "Hound",
                Gender = Pet.AnimalGender.Female,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Daphne Is Not Good With Cats, Great With Children, and She Is House Trained! She Is 9 Years / 11 Months Old.",
                PetCount = true,
                EstimatedCost = 29.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 5,
                PetName = "Finn",
                Type = Pet.AnimalType.Dog,
                AnimalBreed = "Bully Breed Mix",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Finn Is Not Good With Cats Or Other Dogs, Great With Children, and He Is House Trained! He Is 6 Years / 3 Months Old.",
                PetCount = true,
                EstimatedCost = 29.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 6,
                PetName = "Floyd",
                Type = Pet.AnimalType.Dog,
                AnimalBreed = "Bully Breed Mix/Labrador Retriever",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Floyd Is Good With Cats, Great With Children, and He Is House Trained!  He Has A Ton Of Energy. He Is 1 Year / 5 Months Old.",
                PetCount = true,
                EstimatedCost = 29.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 7,
                PetName = "Henry",
                Type = Pet.AnimalType.Dog,
                AnimalBreed = "Husky/Labrador Retriever",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Henry Is Good With Cats, Great With Children, and He Is House Trained! He Is A Flight Risk, So Keep Him On A Leash! He Is 4 Years/ 3 Months Old.",
                PetCount = true,
                EstimatedCost = 29.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 8,
                PetName = "Kaida",
                Type = Pet.AnimalType.Dog,
                AnimalBreed = "Doberman Pinscher/Labrador Retriever",
                Gender = Pet.AnimalGender.Female,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Kaida Is Good With Cats, Great With Children, and She Is House Trained! She Is 3 Years / 10 Months Old.",
                PetCount = true,
                EstimatedCost = 29.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 9,
                PetName = "Kailey",
                Type = Pet.AnimalType.Dog,
                AnimalBreed = "Shepard Mix",
                Gender = Pet.AnimalGender.Female,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Kailey Is Not Good With Cats Or Other Dogs, Great With Children, and She Is House Trained! He Is 6 Years / 0 Months Old.",
                PetCount = true,
                EstimatedCost = 29.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 10,
                PetName = "Max",
                Type = Pet.AnimalType.Dog,
                AnimalBreed = "German Shepard",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Max Is Not Good With Cats, Great With Children, and He Is House Trained! He Is 2 Years / 3 Months Old.",
                PetCount = true,
                EstimatedCost = 29.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 11,
                PetName = "Minnow",
                Type = Pet.AnimalType.Dog,
                AnimalBreed = "Bully Breed Mix",
                Gender = Pet.AnimalGender.Female,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Minnow Is Good With Cats, Great With Children, and She Is House Trained! She Is 2 Years / 2 Months Old.",
                PetCount = true,
                EstimatedCost = 29.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 12,
                PetName = "Peanut",
                Type = Pet.AnimalType.Dog,
                AnimalBreed = "Husky/Collie Mix",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Peanut Is Not Good With Cats, Great With Children, and He Is House Trained! He Is 1 Year / 8 Months Old.",
                PetCount = true,
                EstimatedCost = 29.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 13,
                PetName = "Pepsi",
                Type = Pet.AnimalType.Dog,
                AnimalBreed = "Labrador Retriever/Shepard Mix",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Pepsi Is Good With Cats, Great With Children, But He Is Not Yet House Trained! He Is 0 Years / 8 Months Old.",
                PetCount = true,
                EstimatedCost = 29.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 14,
                PetName = "Rose",
                Type = Pet.AnimalType.Dog,
                AnimalBreed = "Bully Breed Mix",
                Gender = Pet.AnimalGender.Female,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Rose Is Not Good With Cats, Great With Children, and She Is House Trained! She Is 1 Year / 3 Months Old.",
                PetCount = true,
                EstimatedCost = 29.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 15,
                PetName = "Zaffle",
                Type = Pet.AnimalType.Dog,
                AnimalBreed = "Pointer Mix",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Zaffle Is Not Good With Cats, Great With Children, and He Is House Trained! He Is 1 Year / 0 Months Old.",
                PetCount = true,
                EstimatedCost = 29.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 16,
                PetName = "Andie",
                Type = Pet.AnimalType.Cat,
                AnimalBreed = "Domestic Short Hair",
                Gender = Pet.AnimalGender.Female,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Andie Is Not Good With Dogs, Not Great With Children, and She Is House Trained! She Is 3 Years / 1 Month Old.",
                PetCount = true,
                EstimatedCost = 19.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 17,
                PetName = "Asher",
                Type = Pet.AnimalType.Cat,
                AnimalBreed = "Domestic Short Hair",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Asher Is Good With Dogs, Great With Children, and He Is House Trained! He Is 2 Years / 4 Months Old.",
                PetCount = true,
                EstimatedCost = 19.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 18,
                PetName = "Bert",
                Type = Pet.AnimalType.Cat,
                AnimalBreed = "Maine Coon/Domestic Long Hair",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Bert Is Not Good With Dogs, Not Great With Children, and He Is House Trained! He Is 12 Years / 0 Months Old.",
                PetCount = true,
                EstimatedCost = 19.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 19,
                PetName = "Booker",
                Type = Pet.AnimalType.Cat,
                AnimalBreed = "Himalayan/Munchkin",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Booker Is Good With Dogs, Great With Children, and He Is House Trained! He Is 6 Years / 3 Months Old.",
                PetCount = true,
                EstimatedCost = 19.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 20,
                PetName = "Cadell",
                Type = Pet.AnimalType.Cat,
                AnimalBreed = "Domestic Long Hair",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Cadell Is Good With Dogs, Great With Children, and He Is House Trained! He Is 3 Years / 1 Month Old.",
                PetCount = true,
                EstimatedCost = 19.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 21,
                PetName = "Claire",
                Type = Pet.AnimalType.Cat,
                AnimalBreed = "Domestic Short Hair",
                Gender = Pet.AnimalGender.Female,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Claire Is Not Good With Dogs, Great With Children, and She Is House Trained! She Is 0 Years / 9 Months Old.",
                PetCount = true,
                EstimatedCost = 19.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 22,
                PetName = "Dollface",
                Type = Pet.AnimalType.Cat,
                AnimalBreed = "Domestic Short Hair",
                Gender = Pet.AnimalGender.Female,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Dollface Is Good With Dogs, Great With Children, and She Is House Trained! She Is 2 Years / 1 Month Old.",
                PetCount = true,
                EstimatedCost = 19.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 23,
                PetName = "Frank",
                Type = Pet.AnimalType.Cat,
                AnimalBreed = "Domestic Short Hair",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Frank Is Not Good With Dogs, Not Great With Children, and He Is House Trained! He Is 0 Years / 9 Months Old.",
                PetCount = true,
                EstimatedCost = 19.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 24,
                PetName = "Itchy",
                Type = Pet.AnimalType.Cat,
                AnimalBreed = "Domestic Short Hair",
                Gender = Pet.AnimalGender.Female,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Itchy Is Not Good With Dogs, Great With Children, and She Is House Trained! She Is 11 Years / 4 Months Old.",
                PetCount = true,
                EstimatedCost = 19.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 25,
                PetName = "Kid",
                Type = Pet.AnimalType.Cat,
                AnimalBreed = "Abyssinian",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Kid Is Good With Dogs, Great With Children, and He Is House Trained! He Is 3 Years / 1 Month Old.",
                PetCount = true,
                EstimatedCost = 19.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 26,
                PetName = "Aggie",
                Type = Pet.AnimalType.Rabbit,
                AnimalBreed = "American",
                Gender = Pet.AnimalGender.Female,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Aggie Is A Beautiful House Rabbit, Great With Children, and She Is Cage Trained! She Is 1 Year / 3 Months Old.",
                PetCount = true,
                EstimatedCost = 9.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 27,
                PetName = "Dixie",
                Type = Pet.AnimalType.Rabbit,
                AnimalBreed = "American",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Dixie Is A Beautiful House Rabbit, Great With Children, and He Is Cage Trained! He Is 2 Years / 0 Months Old.",
                PetCount = true,
                EstimatedCost = 9.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 28,
                PetName = "Itzy",
                Type = Pet.AnimalType.Rabbit,
                AnimalBreed = "Dwarf",
                Gender = Pet.AnimalGender.Female,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Itzy Is A Beautiful House Rabbit, Great With Children, and She Is Cage Trained! She Is 1 Year / 1 Month Old.",
                PetCount = true,
                EstimatedCost = 9.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 29,
                PetName = "Jasper",
                Type = Pet.AnimalType.Rabbit,
                AnimalBreed = "American",
                Gender = Pet.AnimalGender.Male,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Jasper Is A Beautiful House Rabbit, Great With Children, and He Is Cage Trained! He Is 1 Year / 1 Month Old.",
                PetCount = true,
                EstimatedCost = 9.99m
            });
            context.Pets.AddOrUpdate(p => p.PetId, new Pet()
            {
                PetId = 30,
                PetName = "Pixie",
                Type = Pet.AnimalType.Rabbit,
                AnimalBreed = "American",
                Gender = Pet.AnimalGender.Female,
                Vaccination = Pet.VaccinationRecords.Yes,
                PetHistory = "Pixie Is A Beautiful House Rabbit, Great With Children, and She Is Cage Trained! She Is 2 Years / 0 Months Old.",
                PetCount = true,
                EstimatedCost = 9.99m
            });

            // ``````````Seed Data For Customers`````````` //
            context.Customers.AddOrUpdate(c => c.CustomerId, new Customer()
            {
                CustomerId = 1,
                FirstName = "Clay",
                LastName = "Burnette",
                PhoneNumber = "812-616-4432",
                Address = "1261 S Adams St. Bloomington, IN 47403"
            });
            context.Customers.AddOrUpdate(c => c.CustomerId, new Customer()
            {
                CustomerId = 2,
                FirstName = "Jacob",
                LastName = "Brown",
                PhoneNumber = "812-232-6616",
                Address = "1204 W Bentley St. Bloomington, IN 47403"
            });
            context.Customers.AddOrUpdate(c => c.CustomerId, new Customer()
            {
                CustomerId = 3,
                FirstName = "Corey",
                LastName = "Pfleiger",
                PhoneNumber = "812-345-0091",
                Address = "3145 S James St. Carmel, IN 46032"
            });
            context.Customers.AddOrUpdate(c => c.CustomerId, new Customer()
            {
                CustomerId = 4,
                FirstName = "Hayden",
                LastName = "Linville",
                PhoneNumber = "812-313-0132",
                Address = "2234 E Neat St. Carmel, IN 46032"
            });
            context.Customers.AddOrUpdate(c => c.CustomerId, new Customer()
            {
                CustomerId = 5,
                FirstName = "William",
                LastName = "Lego",
                PhoneNumber = "812-987-1234",
                Address = "8765 N Jones St. Speedway, IN 46222"
            });
            context.Customers.AddOrUpdate(c => c.CustomerId, new Customer()
            {
                CustomerId = 6,
                FirstName = "Christopher",
                LastName = "Pettigrew",
                PhoneNumber = "812-645-7776",
                Address = "1555 E Bounce St. Speedway, IN 46222"
            });
            context.Customers.AddOrUpdate(c => c.CustomerId, new Customer()
            {
                CustomerId = 7,
                FirstName = "Cyrus",
                LastName = "Spencer",
                PhoneNumber = "812-332-7890",
                Address = "4587 W Bruiser St. Indianapolis, IN 46077"
            });
            context.Customers.AddOrUpdate(c => c.CustomerId, new Customer()
            {
                CustomerId = 8,
                FirstName = "Ethan",
                LastName = "Starling",
                PhoneNumber = "812-999-8765",
                Address = "9090 S Elden St. Indianpolis, IN 46077"
            });
            context.Customers.AddOrUpdate(c => c.CustomerId, new Customer()
            {
                CustomerId = 9,
                FirstName = "Stephen",
                LastName = "Reilly",
                PhoneNumber = "812-616-4432",
                Address = "5665 N Jumper St. Greenwood, IN 46142"
            });
            context.Customers.AddOrUpdate(c => c.CustomerId, new Customer()
            {
                CustomerId = 10,
                FirstName = "Avery",
                LastName = "Finchum",
                PhoneNumber = "812-444-3567",
                Address = "8810 E Midnight St. Greenwood, IN 46142"
            });

            // ``````````Seed Data For Transactions`````````` //
            context.TemporaryAdopts.AddOrUpdate(t => t.TransactionId, new TemporaryAdopt()
            {
                TransactionId = 1,
                CustomerId = 1,
                PetId = 1,
                RentalDuration = 2,
                RentalCost = 59.98m,
                PetAvailability = false,
                TransType = (TemporaryAdopt.TransactionType)1,
                TimeOfRental = DateTime.Now
            });
            context.TemporaryAdopts.AddOrUpdate(t => t.TransactionId, new TemporaryAdopt()
            {
                TransactionId = 2,
                CustomerId = 1,
                PetId = 1,
                RentalDuration = 3,
                RentalCost = 89.97m,
                PetAvailability = true,
                TransType = (TemporaryAdopt.TransactionType)2,
                TimeOfRental = DateTime.Now
            });
            context.TemporaryAdopts.AddOrUpdate(t => t.TransactionId, new TemporaryAdopt()
            {
                TransactionId = 3,
                CustomerId = 2,
                PetId = 2,
                RentalDuration = 1,
                RentalCost = 29.99m,
                PetAvailability = false,
                TransType = (TemporaryAdopt.TransactionType)1,
                TimeOfRental = DateTime.Now
            });
            context.TemporaryAdopts.AddOrUpdate(t => t.TransactionId, new TemporaryAdopt()
            {
                TransactionId = 4,
                CustomerId = 2,
                PetId = 2,
                RentalDuration = 1,
                RentalCost = 29.99m,
                PetAvailability = true,
                TransType = (TemporaryAdopt.TransactionType)2,
                TimeOfRental = DateTime.Now
            });
            context.TemporaryAdopts.AddOrUpdate(t => t.TransactionId, new TemporaryAdopt()
            {
                TransactionId = 5,
                CustomerId = 3,
                PetId = 16,
                RentalDuration = 1,
                RentalCost = 19.99m,
                PetAvailability = false,
                TransType = (TemporaryAdopt.TransactionType)1,
                TimeOfRental = DateTime.Now
            });
            context.TemporaryAdopts.AddOrUpdate(t => t.TransactionId, new TemporaryAdopt()
            {
                TransactionId = 6,
                CustomerId = 3,
                PetId = 16,
                RentalDuration = 2,
                RentalCost = 29.98m,
                PetAvailability = true,
                TransType = (TemporaryAdopt.TransactionType)2,
                TimeOfRental = DateTime.Now
            });
            context.TemporaryAdopts.AddOrUpdate(t => t.TransactionId, new TemporaryAdopt()
            {
                TransactionId = 7,
                CustomerId = 4,
                PetId = 20,
                RentalDuration = 3,
                RentalCost = 59.97m,
                PetAvailability = false,
                TransType = (TemporaryAdopt.TransactionType)1,
                TimeOfRental = DateTime.Now
            });
            context.TemporaryAdopts.AddOrUpdate(t => t.TransactionId, new TemporaryAdopt()
            {
                TransactionId = 8,
                CustomerId = 4,
                PetId = 20,
                RentalDuration = 6,
                RentalCost = 119.94m,
                PetAvailability = true,
                TransType = (TemporaryAdopt.TransactionType)2,
                TimeOfRental = DateTime.Now
            });
            context.TemporaryAdopts.AddOrUpdate(t => t.TransactionId, new TemporaryAdopt()
            {
                TransactionId = 9,
                CustomerId = 5,
                PetId = 30,
                RentalDuration = 3,
                RentalCost = 29.97m,
                PetAvailability = false,
                TransType = (TemporaryAdopt.TransactionType)1,
                TimeOfRental = DateTime.Now
            });
            context.TemporaryAdopts.AddOrUpdate(t => t.TransactionId, new TemporaryAdopt()
            {
                TransactionId = 10,
                CustomerId = 5,
                PetId = 30,
                RentalDuration = 4,
                RentalCost = 39.96m,
                PetAvailability = true,
                TransType = (TemporaryAdopt.TransactionType)2,
                TimeOfRental = DateTime.Now
            });
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}