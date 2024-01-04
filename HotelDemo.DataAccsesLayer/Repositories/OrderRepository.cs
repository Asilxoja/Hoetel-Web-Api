using HotelDemo.DataAccsesLayer.Entities.Guests;
using HotelDemo.DataAccsesLayer.Entities.Orders;
using HotelDemo.DataAccsesLayer.Interfaces;

namespace HotelDemo.DataAccsesLayer.Repositories;

public class OrderRepository(AppDbContext dbContext) 
    : Repository<Order>(dbContext), IOrderInterface
{
    private readonly AppDbContext _dbContext = dbContext;

    public int Id { get; set; }
    public int GuestId { get; set; }
    public Guest Guest { get; set; }
    public int AdminId { get; set; }
    public Admin Admin { get; set; }
    public int StatusId { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
