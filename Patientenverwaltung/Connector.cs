﻿using System;
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
        private static List<Doctor> _doctors;
        public static bool Initialized { get; set; }
        public static string SaveType { get; set; }
        public static string SaveLocation { get; set; }

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

        /// <summary>
        /// Return true if Object is in datastore. Modifies the given object
        /// </summary>
        /// <returns></returns>
        public static bool Read(Model model, string extraOptions = "")
        {
            if (!Initialized) Initialize();

            var bRead = false;

            if (SaveType.Equals("JSON"))
            {
                bRead = ReadJson(ref model, extraOptions);

            }
            else if (SaveType.Equals("SQL"))
            {
                bRead = ReadSql(ref model, extraOptions);
            }
            else if (SaveType.Equals("XML"))
            {
                bRead = ReadXml(ref model, extraOptions);
            }

            return bRead;
        }

        #region JSON
        private static void CreateJson(Model model)
        {
            if (model.GetType() == typeof(Doctor))
            {                
                var list = JsonConvert.DeserializeObject<List<Doctor>>(File.ReadAllText($@"{SaveLocation}\Doctor.json"));
                _doctors = list;
                _doctors.Add((Doctor)model);

                var convertedJson = JsonConvert.SerializeObject(_doctors, Formatting.Indented);

                File.WriteAllText($@"{SaveLocation}\Doctor.json", convertedJson);
            }
            else if (model.GetType() == typeof(Patient))
            {
                
            }
            else if (model.GetType() == typeof(HealthInsurance))
            {

            }
            var json = JsonConvert.SerializeObject(model);

            Console.WriteLine(json);
        }

        private static void InitializeJson()
        {
            if (File.Exists($@"{SaveLocation}\Doctor.json"))
            {
                var list = JsonConvert.DeserializeObject<List<Doctor>>(File.ReadAllText($@"{SaveLocation}\Doctor.json"));
                _doctors = list;
            }
            else
            {
                using (var file = File.CreateText($@"{SaveLocation}\Doctor.json"))
                {
                    // Since the file doesnt exist, we can initialize a new list 
                    _doctors = new List<Doctor>();
                }
            }            
        }

        private static bool ReadJson(ref Model model, string extraOptions)
        {
            var bRead = false;

            if (model.GetType() == typeof(Doctor))
            {
                if (!File.Exists($@"{SaveLocation}\Doctor.json")) return false;
                /*
                IList<Doctor> doctors = new List<Doctor>();

                var reader =
                    new JsonTextReader(new StringReader(File.ReadAllText($@"{SaveLocation}\Doctor.json")))
                    {
                        SupportMultipleContent = true
                    };

                while (true)
                {
                    if (!reader.Read())
                    {
                        break;
                    }

                    var serializer = new JsonSerializer();

                    var doctor = serializer.Deserialize<Doctor>(reader);
                    doctors.Add(doctor);
                }

                foreach (var doc in doctors)
                {
                    if (!doc.Username.Equals(((Doctor)model).Username)) continue;
                    if (!doc.Hash.Equals(((Doctor)model).Hash)) continue;
                    model = doc;
                    bRead = true;
                }
                */
                var json = File.ReadAllText($@"{SaveLocation}\Doctor.json");
                var list = JsonConvert.DeserializeObject<List<Doctor>>(json);
                _doctors = list;

                foreach (var doc in _doctors)
                {
                    return doc.Username == ((Doctor) model).Username;
                }
            }
            else if (model.GetType() == typeof(Patient))
            {

            }
            else if (model.GetType() == typeof(HealthInsurance))
            {

            }

            return bRead;
        }
        #endregion JSON

        #region XML
        private static void CreateXml(Model model)
        {
            throw new NotImplementedException();
        }

        private static void InitializeXml()
        {
            throw new NotImplementedException();
        }

        private static bool ReadXml(ref Model model, string extraOptions)
        {
            throw new NotImplementedException();
        }
        #endregion XML

        #region SQL
        private static void CreateSql(Model model)
        {
            throw new NotImplementedException();
        }

        private static void InitializeSql()
        {
            throw new NotImplementedException();
        }

        private static bool ReadSql(ref Model model, string extraOptions)
        {
            throw new NotImplementedException();
        }
        #endregion SQL 
    }
}
