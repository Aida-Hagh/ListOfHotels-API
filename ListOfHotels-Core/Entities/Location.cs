namespace ListOfHotels_Core.Entities;

public class Location
{
    public string Address { get; set; }
    public string City { get; set; }
    public string Country { get; set; } = "ایران";
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
}
