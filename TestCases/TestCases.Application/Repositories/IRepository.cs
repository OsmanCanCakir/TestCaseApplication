using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestCases.Application.Repositories
{
    public interface IRepository<T> where T : class
    {

        T GetByIdAsync(int id);
        Task<T> GetWhere(Expression<Func<T,bool>> method);

        DbSet<T> Table { get; }


    }
}
