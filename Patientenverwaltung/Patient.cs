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
        public List<String> SpecialTraits { get; set; }
        public List<Treatment> Treatments { get; set; }

        public String Key { get; set; }

        public Patient(string firstName, string secondName, string street, int streetNumber, int postalcode, string city, long insuranceId, HealthInsurance healthInsurance, DateTime bitBirthday, int phonenumber, List<string> specialTraits, List<Treatment> treatments)
        {
            FirstName = firstName;
            SecondName = secondName;
            Street = street;
            StreetNumber = streetNumber;
            Postalcode = postalcode;
            City = city;
            InsuranceID = insuranceId;
            HealthInsurance = healthInsurance;
            Birthday = bitBirthday;
            Phonenumber = phonenumber;
            SpecialTraits = specialTraits;
            Treatments = treatments;

            Key = $@"{SecondName}-{FirstName}-{Birthday}";
        }

        public Patient()
        {
            Key = $@"{SecondName}-{FirstName}-{Birthday}";
        }

        public void SetKey()
        {
            Key = $@"{SecondName}-{FirstName}-{Birthday.Date:yyyy-MM-dd}";
        }
    }
}
