using Coworking.Api.Application.Contracts;
using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.DataAccess.Contracts.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Application.Services
{
    public class UserService:IUserService
    {
        private readonly IAdminService _adminService;
        private readonly IUserRepository _userRepository;
        public UserService(IAdminService adminService, IUserRepository userRespository)
        {
            _adminService = adminService;
            _userRepository = userRespository;
        }
        public  async Task<string>GetUserName(int id)
        {
             var nameAdmin = await _adminService.GetAdminName(id);
            return nameAdmin;

        }
    }
}
