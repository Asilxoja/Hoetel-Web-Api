using System.ComponentModel.DataAnnotations;

namespace HotelDemo.DataAccsesLayer.Entities;

public class IdEntity
{
    [Key, Required]
    public int Id { get; set; }
}
