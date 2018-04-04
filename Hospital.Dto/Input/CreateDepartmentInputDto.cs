namespace Hospital.Dto.Input
{
    public class CreateDepartmentInputDto
    {
        public string Address { get; set; }

        public string Name { get; set; }

        public string Profile { get; set; }

        public int TherapeuticInstitutionsId { get; set; }
    }
}
