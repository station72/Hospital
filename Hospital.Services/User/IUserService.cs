using Hospital.Dto;
using System.Threading.Tasks;

namespace Hospital.Services.User
{
    public interface IUserService
    {
        Task<UserDto> Enter(string login, string password);
    }
}
