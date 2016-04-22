using System.Threading.Tasks;
using PathFinder.Security.WebApi.Models;

namespace PathFinder.Security.WebApi.Commands
{
    public interface IRegisterUserCommand
    {
        Task<int?> RegisterUser(RegisterUserModel userModel);
    }
}