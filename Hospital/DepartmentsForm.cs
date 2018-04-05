using Hospital.Data.Enums;
using Hospital.Dto;
using Hospital.Helpers;
using Hospital.Services.Department;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class DepartmentsForm : BaseForm
    {
        private readonly IDepartmentService _departmentService;
        private readonly TherapeuticInstitutionDto _institution;
        private readonly IObjectListUpdateHelper _listUpdateHelper;

        private DepartmentDto _selected;

        public DepartmentsForm(TherapeuticInstitutionDto institution)
        {
            InitializeComponent();

            _institution = institution;

            _listUpdateHelper = new ObjectListUpdateHelper();

            objectListView.MultiSelect = false;
            objectListView.FullRowSelect = true;
            objectListView.SelectedIndexChanged += ObjectListView_SelectedIndexChanged;

            SetEnabledSelectedItemButton(false);

            _departmentService = new DepartmentService();

            InitControls();

        }

        void SetEnabledSelectedItemButton(bool isEnabled)
        {
            editButton.Enabled = isEnabled;
            deleteButton.Enabled = isEnabled;
            showPersonalButton.Enabled = isEnabled;
            detailsButton.Enabled = isEnabled;
        }

        //TODO: move to helper
        private void ObjectListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = objectListView.SelectedObject as DepartmentDto;
            _selected = item;

            if (item == null)
            {
                SetEnabledSelectedItemButton(false);
                return;
            }

            SetEnabledSelectedItemButton(true);
        }

        private void InitControls()
        {
            Text = $"Отделения леч. учреждения {_institution.Name}";

            if (CurrentUser.Role == UserRoles.User)
            {
                addButton.Visible = false;
                editButton.Visible = false;
                deleteButton.Visible = false;
            }
            else
            {
                detailsButton.Visible = false;
            }

            Cursor = Cursors.WaitCursor;
            Task.Run(async () =>
            {
                var list = await _departmentService.GetListAsync(_institution.Id);
                objectListView.SetObjects(list);
                Cursor = Cursors.Default;
            });
        }

        internal void EditEntityInList(DepartmentDto editedEntity)
        {
            if (editedEntity.TherapeuticInstitutionsId != _institution.Id)
            {
                objectListView.RemoveObject(_selected);
                _selected = null;
                return;
            }
            _selected = editedEntity;
            _listUpdateHelper.EditEntityInList(editedEntity, objectListView);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var createForm = new CreateDepartmentForm(this, _institution.Id);
            createForm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (_selected == null)
                return;

            _selected.TherapeuticInstitution = _institution;
            var editForm = new EditDepartmentForm(_selected, this);
            editForm.ShowDialog();
        }

        internal void AddDepartmentToList(DepartmentDto newItem)
        {
            objectListView.AddObject(newItem);
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (_selected == null)
                return;

            try
            {
                SetUiActivity(false);

                await _departmentService.DeleteAsync(_selected.Id);

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

        private void SetUiActivity(bool isActive)
        {
            objectListView.Enabled = isActive;

            addButton.Enabled = isActive;
            editButton.Enabled = isActive;
            deleteButton.Enabled = isActive;
            showPersonalButton.Enabled = isActive;
        }

        private void showPersonalButton_Click(object sender, EventArgs e)
        {
            if (_selected == null)
                return;

            var employeesForm = new EmployeesForm(_selected, _institution);
            employeesForm.ShowDialog();
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            if (_selected == null)
                return;

            var form = new DetailsDepartmentForm(_selected);
            form.ShowDialog();
        }
    }
}
