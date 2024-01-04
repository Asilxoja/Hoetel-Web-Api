using HotelDemo.DataAccsesLayer.Entities;

namespace HotelDemo.DTOAccsesLayer.DTOS.RoomDtos;

public class UpdateRoomDto : IdEntity
{
    public int Number { get; set; }
    public int Price { get; set; }
    public int RoomTypeId { get; set; }
    public int RoomStatusId { get; set; }
}
