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
    public class Room2SericesRepository : IRoom2ServicesRepository
    {
        private readonly ICoworkingDBContext _coworkingDBContext;

        public Room2SericesRepository(ICoworkingDBContext coworkingDBContext)
        {
            _coworkingDBContext = coworkingDBContext;
        }
        public async Task<Room2ServicesEntity> Add(Room2ServicesEntity element)
        {
            await _coworkingDBContext.Room2Services.AddAsync(element);
            await _coworkingDBContext.SaveChangesAsync();
            return element;
        }

        public async Task<Room2ServicesEntity> DeleteASync(int id)
        {
            var entity = await _coworkingDBContext.Room2Services.SingleAsync(x => x.IdRoom == id);
            _coworkingDBContext.Room2Services.Remove(entity);
            await _coworkingDBContext.SaveChangesAsync();
            return entity;
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Room2ServicesEntity> Get(int id)
        {
            var result = await _coworkingDBContext.Room2Services.FirstOrDefaultAsync(x => x.IdRoom == id);
            return result;
                
        }

        public Task<IEnumerable<Room2ServicesEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Room2ServicesEntity> Update(int id, Room2ServicesEntity element)
        {
            var updateEntity = _coworkingDBContext.Room2Services.Update(element);
            await _coworkingDBContext.SaveChangesAsync();
            return updateEntity.Entity;
        }
    }
}
