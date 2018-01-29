using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patientenverwaltung
{
    public partial class HealthInsuranceCtrl : UserControl
    {
        #region Properties
        public ErrorProvider ErrorProvider { get; set; }
        public HealthInsurance HealthInsurance { get; set; }
        public Main Main { get; set; }
        #endregion Properties

        public HealthInsuranceCtrl()
        {            
            InitializeComponent();

            // Krankenkassen aus DB laden
            //using (var db = new DatabaseContext())
            //{
            //    var query = from x in db.HealthInsurances orderby x.Name select x;
            //
            //    foreach (var healthInsurance in query)
            //    {
            //        lstBoxHealthInsurance.Items.Add(healthInsurance);
            //    }
            //}

            // Abspeichern erst möglich, wenn eine Krankenkasse ausgewählt wurde
            btnSave.Visible = false;
            ErrorProvider = new ErrorProvider();
        }

        public void Init()
        {            
            if (Connector.HealthInsurances == null) return;
            lstBoxHealthInsurance.Items.Clear();
            foreach (var healthInsurance in Connector.HealthInsurances)
            {
                lstBoxHealthInsurance.Items.Add(healthInsurance);
            }
        }

        internal void SetParent(Main main1)
        {
            this.Main = main1;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;

            HealthInsurance = new HealthInsurance
            {
                Name = "Bitte Krankenkassendaten ausfüllen"
            };

            lstBoxHealthInsurance.Items.Add(HealthInsurance);
            lstBoxHealthInsurance.SelectedItem = HealthInsurance;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var bValidated = ValidateTextBoxes();
                ValidateRadioButton();

                if (!bValidated) return;

                HealthInsurance.Name = Convert.ToString(txtBoxName.Text);
                //HealthInsurance.InsuranceID = Convert.ToInt64(txtBoxNumber.Text); // This is bound to a Patient and not part of the general healthinsruance
                HealthInsurance.Street = Convert.ToString(txtBoxStreet.Text);
                HealthInsurance.StreetNumber = Convert.ToInt32(txtBoxStreetNumber.Text);
                HealthInsurance.Postalcode = Convert.ToInt32(txtBoxPostalCode.Text);
                HealthInsurance.City = Convert.ToString(txtBoxCity.Text);
                HealthInsurance.State = rdBtnPrivate.Checked
                    ? StatusHealthInsurance.Private
                    : (rdBtnByLaw.Checked ? StatusHealthInsurance.ByLaw : StatusHealthInsurance.Private);
               
                Connector.Create(HealthInsurance);

                Init();

                lstBoxHealthInsurance.Refresh();

                Main.HealthInsurance = HealthInsurance;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Bitte alle Felder ausfüllen");
            }
        }

        private bool ValidateTextBoxes()
        {
            try
            {
                var bValidated = true;
                foreach (Control item in this.Controls)
                {
                    if (item.GetType() != typeof(TextBox)) continue;

                    if (!ValidateString(item))
                    {
                        bValidated = false;
                    }
                }
                return bValidated;
            }
            catch { return false; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();

            lstBoxHealthInsurance.Items.Remove(HealthInsurance);
            foreach (Control item in this.Controls)
            {
                if (item.GetType() != typeof(TextBox)) continue;

                item.Text = string.Empty;
            }

            Main.MakeHealthInsuranceVisible(false);
        }

        private void lstBoxHealthInsurance_MouseClick(object sender, MouseEventArgs e)
        {
            if (ReferenceEquals(lstBoxHealthInsurance.SelectedItem, "")) return;
            if (lstBoxHealthInsurance != null && HealthInsurance == (HealthInsurance)lstBoxHealthInsurance.SelectedItem) return;

            if (lstBoxHealthInsurance != null) HealthInsurance = (HealthInsurance) lstBoxHealthInsurance.SelectedItem;

            // Fill textboxes
            txtBoxCity.Text = HealthInsurance.City;
            txtBoxName.Text = HealthInsurance.Name;
            txtBoxNumber.Text = @"0";
            txtBoxPostalCode.Text = Convert.ToString(HealthInsurance.Postalcode);
            txtBoxStreet.Text = HealthInsurance.Street;
            txtBoxStreetNumber.Text = Convert.ToString(HealthInsurance.StreetNumber);
            rdBtnPrivate.Checked = HealthInsurance.State.Equals(StatusHealthInsurance.Private);
        }

        public void SetValues(HealthInsurance healthInsurance)
        {
            this.HealthInsurance = healthInsurance;
        }

        public async Task AddToDatabaseTask(HealthInsurance healthInsurance)
        {
            using (var db = new DatabaseContext())
            {
                db.HealthInsurances.Add(healthInsurance);

                await db.SaveChangesAsync();
            }
        }

        private void txtBoxNumber_Validating(object sender, CancelEventArgs e)
        {
            ValidateNumber(txtBoxNumber);
        }

        private void ValidateNumber(Control textBox)
        {
            ErrorProvider.SetError(textBox,
                !Regex.IsMatch(textBox.Text, @"^\d+$") ? "Bitte numerischen Wert eingeben" : "");
        }

        private void txtBoxStreetNumber_Validating(object sender, CancelEventArgs e)
        {
            ValidateNumber(txtBoxStreetNumber);
        }

        private void txtBoxPostalCode_Validating(object sender, CancelEventArgs e)
        {
            ValidateNumber(txtBoxPostalCode);
        }

        private void txtBoxName_Validating(object sender, CancelEventArgs e)
        {
            ValidateString(txtBoxName);
        }

        private bool ValidateString(Control textBox)
        {
            var bValidated = textBox.Text != null && !textBox.Text.Equals(string.Empty);
            ErrorProvider.SetError(textBox, bValidated ? $@"" : $@"Feld darf nicht leer sein");
            return bValidated;
        }

        private void txtBoxStreet_Validating(object sender, CancelEventArgs e)
        {
            ValidateString(txtBoxStreet);
        }

        private void txtBoxCity_Validating(object sender, CancelEventArgs e)
        {
            ValidateString(txtBoxCity);
        }

        private void btnSave_Validating(object sender, CancelEventArgs e)
        {
        }

        private bool ValidateRadioButton()
        {
            var bValidated = (!rdBtnPrivate.Checked && !rdBtnByLaw.Checked);
            ErrorProvider.SetError(rdBtnByLaw,  bValidated? "Bitte Art der Versicherung auswählen" : "");
            return bValidated;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (lstBoxHealthInsurance.SelectedItem != null)
            {
                Main.HealthInsurance = HealthInsurance;
                Main.SetHealthInsurance(HealthInsurance);
                Main.MakeHealthInsuranceVisible(false);
            }
            else
            {
                ErrorProvider.SetError(btnChoose, "Keine Versicherung in der Liste ausgewählt");
            }
        }

        public void SetSelectedItem(HealthInsurance getHealthInsurance)
        {
            lstBoxHealthInsurance.SelectedItem = getHealthInsurance;
        }
    }
}
