using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MoneyManager.SaraivaDev.API.Contexts;
using MoneyManager.SaraivaDev.API.Interfaces.Repository;
using MoneyManager.SaraivaDev.API.Interfaces.Service;
using MoneyManager.SaraivaDev.API.Models.Domain;
using MoneyManager.SaraivaDev.API.Repositories;
using MoneyManager.SaraivaDev.API.Services;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneyManager.SaraivaDev.API.IoC
{
    public static class DIConfiguration
    {
        public static IServiceCollection AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MoneyManagerContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("Npgsql")));

            services.AddIdentity<MMUserModel, IdentityRole>()
                            .AddEntityFrameworkStores<MoneyManagerContext>()
                            .AddDefaultTokenProviders();

            return services;
        }
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services
                .AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies())
            .AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description =
                        "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                },
                                Scheme = "oauth2",
                                Name = "Bearer",
                                In = ParameterLocation.Header,

                            },
                            new List<string>()
                        }
                });
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Money Manager",
                    Description = "Money Manager",
                    Contact = new OpenApiContact
                    {
                        Name = "Money Manager API",
                        Email = "carlosaraiva@gmail.com",
                        Url = new Uri("https://www.moneymanager.com/contact"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under BY-NC-ND",
                        Url = new Uri("https://www.moneymanager.com/license"),
                    }
                });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            });

            return services;
        }
        public static IServiceCollection AddAuthorizationAndAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })

            // Adding Jwt Bearer
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = configuration["JWT:ValidAudience"],
                    ValidIssuer = configuration["JWT:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
                };
            });

            return services;
        }
        public static IServiceCollection AddCorsWith(this IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
            }));
            return services;
        }
        public static IServiceCollection AddControllersWith(this IServiceCollection services)
        {
            services.AddControllers()
            .AddNewtonsoftJson(setupAction =>
            {
                setupAction.SerializerSettings.ContractResolver =
                    new CamelCasePropertyNamesContractResolver();
            })
            .AddXmlDataContractSerializerFormatters()
            .ConfigureApiBehaviorOptions(setupAction =>
            {
                setupAction.InvalidModelStateResponseFactory = context =>
                {
                    var problemDetails = new ValidationProblemDetails(context.ModelState)
                    {
                        Type = "https://www.moneymanager.com/modelvalidationproblem",
                        Status = StatusCodes.Status422UnprocessableEntity,
                        Title = "One or more validation errors occurred.",
                        Detail = "See the errors field for details.",
                        Instance = context.HttpContext.Request.Path
                    };

                    problemDetails.Extensions.Add("traceId", context.HttpContext.TraceIdentifier);

                    return new UnprocessableEntityObjectResult(problemDetails)
                    {
                        ContentTypes = { "application/problem+json" }
                    };
                };
            });

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped<IRepository<AddressModel>, AddressRepository>()
                .AddScoped<IRepository<CostCenterModel>, CostCenterRepository>()
                .AddScoped<IRepository<AccountModel>, AccountRepository>()
                .AddScoped<IRepository<CurrencyModel>, CurrencyRepository>()
                .AddScoped<IRepository<EmailModel>, EmailRepository>()
                .AddScoped<IRepository<CategoryModel>, CategoryRepository>()
                .AddScoped<IEntryRepository<EntryModel>, EntryRepository>()
                .AddScoped<IRepository<PaymentTypeModel>, PaymentTypeRepository>()
                .AddScoped<IRepository<PhoneModel>, PhoneRepository>();
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IService<AddressModel>, AddressService>()
                .AddScoped<IService<CostCenterModel>, CostCenterService>()
                .AddScoped<IService<AccountModel>, AccountService>()
                .AddScoped<IService<CurrencyModel>, CurrencyService>()
                .AddScoped<IService<EmailModel>, EmailService>()
                .AddScoped<IService<CategoryModel>, CategoryService>()
                .AddScoped<IService<EntryModel>, EntryService>()
                .AddScoped<IService<PaymentTypeModel>, PaymentTypeService>()
                .AddScoped<IService<PhoneModel>, PhoneService>();
        }
    }
}
