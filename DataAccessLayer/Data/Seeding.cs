using Microsoft.AspNetCore.Identity;
using School.Models;
using DataAccessLayer.Models;
using DataAccessLayer.Data;
public static class ApplicationDbInitializer
{
    public static async Task SeedAsync(UserManager<ApplicationUser> userManager,string adminPassword="", string AdminEmail="")
    {
        Console.WriteLine("Seeding started");
        Console.WriteLine(adminPassword);
        Console.WriteLine(AdminEmail);
        var adminUser = await userManager.FindByEmailAsync(AdminEmail);
        if (adminUser == null)
        {
            adminUser = new ApplicationUser
            {
                UserName = AdminEmail,
                Email = AdminEmail
            };
            var result = await userManager.CreateAsync(adminUser, adminPassword);
        }
    }
}
