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
using Patientenverwaltung.Dialog;

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

            //createPatientCtrl1  .SetParent(this);
            //healthInsuranceCtrl1.SetParent(this);
            //logTreatmentsCtrl1.SetParent(this);

            Patient = new Patient();
            HealthInsurance = new HealthInsurance();

            // Look for JSON Path
            InitializeJson();

            pnlDialog.Controls.Add(new PatientListCtrl());         
        }

        public Main(Doctor doctor) : this()
        {
            Doctor = doctor;
            Connector.Doctor = Doctor;
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

        private void btnCreatePatient_Click(object sender, EventArgs e)
        {            
            //createPatientCtrl1.Visible = !createPatientCtrl1.Visible;

            btnchangeHealthInsurance.Visible = !btnchangeHealthInsurance.Visible;
            btnLogTreatments.Visible = !btnLogTreatments.Visible;
            // Vorerst Button ausschalten
            btnCreatePatient.Visible = !btnCreatePatient.Visible;
        }

        private void btnchangeHealthInsurance_Click(object sender, EventArgs e)
        {            
            //createPatientCtrl1.Visible = !createPatientCtrl1.Visible;

           // healthInsuranceCtrl1.Init();

            //if (createPatientCtrl1.GetHealthInsurance() != null) healthInsuranceCtrl1.SetSelectedItem(createPatientCtrl1.GetHealthInsurance());
            //healthInsuranceCtrl1.Visible = !healthInsuranceCtrl1.Visible;
        }

        public void MakeHealthInsuranceVisible(bool visible)
        {
            //createPatientCtrl1.Visible = !createPatientCtrl1.Visible;
            //healthInsuranceCtrl1.Visible = visible;
        }

        public void MakeCreatePatientVisible(bool visible)
        {
            //createPatientCtrl1.Visible = visible;

            if (visible) return;

            // Main Maske
            //healthInsuranceCtrl1.Visible = false;
            btnCreatePatient.Visible = true;
            btnchangeHealthInsurance.Visible = false;
            btnLogTreatments.Visible = false;
        }

        public void SetHealthInsurance(HealthInsurance healthInsurance)
        {
            //createPatientCtrl1.SetHealthInsurance(healthInsurance);
        }

        private void btnLogTreatments_Click(object sender, EventArgs e)
        {
            //createPatientCtrl1.Visible = !createPatientCtrl1.Visible;
            //
            //treatmentsCtrl1.Visible = !treatmentsCtrl1.Visible;
            //logTreatmentsCtrl1.Init();

            //logTreatmentsCtrl1.Visible = !logTreatmentsCtrl1.Visible;
        }

        public void MakeLogTreatmentsVisible(bool b)
        {
            
        }

        private void btnSearchMask_Click(object sender, EventArgs e)
        {

        }
    }
}
