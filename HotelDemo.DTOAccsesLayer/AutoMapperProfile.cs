using AutoMapper;
using HotelDemo.DataAccsesLayer;
using HotelDemo.DataAccsesLayer.Entities.Guests;
using HotelDemo.DataAccsesLayer.Entities.Rooms;
using HotelDemo.DataAccsesLayer.Entities.Staffs;
using HotelDemo.DTOAccsesLayer.DTOS.AdminDtos;
using HotelDemo.DTOAccsesLayer.DTOS.GuestDtos;
using HotelDemo.DTOAccsesLayer.DTOS.RoomDtos;
using HotelDemo.DTOAccsesLayer.DTOS.StaffDtos;
using HotelDemo.DTOAccsesLayer.DTOS.RoomTypeDtos;
using HotelDemo.DTOAccsesLayer.DTOS.RoomDtos.RoomStatusDtos;
namespace HotelDemo.DTOAccsesLayer;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        #region Staff Dto
        CreateMap<AddStaffDto, Staff>();
        CreateMap<StaffDto, Staff>().ReverseMap();
        CreateMap<UpdateStaffDto, Staff>();
        #endregion

        #region Guest Dto
        CreateMap<AddGuestDto, Guest>();
        CreateMap<GuestDto, Guest>().ReverseMap();
        CreateMap<UpdateGuestDto, Guest>();
        #endregion

        #region Admin Dto
        CreateMap<AddAdminDto, Admin>();
        CreateMap<AdminDto, Admin>().ReverseMap();
        CreateMap<UpdateAdminDto, Guest>();
        #endregion

        #region Room Dto
        CreateMap<AddRoomDto, Room>();
        CreateMap<RoomDto, Room>().ReverseMap();
        CreateMap<UpdateRoomDto, Room>();
        #endregion

        #region Room Status Dto
        CreateMap<AddRoomStatusDto, RoomStatus>();
        CreateMap<RoomStatusDto, RoomStatus>().ReverseMap();
        CreateMap<UpdateRoomStatusDto, RoomStatus>();
        #endregion

        #region Room Type Dto
        CreateMap<AddRoomTypeDto, RoomType>();
        CreateMap<RoomTypeDto, RoomType>().ReverseMap();
        CreateMap<UpdateRoomTypeDto, RoomType>();
        #endregion

    }
}
