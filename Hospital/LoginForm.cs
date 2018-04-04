using Hospital.Common;
using Hospital.Services.User;
using System;

namespace Hospital
{
    public partial class LoginForm : BaseForm
    {
        private readonly IUserService _userService;

        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void SetUiActivity(bool activity)
        {
            if (IsDisposed)
                return;

            PassInput.ReadOnly = !activity;
            UserNameInput.ReadOnly = !activity;
            EnterButton.Enabled = activity;
        }

        private bool Validation()
        {
            var isValid = true;
            var password = PassInput.Text;
            if (string.IsNullOrWhiteSpace(password))
            {
                errorProvider.SetError(PassInput, "Зполните поле");
                isValid = false;
            }

            var login = UserNameInput.Text;
            if (string.IsNullOrWhiteSpace(login))
            {
                errorProvider.SetError(UserNameInput, "Зполните поле");
                isValid = false;
            }

            return isValid;
        }

        private async void EnterButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            var isValid = Validation();
            if (!isValid)
                return;

            try
            {
                SetUiActivity(false);

                var user = await _userService.Enter(UserNameInput.Text, PassInput.Text);
                CurrentUser = user;

                Hide();
                var instForm = new InstitutionsForm();
                instForm.Show();
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
