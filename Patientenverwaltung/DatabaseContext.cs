using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Patientenverwaltung
{
    class DatabaseContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<HealthInsurance> HealthInsurances { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
    }
}
