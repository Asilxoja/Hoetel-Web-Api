using HotelDemo.DataAccsesLayer.Entities.Guests;

namespace HotelDemo.DataAccsesLayer.Interfaces;

public interface IGuestInterface : IRepository<Guest>
{
    int Id { get; }
    string PhoneNumber { get; set; }
    string Passport { get; set; }
    DateTime BirthDate { get; set; }
    DateTime DateOfIssue { get; set; }
    string Address { get; set; }
    string OrganizationName { get; set; }
    string Givenbywhom { get; set; }
    string Citizenship { get; set; }
    string Description { get; set; }
    string Organization { get; set; }
    string Gender { get; set; }
}
