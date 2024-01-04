using HotelDemo.BusnissLogicLayer.Extended;
using HotelDemo.BusnissLogicLayer.Interfaces;
using HotelDemo.DTOAccsesLayer.DTOS.StaffDtos;
using Microsoft.AspNetCore.Mvc;

namespace HoetelDemoWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StaffController(IStaffService staffService) : ControllerBase
{
    private readonly IStaffService _staffService = staffService;
    [HttpPost]
    public async Task<IActionResult> AddStaff(AddStaffDto staffDto)
    {
        try
        {
            await _staffService.AddAsync(staffDto);
            return Ok("added");
        }
        catch (ArgumentNullException ex)
        {
            return NotFound(ex.Message);
        }

        catch(CustomException ex)
        {
            return BadRequest(ex.Message);
        }

        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}
