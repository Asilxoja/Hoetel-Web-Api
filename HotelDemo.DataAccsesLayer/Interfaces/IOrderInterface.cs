using HotelDemo.DataAccsesLayer.Entities.Guests;
using HotelDemo.DataAccsesLayer.Entities.Orders;

namespace HotelDemo.DataAccsesLayer.Interfaces;

public interface IOrderInterface : IRepository<Order>
{
    int Id { get; }
    int GuestId { get; set; }
    Guest Guest { get; set; }
    int AdminId { get; set; }
    Admin Admin { get; set; }
    int StatusId { get; set; }
    OrderStatus Status { get; set; }
    DateTime StartDate { get; set; }
    DateTime EndDate { get; set; }
}