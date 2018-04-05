using Hospital.Data.Model;
using System.Data.Entity;

namespace Hospital.Data
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=Hospital;User ID=station72;Password=111111")
        {
            //http://robsneuron.blogspot.com/2013/11/entity-framework-upgrade-to-6.html
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<TherapeuticInstitutions> TherapeuticInstitutions { get; set; }

        public DbSet<Departments> Departments { get; set; }

        public DbSet<Employees> Employees { get; set; }

        public DbSet<Users> Users { get; set; }
    }
}
