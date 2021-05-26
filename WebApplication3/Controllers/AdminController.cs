using Coworking.Api.Application.Contracts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api.Controllers
{

    [Produces("application/json")]
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;
        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
           var name= await _adminService.GetAdminName(id);
            return Ok(name);
        }
    }
}
