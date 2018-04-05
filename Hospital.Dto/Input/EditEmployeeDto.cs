namespace Hospital.Dto.Input
{
    public class EditEmployeeDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public string Schedule { get; set; }

        public string Cabinet { get; set; }

        public int DepartmentId { get; set; }
    }
}
