using PetRental.WebMVC1.Models;
using System.Drawing;
using System.IO;

namespace PetRental.WebMVC1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Drawing;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PetRental.WebMVC1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(PetRental.WebMVC1.Models.ApplicationDbContext context)
        {
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

            // ``````````Seed Data For Images`````````` //
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 1,
                Title = "Apollo",
                Description = "We Had So Much Fun Getting To Know Apollo!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Apollo.jpg")
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 2,
                Title = "Cierra",
                Description = "It Was Awesome Hanging With Cierra!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Cierra.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 3,
                Title = "Curtis",
                Description = "Curtis Is One Of The Coolest Dogs Ever!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Curtis.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 4,
                Title = "Daphne",
                Description = "Daphne Loves To Play!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Daphne.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 5,
                Title = "Finn",
                Description = "I Love Finn, He Is So Energetic!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Finn.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 6,
                Title = "Floyd",
                Description = "We Had A Ball Hanging With Floyd!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Floyd.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 7,
                Title = "Henry",
                Description = "Henry Always Keeps Me Company!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Henry.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 8,
                Title = "Kaida",
                Description = "Kaida Loved Playing Ball!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Kaida.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 9,
                Title = "Kailey",
                Description = "Kailey Is A Beautiful Girl!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Kailey.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 10,
                Title = "Max",
                Description = "Max Always Holds A Place In Our Hearts!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Max.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 11,
                Title = "Minnow",
                Description = "Minnow Has To Be The Coolest Pet!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Minnow.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 12,
                Title = "Peanut",
                Description = "Peanut Helped Me Get Through Some Tough Times!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Peanut.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 13,
                Title = "Pepsi",
                Description = "Pepsi Knows How To Do A Lot Of Tricks!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Pepsi.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 14,
                Title = "Rose",
                Description = "Rose, We Can't Say Enough About Her!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Rose.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 15,
                Title = "Zaffle",
                Description = "Zaffle Makes Me So Happy!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Zaffle.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 16,
                Title = "Andie",
                Description = "Andie Was So Comfortable To Be Around!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Andie.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 17,
                Title = "Asher",
                Description = "Asher Has A Lot Of Energy!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Asher.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 18,
                Title = "Bert",
                Description = "Bert Loves To Take Naps With Me!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Bert.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 19,
                Title = "Booker",
                Description = "Booker Is Such A Cool Cat!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Booker.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 20,
                Title = "Cadell",
                Description = "Cadell Is So Much Fun!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Cadell.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 21,
                Title = "Claire",
                Description = "Claire Loves To Play!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Claire.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 22,
                Title = "Dollface",
                Description = "Dollface Is Beautiful!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Dollface.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 23,
                Title = "Frank",
                Description = "Frank Is So Funny!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Frank.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 24,
                Title = "Itchy",
                Description = "Itchy Loves Being Vocal!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Itchy.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 25,
                Title = "Kid",
                Description = "Kid Is So Cool!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Kid.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 26,
                Title = "Aggie",
                Description = "Aggie Loves Hopping Around!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Aggie.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 27,
                Title = "Dixie",
                Description = "Dixie Is Super Smart!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Dixie.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 28,
                Title = "Itzy",
                Description = "Itzy Loves To Sleep!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Itzy.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 29,
                Title = "Jasper",
                Description = "Jasper Eats Like A King!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Jasper.jpg"),
            });
            context.Contents.AddOrUpdate(p => p.ID, new Content()
            {
                ID = 30,
                Title = "Pixie",
                Description = "Pixie Is So Fluffy!",
                Image = ReadFile("C:/Users/clayb/OneDrive/Documents/Work/Coding/ElevenFiftyProjects/135SD/Random/PetRental.WebMVC/PetRental.WebMVC1/Content/Images/Pixie.jpg"),
            });
        }
        public byte[] ReadFile(string sPath)
        {
            byte[] data = null;

            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fStream);

            data = br.ReadBytes((int)numBytes);

            return data;
        }
    }
}