using Hospital.Dto;
using System.Windows.Forms;

namespace Hospital
{
    public class BaseForm : Form
    {
        protected static UserDto CurrentUser { get; set; }

        protected readonly string FieldIsRequiredMessage = "Поле обязательно для ввода";
    }
}
