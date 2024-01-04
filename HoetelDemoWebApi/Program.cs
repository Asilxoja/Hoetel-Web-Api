using AutoMapper;
using HotelDemo.BusnissLogicLayer.Interfaces;
using HotelDemo.BusnissLogicLayer.Services;
using HotelDemo.DataAccsesLayer;
using HotelDemo.DataAccsesLayer.Interfaces;
using HotelDemo.DataAccsesLayer.Repositories;
using HotelDemo.DTOAccsesLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Add DB Context 
builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("LocalSqlServer")));
#endregion

#region Add Interface and Service
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IStaffInterface, StaffRepository>();
builder.Services.AddTransient<IAdminInterface, AdminRepository>();


builder.Services.AddTransient<IStaffService, StaffService>();

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new AutoMapperProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();