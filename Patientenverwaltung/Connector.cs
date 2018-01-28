using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Patientenverwaltung
{
    /// <summary>
    /// Connector class for Data Manipulation abstraction. The API exposes one Interface to create,read, update and delete data.
    /// The Connector could change a database, file or whatever is used to sotre data
    /// From Outside this information is hidden.
    /// </summary>
    static class Connector
    {
        
        public static void Create(Model model)
        {
            var json = JsonConvert.SerializeObject(model);

            Console.WriteLine(json);
        }

        public static void Read()
        {
            
        }
    }
}
