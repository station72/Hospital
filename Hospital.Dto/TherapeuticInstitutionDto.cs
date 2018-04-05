using Hospital.Common;

namespace Hospital.Dto
{
    public class TherapeuticInstitutionDto : IIdEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string OKPO { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
