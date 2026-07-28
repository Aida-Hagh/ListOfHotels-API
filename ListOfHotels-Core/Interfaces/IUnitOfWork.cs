using ListOfHotels_Core.Entities;

namespace ListOfHotels_Core.Interfaces;

public interface IUnitOfWork:IDisposable
{
    public IGenericRepository<City> Cities { get;  }
    public IGenericRepository<Hotel> Hotels { get;  }

    Task SaveChangeAsync();
}
