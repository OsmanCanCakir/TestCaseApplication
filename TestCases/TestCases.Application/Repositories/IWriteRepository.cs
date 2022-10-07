using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TestCases.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : class
    {

        Task<bool> AddAsync(T model);

        Task<bool> AddRangeAsync(List<T> model);

        Task<bool> Remove(T model);

        Task<bool> Remove(string id);

        Task<bool> UpdateAsync(T model);

        Task<int> SaveAsync();





    }
}
