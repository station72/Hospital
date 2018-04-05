using Hospital.Common;
using Hospital.Dto;
using Hospital.Dto.Input;
using Hospital.Services.Department;
using Hospital.Services.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class EditEmployeeForm : BaseForm
    {
        private readonly IEmployeeService _employeeService;
        private readonly EmployeesForm _departmentForm;
        private int _departmentId;
        private readonly int _entityId;
        private IDepartmentService _departmentService { get; }

        public EditEmployeeForm(EmployeeDto entity, EmployeesForm employeesForm)
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
            _departmentForm = employeesForm;
            _departmentId = entity.DepartmentId;
            _entityId = entity.Id;
            _departmentService = new DepartmentService();

            InitFields(entity);
            InitAutoComlete(entity.Department);
        }

        private void InitFields(EmployeeDto entity)
        {
            firstNameInput.Text = entity.FirstName;
            secondNameInput.Text = entity.LastName;
            patronymicInput.Text = entity.Patronymic;
            cabinetInput.Text = entity.Cabinet;
            scheduleInput.Text = entity.Schedule;
        }

        private void InitAutoComlete(DepartmentDto currentDepartment)
        {
            suggestDepartmentInput.AllowDrop = true;
            suggestDepartmentInput.DropDownStyle = ComboBoxStyle.DropDownList;

            suggestDepartmentInput.Enabled = false;
            suggestDepartmentInput.DataSource = new List<DepartmentDto> { currentDepartment };
            Task.Run(async () =>
            {
                var items = (await _departmentService.GetListAsync(currentDepartment.TherapeuticInstitutionsId)).ToList();

                suggestDepartmentInput.BeginInvoke(new Action(() =>
                {
                    suggestDepartmentInput.DataSource = items;
                    suggestDepartmentInput.Enabled = true;
                    suggestDepartmentInput.SelectedItem = items.First(u => u.Id == currentDepartment.Id);
                }));
            });

            suggestDepartmentInput.SelectedValueChanged += (s, a) =>
            {
                var department = suggestDepartmentInput.SelectedItem as DepartmentDto;
                if (department == null)
                    return;

                _departmentId = department.Id;
            };
        }

        //TODO: move to helper
        private bool Validation()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(firstNameInput.Text))
            {
                errorProvider.SetError(firstNameInput, "Поле обязательно для ввода");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(secondNameInput.Text))
            {
                errorProvider.SetError(secondNameInput, "Поле обязательно для ввода");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(patronymicInput.Text))
            {
                errorProvider.SetError(patronymicInput, "Поле обязательно для ввода");
                isValid = false;
            }

            return isValid;
        }

        void SetUiActivity(bool isActive)
        {
            if (IsDisposed)
                return;

            firstNameInput.Enabled = isActive;
            secondNameInput.Enabled = isActive;
            patronymicInput.Enabled = isActive;
            cabinetInput.Enabled = isActive;
            scheduleInput.Enabled = isActive;

            editButton.Enabled = isActive;
            cancelButton.Enabled = isActive;
        }

        private async void editButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (!Validation())
                return;

            try
            {
                SetUiActivity(false);

                var inputDto = new EditEmployeeDto()
                {
                   Id = _entityId,
                   Cabinet = cabinetInput.Text,
                   DepartmentId = _departmentId,
                   FirstName = firstNameInput.Text,
                   LastName = secondNameInput.Text,
                   Patronymic = patronymicInput.Text,
                   Schedule = scheduleInput.Text
                };

                var editedEntity = await _employeeService.EditAsync(inputDto);
                _departmentForm.EditEntityInList(editedEntity);
                Close();
            }
            catch (HospitalException ex)
            {
                errorProvider.SetError(editButton, ex.Message);
            }
            finally
            {
                SetUiActivity(true);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
