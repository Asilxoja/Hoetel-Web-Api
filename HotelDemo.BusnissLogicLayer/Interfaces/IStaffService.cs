using HotelDemo.DTOAccsesLayer.DTOS.StaffDtos;

namespace HotelDemo.BusnissLogicLayer.Interfaces;

public interface IStaffService
{
    Task<List<StaffDto>> GetAllAsync();
    Task<StaffDto> GetByIdAsync(int id);
    Task AddAsync(AddStaffDto staffDtoDto);
    Task UpdateAsync(UpdateStaffDto updatedStaffDtoDto);
    Task DeleteAsync(int id);
}
