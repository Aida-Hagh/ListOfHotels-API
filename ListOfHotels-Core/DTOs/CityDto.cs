using System.ComponentModel.DataAnnotations;

namespace ListOfHotels_Core.DTOs;

public class CityDto
{
    public int Id { get; set; }
    [Required]
    [Display(Name ="نام شهر")]
    [StringLength(maximumLength: 100, ErrorMessage = "تعداد کارکتر بیش از حد مجاز است")]
    public string Name { get; set; }

    [Required]
    [Display(Name = "نام اختصاری")]
    [StringLength(maximumLength: 3, ErrorMessage = "تعداد کارکتر بیش از حد مجاز است")]
    public string ShortName { get; set; }

    [Display(Name = "لیست هتلها")]
    public IList<HotelDto> Hotels { get; set; }
}
public class CreateCityDto
{
    [Display(Name = "نام")]
    [StringLength(maximumLength: 100, ErrorMessage = "تعداد کارکتر بیش از حد مجاز است")]
    public string Name { get; set; }

    [Required]
    [Display(Name = "نام اختصاری")]
    [StringLength(maximumLength: 3, ErrorMessage = "تعداد کارکتر بیش از حد مجاز است")]
    public string ShortName { get; set; }

}
public class UpdateCityDto: CreateCityDto
{
}
