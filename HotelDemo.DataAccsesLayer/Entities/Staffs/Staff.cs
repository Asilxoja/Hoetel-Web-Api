using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelDemo.DataAccsesLayer.Entities.Staffs;

public class Staff : BaseEntitiy
{

    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Username length must be between 3 and 50")]
    public string Username { get; set; } = string.Empty;

    [Required]
    [StringLength(60, MinimumLength = 10, ErrorMessage = "Email length must be between 10 and 60")]
    public string Email { get; set; } = string.Empty;

    public int PositionId { get; set; }

    [ForeignKey("PositionId")]
    public Position Position { get; set; } = new();

    [StringLength(15)]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required,StringLength(5)]
    public string Gender { get; set; } = string.Empty;
    [Required]
    public DateTime BirthDate { get; set; }
    [Required]
    [StringLength(100)]
    public string Address { get; set; } = string.Empty;

    [StringLength(1500, MinimumLength = 3,
        ErrorMessage = "Description length must be between 3 and 1500")]
    public string Description { get; set; } = string.Empty;
}
