using Hospital.Dto;
using System.Windows.Forms;

namespace Hospital
{
    public partial class DetailInstitutionForm : Form
    {
        public DetailInstitutionForm(TherapeuticInstitutionDto entity)
        {
            InitializeComponent();
            InitControls(entity);
        }

        private void InitControls(TherapeuticInstitutionDto entity)
        {
            Text = $"Лечебное учреждение {entity.Name}" ;

            addressInput.Text = entity.Address;
            nameInput.Text = entity.Name;
            okpoInput.Text = entity.Name;

            addressInput.Enabled = false;
            nameInput.Enabled = false;
            okpoInput.Enabled = false;
        }
    }
}
