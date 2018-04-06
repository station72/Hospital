using Hospital.Common;
using Hospital.Dto;
using Hospital.Dto.Input;
using Hospital.Helpers;
using Hospital.Services.Institution;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hospital
{
    public partial class EditInstitutionForm : BaseForm
    {
        private readonly IFieldIsRequiredValidationHelper _validHelper;
        private readonly int _entityId;
        private readonly ITherapeuticInstitutionsService _institutionService;
        private readonly InstitutionsForm _institutionsForm;

        public EditInstitutionForm(TherapeuticInstitutionDto entity, InstitutionsForm institutionsForm)
        {
            InitializeComponent();
            
            ControlBox = false;
            InitControls(entity);
            _validHelper = new FieldIsRequiredValidationHelper(errorProvider, new List<TextBox>
            {
               addressInput, nameInput, okpoInput
            });

            _entityId = entity.Id;
            _institutionsForm = institutionsForm;
            _institutionService = new TherapeuticInstitutionsService();
        }

        private void InitControls(TherapeuticInstitutionDto entity)
        {
            addressInput.Text = entity.Address;
            okpoInput.Text = entity.OKPO;
            nameInput.Text = entity.Name;
        }

        void SetUiActivity(bool isActive)
        {
            if (IsDisposed)
                return;

            okpoInput.Enabled = isActive;
            nameInput.Enabled = isActive;
            addressInput.Enabled = isActive;

            editButton.Enabled = isActive;
            cancelButton.Enabled = isActive;
        }

        private async void editButton_Click(object sender, System.EventArgs e)
        {
            errorProvider.Clear();

            if (!_validHelper.Validate())
                return;

            try
            {
                SetUiActivity(false);

                var inputDto = new EditInsitutionInputDto()
                {
                    Id = _entityId,
                    Address = addressInput.Text,
                    Name = nameInput.Text,
                    OKPO = okpoInput.Text
                };

                var editedEntity = await _institutionService.EditAsync(inputDto);
                _institutionsForm.EditEntityInList(editedEntity);
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

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
