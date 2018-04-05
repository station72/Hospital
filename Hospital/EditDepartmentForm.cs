using Hospital.Common;
using Hospital.Dto;
using Hospital.Dto.Input;
using Hospital.Services.Department;
using Hospital.Services.Institution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class EditDepartmentForm : Form
    {
        private readonly int _entityId;
        private int _institutionId;
        private readonly IDepartmentService _departmentService;
        private readonly ITherapeuticInstitutionsService _institutionService;
        private readonly DepartmentsForm _departmentsForm;

        public EditDepartmentForm(
            DepartmentDto entity,
            DepartmentsForm departmentsForm)
        {
            _entityId = entity.Id;
            _institutionId = entity.TherapeuticInstitutionsId;
            _departmentService = new DepartmentService();
            _institutionService = new TherapeuticInstitutionsService();
            _departmentsForm = departmentsForm;

            InitializeComponent();
            InitFields(entity);
            InitAutoComlete(entity.TherapeuticInstitution);
        }

        private void InitAutoComlete(TherapeuticInstitutionDto currentInstitution)
        {
            suggestInstitutionInput.AllowDrop = true;
            suggestInstitutionInput.DropDownStyle = ComboBoxStyle.DropDownList;

            suggestInstitutionInput.Enabled = false;
            suggestInstitutionInput.DataSource = new List<TherapeuticInstitutionDto> { currentInstitution };
            Task.Run(async () =>
            {
                var items = (await _institutionService.GetListAsync()).ToList();

                suggestInstitutionInput.BeginInvoke(new Action(() =>
                {
                    suggestInstitutionInput.DataSource = items;
                    suggestInstitutionInput.Enabled = true;
                    suggestInstitutionInput.SelectedItem = items.First(u => u.Id == currentInstitution.Id);
                }));
            });

            suggestInstitutionInput.SelectedValueChanged += (s, a) =>
            {
                var currentInstituition = suggestInstitutionInput.SelectedItem as TherapeuticInstitutionDto;
                if (currentInstituition == null)
                    return;

                _institutionId = currentInstituition.Id;
            };
        }

        private void InitFields(DepartmentDto entity)
        {
            nameInput.Text = entity.Name;
            addressInput.Text = entity.Address;
            profileInput.Text = entity.Profile;
        }

        private async void editButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (!Validation())
                return;

            try
            {
                SetUiActivity(false);

                var inputDto = new EditDepartmentInputDto()
                {
                    Id = _entityId,
                    Address = addressInput.Text,
                    Name = nameInput.Text,
                    Profile = profileInput.Text,
                    TherapeuticInstitutionsId = _institutionId
                };

                var editedEntity = await _departmentService.EditAsync(inputDto);
                _departmentsForm.EditEntityInList(editedEntity);
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

        private bool Validation()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(profileInput.Text))
            {
                errorProvider.SetError(profileInput, "Поле обязательно для ввода");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(nameInput.Text))
            {
                errorProvider.SetError(nameInput, "Поле обязательно для ввода");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(addressInput.Text))
            {
                errorProvider.SetError(addressInput, "Поле обязательно для ввода");
                isValid = false;
            }

            return isValid;
        }

        void SetUiActivity(bool isActive)
        {
            if (IsDisposed)
                return;

            profileInput.Enabled = isActive;
            nameInput.Enabled = isActive;
            addressInput.Enabled = isActive;

            editButton.Enabled = isActive;
            cancelButton.Enabled = isActive;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
