namespace Patientenverwaltung
{
    partial class HealthInsuranceCtrl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBoxHealthInsurance = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.txtBoxStreetNumber = new System.Windows.Forms.TextBox();
            this.lblStreetNumber = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtBoxPostalCode = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInsuranceID = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdBtnPrivate = new System.Windows.Forms.RadioButton();
            this.rdBtnByLaw = new System.Windows.Forms.RadioButton();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxHealthInsurance
            // 
            this.lstBoxHealthInsurance.FormattingEnabled = true;
            this.lstBoxHealthInsurance.Location = new System.Drawing.Point(29, 51);
            this.lstBoxHealthInsurance.Name = "lstBoxHealthInsurance";
            this.lstBoxHealthInsurance.Size = new System.Drawing.Size(231, 407);
            this.lstBoxHealthInsurance.TabIndex = 0;
            this.lstBoxHealthInsurance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstBoxHealthInsurance_MouseClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(480, 472);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Validating += new System.ComponentModel.CancelEventHandler(this.btnSave_Validating);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(629, 472);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 23);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.Location = new System.Drawing.Point(356, 143);
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(386, 20);
            this.txtBoxStreet.TabIndex = 3;
            this.txtBoxStreet.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxStreet_Validating);
            // 
            // txtBoxStreetNumber
            // 
            this.txtBoxStreetNumber.Location = new System.Drawing.Point(356, 186);
            this.txtBoxStreetNumber.Name = "txtBoxStreetNumber";
            this.txtBoxStreetNumber.Size = new System.Drawing.Size(386, 20);
            this.txtBoxStreetNumber.TabIndex = 4;
            this.txtBoxStreetNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxStreetNumber_Validating);
            // 
            // lblStreetNumber
            // 
            this.lblStreetNumber.AutoSize = true;
            this.lblStreetNumber.Location = new System.Drawing.Point(282, 186);
            this.lblStreetNumber.Name = "lblStreetNumber";
            this.lblStreetNumber.Size = new System.Drawing.Size(69, 13);
            this.lblStreetNumber.TabIndex = 27;
            this.lblStreetNumber.Text = "Hausnummer";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(282, 144);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(42, 13);
            this.lblStreet.TabIndex = 26;
            this.lblStreet.Text = "Strasse";
            // 
            // txtBoxPostalCode
            // 
            this.txtBoxPostalCode.Location = new System.Drawing.Point(356, 229);
            this.txtBoxPostalCode.Name = "txtBoxPostalCode";
            this.txtBoxPostalCode.Size = new System.Drawing.Size(386, 20);
            this.txtBoxPostalCode.TabIndex = 5;
            this.txtBoxPostalCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxPostalCode_Validating);
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(356, 272);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(386, 20);
            this.txtBoxCity.TabIndex = 6;
            this.txtBoxCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCity_Validating);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(282, 270);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(21, 13);
            this.lblCity.TabIndex = 31;
            this.lblCity.Text = "Ort";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(282, 228);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(60, 13);
            this.lblPostalCode.TabIndex = 30;
            this.lblPostalCode.Text = "Postleitzahl";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(282, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "Name";
            // 
            // lblInsuranceID
            // 
            this.lblInsuranceID.AutoSize = true;
            this.lblInsuranceID.Location = new System.Drawing.Point(282, 102);
            this.lblInsuranceID.Name = "lblInsuranceID";
            this.lblInsuranceID.Size = new System.Drawing.Size(46, 13);
            this.lblInsuranceID.TabIndex = 35;
            this.lblInsuranceID.Text = "Nummer";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(356, 57);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(386, 20);
            this.txtBoxName.TabIndex = 1;
            this.txtBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxName_Validating);
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(356, 100);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(386, 20);
            this.txtBoxNumber.TabIndex = 2;
            this.txtBoxNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxNumber_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Krankenversicherung";
            // 
            // rdBtnPrivate
            // 
            this.rdBtnPrivate.AutoSize = true;
            this.rdBtnPrivate.Location = new System.Drawing.Point(356, 354);
            this.rdBtnPrivate.Name = "rdBtnPrivate";
            this.rdBtnPrivate.Size = new System.Drawing.Size(113, 17);
            this.rdBtnPrivate.TabIndex = 7;
            this.rdBtnPrivate.TabStop = true;
            this.rdBtnPrivate.Text = "Privatversicherung";
            this.rdBtnPrivate.UseVisualStyleBackColor = true;
            // 
            // rdBtnByLaw
            // 
            this.rdBtnByLaw.AutoSize = true;
            this.rdBtnByLaw.Location = new System.Drawing.Point(597, 354);
            this.rdBtnByLaw.Name = "rdBtnByLaw";
            this.rdBtnByLaw.Size = new System.Drawing.Size(145, 17);
            this.rdBtnByLaw.TabIndex = 8;
            this.rdBtnByLaw.TabStop = true;
            this.rdBtnByLaw.Text = "Gesetzliche Versicherung";
            this.rdBtnByLaw.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(331, 472);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 23);
            this.btnNew.TabIndex = 41;
            this.btnNew.Text = "Neu";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(173, 472);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(112, 23);
            this.btnChoose.TabIndex = 42;
            this.btnChoose.Text = "Wählen";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // HealthInsuranceCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.rdBtnByLaw);
            this.Controls.Add(this.rdBtnPrivate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxNumber);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblInsuranceID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxPostalCode);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.txtBoxStreet);
            this.Controls.Add(this.txtBoxStreetNumber);
            this.Controls.Add(this.lblStreetNumber);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstBoxHealthInsurance);
            this.Name = "HealthInsuranceCtrl";
            this.Size = new System.Drawing.Size(771, 513);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxHealthInsurance;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private System.Windows.Forms.TextBox txtBoxStreetNumber;
        private System.Windows.Forms.Label lblStreetNumber;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtBoxPostalCode;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInsuranceID;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdBtnPrivate;
        private System.Windows.Forms.RadioButton rdBtnByLaw;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnChoose;
    }
}
