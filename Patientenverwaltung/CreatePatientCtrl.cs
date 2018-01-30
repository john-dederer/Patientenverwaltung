using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patientenverwaltung
{
    public partial class CreatePatientCtrl : UserControl
    {
        public Main Main { get; set; }
        public ErrorProvider ErrorProvider { get; set; }
        public Patient Patient { get; set; }
        public HealthInsurance HealthInsurance { get; private set; }

        public CreatePatientCtrl()
        {
            InitializeComponent();
            ErrorProvider = new ErrorProvider();
            Patient = new Patient();
        }

        public CreatePatientCtrl(Main main)
        {
            this.Main = main;
            ErrorProvider = new ErrorProvider();
        }

        private void txtBoxHealthInsurance_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Validate input
            if (!ValidateInput()) return;

            SetValues();
        }

        private void SetValues()
        {
            // TODO: Add vallidation

            Patient = new Patient
            {
                City = txtBoxCity.Text,
                FirstName = txtBoxFirstName.Text,
                HealthInsurance = Main.HealthInsurance,
                InsuranceID = Main.HealthInsurance.InsuranceID,
                Phonenumber = Convert.ToInt32(txtBoxPhoneNumber.Text),
                Postalcode = Convert.ToInt32(txtBoxPostalCode.Text),
                SecondName = txtBoxSecondName.Text,
                Street = txtBoxStreet.Text,
                StreetNumber = Convert.ToInt32(txtBoxStreetNumber.Text),
                Birthday = Convert.ToDateTime(datePickerBirthday.Value.ToString("yyyy-MM-dd")),
                SpecialTraits = lstBoxSpecialTraits.Items.Cast<String>().ToList(),
                //Treatments = lstBoxTreatments.Items
            };
            Patient.SetKey();

            // Since patients belong to a doctor we provide the logged in doctor context
            Connector.Create(Patient);
        }

        private bool ValidateInput()
        {
            try
            {
                bool bValidated = true;
                foreach (Control item in this.Controls)
                {
                    if (item.GetType() != typeof(TextBox)) continue;

                    if (((TextBox) item).ReadOnly)
                    {
                        ValidateHealthInsurance(item);
                        continue;
                    }

                    if (!ValidateString(item))
                    {
                        bValidated = false;
                    }
                }
                return bValidated /*(textBoxData != string.Empty)*/;
            }
            catch { return false; }
        }

        private void ValidateHealthInsurance(Control item)
        {
            var bValidated = item.Text != null && !item.Text.Equals(string.Empty);
            ErrorProvider.SetError(item, bValidated ? $@"" : $@"Bitte Krankenkasse auswählen");
        }

        private bool ValidateString(Control item)
        {
            var bValidated = item.Text != null && !item.Text.Equals(string.Empty);
            ErrorProvider.SetError(item, bValidated ? $@"" : $@"Feld darf nicht leer sein");
            return bValidated;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();

            foreach (Control item in this.Controls)
            {
                if (item.GetType() != typeof(TextBox)) continue;

                item.Text = string.Empty;
            }

            Main.MakeCreatePatientVisible(false);
        }

        public void SetParent(Main main1)
        {
            this.Main = main1;
        }

        private void txtBoxPhoneNumber_Validating(object sender, CancelEventArgs e)
        {           
            ValidateNumber(txtBoxPhoneNumber, e);
        }

        private void ValidateNumber(Control textBox, CancelEventArgs cancelEventArgs)
        {
            var bValidated = Regex.IsMatch(textBox.Text, @"^\d+$");

            ErrorProvider.SetError(textBox,
                bValidated ? "" : "Bitte numerischen Wert eingeben");

            if (!bValidated) cancelEventArgs.Cancel = true;
        }

        private void txtBoxStreetNumber_Validating(object sender, CancelEventArgs e)
        {
            ValidateNumber(txtBoxStreetNumber, e);
        }

        private void txtBoxPostalCode_Validating(object sender, CancelEventArgs e)
        {
            ValidateNumber(txtBoxPostalCode, e);
        }

        public void SetHealthInsurance(HealthInsurance healthInsurance)
        {
            txtBoxHealthInsurance.Text = healthInsurance.Name;
            txtBoxInsuranceID.Text = healthInsurance.InsuranceID.ToString();

            HealthInsurance = healthInsurance;
        }

        public HealthInsurance GetHealthInsurance()
        {
            return HealthInsurance;
        }

        private void txtBoxSpecialTraits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char) Keys.Enter) return;
            if (txtBoxSpecialTraits.Text != string.Empty)
            {
                lstBoxSpecialTraits.Items.Add(txtBoxSpecialTraits.Text);

            }
        }
    }
}
