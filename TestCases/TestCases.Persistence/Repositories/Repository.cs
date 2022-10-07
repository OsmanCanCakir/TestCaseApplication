using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestCases.Persistence.Contexts;

namespace TestCases.Persistence.Repositories
{
    public class Repository<T> where T : class
    {

        private readonly TestCasesDbContext _context;
        public Repository(TestCasesDbContext context)
        {
            _context = context;
        }


        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
        {
            return Table;
        }

        //public Task<T> GetByIdAsync(int Id)
        //{
        //    return Table.FirstOrDefaultAsync(o => o.Id == Id);
        //}

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
        {
            return await Table.FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        {
            return Table.Where(method);
        }
    }
}
