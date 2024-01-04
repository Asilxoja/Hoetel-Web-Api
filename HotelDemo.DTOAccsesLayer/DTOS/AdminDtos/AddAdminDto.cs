
using HotelDemo.DTOAccsesLayer.DTOS.OrderDtos;
using System.ComponentModel.DataAnnotations;

namespace HotelDemo.DTOAccsesLayer.DTOS.AdminDtos;

public class AddAdminDto
{
    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "FirstName length must be between 3 and 50")]
    public string FirstName { get; set; } = string.Empty!;

    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "LastName length must be between 3 and 50")]
    public string LastName { get; set; } = string.Empty!;

    [StringLength(50, MinimumLength = 3, ErrorMessage = "FatherName length must be between 3 and 50")]
    public string FatherName { get; set; } = string.Empty!;
    [Required]
    public DateTime AddedTime { get; set; }
    [Required]
    public DateTime EditedTime { get; set; }

    [Required, StringLength(100)]
    public string Address { get; set; } = string.Empty!;
    public List<OrderDto> Orders { get; set; } = new();
}
