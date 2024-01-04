using AutoMapper;
using HotelDemo.DataAccsesLayer.Entities.Staffs;
using HotelDemo.DTOAccsesLayer.DTOS.StaffDtos;

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

    }
}
