using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public static bool Initialized { get; set; }
        public static string SaveType { get; set; }
        public static string SaveLocation { get; set; }

        public static List<HealthInsurance> HealthInsurances { get; private set; }

        public static List<Doctor> Doctors { get; private set; }

        // Current logged in Doctor
        public static Doctor Doctor { get; set; }

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
        public static bool Read(ref Doctor model, string extraOptions = "")
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

        public static bool Read(ref HealthInsurance model, string extraOptions = "")
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
                Doctors = list ?? new List<Doctor>();
                Doctors.Add((Doctor)model);

                var convertedJson = JsonConvert.SerializeObject(Doctors, Formatting.Indented);

                File.WriteAllText($@"{SaveLocation}\Doctor.json", convertedJson);
            }
            else if (model.GetType() == typeof(Patient))
            {
                var list = JsonConvert.DeserializeObject<List<Doctor>>(File.ReadAllText($@"{SaveLocation}\Doctor.json"));
                Doctors = list ?? new List<Doctor>();

                foreach (var doctor in Doctors)
                {
                    // Search current logged in doctor
                    if (doctor.Username != Doctor.Username) continue;

                    if (doctor.Patients == null) doctor.Patients = new List<Patient>();

                    // Search if patient already exists
                    foreach (var patient in doctor.Patients)
                    {
                        if (patient.Key == ((Patient) model).Key) throw new PatientAlreadyExistsExcepetion();
                    }

                    // Add then
                    doctor.Patients.Add((Patient)model);         
                }

                var convertedJson = JsonConvert.SerializeObject(Doctors, Formatting.Indented);

                File.WriteAllText($@"{SaveLocation}\Doctor.json", convertedJson);

            }
            else if (model.GetType() == typeof(HealthInsurance))
            {
                var list = JsonConvert.DeserializeObject<List<HealthInsurance>>(File.ReadAllText($@"{SaveLocation}\HealthInsurances.json"));
                HealthInsurances = list ?? new List<HealthInsurance>();
                HealthInsurances.Add((HealthInsurance)model);

                var convertedJson = JsonConvert.SerializeObject(HealthInsurances, Formatting.Indented);

                File.WriteAllText($@"{SaveLocation}\HealthInsurances.json", convertedJson);
            }
            var json = JsonConvert.SerializeObject(model);

            Console.WriteLine(json);
        }

        private static void InitializeJson()
        {
            if (File.Exists($@"{SaveLocation}\Doctor.json"))
            {
                var list = JsonConvert.DeserializeObject<List<Doctor>>(File.ReadAllText($@"{SaveLocation}\Doctor.json"));
                Doctors = list;
            }
            else
            {
                using (var file = File.CreateText($@"{SaveLocation}\Doctor.json"))
                {
                    // Since the file doesnt exist, we can initialize a new list 
                    Doctors = new List<Doctor>();
                }
            }

            if (File.Exists($@"{SaveLocation}\HealthInsurances.json"))
            {
                var list = JsonConvert.DeserializeObject<List<HealthInsurance>>(File.ReadAllText($@"{SaveLocation}\HealthInsurances.json"));
                HealthInsurances = list;
            }
            else
            {
                using (var file = File.CreateText($@"{SaveLocation}\HealthInsurances.json"))
                {
                    // Since the file doesnt exist, we can initialize a new list 
                    HealthInsurances = new List<HealthInsurance>();
                }
            }
        }

        private static bool ReadJson(ref Doctor model, string extraOptions = "")
        {
            try
            {
                var bRead = false;

                if (!File.Exists($@"{SaveLocation}\Doctor.json")) return false;

                var json = File.ReadAllText($@"{SaveLocation}\Doctor.json");

                if (json == string.Empty) throw new UserDoesNotExist();

                var list = JsonConvert.DeserializeObject<List<Doctor>>(json);
                Doctors = list;

                var docModel = (Doctor)model;
                foreach (var doc in Doctors)
                {
                    if (extraOptions == "password")
                    {
                        if (!doc.Username.Equals(docModel.Username) || !doc.Hash.Equals(docModel.Hash)) continue;
                        model = doc;
                        return true;
                    }
                    else
                    {
                        if (!doc.Username.Equals(docModel.Username)) continue;
                        model = doc;
                        return true;
                    }
                }



                return bRead;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
                throw new UserDoesNotExist();
            }
        }

        private static bool ReadJson(ref HealthInsurance model, string extraOptions = "")
        {
            try
            {
                var bRead = false;

                if (!File.Exists($@"{SaveLocation}\HealthInsurances.json")) return false;

                var json = File.ReadAllText($@"{SaveLocation}\HealthInsurances.json");

                if (json == string.Empty) throw new HealthInsurancesDoesNotExist();

                var list = JsonConvert.DeserializeObject<List<HealthInsurance>>(json);
                HealthInsurances = list;

                var healthInsuranceModel = (HealthInsurance)model;
                foreach (var healthInsurance in HealthInsurances)
                {
                    if (!healthInsurance.Name.Equals(healthInsuranceModel.Name)) continue;
                    model = healthInsurance;
                    return true;
                }

                return bRead;

            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
                throw new HealthInsurancesDoesNotExist();
            }
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

        private static bool ReadXml(ref Doctor model, string extraOptions)
        {
            throw new NotImplementedException();
        }

        private static bool ReadXml(ref HealthInsurance model, string extraOptions)
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

        private static bool ReadSql(ref Doctor model, string extraOptions)
        {
            throw new NotImplementedException();
        }

        private static bool ReadSql(ref HealthInsurance model, string extraOptions)
        {
            throw new NotImplementedException();
        }
        #endregion SQL 
    }

    internal class PatientAlreadyExistsExcepetion
        : Exception
    {
    }

    internal class HealthInsurancesDoesNotExist : Exception
    {
    }
}
