using ListOfHotels_Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListOfHotels_Data.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
        
    }
    public DbSet<City>Cities { get; set; }  
    public DbSet<Hotel>Hotels { get; set; }  

}
