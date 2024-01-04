using HotelDemo.DataAccsesLayer.Entities.Orders;
using HotelDemo.DataAccsesLayer.Interfaces;

namespace HotelDemo.DataAccsesLayer.Repositories;

public class OrderStatusRepository : Repository<OrderStatus>,IOrderStatusInterface
{
    private readonly AppDbContext _dbContext;

    public OrderStatusRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public int Id { get; set; }
    public string Name { get; set; }
}