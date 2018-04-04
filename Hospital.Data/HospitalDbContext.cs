using Hospital.Data.Model;
using System.Data.Entity;

namespace Hospital.Data
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext() : base("Server=localhost;Database=Hospital;Trusted_Connection=Yes;")
        { }

        public DbSet<TherapeuticInstitutions> TherapeuticInstitutions { get; set; }

        public DbSet<Departments> Departments { get; set; }

        public DbSet<Employees> Employees { get; set; }

        public DbSet<Users> Users { get; set; }
    }
}
