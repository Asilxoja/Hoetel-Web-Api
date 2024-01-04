using HotelDemo.DataAccsesLayer.Entities.Staffs;

namespace HotelDemo.BusnissLogicLayer.Extended;

public static class Validator
{
    public static bool IsValid(this Staff staff)
        => staff != null
        && !string.IsNullOrEmpty(staff.FirstName)
        && !string.IsNullOrEmpty(staff.LastName)
        && !string.IsNullOrEmpty(staff.FatherName)
        && !string.IsNullOrEmpty(staff.Gender)
        && staff.FirstName.Length >= 2
        && staff.FirstName.Length <= 50
        && staff.LastName.Length >= 2
        && staff.FirstName.Length <= 50;
}
