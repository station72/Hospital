using Hospital.Data.Enums;
using Hospital.Dto;
using Hospital.Services.Department;
using System;
using System.Threading.Tasks;

namespace Hospital
{
    public partial class DepartmentsForm : BaseForm
    {
        private readonly IDepartmentService _departmentService;
        private readonly int _institutionId;

        private DepartmentDto _selected;

        public DepartmentsForm(int institutionId)
        {
            _institutionId = institutionId;
            InitializeComponent();

            objectListView.MultiSelect = false;
            objectListView.FullRowSelect = true;
            objectListView.SelectedIndexChanged += ObjectListView_SelectedIndexChanged;

            editButton.Enabled = false;
            deleteButton.Enabled = false;

            _departmentService = new DepartmentService();

            InitControls();
        }

        //TODO: move to helper
        private void ObjectListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = objectListView.SelectedObject as DepartmentDto;
            _selected = item;

            if (item == null)
            {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                showPersonalButton.Enabled = false;
                return;
            }

            editButton.Enabled = true;
            deleteButton.Enabled = true;
            showPersonalButton.Enabled = true;
        }

        private void InitControls()
        {
            if (CurrentUser.Role == UserRoles.User)
            {
                addButton.Visible = false;
                editButton.Visible = false;
                deleteButton.Visible = false;
            }

            Task.Run(async () =>
            {
                var list = await _departmentService.GetListAsync(_institutionId);
                objectListView.SetObjects(list);
            });
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var createForm = new CreateDepartmentForm(this, _institutionId);
            createForm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (_selected == null)
                return;

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
    }
}
