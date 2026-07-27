using ListOfHotels_Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListOfHotels_Data.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hotel>(entity =>
        {
            // لوکیشن یک ولیوآبجکت هست و بعنوان
            // Owned Type در همین جدول هتل ذخیره میشود 
            entity.OwnsOne(h => h.Location, loc =>
            {
                loc.Property(l => l.Address).HasColumnName("Address");
                loc.Property(l => l.City).HasColumnName("City");
                loc.Property(l => l.Country).HasColumnName("Country");
                loc.Property(l => l.Latitude).HasColumnName("Latitude");
                loc.Property(l => l.Longitude).HasColumnName("Longitude");

                // ✅ Seed کردن Location با Anonymous Type
                //در اینجا خود EF Core  براش HotelId ساخته
                loc.HasData(
                    new { HotelId = 1, Address = "خیابان اهراب", City = "تبریز", Country = "ایران", Latitude = (double?)null, Longitude = (double?)null },
                    new { HotelId = 2, Address = "خیابان شهریار", City = "تبریز", Country = "ایران", Latitude = (double?)null, Longitude = (double?)null },
                    new { HotelId = 3, Address = "خیابان شاه گلی", City = "تبریز", Country = "ایران", Latitude = (double?)null, Longitude = (double?)null },
                    new { HotelId = 4, Address = "خیابان نگین کیش", City = "کیش", Country = "ایران", Latitude = (double?)null, Longitude = (double?)null },
                    new { HotelId = 5, Address = "خیابان گلهای شیرازی", City = "شیراز", Country = "ایران", Latitude = (double?)null, Longitude = (double?)null },
                    new { HotelId = 6, Address = "خیابان یاسمن", City = "مشهد", Country = "ایران", Latitude = (double?)null, Longitude = (double?)null },
                    new { HotelId = 7, Address = "خیابان آزادی", City = "کیش", Country = "ایران", Latitude = (double?)null, Longitude = (double?)null },
                    new { HotelId = 8, Address = "خیابان گیلکان", City = "گیلان", Country = "ایران", Latitude = (double?)null, Longitude = (double?)null },
                    new { HotelId = 9, Address = "خیابان پل دختر", City = "اصفهان", Country = "ایران", Latitude = (double?)null, Longitude = (double?)null },
                    new { HotelId = 10, Address = "خیابان حافظ شیرازی", City = "شیراز", Country = "ایران", Latitude = (double?)null, Longitude = (double?)null },
                    new { HotelId = 11, Address = "خیابان هگمتانه", City = "همدان", Country = "ایران", Latitude = (double?)null, Longitude = (double?)null },
                    new { HotelId = 12, Address = "خیابان چهل ستون", City = "اصفهان", Country = "ایران", Latitude = (double?)null, Longitude = (double?)null }
                );
            });
        });

        modelBuilder.Entity<City>().HasData(
            new City { Id = 1, Name = "Tabriz", ShortName = "TBZ" },
            new City { Id = 2, Name = "Shiraz", ShortName = "SHZ" },
            new City { Id = 3, Name = "Esfahan", ShortName = "EFN" },
            new City { Id = 4, Name = "Kish", ShortName = "KSH" },
            new City { Id = 5, Name = "Hamedan", ShortName = "HMN" },
            new City { Id = 6, Name = "Mashhad", ShortName = "MSH" },
            new City { Id = 7, Name = "Gilan", ShortName = "GLN" }
            );

        modelBuilder.Entity<Hotel>().HasData(
            new Hotel
            {
                Id = 1,
                Name = "هتل اهراب",
                Stars = 3,
                CityId = 1,
                
            },
            new Hotel
            {
                Id = 2,
                Name = "Shahriyar",
                Stars = 5,
                CityId = 1
            },
            new Hotel

            {
                Id = 3,
                Name = "Pars",
                Stars = 4,
                CityId = 1
            },
            new Hotel

            {
                Id = 4,
                Name = "Negin",
                Stars = 3,
                CityId = 4
            },
            new Hotel
            {
                Id = 5,
                Name = "Golha",
                Stars = 4,
                CityId = 2
            },
            new Hotel

            {
                Id = 6,
                Name = "Yas",
                Stars = 3,
                CityId = 6
            },
            new Hotel
            {
                Id = 7,
                Name = "Azadi",
                Stars = 4,
                CityId = 4
            },
            new Hotel
            {
                Id = 8,
                Name = "Gisu",
                Stars = 4,
                CityId = 7
            },
            new Hotel
            {
                Id = 9,
                Name = "PolDokhtar",
                Stars = 5,
                CityId = 3
            },
            new Hotel
            {
                Id = 10,
                Name = "Hafez",
                Stars = 5,
                CityId = 2
            },
            new Hotel
            {
                Id = 11,
                Name = "Hegmatane",
                Stars = 5,
                CityId = 5
            },
             new Hotel

             {
                 Id = 12,
                 Name = "ChehelSotun",
                 Stars = 5,
                 CityId = 3
             }
            );

        base.OnModelCreating(modelBuilder);
    }
    public DbSet<City> Cities { get; set; }
    public DbSet<Hotel> Hotels { get; set; }

}
