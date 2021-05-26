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
    public class Office2RoomsRespository : IOffice2RoomsRespository
    {
        private readonly ICoworkingDBContext _coworkingDBContext;

        public Office2RoomsRespository(ICoworkingDBContext coworkingDBContext)
        {
            _coworkingDBContext = coworkingDBContext;
        }
        public async Task<Office2RoomsEntity> Add(Office2RoomsEntity element)
        {
            await _coworkingDBContext.Office2Rooms.AddAsync(element);
            await _coworkingDBContext.SaveChangesAsync();
            return element;
        }

        public async Task<Office2RoomsEntity> DeleteASync(int id)
        {
            var entity = await _coworkingDBContext.Office2Rooms.SingleAsync(x => x.OfficeId == id);
            _coworkingDBContext.Office2Rooms.Remove(entity);
            await _coworkingDBContext.SaveChangesAsync();
            return entity;
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Office2RoomsEntity> Get(int id)
        {
            var result = await _coworkingDBContext.Office2Rooms.FirstOrDefaultAsync(x => x.OfficeId == id);
            return result;
                
        }

        public Task<IEnumerable<Office2RoomsEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Office2RoomsEntity> Update(int id, Office2RoomsEntity element)
        {
            var updateEntity = _coworkingDBContext.Office2Rooms.Update(element);
            await _coworkingDBContext.SaveChangesAsync();
            return updateEntity.Entity;
        }
    }
}
