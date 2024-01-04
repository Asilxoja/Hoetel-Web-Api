using HotelDemo.DataAccsesLayer.Entities.Rooms;

namespace HotelDemo.DataAccsesLayer.Interfaces;

public interface IRoomTypeInterface : IRepository<RoomType>
{
    int Id { get; set; }
    string Name { get; set; }
    int PersonCount { get; set; }
    ICollection<Room> Rooms { get; set; }
}
