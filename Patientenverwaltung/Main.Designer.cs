namespace Patientenverwaltung
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxSearchPatient = new System.Windows.Forms.TextBox();
            this.btnCreatePatient = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnchangeHealthInsurance = new System.Windows.Forms.Button();
            this.healthInsuranceCtrl1 = new Patientenverwaltung.HealthInsuranceCtrl();
            this.createPatientCtrl1 = new Patientenverwaltung.CreatePatientCtrl();
            this.SuspendLayout();
            // 
            // txtBoxSearchPatient
            // 
            this.txtBoxSearchPatient.Location = new System.Drawing.Point(234, 481);
            this.txtBoxSearchPatient.Name = "txtBoxSearchPatient";
            this.txtBoxSearchPatient.Size = new System.Drawing.Size(748, 20);
            this.txtBoxSearchPatient.TabIndex = 0;
            this.txtBoxSearchPatient.TextChanged += new System.EventHandler(this.txtBoxSearchPatient_TextChanged);
            // 
            // btnCreatePatient
            // 
            this.btnCreatePatient.Location = new System.Drawing.Point(12, 12);
            this.btnCreatePatient.Name = "btnCreatePatient";
            this.btnCreatePatient.Size = new System.Drawing.Size(187, 23);
            this.btnCreatePatient.TabIndex = 1;
            this.btnCreatePatient.Text = "Neuen Patient anlegen";
            this.btnCreatePatient.UseVisualStyleBackColor = true;
            this.btnCreatePatient.Click += new System.EventHandler(this.btnCreatePatient_Click);
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(214, 513);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // btnchangeHealthInsurance
            // 
            this.btnchangeHealthInsurance.Location = new System.Drawing.Point(12, 62);
            this.btnchangeHealthInsurance.Name = "btnchangeHealthInsurance";
            this.btnchangeHealthInsurance.Size = new System.Drawing.Size(187, 23);
            this.btnchangeHealthInsurance.TabIndex = 5;
            this.btnchangeHealthInsurance.Text = "Krankenversicherung ändern";
            this.btnchangeHealthInsurance.UseVisualStyleBackColor = true;
            this.btnchangeHealthInsurance.Visible = false;
            this.btnchangeHealthInsurance.Click += new System.EventHandler(this.btnchangeHealthInsurance_Click);
            // 
            // healthInsuranceCtrl1
            // 
            this.healthInsuranceCtrl1.Location = new System.Drawing.Point(220, 0);
            this.healthInsuranceCtrl1.Name = "healthInsuranceCtrl1";
            this.healthInsuranceCtrl1.Size = new System.Drawing.Size(771, 513);
            this.healthInsuranceCtrl1.TabIndex = 4;
            this.healthInsuranceCtrl1.Visible = false;
            // 
            // createPatientCtrl1
            // 
            this.createPatientCtrl1.Location = new System.Drawing.Point(220, 0);
            this.createPatientCtrl1.Name = "createPatientCtrl1";
            this.createPatientCtrl1.Size = new System.Drawing.Size(771, 513);
            this.createPatientCtrl1.TabIndex = 3;
            this.createPatientCtrl1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 513);
            this.Controls.Add(this.healthInsuranceCtrl1);
            this.Controls.Add(this.btnchangeHealthInsurance);
            this.Controls.Add(this.createPatientCtrl1);
            this.Controls.Add(this.btnCreatePatient);
            this.Controls.Add(this.txtBoxSearchPatient);
            this.Controls.Add(this.splitter1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSearchPatient;
        private System.Windows.Forms.Button btnCreatePatient;
        private System.Windows.Forms.Splitter splitter1;
        private CreatePatientCtrl createPatientCtrl1;
        private HealthInsuranceCtrl healthInsuranceCtrl1;
        private System.Windows.Forms.Button btnchangeHealthInsurance;
    }
}