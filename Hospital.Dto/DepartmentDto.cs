namespace Hospital.Dto
{
    public class DepartmentDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Profile { get; set; }

        public string Address { get; set; }

        public int TherapeuticInstitutionsId { get; set; }

        public TherapeuticInstitutionDto TherapeuticInstitution { get; set; }
    }
}
