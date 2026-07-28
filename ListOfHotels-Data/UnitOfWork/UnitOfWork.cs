using ListOfHotels_Core.Entities;
using ListOfHotels_Core.Interfaces;
using ListOfHotels_Data.Data;
using ListOfHotels_Data.Repository;

namespace ListOfHotels_Data.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private IGenericRepository<City> _cities;
    private IGenericRepository<Hotel> _hotels;
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public IGenericRepository<City> Cities =>
        _cities ??= new GenericRepository<City>(_context);

    public IGenericRepository<Hotel> Hotels =>
        _hotels ??= new GenericRepository<Hotel>(_context);

    public void Dispose()
    {
       _context.Dispose();
        GC.SuppressFinalize(this);  
    }

    public async Task SaveChangeAsync()
    {
       await _context.SaveChangesAsync();
    }
}
