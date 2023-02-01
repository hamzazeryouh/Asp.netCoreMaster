using Microsoft.OpenApi.Models;
using System.Runtime.CompilerServices;

namespace NetCoreMaster.Extensions
{
    public static class ConfigSwagger
    {

        public static void ConfigSawgger(this IServiceCollection Service)
        {
            Service.AddSwaggerGen(e =>
            {
                e.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "NetCoreMaster  API",
                    Description = "NetCoreMaster API Swagger ",


                });

                e.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme (Example: 'Bearer token')",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                e.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    Array.Empty<string>()
                }
     });
            });
        } 
    }
}



