using Hospital.Dto;
using System.Windows.Forms;

namespace Hospital
{
    public partial class DetailsDepartmentForm : Form
    {
        public DetailsDepartmentForm(DepartmentDto entity)
        {
            InitializeComponent();
            InitControls(entity);
        }

        private void InitControls(DepartmentDto entity)
        {
            Text = $"Отделение {entity.Name}";

            addressInput.Text = entity.Address;
            nameInput.Text = entity.Name;
            profileInput.Text = entity.Profile;

            addressInput.Enabled = false;
            nameInput.Enabled = false;
            profileInput.Enabled = false;
        }
    }
}
