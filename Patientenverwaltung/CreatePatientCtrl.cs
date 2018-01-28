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
            Patient = new Patient();

            foreach (var control in this.Controls)
            {
                if (control.GetType() != typeof(TextBox)) continue;

                var item = (TextBox) control;
                if (item.Name.Equals(txtBoxCity.Name)) Patient.City = item.Text;
                if (item.Name.Equals(txtBoxFirstName.Name)) Patient.FirstName = item.Text;
                if (item.Name.Equals(txtBoxHealthInsurance.Name)) Patient.HealthInsurance = Main.HealthInsurance;
                if (item.Name.Equals(txtBoxInsuranceID.Name)) Patient.InsuranceID = Main.HealthInsurance.InsuranceID;
                if (item.Name.Equals(txtBoxPhoneNumber.Name)) Patient.Phonenumber = Convert.ToInt32(item.Text);
                if (item.Name.Equals(txtBoxPostalCode.Name)) Patient.Postalcode = Convert.ToInt32(item.Text);
                if (item.Name.Equals(txtBoxSecondName.Name)) Patient.SecondName = item.Text;
                if (item.Name.Equals(txtBoxStreet.Name)) Patient.Street = item.Text;
                if (item.Name.Equals(txtBoxStreetNumber.Name)) Patient.StreetNumber = Convert.ToInt32(item.Text);

                Patient.Birthday = Convert.ToDateTime(datePickerBirthday.Value.ToString("yyyy-MM-dd"));

            }
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
    }
}
