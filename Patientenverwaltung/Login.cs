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

        public Login()
        {
            InitializeComponent();

            // Localize Strings
            lblUsername.Text = Strings.Username;
            lblPassword.Text = Strings.Password;
            ErrorProvider = new ErrorProvider();

            // Look for JSON Path
            InitializeJson();
        }

        private void InitializeJson()
        {
            DoctorJsonPath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Doctor.json";

            // Read JSON from File or Create if necessary
            if (!File.Exists(DoctorJsonPath)) { CreateJsonFile(DoctorJsonPath); }
        }

        private static void CreateJsonFile(string jsonPath)
        {
            using (var file = File.CreateText(jsonPath))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, "{}");
            }
        }

        private static void UpdateJsonFile(string jsonPath, Object obj)
        {
            using (var file = File.OpenRead(jsonPath))
            {
                var serializer = new JsonSerializer();
                //serializer.Serialize(file, "{}");
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
            //if (!CheckCredentials(this.txtUserName.Text))
            //{
            //    ErrorProvider.SetError(btnCreate, "Username already exists");
            //    return;
            //}

            var doctor = new Doctor
            {
                Username = this.txtUserName.Text,
                Hash = PasswordStorage.CreateHash(this.txtPassword.Text)
            };

            Connector.Create(doctor);
        }

        private static bool CheckCredentials(string username, string password = "")
        {
            var bChecked = false;
            if (password.Equals(string.Empty))
            {
                // Just look if Username exists
                var json = JObject.Parse(GetJson(DoctorJsonPath));

                
            }
            else
            {
                // Check if credentials match with saved ones
                
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
    }
}
