using HotelDemo.DTOAccsesLayer.DTOS.AdminDtos;
using HotelDemo.DTOAccsesLayer.DTOS.GuestDtos;

namespace HotelDemo.DTOAccsesLayer.DTOS.OrderDtos;

public class OrderDto
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int GuestId { get; set; }
    public int AdminId { get; set; }
    public int StatusId { get; set; }

    public GuestDto Guest { get; set; } = new();
    public AdminDto Admin { get; set; } = new();
    public OrderStatusDto Status { get; set; } = new();
}
