using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using API.DTOs;

namespace API.Controllers
{

    [Authorize]
    public class AppUsersController : BaseController
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public AppUsersController(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDTO>>> GetAppUsers()
        {
            /* var users = await _userRepository.GetUsersAsync();
            var usersToReturn = _mapper.Map<IEnumerable<MemberDTO>>(users);
            return Ok(usersToReturn); */

            var users = await _userRepository.GetMembersAsync();
            return Ok(users);

        }

        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDTO>> GetAppUserByName(string username)
        {
           /*  var user = await _userRepository.GetUserByNameAsync(username); 
            return _mapper.Map<MemberDTO>(user); */
            
            return await _userRepository.GetMemberNameByAsync(username);

        }

    }

}