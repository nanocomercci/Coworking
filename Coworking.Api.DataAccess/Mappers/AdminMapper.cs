using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Mappers
{
    public static class AdminMapper
    {
        public static AdminEntity Map(Admin dto)
        {
            return new AdminEntity()
            {
                Id = dto.Id,
                Email = dto.Email,
                
                Name = dto.Name,
                Phone = dto.Phone
            };
        }
        public static Admin Map(AdminEntity entity)
        {
            return new Admin()
            {
                Email = entity.Email,
                Id = entity.Id,
                Name = entity.Name,
                
                Phone = entity.Phone
            };
        }
    }
}
