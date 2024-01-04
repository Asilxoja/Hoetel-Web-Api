using HotelDemo.DataAccsesLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace HotelDemo.DTOAccsesLayer.DTOS.GuestDtos;

public class UpdateGuestDto : BaseEntitiy
{
    [StringLength(15)]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required]
    [StringLength(60, ErrorMessage = "Passport length must be less than 60")]
    public string Passport { get; set; } = string.Empty;

    public DateTime BirthDate { get; set; }
    public DateTime DateOfIssue { get; set; }

    [StringLength(100)]
    public string Address { get; set; } = string.Empty;

    [StringLength(50)]
    public string OrganizationName { get; set; } = string.Empty;

    [StringLength(50)]
    public string Givenbywhom { get; set; } = string.Empty;

    [StringLength(50)]
    public string Citizenship { get; set; } = string.Empty;

    [StringLength(50)]
    public string Description { get; set; } = string.Empty;

    [StringLength(50)]
    public string Organization { get; set; } = string.Empty;

    [StringLength(5)]
    public string Gender { get; set; } = string.Empty;
}
