using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;

namespace Controller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserRepository _userRepository;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserRepository userRepository, ILogger<UserController> logger)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            var users = await _userRepository.GetAll();

            return users;
        }
    }
}