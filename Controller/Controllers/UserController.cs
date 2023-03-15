using AutoMapper;
using Controller.Dtos.User;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;

namespace Controller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private IMapper _mapper;
        private IUserRepository _userRepository;

        public UserController(ILogger<UserController> logger, IMapper mapper, IUserRepository userRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<UserDTO>> GetAll()
        {
            var users = await _userRepository.GetAll();

            var usersDTO = _mapper.Map<IEnumerable<UserDTO>>(users);

            return usersDTO;
        }

        [HttpGet("{id}")]
        public async Task<UserDTO> findById([FromQuery] string id)
        {
            var user = await _userRepository.FindById(id);

            var userDTO = _mapper.Map<UserDTO>(user);

            return userDTO;
        }
    }
}