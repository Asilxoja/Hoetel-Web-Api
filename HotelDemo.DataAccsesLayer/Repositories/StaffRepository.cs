using HotelDemo.DataAccsesLayer.Entities.Staffs;
using HotelDemo.DataAccsesLayer.Interfaces;

namespace HotelDemo.DataAccsesLayer.Repositories;

public class StaffRepository : Repository<Staff>, IStaffInterface
{
    public StaffRepository(AppDbContext dbContext)
        : base(dbContext)
    {
    }
}
