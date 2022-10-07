using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCases.Domain.Entities;

namespace TestCases.Application.Repositories.User
{
    public interface IUserRepository : IRepository<Users>
    {
        Task<bool> AddAsync(Users model);
        int SaveChanges();
    }
}
