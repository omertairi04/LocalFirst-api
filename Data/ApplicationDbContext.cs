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
    public DbSet<Company> Companies { get; set; }
    public DbSet<NormalUser> NormalUsers { get; set; }
    public DbSet<MainCategory> MainCategories { get; set; }
    public DbSet<SubCategory> SubCategories { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        // Configure the TPH inheritance for AppUser
        builder.Entity<AppUser>()
            .HasDiscriminator<string>("UserType")
            .HasValue<Company>("Company")
            .HasValue<NormalUser>("NormalUser");

        builder.Entity<Cities>()
            .HasKey(c => c.Id);

        builder.Entity<Company>()
            .HasOne(c => c.City)
            .WithMany(c => c.Companies)
            .HasForeignKey(c => c.CityId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.Entity<NormalUser>()
            .HasOne(u => u.City)
            .WithMany(c => c.NormalUsers)
            .HasForeignKey(u => u.CityId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.Entity<SubCategory>()
            .HasOne(p => p.MainCategory)
            .WithMany(c => c.SubCategories)
            .HasForeignKey(p => p.MainCategoryId)
            .OnDelete(DeleteBehavior.Cascade);

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
            new IdentityRole()
            {
                Name = "Company",
                NormalizedName = "COMPANY"
            }
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

        builder.Entity<Cities>().HasData(citiesList);
        
        /*
         * Creating Categories
         */
        var clothing = new MainCategory
        {
            Id = Guid.NewGuid(),
            Name = "Clothing",
            Description = "Apparel and accessories",
        };

        var houseHoldItems = new MainCategory
        {
            Id = Guid.NewGuid(),
            Name = "Household Items",
            Description = "Every day house hold items",
        };

        var electronics = new MainCategory
        {
            Id = Guid.NewGuid(),
            Name = "Electronics",
            Description = "Electronics",
        };
        var booksAndMedia = new MainCategory
        {
            Id = Guid.NewGuid(),
            Name = "Books and Media",
            Description = "Donate your books or medias.",
        };
        var ToysAndGames = new MainCategory
        {
            Id = Guid.NewGuid(),
            Name = "Toys and Games",
            Description = "Donate your Toys and Games.",
        };
        var SportOrFitnessEquipment = new MainCategory
        {
            Id = Guid.NewGuid(),
            Name = "Sports of Fitness Equipment",
            Description = "Donate your sport or fitness equipment.",
        };
        var FoodAndGroceries = new MainCategory
        {
            Id = Guid.NewGuid(),
            Name = "Food and Groceries",
            Description = "Donate your food and groceries.",
        };
        builder.Entity<MainCategory>().HasData(
            clothing,
            houseHoldItems,
            electronics,
            booksAndMedia,
            ToysAndGames,
            SportOrFitnessEquipment,
            FoodAndGroceries
        );
        
        // Subcategories
        var mensClothing = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Men's Clothing",
            Description = "Apparel for men",
            MainCategoryId = clothing.Id
        };

        var womensClothing = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Women's Clothing",
            Description = "Apparel for women",
            MainCategoryId = clothing.Id
        };

        var childrensClothing = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Children's Clothing",
            Description = "Apparel for children",
            MainCategoryId = clothing.Id
        };

        var shoesFootwear = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Shoes & Footwear",
            Description = "Footwear for all",
            MainCategoryId = clothing.Id
        };

        var accessories = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Accessories",
            Description = "Hats, scarves, belts, etc.",
            MainCategoryId = clothing.Id
        };

        var furniture = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Furniture",
            Description = "Household furniture",
            MainCategoryId = houseHoldItems.Id
        };

        var kitchenware = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Kitchenware",
            Description = "Utensils and appliances for the kitchen",
            MainCategoryId = houseHoldItems.Id
        };

        var beddingLinens = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Bedding & Linens",
            Description = "Bedding essentials",
            MainCategoryId = houseHoldItems.Id
        };

        var cleaningSupplies = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Cleaning Supplies",
            Description = "Cleaning essentials",
            MainCategoryId = houseHoldItems.Id
        };

        var homeDecor = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Home Décor",
            Description = "Decorative items for the home",
            MainCategoryId = houseHoldItems.Id
        };

        var computersLaptops = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Computers & Laptops",
            Description = "Computers and laptops",
            MainCategoryId = electronics.Id
        };

        var mobilePhonesTablets = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Mobile Phones & Tablets",
            Description = "Smartphones and tablets",
            MainCategoryId = electronics.Id
        };

        var homeAppliances = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Home Appliances",
            Description = "Appliances for home use",
            MainCategoryId = electronics.Id
        };

        var tvsAudioSystems = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "TVs & Audio Systems",
            Description = "Televisions and audio equipment",
            MainCategoryId = electronics.Id
        };

        var books = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Books",
            Description = "Fiction, non-fiction, educational",
            MainCategoryId = booksAndMedia.Id
        };

        var magazines = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Magazines",
            Description = "Various magazines",
            MainCategoryId = booksAndMedia.Id
        };

        var cdsDvdsBlurays = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "CDs, DVDs, Blu-rays",
            Description = "Media collection",
            MainCategoryId = booksAndMedia.Id
        };

        var boardGamesPuzzles = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Board Games & Puzzles",
            Description = "Games for fun and challenges",
            MainCategoryId = ToysAndGames.Id
        };

        var babyToddlerToys = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Baby & Toddler Toys",
            Description = "Toys for young children",
            MainCategoryId = ToysAndGames.Id
        };

        var educationalToys = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Educational Toys",
            Description = "Toys that promote learning",
            MainCategoryId = ToysAndGames.Id
        };

        var videoGamesConsoles = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Video Games & Consoles",
            Description = "Gaming systems and games",
            MainCategoryId = ToysAndGames.Id
        };

        var gymEquipment = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Gym Equipment",
            Description = "Equipment for gym workouts",
            MainCategoryId = SportOrFitnessEquipment.Id
        };

        var sportsGear = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Sports Gear",
            Description = "Gear for various sports",
            MainCategoryId = SportOrFitnessEquipment.Id
        };

        var bicyclesScooters = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Bicycles & Scooters",
            Description = "Bicycles and scooters for all ages",
            MainCategoryId = SportOrFitnessEquipment.Id
        };

        var campingOutdoorGear = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Camping & Outdoor Gear",
            Description = "Equipment for outdoor activities",
            MainCategoryId = SportOrFitnessEquipment.Id
        };
        var cannedGoods = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Canned Goods",
            Description = "Canned food items",
            MainCategoryId = FoodAndGroceries.Id
        };

        var nonPerishableItems = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Non-Perishable Items",
            Description = "Non-perishable food products",
            MainCategoryId = FoodAndGroceries.Id
        };

        var babyFoodFormula = new SubCategory
        {
            Id = Guid.NewGuid(),
            Name = "Baby Food & Formula",
            Description = "Food and formula for infants",
            MainCategoryId = FoodAndGroceries.Id
        };

        // Add to the model builder
        builder.Entity<SubCategory>().HasData(
            mensClothing,
            womensClothing,
            childrensClothing,
            shoesFootwear,
            accessories,
            furniture,
            kitchenware,
            beddingLinens,
            cleaningSupplies,
            homeDecor,
            computersLaptops,
            mobilePhonesTablets,
            homeAppliances,
            tvsAudioSystems,
            books,
            magazines,
            cdsDvdsBlurays,
            boardGamesPuzzles,
            babyToddlerToys,
            educationalToys,
            videoGamesConsoles,
            gymEquipment,
            sportsGear,
            bicyclesScooters,
            campingOutdoorGear,
            cannedGoods,
            nonPerishableItems,
            babyFoodFormula
        );
    }
}