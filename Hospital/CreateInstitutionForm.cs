using Hospital.Common;
using Hospital.Dto.Input;
using Hospital.Helpers;
using Hospital.Services.Institution;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hospital
{
    public partial class CreateInstitutionForm : BaseForm
    {
        private readonly ITherapeuticInstitutionsService _institutionService;
        private readonly InstitutionsForm _parentForm;
        private readonly IFieldIsRequiredValidationHelper _validHelper;

        public CreateInstitutionForm(InstitutionsForm parentForm)
        {
            InitializeComponent();
            _institutionService = new TherapeuticInstitutionsService();
            _parentForm = parentForm;

            _validHelper = new FieldIsRequiredValidationHelper(errorProvider, new List<TextBox>
            {
               addressInput, nameInput, okpoInput
            });
        }

        private void SetUiActivity(bool isActive)
        {
            if (IsDisposed)
                return;

            okpoInput.Enabled = isActive;
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

                var newItem = await _institutionService.CreateNewAsync(new CreateInstitutionInputDto
                {
                    OKPO = okpoInput.Text,
                    Address = addressInput.Text,
                    Name = nameInput.Text
                });

                _parentForm.AddInsitutionToList(newItem);

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