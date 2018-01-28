using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Patientenverwaltung
{
    /// <summary>
    /// Connector class for Data Manipulation abstraction. The API exposes one Interface to create,read, update and delete data.
    /// The Connector could change a database, file or whatever is used to sotre data
    /// From Outside this information is hidden.
    /// </summary>
    static class Connector
    {
        private static JObject _jObject;
        public static bool Initialized { get; set; }
        public static string SaveType { get; set; }
        public static string SaveLocation { get; set; }

        public static void Create(Model model)
        {           
            if (!Initialized) Initialize();

            if (SaveType.Equals("JSON"))
            {
                CreateJson(model);
                
            }
            else if (SaveType.Equals("SQL"))
            {
                CreateSql(model);
            }
            else if (SaveType.Equals("XML"))
            {
                CreateXml(model);
            }            
        }

        private static void CreateXml(Model model)
        {
            throw new NotImplementedException();
        }

        private static void CreateSql(Model model)
        {
            throw new NotImplementedException();
        }

        private static void CreateJson(Model model)
        {
            var json = JsonConvert.SerializeObject(model);

            Console.WriteLine(json);
        }

        private static void Initialize()
        {
            if (SaveType.Equals("JSON"))
            {
                InitializeJson();

            }
            else if (SaveType.Equals("SQL"))
            {
                InitializeSql();
            }
            else if (SaveType.Equals("XML"))
            {
                InitializeXml();
            }

            Initialized = true;
        }

        private static void InitializeXml()
        {
            throw new NotImplementedException();
        }

        private static void InitializeSql()
        {
            throw new NotImplementedException();
        }

        private static void InitializeJson()
        {
            _jObject = JObject.Parse(
                File.ReadAllText($@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Doctor.json"));
        }


        public static void Read()
        {
            
        }
    }
}
