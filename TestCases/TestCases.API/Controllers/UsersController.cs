using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using TestCases.Application.Repositories;
using TestCases.Application.Repositories.User;
using TestCases.Application.ViewModels.Users;
using TestCases.Domain.Entities;
using TestCases.Persistence.Contexts;

namespace TestCases.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

      
        readonly private IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            //_writeRepository = writeRepository;

        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get(int Id)
        {
            Users user = _userRepository.GetByIdAsync(Id);
            return Ok(user);

        }

        [HttpGet]
     
        public async Task<IActionResult> GetDeneme()
        {
            
            return Ok();

        }


        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_User model)
        {
           
            await _userRepository.AddAsync(new()
            {
                Name = model.Name,
                SurName = model.SurName,
                PhoneNumber = model.PhoneNumber,
                EMail = model.EMail,
                Password = model.Password,
            });

             _userRepository.SaveChanges();
            return Ok();









            //}

        }
    }
}
