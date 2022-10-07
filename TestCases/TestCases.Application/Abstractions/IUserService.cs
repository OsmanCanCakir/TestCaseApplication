using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCases.Domain.Entities;

namespace TestCases.Application.Abstractions
{
    public interface IUserService
    {
        List<Users> GetUsers();


    }
}
