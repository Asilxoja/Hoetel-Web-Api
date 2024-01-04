using HotelDemo.DataAccsesLayer.Entities.Rooms;
using HotelDemo.DataAccsesLayer.Interfaces;

namespace HotelDemo.DataAccsesLayer.Repositories;

public class RoomRepository(AppDbContext dbContext) : Repository<Room>(dbContext), IRoomInterface
{
    private readonly AppDbContext _dbContext = dbContext;

    public int Id { get; set; }
    public int Number { get; set; }
    public int Price { get; set; }
    public int RoomTypeId { get; set; }
    public RoomType RoomType { get; set; } = new();
    public int RoomStatusId { get; set; }
    public RoomStatus RoomStatus { get; set; } = new();
}
    