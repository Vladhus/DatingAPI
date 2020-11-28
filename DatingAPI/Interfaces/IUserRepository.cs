using DatingAPI.DTOS;
using DatingAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAPI.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);

        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();

        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsername(string username);
        Task<IEnumerable<MemberDTO>> GetMembersAsync();
        Task<MemberDTO> GetMemberAsync(string username);

    }
}
