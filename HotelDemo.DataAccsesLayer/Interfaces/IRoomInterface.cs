using HotelDemo.DataAccsesLayer.Entities.Rooms;

namespace HotelDemo.DataAccsesLayer.Interfaces;

public interface IRoomInterface : IRepository<Room>
{
    int Id { get; set; }
    int Number { get; set; }
    int Price { get; set; }
    int RoomTypeId { get; set; }
    RoomType RoomType { get; set; }
    int RoomStatusId { get; set; }
    RoomStatus RoomStatus { get; set; }
}
