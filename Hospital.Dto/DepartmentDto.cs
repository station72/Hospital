using Hospital.Common;

namespace Hospital.Dto
{
    public class DepartmentDto : IIdEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Profile { get; set; }

        public string Address { get; set; }

        public int TherapeuticInstitutionsId { get; set; }

        public TherapeuticInstitutionDto TherapeuticInstitution { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
