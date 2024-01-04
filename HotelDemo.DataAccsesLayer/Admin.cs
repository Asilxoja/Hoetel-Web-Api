using HotelDemo.DataAccsesLayer.Entities;
using HotelDemo.DataAccsesLayer.Entities.Orders;

namespace HotelDemo.DataAccsesLayer;

public class Admin : BaseEntitiy
{
    public string Address { get; set; } = string.Empty;

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
