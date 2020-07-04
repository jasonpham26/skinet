using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Bobby",
                    Email = "bob0206@gmail.com",
                    UserName = "bob0206@gmail.com",
                    Address = new Address
                    {
                    FirstName = "Bob",
                    LastName = "Bobbity",
                    Street = "10 Ann Street",
                    City = "Brisbane",
                    State = "QLD",
                    Zipcode = "4300"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}