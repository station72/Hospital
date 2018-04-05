using Hospital.Dto;
using Hospital.Helpers;
using Hospital.Services.Employee;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class EmployeesForm : BaseForm
    {
        private readonly IEmployeeService _employeeService;
        private readonly ObjectListUpdateHelper _listUpdateHelper;
        private EmployeeDto _selected;
        private readonly DepartmentDto _department;
        private readonly TherapeuticInstitutionDto _institution;

        public EmployeesForm(DepartmentDto department, TherapeuticInstitutionDto institution)
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
            _listUpdateHelper = new ObjectListUpdateHelper();
            _department = department;
            _institution = institution;
            InitControls();

            objectListView.MultiSelect = false;
            objectListView.FullRowSelect = true;
            objectListView.SelectedIndexChanged += ObjectListView_SelectedIndexChanged;

            editButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        //TODO: move to helper
        private void ObjectListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = objectListView.SelectedObject as EmployeeDto;
            _selected = item;

            if (item == null)
            {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                return;
            }

            editButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void SetUiActivity(bool isActive)
        {
            addButton.Enabled = isActive;
            editButton.Enabled = isActive;
            deleteButton.Enabled = isActive;
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
                var result = await _employeeService.GetListAsync();
                objectListView.SetObjects(result);
                Cursor = Cursors.Default;
            });
        }

        internal void EditEntityInList(EmployeeDto editedEntity)
        {
            _selected = editedEntity;
            BeginInvoke(new Action(() =>
            {
                _listUpdateHelper.EditEntityInList(editedEntity, objectListView);
            }));
        }

        internal void AddEntityToList(EmployeeDto newItem)
        {
            BeginInvoke(new Action(()=> 
            {
                objectListView.AddObject(newItem);
            })) ;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var createForm = new CreateEmployeeForm(this, _department.Id);
            createForm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (_selected == null)
                return;

            var editForm = new EditEmployeeForm(_selected, this);
            editForm.ShowDialog();
        }

        private async void deleteButton_ClickAsync(object sender, EventArgs e)
        {
            if (_selected == null)
                return;

            try
            {
                SetUiActivity(false);

                await _employeeService.DeleteAsync(_selected.Id);

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
    }
}
