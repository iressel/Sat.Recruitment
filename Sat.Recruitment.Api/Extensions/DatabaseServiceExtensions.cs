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
        public static void AddDatabaseService(this IServiceCollection services)
        {
            services
                .AddEntityFrameworkSqlServer()
                .AddDbContext<RecruitmentDB>(options =>
            {

                options.UseSqlServer(
                    "Server=DESKTOP-42KK2JH; Database=Recruitment; Integrated Security=True;",
                    dbOptions => dbOptions.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds)
                                          .MigrationsAssembly("Sat.Recruitment.Model"));
            });
        }
    }
}
