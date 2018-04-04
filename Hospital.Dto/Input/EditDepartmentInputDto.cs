namespace Hospital.Dto.Input
{
    public class EditDepartmentInputDto
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public string Name { get; set; }

        public string Profile { get; set; }

        public int TherapeuticInstitutionsId { get; set; }
    }
}
