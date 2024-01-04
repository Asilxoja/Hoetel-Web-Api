using HotelDemo.DataAccsesLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelDemo.DataAccsesLayer.Repositories;

public class UnitOfWork(AppDbContext dbContext,
                       IStaffInterface staffInterface,
                       IAdminInterface adminInterface,
                       IGuestInterface guestInterface,
                       IOrderInterface orderInterface,
                       IOrderStatusInterface orderStatusInterface,
                       IRoomInterface roomInterface,
                       IRoomStatusInterface roomStatusInterface,
                       IRoomTypeInterface roomTypeInterface) : IUnitOfWork
{
    private readonly AppDbContext _dbContext = dbContext;

    public IStaffInterface StaffInterface { get; } = staffInterface;

    public IAdminInterface AdminInterface { get; } = adminInterface;

    public IGuestInterface GuestInterface { get; } = guestInterface;

    public IOrderStatusInterface OrderStatusInterface { get; } = orderStatusInterface;

    public IOrderInterface OrderInterface { get; } = orderInterface;

    public IRoomInterface RoomInterface { get; } = roomInterface;

    public IRoomStatusInterface RoomStatusInterface { get; } = roomStatusInterface;

    public IRoomTypeInterface RoomTypeInterface { get; } = roomTypeInterface;

    public void Dispose()
         => GC.SuppressFinalize(this);

    public async Task SaveAsync()
            => await _dbContext.SaveChangesAsync();
}