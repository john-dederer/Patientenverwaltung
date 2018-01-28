using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Patientenverwaltung.Properties;
using static System.Windows.Forms.Keys;

namespace Patientenverwaltung
{
    public partial class Login : Form
    {
        public string Password { get; set; }
        public string Username { get; set; }
        public ErrorProvider ErrorProvider { get; set; }
        public static string DoctorJsonPath { get; set; }
        public static string SettingsJsonPath { get; set; }

        private bool _bFirstStart = false;

        public Login()
        {
            InitializeComponent();

            // Localize Strings
            lblUsername.Text = Strings.Username;
            lblPassword.Text = Strings.Password;
            ErrorProvider = new ErrorProvider();

            // Initialize Settings
            IntializeSettings();

            settingsCtrl1.SetParent(this);
            settingsCtrl1.Init();

            if (_bFirstStart)
            {
                btnCreate.Visible = false;
                btnLogin.Visible = false;
                btnEditSettings.Visible = false;
                settingsCtrl1.Visible = true;

                MessageBox.Show(
                    "Dies ist Ihr erster Start dieses Programmes. Bitte legen sie die nötigen Einstellungen für das Programm fest.");
            }
        }

        private void IntializeSettings()
        {
            SettingsJsonPath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Settings.json";
            if (File.Exists(SettingsJsonPath)) return;
            CreateJsonFile(SettingsJsonPath);
            _bFirstStart = true;
        }

        private static void CreateJsonFile(string jsonPath)
        {
            using (var file = File.CreateText(jsonPath))
            {
                                
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate login data
            ValidateInput();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Validate login data
                ValidateInput();
            }
        }

        /*
        private void ValidateInput()
        {
            try
            {
                // Checks if User is known
                Password = txtPassword.Text;
                Username = txtUserName.Text;

                var user = JObject.Parse(File.ReadAllText($@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Users.json"));
                var result = JsonConvert.DeserializeObject<User>(user.ToString());
                var test = result.Username;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);

//                if (MessageBox.Show("User existiert nicht. Hinzufügen ?", "", MessageBoxButtons.OKCancel));
                var user = new User()
                {
                    Username = Username,
                    Password = Password
                };

                var oUserJObject = (JObject) JToken.FromObject(user);
                // Create File
                using (var file = File.Create($@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Users.json"))
                {
                    Byte[] json = new UTF8Encoding(true).GetBytes(oUserJObject.ToString());
                    file.Write(json, 0, json.Length);
                }
            }
           
            
            var hash = PasswordStorage.CreateHash(this.Password);
            
        }
        */

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Validate Input
            if (!ValidateInput()) return;

            // Check if username already exists
            if (!CheckCredentials(this.txtUserName.Text))
            {
                ErrorProvider.SetError(btnCreate, "Username already exists");
                return;
            }

            var doctor = new Doctor
            {
                Username = this.txtUserName.Text,
                Hash = PasswordStorage.CreateHash(this.txtPassword.Text),
                Patients = new List<Patient>()
            };

            Connector.Create(doctor);
        }

        private static bool CheckCredentials(string username, string password = "")
        {
            var bChecked = false;
            if (password.Equals(string.Empty))
            {
                // Just look if Username exists                
                var doctor = new Doctor {Username = username};

                bChecked = !Connector.Read(doctor);
            }
            else
            {
                // Check if credentials match with saved ones
                var doctor = new Doctor { Username = username, Hash = password};

                bChecked = !Connector.Read(doctor);
            }

            return bChecked;
        }

        private static string GetJson(string jsonPath)
        {
            return File.ReadAllText(jsonPath);
        }

        private bool ValidateInput()
        {
            var bValidated = false;
            foreach (Control item in this.Controls)
            {
                if (item.GetType() != typeof(TextBox)) continue;

                bValidated = (item.Text != null  && !item.Text.Equals(string.Empty));

                ErrorProvider.SetError(item, bValidated ? $@"" : $@"Feld darf nicht leer sein");
            }

            return bValidated;
        }

        private void btnEditSettings_Click(object sender, EventArgs e)
        {
            if (settingsCtrl1.Visible) return;
            settingsCtrl1.Init();
            settingsCtrl1.Visible = true;
        }

        public void ResetButtons()
        {
            btnCreate.Visible = true;
            btnLogin.Visible = true;
            btnEditSettings.Visible = true;
        }
    }
}
