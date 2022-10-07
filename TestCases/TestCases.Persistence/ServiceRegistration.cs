using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCases.Application.Repositories.User;
using TestCases.Persistence.Contexts;
using TestCases.Persistence.Repositories;

namespace TestCases.Persistence
{
    public static class ServiceRegistration
    {

        public static void AddPersistenceService(this IServiceCollection services)
        {

            services.AddDbContext<TestCasesDbContext>(option => option.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<IUserRepository, UserRepository>();



        }


    }
}
