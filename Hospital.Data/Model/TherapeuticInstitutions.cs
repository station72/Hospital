using System.Collections.Generic;

namespace Hospital.Data.Model
{
    public class TherapeuticInstitutions
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        //public string ChiefPhysician { get; set; }

        public IList<Departments> Departments { get; set; }
    }
}
