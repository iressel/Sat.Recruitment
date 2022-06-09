using Microsoft.Extensions.DependencyInjection;
using Sat.Recruitment.Api.Controllers;
using Sat.Recruitment.Services;
using Sat.Recruitment.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services) 
        {
            services.AddScoped<IUserManager, UserManager>();
            services.AddTransient<IMoneyManager, MoneyManager>();
            services.AddTransient<UsersController>();
        }
    }
}
