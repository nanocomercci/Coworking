using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Contracts
{
    public interface ICoworkingDBContext
    {
         DbSet<UserEntity> Users { get; set; }
         DbSet<AdminEntity> Admins { get; set; }
         DbSet<BookingEntity> Bookings { get; set; }
         DbSet<OfficeEntity> Offices { get; set; }
         DbSet<Office2RoomsEntity> Office2Rooms { get; set; }
         DbSet<Room2ServicesEntity> Room2Services { get; set; }
         DbSet<RoomEntity> Rooms { get; set; }
         DbSet<ServiceEntity> Services { get; set; }
    }
}
