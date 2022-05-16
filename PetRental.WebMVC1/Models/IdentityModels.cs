using System.Collections;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PetRental.WebMVC1.Models
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IEnumerable
    {
        public ApplicationDbContext()
            : base("PetMVC", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<PetRental.WebMVC1.Models.Pet> Pets { get; set; }
        public DbSet<PetRental.WebMVC1.Models.Customer> Customers { get; set; }
        public DbSet<PetRental.WebMVC1.Models.TemporaryAdopt> TemporaryAdopts { get; set; }
        public DbSet<PetRental.WebMVC1.Models.Content> Contents { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}