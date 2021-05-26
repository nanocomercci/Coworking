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
    public class RoomRepository:IRoomRepository
    {
        private readonly ICoworkingDBContext _coworkingDBContext;

        public RoomRepository(ICoworkingDBContext coworkingDBContext)
        {
            _coworkingDBContext = coworkingDBContext;
        }

        public async Task<RoomEntity> Add(RoomEntity element)
        {
            await _coworkingDBContext.Rooms.AddAsync(element);
            await _coworkingDBContext.SaveChangesAsync();
            return element;
        }

        public async Task<RoomEntity> DeleteASync(int id)
        {
            var entity = await _coworkingDBContext.Rooms.SingleAsync(x => x.Id == id);
            _coworkingDBContext.Rooms.Remove(entity);
            await _coworkingDBContext.SaveChangesAsync();
            return entity;
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<RoomEntity> Get(int id)
        {
            var result = await _coworkingDBContext.Rooms.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public Task<IEnumerable<RoomEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<RoomEntity> Update(int id, RoomEntity element)
        {
            var updateEntity = _coworkingDBContext.Rooms.Update(element);
            await _coworkingDBContext.SaveChangesAsync();
            return updateEntity.Entity;
        }
    }
}
