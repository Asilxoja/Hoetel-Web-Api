using HotelDemo.DataAccsesLayer.Entities;

namespace HotelDemo.DTOAccsesLayer.DTOS.OrderDtos;

public class OrderStatusDto : IdEntity
{
    public string Name { get; set; } = string.Empty;
}
