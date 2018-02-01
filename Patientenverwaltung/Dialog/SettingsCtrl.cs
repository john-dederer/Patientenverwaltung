using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Patientenverwaltung
{
    public partial class SettingsCtrl : UserControl
    {
        public ErrorProvider ErrorProvider { get; set; }
        public string SaveType { get; set; }
        public string SaveLocation { get; set; }
        public Login Login { get; set; }

        public SettingsCtrl()
        {
            InitializeComponent();

            ErrorProvider = new ErrorProvider(
                );

            // Speichertypen füllen
            comboBox1.Items.Add("JSON");
            comboBox1.Items.Add("SQL");
            comboBox1.Items.Add("XML");                    
        }

        public void Init()
        {
            // read settings
            ReadSettingsFromFile();

            Connector.SaveType = this.SaveType;
            Connector.SaveLocation = this.SaveLocation;
        }

        private void ReadSettingsFromFile()
        {
            // Save to file
            var file = File.ReadAllText($@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Settings.json");

            var settings = JsonConvert.DeserializeObject<Settings>(file);

            if (settings == null) return;

            SaveType = settings.SaveType;
            comboBox1.SelectedItem = settings.SaveType;
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf(settings.SaveType);

            txtBoxSaveLoc.Text = settings.SaveLocation;
            SaveLocation = settings.SaveLocation;
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider.SetError(comboBox1, comboBox1.SelectedIndex < 0 ? "Speichertyp auswählen" : "");

            if (comboBox1.SelectedItem != null) SaveType = comboBox1.SelectedItem.ToString();
        }

        private void btnChooseSaveLoc_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK) return;
            SaveLocation = folderBrowserDialog1.SelectedPath;

            txtBoxSaveLoc.Text = SaveLocation;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput()) return;


            var settings = new Settings
            {
                SaveLocation = this.SaveLocation,
                SaveType = this.SaveType
            };

            // Save to file
            using (var file = File.CreateText($@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Settings.json"))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file,settings);
            }

            Connector.SaveType = settings.SaveType;
            Connector.SaveLocation = settings.SaveLocation;
            Login.ResetButtons();

            this.Visible = false;
        }

        private bool ValidateInput()
        {
            var bValidated = comboBox1.SelectedIndex < 0;

            ErrorProvider.SetError(comboBox1, bValidated ? "Speichertyp auswählen" : "");

            bValidated = txtBoxSaveLoc.Text.Equals(string.Empty);

            ErrorProvider.SetError(txtBoxSaveLoc, bValidated ? "Speicherort auswählen" : "");

            return bValidated;
        }

        private void txtBoxSaveLoc_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider.SetError(txtBoxSaveLoc, txtBoxSaveLoc.Text.Equals(string.Empty) ? "Speicherort auswählen" : "");
        }

        private void txtBoxSaveLoc_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Login.ResetButtons();
            this.Visible = false;
        }

        public void SetParent(Login login)
        {
            this.Login = login;
        }
    }
}
