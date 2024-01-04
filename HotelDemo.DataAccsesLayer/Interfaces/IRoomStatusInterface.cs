using HotelDemo.DataAccsesLayer.Entities;
using HotelDemo.DataAccsesLayer.Entities.Rooms;

namespace HotelDemo.DataAccsesLayer.Interfaces;

public interface IRoomStatusInterface: IRepository<RoomStatus>
{
    int Id { get; }
    string Name { get; }
    ICollection<Room> Rooms { get; }
}
