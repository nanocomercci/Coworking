using Coworking.Api.DataAccess.Contracts;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Respositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Repositories
{
    public class AdminRepository:IAdminRepository
    {
        //CRUD
        private readonly ICoworkingDBContext _coworkingDBContext;

        public AdminRepository(ICoworkingDBContext coworkingDBContext)
        {
            _coworkingDBContext = coworkingDBContext;
        }

        public async Task<AdminEntity> Add(AdminEntity element)
        {
            await _coworkingDBContext.Admins.AddAsync(element);
            await _coworkingDBContext.SaveChangesAsync();
            return element;
        }

        public async Task<AdminEntity> DeleteASync(int id)
        {
            var entity = await _coworkingDBContext.Admins.SingleAsync(x => x.Id == id);
            _coworkingDBContext.Admins.Remove(entity);
            await _coworkingDBContext.SaveChangesAsync();
            return entity;


        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<AdminEntity> Get(int id)
        {
            var result = await _coworkingDBContext.Admins.FirstOrDefaultAsync(x => x.Id == id);
            return result;


        }

        public async Task<IEnumerable<AdminEntity>> GetAll()
        {
            return  _coworkingDBContext.Admins.Select(x => x);
        }

        public async Task<AdminEntity> Update(int id, AdminEntity element)
        {
            var updateEntity = _coworkingDBContext.Admins.Update(element);
            await _coworkingDBContext.SaveChangesAsync();
            return updateEntity.Entity;
        }
    }
}
