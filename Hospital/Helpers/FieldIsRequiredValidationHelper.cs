using System.Collections.Generic;
using System.Windows.Forms;

namespace Hospital.Helpers
{
    internal class FieldIsRequiredValidationHelper : IFieldIsRequiredValidationHelper
    {
        private readonly List<TextBox> _list;
        private readonly ErrorProvider _errorProvider;


        public FieldIsRequiredValidationHelper(ErrorProvider errorProvider, List<TextBox> list)
        {
            _errorProvider = errorProvider;
            _list = list;
        }

        public bool Validate()
        {
            var isValid = true;
            foreach (var item in _list)
            {
                if (string.IsNullOrWhiteSpace(item.Text))
                {
                    _errorProvider.SetError(item, "Поле обязательно для ввода!");
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}
