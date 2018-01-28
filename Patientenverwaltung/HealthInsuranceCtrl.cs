﻿using System;
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
                HealthInsurance.InsuranceID = Convert.ToInt64(txtBoxNumber.Text);
                HealthInsurance.Street = Convert.ToString(txtBoxStreet.Text);
                HealthInsurance.StreetNumber = Convert.ToInt32(txtBoxStreetNumber.Text);
                HealthInsurance.Postalcode = Convert.ToInt32(txtBoxPostalCode.Text);
                HealthInsurance.City = Convert.ToString(txtBoxCity.Text);
                HealthInsurance.State = rdBtnPrivate.Enabled
                    ? StatusHealthInsurance.Private
                    : (rdBtnByLaw.Enabled ? StatusHealthInsurance.ByLaw : StatusHealthInsurance.Private);

                var task = AddToDatabaseTask(HealthInsurance);
                lstBoxHealthInsurance.Refresh();
                task.Wait();

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
                var textBoxData = string.Empty;
                bool bValidated = false;
                foreach (Control item in this.Controls)
                {
                    if (item.GetType() != typeof(TextBox)) continue;
                    textBoxData += item.Text;

                    if (!ValidateString(item))
                    {
                        bValidated = false;
                    }
                }
                return bValidated /*(textBoxData != string.Empty)*/;
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
            HealthInsurance = (HealthInsurance)lstBoxHealthInsurance.SelectedItem;
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
    }
}
