using Hospital.Dto;
using Hospital.Services.TherapeuticInstitutions;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class InstitutionsForm : BaseForm
    {
        private readonly ITherapeuticInstitutionsService _institutionsService;

        private TherapeuticInstitutionDto _selected;

        public InstitutionsForm()
        {
            InitializeComponent();
            _institutionsService = new TherapeuticInstitutionsService();
            InitControls();

            objectListView.MultiSelect = false;
            objectListView.FullRowSelect = true;
            objectListView.SelectedIndexChanged += ObjectListView_SelectedIndexChanged;

            editButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void ObjectListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = objectListView.SelectedObject as TherapeuticInstitutionDto;

            if (item == null)
            {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                return;
            }

            _selected = item;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        void SetUiActivity(bool isActive)
        {
            addButton.Enabled = isActive;
            editButton.Enabled = isActive;
            deleteButton.Enabled = isActive;
        }

        private void InitControls()
        {
            if (CurrentUser.Role == Data.Enums.UserRoles.User)
            {
                addButton.Visible = false;
                editButton.Visible = false;
                deleteButton.Visible = false;
            }

            Task.Run(async () =>
            {
                var result = await _institutionsService.GetInstitutionsAsync();
                objectListView.SetObjects(result);
            });
        }

        private void InstitutionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Debug.Print("InstitutionsForm_FormClosed");
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (_selected == null)
                return;

            try
            {
                SetUiActivity(false);

                await _institutionsService.DeleteAsync(_selected.Id);

                objectListView.RemoveObject(_selected);
                _selected = null;
            }
            catch (Exception ex)
            {
                                
            }
            finally
            {
                SetUiActivity(true);
            }
        }

        internal void AddInsitution(TherapeuticInstitutionDto newItem)
        {
            objectListView.AddObject(newItem);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var createForm = new CreateInstitutionForm(this);
            createForm.ShowDialog();
        }
    }
}
