namespace HotelDemo.DataAccsesLayer.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IStaffInterface StaffInterface { get; }
    IAdminInterface AdminInterface { get; }
    Task SaveAsync();
}
