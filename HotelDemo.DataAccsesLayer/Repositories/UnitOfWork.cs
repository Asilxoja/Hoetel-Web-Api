using HotelDemo.DataAccsesLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelDemo.DataAccsesLayer.Repositories;

public class UnitOfWork(AppDbContext dbContext,
                       IStaffInterface staffInterface
                       ,IAdminInterface adminInterface) : IUnitOfWork
{
    private readonly AppDbContext _dbContext = dbContext;

    public IStaffInterface StaffInterface { get; } = staffInterface;

    public IAdminInterface AdminInterface { get; } = adminInterface;

    public void Dispose()
         => GC.SuppressFinalize(this);

    public async Task SaveAsync()
            => await _dbContext.SaveChangesAsync();
}