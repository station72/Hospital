using Hospital.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Data.Model
{
    public class Departments : IDeletable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Profile { get; set; }

        public int TherapeuticInstitutionsId { get; set; }

        public string Address { get; set; }

        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(TherapeuticInstitutionsId))]
        public TherapeuticInstitutions TherapeuticInstitution { get; set; }
    }
}
