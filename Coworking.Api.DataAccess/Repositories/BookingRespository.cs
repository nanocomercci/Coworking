using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Repositories
{
    class BookingRespository : IBookingRepository
    {
        public Task<BookingEntity> Add(BookingEntity element)
        {
            throw new NotImplementedException();
        }

        public Task<BookingEntity> DeleteASync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BookingEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BookingEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<BookingEntity> Update(int id, BookingEntity element)
        {
            throw new NotImplementedException();
        }
    }
}
