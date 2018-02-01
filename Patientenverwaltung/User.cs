using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patientenverwaltung
{
    class User
    {
        private String _username;
        private String _password;

        [Key]
        [Column(Order = 1)]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
