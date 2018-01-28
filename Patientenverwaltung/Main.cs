using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Patientenverwaltung
{
    public partial class Main : Form
    {
        public Patient Patient { get; set; }
        public HealthInsurance HealthInsurance { get; set; }
        //public string UsersJsonPath { get; set; }
        //public string PatientJsonPath { get; set; }
        //public string HealthInsuranceJsonPath { get; set; }
        //public string TreatmentJsonPath { get; set; }
        public string DoctorJsonPath { get; set; }
        public Doctor Doctor { get; set; }

        public Main()
        {
            InitializeComponent();

            createPatientCtrl1  .SetParent(this);
            healthInsuranceCtrl1.SetParent(this);
            Patient = new Patient();
            HealthInsurance = new HealthInsurance();

            // Look for JSON Path
            InitializeJson();            
        }

        public Main(Doctor doctor) : this()
        {
            Doctor = doctor;

            this.Text = $@"{Doctor.Username} ist eingeloggt";
        }

        private void InitializeJson()
        {
            //var user = JObject.Parse(File.ReadAllText($@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Users.json"));
            //UsersJsonPath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Users.json";
            //PatientJsonPath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Patient.json";
            //HealthInsuranceJsonPath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\HealthInsurance.json";
            //TreatmentJsonPath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Treatment.json";
            DoctorJsonPath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Doctor.json";

            // Read JSON from File or Create if necessary
            //if (!File.Exists(UsersJsonPath))           { CreateJsonFile(UsersJsonPath); }
            //if (!File.Exists(PatientJsonPath))         { CreateJsonFile(PatientJsonPath); }
            //if (!File.Exists(HealthInsuranceJsonPath)) { CreateJsonFile(HealthInsuranceJsonPath); }
            //if (!File.Exists(TreatmentJsonPath))       { CreateJsonFile(TreatmentJsonPath); }
            if (!File.Exists(DoctorJsonPath))          { CreateJsonFile(DoctorJsonPath); }
        }

        private static void CreateJsonFile(string jsonPath)
        {
            using (var file = File.CreateText(jsonPath))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file,"{}");
            }
        }

        private void txtBoxSearchPatient_TextChanged(object sender, EventArgs e)
        {
            // Search for patient
            if (txtBoxSearchPatient.Text == null) return;

            using (var db = new DatabaseContext())
            {
                var query = from x in db.Patients
                            where x.FirstName.Contains(txtBoxSearchPatient.Text)
                            orderby x.SecondName
                            select x;

                foreach (var patient in query)
                {
                    Button xButton = new Button();
                    
                }
            }

        }

        private void btnCreatePatient_Click(object sender, EventArgs e)
        {            
            createPatientCtrl1.Visible = !createPatientCtrl1.Visible;

            btnchangeHealthInsurance.Visible = !btnchangeHealthInsurance.Visible;

            // Vorerst Button ausschalten
            btnCreatePatient.Visible = !btnCreatePatient.Visible;
        }

        private void btnchangeHealthInsurance_Click(object sender, EventArgs e)
        {
            createPatientCtrl1.Visible = !createPatientCtrl1.Visible;

            healthInsuranceCtrl1.Visible = !healthInsuranceCtrl1.Visible;
        }

        public void MakeHealthInsuranceVisible(bool visible)
        {
            createPatientCtrl1.Visible = !createPatientCtrl1.Visible;
            healthInsuranceCtrl1.Visible = visible;
        }

        public void MakeCreatePatientVisible(bool visible)
        {
            createPatientCtrl1.Visible = visible;

            if (visible) return;

            // Main Maske
            healthInsuranceCtrl1.Visible = false;
            btnCreatePatient.Visible = true;
            btnchangeHealthInsurance.Visible = false;
        }
    }
}
