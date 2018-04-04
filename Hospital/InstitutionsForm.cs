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
                var result = await _institutionsService.GetInstitutionsAsync();
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
            var rowIndex = GetRowIndex(editedEntity.Id);
            if (!rowIndex.HasValue)
            {
                Debug.Fail($"Row index has not been found. Entity id {editedEntity.Id}");
                return;
            }

            var listItem = objectListView.GetItem(rowIndex.Value);
            listItem.RowObject = editedEntity;
        }

        private int? GetRowIndex(int institutionId)
        {
            for (int i = 0; i < objectListView.GetItemCount(); i++)
            {
                var item = objectListView.GetItem(i);
                var institution = item.RowObject as TherapeuticInstitutionDto;
                if (institution.Id == institutionId)
                {
                    return i;
                }
            }

            return null;
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
            deparmentsForm.Show();
        }
    }
}
