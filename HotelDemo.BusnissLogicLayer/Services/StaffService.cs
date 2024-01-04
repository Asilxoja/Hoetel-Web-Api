using AutoMapper;
using HotelDemo.BusnissLogicLayer.Extended;
using HotelDemo.BusnissLogicLayer.Interfaces;
using HotelDemo.DataAccsesLayer.Entities.Staffs;
using HotelDemo.DataAccsesLayer.Interfaces;
using HotelDemo.DTOAccsesLayer.DTOS.StaffDtos;

namespace HotelDemo.BusnissLogicLayer.Services;

public class StaffService(IUnitOfWork unitOfWork, IMapper mapper) : IStaffService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;
    public async Task AddAsync(AddStaffDto staffDtoDto)
    {
        if (staffDtoDto is null)
        {
            throw new ArgumentNullException("Staf is null\n\n", nameof(staffDtoDto));
        }
        var staff = _mapper.Map<Staff>(staffDtoDto);

        try
        {
            await _unitOfWork.StaffInterface.AddAsync(staff);
            await _unitOfWork.SaveAsync();
        }
        catch (CustomException ex)
        {
            throw new Exception(ex.Message);
        }
    }


    public async Task DeleteAsync(int id)
    {
        var staff = await _unitOfWork.StaffInterface.GetByIdAsync(id);
        if (!staff.IsValid())
        {
            throw new CustomException($"{nameof(Staff)} cannot be deleted");
        }
        await _unitOfWork.StaffInterface.DeleteAsync(staff);
        await _unitOfWork.SaveAsync();
    }

    public Task<List<StaffDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<StaffDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(UpdateStaffDto updatedStaffDtoDto)
    {
        throw new NotImplementedException();
    }
}
