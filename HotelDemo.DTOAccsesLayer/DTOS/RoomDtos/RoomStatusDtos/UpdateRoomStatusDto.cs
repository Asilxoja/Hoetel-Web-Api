using HotelDemo.DataAccsesLayer.Entities;

namespace HotelDemo.DTOAccsesLayer.DTOS.RoomDtos.RoomStatusDtos;

public class UpdateRoomStatusDto : IdEntity
{
    public string Name { get; set; } = string.Empty;
}
