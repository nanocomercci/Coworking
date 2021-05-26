using Coworking.Api.Business.Models;
using Coworking.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api.Mappers
{
    public static class AdminMapper
    {
        public static Admin Map(AdminModel model)
        {
            return new Admin()
            {
                Id=model.Id,
                OfficeId=10,
                Email = model.Email,
                Name = model.Name,
                Phone = model.Phone,

            };
        }
    }
        
}
