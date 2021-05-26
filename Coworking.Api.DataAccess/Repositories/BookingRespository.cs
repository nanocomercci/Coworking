using Coworking.Api.DataAccess.Contracts;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Respositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Repositories
{
    public class BookingRespository : IBookingRepository
    {
        private readonly ICoworkingDBContext _coworkingDBContext;

        public BookingRespository(ICoworkingDBContext coworkingDBContext)
        {
            _coworkingDBContext = coworkingDBContext;
        }
        public async Task<BookingEntity> Add(BookingEntity element)
        {
            await _coworkingDBContext.Bookings.AddAsync(element);
            await _coworkingDBContext.SaveChangesAsync();
            return element;
        }

        public async Task<BookingEntity> DeleteASync(int id)
        {
            var entity = await _coworkingDBContext.Bookings.SingleAsync(x => x.Id == id);
            _coworkingDBContext.Bookings.Remove(entity);
            await _coworkingDBContext.SaveChangesAsync();
            return entity;
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<BookingEntity> Get(int id)
        {
            var result = await _coworkingDBContext.Bookings.FirstOrDefaultAsync(x => x.Id == id);
            return result;
                
        }

        public Task<IEnumerable<BookingEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<BookingEntity> Update(int id, BookingEntity element)
        {
            var updateEntity = _coworkingDBContext.Bookings.Update(element);
            await _coworkingDBContext.SaveChangesAsync();
            return updateEntity.Entity;
        }
    }
}
