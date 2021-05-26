using Coworking.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Application.Contracts.Services
{
    public interface IAdminService
    {
        public Task<string> GetAdminName(int id);
        public Task<Admin> AddAdmin(Admin admin);
    }
}
