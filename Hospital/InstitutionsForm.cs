using Hospital.Dto;
using Hospital.Helpers;
using Hospital.Services.Institution;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class InstitutionsForm : BaseForm
    {
        private readonly ITherapeuticInstitutionsService _institutionsService;
        private readonly ObjectListUpdateHelper _listUpdateHelper;
        private TherapeuticInstitutionDto _selected;

        public InstitutionsForm()
        {
            InitializeComponent();
            _institutionsService = new TherapeuticInstitutionsService();
            _listUpdateHelper = new ObjectListUpdateHelper();
            InitControls();

            objectListView.MultiSelect = false;
            objectListView.FullRowSelect = true;
            objectListView.SelectedIndexChanged += ObjectListView_SelectedIndexChanged;

            editButton.Enabled = false;
            deleteButton.Enabled = false;
            showDepartmentsButton.Enabled = false;
        }

        //TODO: move to helper
        private void ObjectListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = objectListView.SelectedObject as TherapeuticInstitutionDto;
            _selected = item;

            if (item == null)
            {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                showDepartmentsButton.Enabled = false;
                return;
            }

            editButton.Enabled = true;
            deleteButton.Enabled = true;
            showDepartmentsButton.Enabled = true;
        }

        private void SetUiActivity(bool isActive)
        {
            addButton.Enabled = isActive;
            editButton.Enabled = isActive;
            deleteButton.Enabled = isActive;
            showDepartmentsButton.Enabled = isActive;
            objectListView.Enabled = isActive;
        }

        private void InitControls()
        {
            if (CurrentUser.Role == Data.Enums.UserRoles.User)
            {
                addButton.Visible = false;
                editButton.Visible = false;
                deleteButton.Visible = false;
            }

            Cursor = Cursors.WaitCursor;
            Task.Run(async () =>
            {
                var result = await _institutionsService.GetListAsync();
                objectListView.SetObjects(result);
                Cursor = Cursors.Default;
            });
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
            catch (Exception)
            {
            }
            finally
            {
                SetUiActivity(true);
            }
        }

        internal void EditEntityInList(TherapeuticInstitutionDto editedEntity)
        {
            _selected = editedEntity;
            _listUpdateHelper.EditEntityInList(editedEntity, objectListView);
        }

        internal void AddInsitutionToList(TherapeuticInstitutionDto newItem)
        {
            objectListView.AddObject(newItem);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var createForm = new CreateInstitutionForm(this);
            createForm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (_selected == null)
                return;

            var editForm = new EditInstitutionForm(_selected, this);
            editForm.ShowDialog();
        }

        private void showDepartmentsButton_Click(object sender, EventArgs e)
        {
            if (_selected == null)
                return;

            var deparmentsForm = new DepartmentsForm(_selected.Id);
            deparmentsForm.ShowDialog();
        }
    }
}
