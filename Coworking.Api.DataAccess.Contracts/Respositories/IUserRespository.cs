using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Contracts.Respositories
{
    public interface IUserRepository : IRepository<UserEntity>
    {
    }
}
