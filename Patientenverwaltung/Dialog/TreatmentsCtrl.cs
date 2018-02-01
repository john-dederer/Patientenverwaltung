using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patientenverwaltung
{
    public partial class TreatmentsCtrl : UserControl
    {
        public ErrorProvider ErrorProvider { get; set; }
        public Main Main { get; set; }
        public Treatment Treatment { get; set; }
        public List<Treatment> Treatments { get; set; }

        public TreatmentsCtrl()
        {
            InitializeComponent();

            ErrorProvider = new ErrorProvider();
            Treatment = new Treatment();
            Treatments = new List<Treatment>();
        }

        public void SetParent(Main main)
        {
            Main = main;
        }

        private void btnCreateTreatment_Click(object sender, EventArgs e)
        {
            var treatment = new Treatment
            {
                Date = dateTimePicker2.Value,
                Description = txtBoxTreatments.Text,
                Other = txtBoxOther.Text
            };

            if (Treatments.Contains(treatment)) return;
            Treatments.Add(treatment);

            lstBoxTreatments.Items.Add(treatment);
            lstBoxTreatments.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();

            foreach (Control item in this.Controls)
            {
                if (item.GetType() != typeof(TextBox)) continue;

                item.Text = string.Empty;
            }

            Main.MakeLogTreatmentsVisible(false);
        }

        private void lstBoxTreatments_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstBoxTreatments.SelectedItem == null) return;
            if (lstBoxTreatments.SelectedItem == Treatment) return;

            Treatment = (Treatment) lstBoxTreatments.SelectedItem;

            txtBoxTreatments.Text = Treatment.Description;
            txtBoxOther.Text = Treatment.Other;
            dateTimePicker2.Value = Treatment.Date;
        }

        private void txtBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;

            // TODO: Search functionality like date, description, other
        }
    }
}
