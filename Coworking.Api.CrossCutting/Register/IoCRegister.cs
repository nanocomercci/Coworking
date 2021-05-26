﻿using Coworking.Api.DataAccess.Repositories;
using Coworking.Api.DataAccess.Contracts.Respositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Application.Services;
using Coworking.Api.Application.Contracts;


namespace Coworking.Api.CrossCutting.Register
{
    public static class IoCRegister
    {
        public static IServiceCollection  AddRegistration(this IServiceCollection services)
        {
            AddRegisterServices(services);
            AddRegisterRepositories(services);
            return services;

        }

        private static IServiceCollection AddRegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IAdminService, AdminService>();
            services.AddTransient<IUserService, UserService>();
            return services;
        }
        private static IServiceCollection AddRegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<IAdminRepository, AdminRepository>();
            services.AddTransient<IBookingRepository, BookingRespository>();
            services.AddTransient<IOfficeRepository, OfficeRepository>();
            services.AddTransient<IRoomRepository, RoomRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            return services;
        }
    }
}
