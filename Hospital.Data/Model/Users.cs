using Hospital.Common;
using Hospital.Data.Enums;

namespace Hospital.Data.Model
{
    public class Users : IDeletable
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public bool IsDeleted { get; set; }

        public UserRoles Role { get; set; }
    }
}
