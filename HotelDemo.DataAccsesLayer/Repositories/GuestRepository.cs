using HotelDemo.DataAccsesLayer.Entities.Guests;
using HotelDemo.DataAccsesLayer.Interfaces;

namespace HotelDemo.DataAccsesLayer.Repositories;

public class GuestRepository(AppDbContext dbContext)
    : Repository<Guest>(dbContext), IGuestInterface
{
    private readonly AppDbContext _dbContext = dbContext;

    public int Id { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public string Passport { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public DateTime DateOfIssue { get; set; }
    public string Address { get; set; } = string.Empty;
    public string OrganizationName { get; set; } = string.Empty;
    public string Givenbywhom { get; set; } = string.Empty;
    public string Citizenship { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Organization { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
}
