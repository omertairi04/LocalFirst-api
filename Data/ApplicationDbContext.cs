using Local_Alternatives.Helpers;
using Local_Alternatives.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.IO;

namespace Local_Alternatives.Data;

public class ApplicationDbContext : IdentityDbContext<AppUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Cities> Cities { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        List<IdentityRole> roles = new List<IdentityRole>
        {
            new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Name = "User",
                NormalizedName = "USER"
            },
        };
        builder.Entity<IdentityRole>().HasData(roles);

        var jsonFilePath = "/home/omer/RiderProjects/Local-Alternatives/Local-Alternatives/mk.json";
        var jsonData = File.ReadAllText(jsonFilePath);

        // Deserialize the JSON data into a list of anonymous objects
        var citiesData = JsonConvert.DeserializeObject<List<CityJson>>(jsonData);

        var citiesList = new List<Cities>();

        if (citiesData != null)
        {
            foreach (var city in citiesData)
            {
                citiesList.Add(new Cities
                (
                    name: city.City,
                    primaryCity: city.AdminName,
                    country: city.Country
                ));
            }
        }


        // Seed the data into the database
        builder.Entity<Cities>().HasData(citiesList);
    }
}