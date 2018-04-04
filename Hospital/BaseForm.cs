using Hospital.Dto;
using System.Windows.Forms;

namespace Hospital
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            //TODO: remove
            CurrentUser = new UserDto { Id = 1, Login = "admin", Role = Data.Enums.UserRoles.Admin };
        }

        public static UserDto CurrentUser { get; set; }
    }
}
