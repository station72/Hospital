using Hospital.Common;
using Hospital.Dto.Input;
using Hospital.Services.TherapeuticInstitutions;
using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class CreateInstitutionForm : Form
    {
        private readonly ITherapeuticInstitutionsService _institutionService;
        private readonly InstitutionsForm _parentForm;

        public CreateInstitutionForm(InstitutionsForm parentForm)
        {
            InitializeComponent();
            _institutionService = new TherapeuticInstitutionsService();
            _parentForm = parentForm;
        }

        private bool Validation()
        {
            var isValid = true;

            var okpo = okpoInput.Text;
            if (string.IsNullOrWhiteSpace(okpo))
            {
                errorProvider.SetError(okpoInput, "Поле обязательно для ввода");
                isValid = false;
            }

            var name = nameInput.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider.SetError(nameInput, "Поле обязательно для ввода");
                isValid = false;
            }

            var address = addressInput.Text;
            if (string.IsNullOrWhiteSpace(address))
            {
                errorProvider.SetError(addressInput, "Поле обязательно для ввода");
                isValid = false;
            }

            return isValid;
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

            if (!Validation())
            {
                return;
            }

            try
            {
                SetUiActivity(false);

                var newItem = await _institutionService.CreateNewAsync(new CreateInstitutionInputDto
                {
                    OKPO = okpoInput.Text,
                    Address = addressInput.Text,
                    Name = addressInput.Text
                });

                _parentForm.AddInsitutionToList(newItem);

                this.Close();
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

        private void CreateInstitutionForm_Load(object sender, EventArgs e)
        {

        }

        private void okpoLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void okpoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
