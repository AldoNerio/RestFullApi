using SocialMedia.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMedia.Core.Interfaces
{
    public interface IUserRepository
    {        
        Task<User> GetUsers(int id);
        Task<IEnumerable<User>> GetUsers();
    }
}