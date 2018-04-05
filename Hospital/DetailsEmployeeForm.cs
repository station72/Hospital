using Hospital.Dto;

namespace Hospital
{
    public partial class DetailsEmployeeForm : BaseForm
    {
        public DetailsEmployeeForm(EmployeeDto entity)
        {
            InitializeComponent();
            InitControls(entity);
        }

        private void InitControls(EmployeeDto entity)
        {
            Text = $"Мед. работник";

            cabinetInput.Text = entity.Cabinet;
            firstNameInput.Text = entity.FirstName;
            patronymicInput.Text = entity.Patronymic;
            secondNameInput.Text = entity.LastName;
            scheduleInput.Text = entity.Schedule;

            cabinetInput.Enabled = false;
            firstNameInput.Enabled = false;
            patronymicInput.Enabled = false;
            secondNameInput.Enabled = false;
            scheduleInput.Enabled = false;
        }
    }
}
