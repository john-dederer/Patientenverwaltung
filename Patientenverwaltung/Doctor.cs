using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung
{
    internal class Doctor : Model
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Username { get; set; }
        public string Hash { get; set; }

        public List<Patient> Patients { get; set; }
    }
}
