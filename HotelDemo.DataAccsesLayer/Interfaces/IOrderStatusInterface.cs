using HotelDemo.DataAccsesLayer.Entities.Orders;

namespace HotelDemo.DataAccsesLayer.Interfaces;

public interface IOrderStatusInterface : IRepository<OrderStatus>
{
    int Id { get; }
    string Name { get; set; }
}