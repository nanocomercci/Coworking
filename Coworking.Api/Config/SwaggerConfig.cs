using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.IO;
using Microsoft.AspNetCore.Builder;

namespace Coworking.Api.Config
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddRegistration (this IServiceCollection services)
        {
            var basepath = System.AppDomain.CurrentDomain.BaseDirectory;
            var xmlPath = Path.Combine(basepath, "Coworking.Api.xml");
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Coworking Api V1", Version = "v1" });
                c.IncludeXmlComments(xmlPath);
            }

                 );
            return services;
        }

        public static IApplicationBuilder AddRegistration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json","Coworking Api V1"));
            return app;
        }
    }
}
