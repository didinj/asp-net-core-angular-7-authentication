using System.Threading.Tasks;
using AspNetAngularAuth.Models;

namespace AspNetAngularAuth.Repositories
{
    public interface IAuthRepository
    {
        Task<TblUser> Register(TblUser user, string password);
        Task<TblUser> Login(string username, string password);
        Task<bool> UserExists(string username); 
    }
}