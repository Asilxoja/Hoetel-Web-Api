using HotelDemo.DataAccsesLayer.Entities.Guests;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelDemo.DataAccsesLayer.Entities.Orders;

public class Order : IdEntity
{
    public int GuestId { get; set; }
    [ForeignKey("GuestId")]
    public Guest Guest { get; set; } = new();

    public int AdminId { get; set; }
    [ForeignKey("AdminId")]
    public Admin Admin { get; set; } = new();

    public int StatusId { get; set; }
    [ForeignKey("StatusId")]
    public OrderStatus Status { get; set; } = new();

    public int StartDate { get; set; }
    public int EndDate { get; set; }
}
