using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool>SaveAsync();

        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);

        Task<AppUser> GetUserByNameAsync(string username);

        Task<IEnumerable<MemberDTO>> GetMembersAsync();
        Task<MemberDTO>GetMemberByNameAsync(string username);

    }
}