using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCases.Application.Abstractions;
using TestCases.Domain.Entities;

namespace TestCases.Persistence.Concretes
{
    public class UserService : IUserService
    {


        public List<Users> GetUsers()
     => new()
     {
            new()
            {
               Id = 1, Name= "Osmancan", EMail="cakirosman9@outlook.com", SurName="cakir", Password="test", PhoneNumber="4564565"
            }
     };
    }
}
