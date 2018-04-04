using System.Threading.Tasks;
using Hospital.Dto;
using Hospital.Common;
using System;
using Hospital.Data.Enums;

namespace Hospital.Services.User
{
    public class UserService : IUserService
    {
        public async Task<UserDto> Enter(string login, string password)
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            if (login == "a")
            {
                throw new HospitalException("Неверно введен логин или пароль!");
            }

            if (password == "a")
            {
                throw new HospitalException("Неверно введен логин или пароль!");
            }

            var role = UserRoles.User;
            if (login == "admin")
            {
                role = UserRoles.Admin;
            }
            return new UserDto { Id = 1, Login = login, Role = role };
        }
    }
}
