using Hospital.Common;
using Hospital.Dto.Input;
using Hospital.Helpers;
using Hospital.Services.Department;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hospital
{
    public partial class CreateDepartmentForm : BaseForm
    {
        private readonly IDepartmentService _departmentService;
        private readonly IFieldIsRequiredValidationHelper _validHelper;
        private readonly DepartmentsForm _parentForm;
        private readonly int _therapeuticInstitutionId;

        public CreateDepartmentForm(DepartmentsForm departmentsForm, int therapeuticInstitutionId)
        {
            InitializeComponent();

            _therapeuticInstitutionId = therapeuticInstitutionId;
            _parentForm = departmentsForm;
            _departmentService = new DepartmentService();
            _validHelper = new FieldIsRequiredValidationHelper(errorProvider, new List<TextBox>
            {
               addressInput, nameInput, profileInput
            });
        }

        private void SetUiActivity(bool isActive)
        {
            if (IsDisposed)
                return;

            profileInput.Enabled = isActive;
            nameInput.Enabled = isActive;
            addressInput.Enabled = isActive;
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

                var newItem = await _departmentService.CreateNewAsync(new CreateDepartmentInputDto
                {
                    Address = addressInput.Text,
                    Name = nameInput.Text,
                    Profile = profileInput.Text,
                    TherapeuticInstitutionsId = _therapeuticInstitutionId
                });

                _parentForm.AddDepartmentToList(newItem);

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