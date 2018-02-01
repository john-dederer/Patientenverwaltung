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
            this.btnCreatePatient = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnchangeHealthInsurance = new System.Windows.Forms.Button();
            this.btnLogTreatments = new System.Windows.Forms.Button();
            this.btnSearchMask = new System.Windows.Forms.Button();
            this.pnlDialog = new System.Windows.Forms.Panel();
            this.SuspendLayout();
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
            // btnLogTreatments
            // 
            this.btnLogTreatments.Location = new System.Drawing.Point(12, 113);
            this.btnLogTreatments.Name = "btnLogTreatments";
            this.btnLogTreatments.Size = new System.Drawing.Size(187, 23);
            this.btnLogTreatments.TabIndex = 6;
            this.btnLogTreatments.Text = "Behandlungen erfassen";
            this.btnLogTreatments.UseVisualStyleBackColor = true;
            this.btnLogTreatments.Visible = false;
            this.btnLogTreatments.Click += new System.EventHandler(this.btnLogTreatments_Click);
            // 
            // btnSearchMask
            // 
            this.btnSearchMask.Location = new System.Drawing.Point(12, 478);
            this.btnSearchMask.Name = "btnSearchMask";
            this.btnSearchMask.Size = new System.Drawing.Size(187, 23);
            this.btnSearchMask.TabIndex = 8;
            this.btnSearchMask.Text = "Suchen";
            this.btnSearchMask.UseVisualStyleBackColor = true;
            this.btnSearchMask.Click += new System.EventHandler(this.btnSearchMask_Click);
            // 
            // pnlDialog
            // 
            this.pnlDialog.Location = new System.Drawing.Point(220, 0);
            this.pnlDialog.Name = "pnlDialog";
            this.pnlDialog.Size = new System.Drawing.Size(771, 513);
            this.pnlDialog.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 513);
            this.Controls.Add(this.pnlDialog);
            this.Controls.Add(this.btnSearchMask);
            this.Controls.Add(this.btnLogTreatments);
            this.Controls.Add(this.btnchangeHealthInsurance);
            this.Controls.Add(this.btnCreatePatient);
            this.Controls.Add(this.splitter1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreatePatient;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnchangeHealthInsurance;
        private System.Windows.Forms.Button btnLogTreatments;
        private System.Windows.Forms.Button btnSearchMask;
        private System.Windows.Forms.Panel pnlDialog;
    }
}