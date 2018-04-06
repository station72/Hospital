using Hospital.Common;
using Hospital.Helpers;
using Hospital.Services.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class LoginForm : BaseForm
    {
        private readonly IUserService _userService;
        private readonly IFieldIsRequiredValidationHelper _validHelper;

        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();

            _validHelper = new FieldIsRequiredValidationHelper(errorProvider, new List<TextBox>
            {
                PassInput, UserNameInput
            });
        }

        private void SetUiActivity(bool isActive)
        {
            if (IsDisposed)
                return;

            PassInput.Enabled = isActive;
            UserNameInput.Enabled = isActive;
            EnterButton.Enabled = isActive;
        }

        private async void EnterButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (!_validHelper.Validate())
                return;

            try
            {
                SetUiActivity(false);

                await Task.Run(async () =>
                {
                    var user = await _userService.EnterAsync(UserNameInput.Text, PassInput.Text);
                    CurrentUser = user;
                    
                }).ContinueWith((a)=> 
                {
                    BeginInvoke(new Action(() =>
                    {
                        Hide();
                        var instForm = new InstitutionsForm();
                        instForm.Show();
                    }));
                });

            }
            catch (HospitalException ex)
            {
                errorProvider.SetError(EnterButton, ex.Message);
            }
            finally
            {
                SetUiActivity(true);
            }
        }
    }
}
