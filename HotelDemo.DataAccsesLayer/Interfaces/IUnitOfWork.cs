namespace HotelDemo.DataAccsesLayer.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IStaffInterface StaffInterface { get; }
    IAdminInterface AdminInterface { get; }
    IGuestInterface GuestInterface { get; }
    IOrderStatusInterface OrderStatusInterface { get; }
    IOrderInterface OrderInterface { get; }
    IRoomInterface RoomInterface { get; }
    IRoomStatusInterface RoomStatusInterface { get; }
    IRoomTypeInterface RoomTypeInterface { get; }

    Task SaveAsync();
}
