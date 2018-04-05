using Hospital.Common;
using Hospital.Dto.Input;
using Hospital.Services.Department;
using System;

namespace Hospital
{
    public partial class CreateDepartmentForm : BaseForm
    {
        private readonly IDepartmentService _departmentService;
        private readonly DepartmentsForm _parentForm;
        private readonly int _therapeuticInstitutionId;

        public CreateDepartmentForm(DepartmentsForm departmentsForm, int therapeuticInstitutionId)
        {
            InitializeComponent();
            _therapeuticInstitutionId = therapeuticInstitutionId;
            _parentForm = departmentsForm;
            _departmentService = new DepartmentService();
        }

        //TODO: move to helper
        private bool Validation()
        {
            var isValid = true;

            var okpo = profileInput.Text;
            if (string.IsNullOrWhiteSpace(okpo))
            {
                errorProvider.SetError(profileInput, FieldIsRequiredMessage);
                isValid = false;
            }

            var name = nameInput.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider.SetError(nameInput, FieldIsRequiredMessage);
                isValid = false;
            }

            var address = addressInput.Text;
            if (string.IsNullOrWhiteSpace(address))
            {
                errorProvider.SetError(addressInput, FieldIsRequiredMessage);
                isValid = false;
            }

            return isValid;
        }

        //TODO: move to helper
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

            if (!Validation())
            {
                return;
            }

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
