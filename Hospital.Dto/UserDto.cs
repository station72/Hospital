using Hospital.Data.Enums;

namespace Hospital.Dto
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public UserRoles Role { get; set; }
    }
}
