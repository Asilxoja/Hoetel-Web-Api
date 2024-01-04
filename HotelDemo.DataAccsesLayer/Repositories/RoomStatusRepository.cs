using HotelDemo.DataAccsesLayer.Entities;
using HotelDemo.DataAccsesLayer.Entities.Rooms;
using HotelDemo.DataAccsesLayer.Interfaces;

namespace HotelDemo.DataAccsesLayer.Repositories;

public class RoomStatusRepository : Repository<RoomStatus>, IRoomStatus
{
    private readonly AppDbContext _dbContext;
    public RoomStatusRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
        Rooms = new List<Room>();
    }

    public string Name { get; set; }
    public ICollection<Room> Rooms { get; set; }
        = new List<Room>();

    
    public int Id => throw new NotImplementedException();
}