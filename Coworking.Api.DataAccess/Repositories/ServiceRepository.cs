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
    class ServiceRespoitory : IServiceRepository
    {
        private readonly ICoworkingDBContext _coworkingDBContext;

        public ServiceRespoitory(ICoworkingDBContext coworkingDBContext)
        {
            _coworkingDBContext = coworkingDBContext;
        }

        public async Task<ServiceEntity> Add(ServiceEntity element)
        {
            await _coworkingDBContext.Services.AddAsync(element);
            await _coworkingDBContext.SaveChangesAsync();
            return element;
        }

        public async Task<ServiceEntity> DeleteASync(int id)
        {
            var entity = await _coworkingDBContext.Services.SingleAsync(x => x.Id == id);
            _coworkingDBContext.Services.Remove(entity);
            await _coworkingDBContext.SaveChangesAsync();
            return entity;
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceEntity> Get(int id)
        {
            var result =  await _coworkingDBContext.Services.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public Task<IEnumerable<ServiceEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceEntity> Update(int id, ServiceEntity element)
        {
            var updateEntity = _coworkingDBContext.Services.Update(element);
            await _coworkingDBContext.SaveChangesAsync();
            return updateEntity.Entity;
        }
    }
}
