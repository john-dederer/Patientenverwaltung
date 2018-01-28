using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung
{
    public class Patient : Model
    {
        [Key]
        [Column(Order = 1)]
        public String FirstName { get; set; }

        [Key]
        [Column(Order = 2)]
        public String SecondName { get; set; }
        public String Street { get; set; }
        public int StreetNumber { get; set; }
        public int Postalcode { get; set; }
        public String City { get; set; }
        public long InsuranceID { get; set; }
        public HealthInsurance HealthInsurance { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime Birthday { get; set; }
        public int Phonenumber { get; set; }
        public virtual List<String> SpecialTraits { get; set; }
        public List<Treatment> Treatments { get; set; }
    }
}
