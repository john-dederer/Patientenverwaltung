using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patientenverwaltung
{
    public enum StatusHealthInsurance
    {
        Private,
        ByLaw
    }


    public class HealthInsurance : Model
    {
        [Key]
        [Column(Order = 1)]
        public String Name { get; set; }
        public long InsuranceID { get; set; }
        public String Street { get; set; }
        public int StreetNumber { get; set; }
        public int Postalcode { get; set; }
        public String City { get; set; }
        public StatusHealthInsurance State { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}