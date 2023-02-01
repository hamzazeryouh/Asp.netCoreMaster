"NetCoreMaster" is a project that aims to provide comprehensive information and knowledge about .NET Core 7. It is organized into branches, where each branch focuses on specific topics related to .NET Core. The "master" branch serves as a central hub, compiling all of the information and resources available across the different branches, making it an all-in-one destination for anyone looking to learn about .NET Core 7.
by hamza zeryouh
gmail:zeryouhbusiness@gmail.com
Linkdin: https://www.linkedin.com/in/hamza-zeryouh/

Add custom Swagger in .net core 7 

Here's a basic example of how you can use Swagger in .NET Core:

Install the Swashbuckle.AspNetCore NuGet package in your .NET Core project.

Add the following code to the Program.cs file:

 builder.Services.AddSwaggerGen(e =>
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
            
            /// var app = builder.Build();
             if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            
            
Run your application and navigate to http://localhost:<port>/swagger to view the generated Swagger UI.
This is just a basic example, and you can customize the generated Swagger documentation by adding additional configuration options to the AddSwaggerGen method.
            
            



