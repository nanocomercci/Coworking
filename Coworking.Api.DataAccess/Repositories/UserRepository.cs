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
    class UserRepository:IUserRepository
    {
        private readonly ICoworkingDBContext _coworkingDBContext;

        public UserRepository(ICoworkingDBContext coworkingDBContext)
        {
            _coworkingDBContext = coworkingDBContext;
        }

        public async Task<UserEntity> Add(UserEntity element)
        {
            await _coworkingDBContext.Users.AddAsync(element);
            await _coworkingDBContext.SaveChangesAsync();
            return element;
        }

        public async Task<UserEntity> DeleteASync(int id)
        {
            var entity = await _coworkingDBContext.Users.SingleAsync(x => x.Id == id);
            _coworkingDBContext.Users.Remove(entity);
            await _coworkingDBContext.SaveChangesAsync();
            return entity;
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserEntity> Get(int id)
        {
            var result = await _coworkingDBContext.Users.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public Task<IEnumerable<UserEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<UserEntity> Update(int id, UserEntity element)
        {
            var updateEntity = _coworkingDBContext.Users.Update(element);
            await _coworkingDBContext.SaveChangesAsync();
            return updateEntity.Entity;
        }
    }
}
