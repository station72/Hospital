﻿using Hospital.Common;
using Hospital.Dto.Input;
using Hospital.Services.Institution;
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
