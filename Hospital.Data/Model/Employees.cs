using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Data.Model
{
    public class Employees
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public string Schedule { get; set; }

        public string Cabinet { get; set; }

        public int DepartmentId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public Departments Department { get; set; }
    }
}
