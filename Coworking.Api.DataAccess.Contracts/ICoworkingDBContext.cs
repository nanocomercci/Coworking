using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellation = default(CancellationToken));
        void RemoveRange(IEnumerable<object> entities);
        EntityEntry Update(object entity);


    }
}
