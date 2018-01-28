using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung
{
    public class Treatment : Model
    {
        [Key]
        [Column(Order = 1)]
        public DateTime Date { get; set; }
        [Key]
        [Column(Order = 2)]
        public int Number {get; set; }

        public String Description { get; set; }
        public String Other { get; set; }
    }
}
