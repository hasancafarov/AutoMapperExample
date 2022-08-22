using AutoMapper;
using AutoMapperExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperExample.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpGet]
        public UserDto Get()
        {
            var user = new User
            {
                Id=1,
                FirstName="Hasan",
                LastName="Jafarov",
                Status=1
            };
            var userInfo = _mapper.Map<UserDto>(user);
            return userInfo;
        }
    }
}
