using HotelDemo.DataAccsesLayer.Entities;
using HotelDemo.DTOAccsesLayer.DTOS.OrderDtos;

namespace HotelDemo.DTOAccsesLayer.DTOS.AdminDtos;

public class AdminDto : BaseEntitiy
{
    public string Address { get; set; } = string.Empty!;
    public List<OrderDto> Orders { get; set; } = new();
}
