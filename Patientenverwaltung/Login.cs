using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Patientenverwaltung
{
    public partial class Login : Form
    {
        private bool _bFirstStart;

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
                    Strings.Login_Login_Dies_ist_Ihr_erster_Start_dieses_Programmes__Bitte_legen_sie_die_nötigen_Einstellungen_für_das_Programm_fest_);
            }
        }

        public string Password { get; set; }
        public string Username { get; set; }
        public ErrorProvider ErrorProvider { get; set; }
        public static string DoctorJsonPath { get; set; }
        public static string SettingsJsonPath { get; set; }

        private void IntializeSettings()
        {
            SettingsJsonPath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Settings.json";
            if (File.Exists(SettingsJsonPath)) return;
            CreateJsonFile(SettingsJsonPath);
            _bFirstStart = true;
        }

        private static void CreateJsonFile(string jsonPath)
        {
            using (File.CreateText(jsonPath))
            {
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate login data
                ValidateInput();

                // Get User with hash
                var doctor = new Doctor {Username = txtUserName.Text};

                if (!Connector.Read(ref doctor))
                {
                    ErrorProvider.SetError(btnLogin, "User existiert nicht");
                    return;
                }

                if (PasswordStorage.VerifyPassword(txtPassword.Text, doctor.Hash))
                {
                    Program.OpenMainFormOnClose = true;
                    Program.Doctor = doctor;
                    Close();
                }
                else
                {
                    ErrorProvider.SetError(btnLogin, "Login Daten stimmen nicht überein");
                }
            }
            catch (UserDoesNotExist)
            {
                var result =
                MessageBox.Show($@"User '{txtUserName.Text}' existiert nicht. Soll dieser angelegt werden ?", "",
                    MessageBoxButtons.OKCancel);
                  
                if (result == DialogResult.OK)
                {
                    CreateUser(false);
                }
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
                ValidateInput();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Validate Input
            if (!ValidateInput()) return;

            CreateUser();            
        }

        private void CreateUser(bool check = true)
        {
            // Check if username already exists
            if (check)
            {
                if (!CheckCredentials(txtUserName.Text))
                {
                    ErrorProvider.SetError(btnCreate, "Benutzername existiert bereits");
                    return;
                }
            }            

            var doctor = new Doctor
            {
                Username = txtUserName.Text,
                Hash = PasswordStorage.CreateHash(txtPassword.Text),
                Patients = new List<Patient>()
            };

            Connector.Create(doctor);
            Connector.Doctor = doctor;
            // Login after 

            Program.OpenMainFormOnClose = true;

            Close();
        }

        private static bool CheckCredentials(string username, string password = "")
        {
            bool bChecked;
            if (password.Equals(string.Empty))
            {
                // Just look if Username exists                
                var doctor = new Doctor {Username = username};

                bChecked = !Connector.Read(ref doctor);
            }
            else
            {
                // Check if credentials match with saved ones
                var doctor = new Doctor {Username = username, Hash = password};

                bChecked = !Connector.Read(ref doctor);
            }

            return bChecked;
        }

        private bool ValidateInput()
        {
            var bValidated = false;
            foreach (Control item in Controls)
            {
                if (item.GetType() != typeof(TextBox)) continue;

                bValidated = item.Text != null && !item.Text.Equals(string.Empty);

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

    internal class UserDoesNotExist : Exception
    {
    }
}