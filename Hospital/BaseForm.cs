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

        protected static UserDto CurrentUser { get; set; }

        protected void DisableResize()
        {
            MaximumSize = Size;
            MinimumSize = Size;
        }
    }
}
