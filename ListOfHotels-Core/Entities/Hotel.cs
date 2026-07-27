using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace ListOfHotels_Core.Entities;

public class Hotel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Location Location { get; set; }
    public int Stars { get; set; }

    [ForeignKey(nameof(City))]
    public int CityId { get; set; }
    public City City { get; set; }
}
