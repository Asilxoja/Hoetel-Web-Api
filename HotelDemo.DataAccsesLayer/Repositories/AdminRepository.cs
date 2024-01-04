using HotelDemo.DataAccsesLayer.Interfaces;

namespace HotelDemo.DataAccsesLayer.Repositories;

public class AdminRepository : Repository<Admin>, IAdminInterface
{
    public AdminRepository(AppDbContext dbContext)
        : base(dbContext)
    {
    }
}
