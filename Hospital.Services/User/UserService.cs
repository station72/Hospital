using AutoMapper;
using Hospital.Common;
using Hospital.Data;
using Hospital.Dto;
using System.Data.Entity;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Hospital.Services.User
{
    public class UserService : IUserService
    {
        private readonly HospitalDbContext _dc;

        public UserService()
        {
            _dc = new HospitalDbContext();
        }

        public async Task<UserDto> EnterAsync(string login, string password)
        {
            var user =  await _dc.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Login == login && u.Password == u.Password);
            if (user == null)
                throw new HospitalException("Неверный логин или пароль!");

            var mappedUser = Mapper.Map<UserDto>(user);
            return mappedUser;
        }
    }
}
