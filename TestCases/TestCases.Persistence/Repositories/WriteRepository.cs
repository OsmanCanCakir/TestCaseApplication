using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestCases.Application.Repositories;
using TestCases.Persistence.Contexts;

namespace TestCases.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class
    {

        readonly private TestCasesDbContext testCasesDbContext;

        public WriteRepository(TestCasesDbContext context)
        {
            testCasesDbContext = context;
        }




        public DbSet<T> Table =>testCasesDbContext.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> model)
        {
            await Table.AddRangeAsync(model);
            return true;
        }

        public T GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetWhere(Expression<Func<T, bool>> method)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(T model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(string id)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }


        public Task<bool> UpdateAsync(T model)
        {
            throw new NotImplementedException();
        }
    }
}
