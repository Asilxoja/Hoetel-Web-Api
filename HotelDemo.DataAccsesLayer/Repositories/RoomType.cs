using HotelDemo.DataAccsesLayer.Entities.Rooms;
using HotelDemo.DataAccsesLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelDemo.DataAccsesLayer.Repositories
{
    public class RoomTypeRepository(AppDbContext dbContext) : Repository<RoomType>(dbContext), IRoomType
    {
        private readonly AppDbContext _dbContext = dbContext;

        public int Id { get; set; }
        public string Name { get; set; }
        public int PersonCount { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
