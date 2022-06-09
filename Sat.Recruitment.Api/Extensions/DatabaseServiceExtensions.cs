using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sat.Recruitment.Model.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Extensions
{
    public static class DatabaseServiceExtensions
    {
        public static void AddDatabaseService(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddEntityFrameworkSqlServer()
                .AddDbContext<RecruitmentDB>(options =>
            {

                options.UseSqlServer(
                    GetRecruitmentConnectionString(configuration),
                    dbOptions => dbOptions.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds)
                                          .MigrationsAssembly("Sat.Recruitment.Model"));
            });
        }

        public static string GetRecruitmentConnectionString(IConfiguration configuration)
        {
            var recruitmentDBConnectionStringKey = configuration.GetValue("Launch:EnvironmentVariables:DBConnectionString", "RecruitmentDB");
            return Environment.GetEnvironmentVariable(recruitmentDBConnectionStringKey);
        }
    }
}
