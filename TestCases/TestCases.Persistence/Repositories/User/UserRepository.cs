using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestCases.Application.Repositories;
using TestCases.Application.Repositories.User;
using TestCases.Domain.Entities;
using TestCases.Persistence.Contexts;
using static TestCases.Persistence.Repositories.UserRepository;

namespace TestCases.Persistence.Repositories
{
    
        public class UserRepository : Repository<Users>, IUserRepository
        {

        readonly private TestCasesDbContext testCasesDbContext;
        public UserRepository(TestCasesDbContext context) : base(context)
        {
            testCasesDbContext = context;
        }
        public DbSet<Users> Table => testCasesDbContext.Set<Users>();
        public async Task<bool> AddAsync(Users model)
        {
            EntityEntry<Users> entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public Users GetByIdAsync(int id)
        {
            return Table.FirstOrDefault(o => o.Id == id);
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            testCasesDbContext.SaveChanges();
            return 1;
        }

        Task<Users> IRepository<Users>.GetWhere(Expression<Func<Users, bool>> method)
        {
            throw new NotImplementedException();
        }
    }


    
}
