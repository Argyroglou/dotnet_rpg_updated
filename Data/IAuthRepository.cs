using System.Threading.Tasks;
using dotnet_rpg_updated.Models;

namespace dotnet_rpg_updated.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}