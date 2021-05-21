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
    class OfficeRepository:IOfficeRepository
    {
        private readonly ICoworkingDBContext _coworkingDBContext;

        public OfficeRepository(ICoworkingDBContext coworkingDBContext)
        {
            _coworkingDBContext = coworkingDBContext;
        }

        public async Task<OfficeEntity> Add(OfficeEntity element)
        {
            await _coworkingDBContext.Offices.AddAsync(element);
            await _coworkingDBContext.SaveChangesAsync();
            return element;
        }

        public async Task<OfficeEntity> DeleteASync(int id)
        {
            var entity = await _coworkingDBContext.Offices.SingleAsync(x => x.Id == id);
            _coworkingDBContext.Offices.Remove(entity);
            await _coworkingDBContext.SaveChangesAsync();
            return entity;
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<OfficeEntity> Get(int id)
        {
            var result = await _coworkingDBContext.Offices.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public Task<IEnumerable<OfficeEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<OfficeEntity> Update(int id, OfficeEntity element)
        {
            var updateEntity = _coworkingDBContext.Offices.Update(element);
            await _coworkingDBContext.SaveChangesAsync();
            return updateEntity.Entity;
        }
    }
}
