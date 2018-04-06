using Hospital.Common;
using Hospital.Dto.Input;
using Hospital.Helpers;
using Hospital.Services.Employee;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hospital
{
    public partial class CreateEmployeeForm : BaseForm
    {
        private readonly IEmployeeService _employeeService;
        private readonly IFieldIsRequiredValidationHelper _validHelper;
        private readonly EmployeesForm _parentForm;
        private readonly int _departmentId;

        public CreateEmployeeForm(EmployeesForm employeesForm, int departmentId)
        {
            InitializeComponent();

            _departmentId = departmentId;
            _parentForm = employeesForm;
            _employeeService = new EmployeeService();
            _validHelper = new FieldIsRequiredValidationHelper(errorProvider, new List<TextBox>
            {
               firstNameInput, patronymicInput, secondNameInput
            });
        }

        //TODO: move to helper
        private void SetUiActivity(bool isActive)
        {
            if (IsDisposed)
                return;

            firstNameInput.Enabled = isActive;
            secondNameInput.Enabled = isActive;
            patronymicInput.Enabled = isActive;
            cabinetInput.Enabled = isActive;
            scheduleInput.Enabled = isActive;

            createButton.Enabled = isActive;
        }

        private async void createButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (!_validHelper.Validate())
                return;

            try
            {
                SetUiActivity(false);

                var newItem = await _employeeService.CreateNewAsync(new CreateEmployeeInputDto
                {
                    FirstName = firstNameInput.Text,
                    LastName = secondNameInput.Text,
                    Patronymic = patronymicInput.Text,
                    Schedule = scheduleInput.Text,
                    Cabinet = cabinetInput.Text,
                    DepartmentId = _departmentId
                });

                _parentForm.AddEntityToList(newItem);

                Close();
            }
            catch (HospitalException ex)
            {
                errorProvider.SetError(createButton, ex.Message);
            }
            finally
            {
                SetUiActivity(true);
            }
        }
    }
}