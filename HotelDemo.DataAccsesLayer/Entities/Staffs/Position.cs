namespace HotelDemo.DataAccsesLayer.Entities.Staffs;

public class Position : IdEntity
{
    public string Name { get; set; } = string.Empty;
    public ICollection<Staff> StaffMembers { get; set; } = new List<Staff>();
}
