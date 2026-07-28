using AutoMapper;
using ListOfHotels_Core.DTOs;
using ListOfHotels_Core.Entities;

namespace ListOfHotels_Core.AutoMapper;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<City,CityDto>().ReverseMap();
        CreateMap<City,CreateCityDto>().ReverseMap();
        CreateMap<City,UpdateCityDto>().ReverseMap();
        CreateMap<Hotel,HotelDto>().ReverseMap();
        CreateMap<Hotel,CreateHotelDto>().ReverseMap();
        CreateMap<Hotel,UpdateHotelDto>().ReverseMap();

    }
}
