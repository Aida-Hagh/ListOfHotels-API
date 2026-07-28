using ListOfHotels_Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ListOfHotels_Core.DTOs;

public class HotelDto
{
    public int Id { get; set; }
    [Required]
    [Display(Name = "نام هتل")]
    [StringLength(maximumLength: 100,ErrorMessage ="تعداد کارکتر بیش از حد مجاز است")]
    public string Name { get; set; }

    [Required]
    [Display(Name = "آدرس")]
    [StringLength(maximumLength: 250, ErrorMessage = "تعداد کارکتر بیش از حد مجاز است")]
    public string Address { get; set; }

    [Required]
    [Display(Name = "نام کشور")]
    [StringLength(maximumLength: 100, ErrorMessage = "تعداد کارکتر بیش از حد مجاز است")]
    public string Country { get; set; } = "ایران";

    [Required]
    [Display(Name = "نام شهر")]
    [StringLength(maximumLength: 100, ErrorMessage = "تعداد کارکتر بیش از حد مجاز است")]
    public string CityName { get; set; }

    [Required]
    [Range(1,5)]
    [Display(Name = "چند ستاره است؟")]
    public int Stars { get; set; }

}

public class CreateHotelDto
{
    [Required]
    [Display(Name = "نام هتل")]
    [StringLength(maximumLength: 100, ErrorMessage = "تعداد کارکتر بیش از حد مجاز است")]
    public string Name { get; set; }

    [Required]
    [Display(Name = "آدرس")]
    [StringLength(maximumLength: 250, ErrorMessage = "تعداد کارکتر بیش از حد مجاز است")]
    public string Address { get; set; }

    [Required]
    [Display(Name = "نام کشور")]
    [StringLength(maximumLength: 100, ErrorMessage = "تعداد کارکتر بیش از حد مجاز است")]
    public string Country { get; set; } = "ایران";

    [Required]
    [Display(Name = "نام شهر")]
    [StringLength(maximumLength: 100, ErrorMessage = "تعداد کارکتر بیش از حد مجاز است")]
    public string CityName { get; set; }

    [Required]
    [Range(1, 5)]
    [Display(Name = "چند ستاره است؟")]
    public int Stars { get; set; }
    public int CityId { get; set; }

}

public class UpdateHotelDto:CreateHotelDto
{

}
