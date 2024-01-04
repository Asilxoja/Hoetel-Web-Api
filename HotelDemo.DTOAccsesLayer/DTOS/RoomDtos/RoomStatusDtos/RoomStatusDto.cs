using HotelDemo.DataAccsesLayer.Entities;

namespace HotelDemo.DTOAccsesLayer.DTOS.RoomDtos.RoomStatusDtos;

public class RoomStatusDto : IdEntity
{
    public string Name { get; set; } = string.Empty;
}
