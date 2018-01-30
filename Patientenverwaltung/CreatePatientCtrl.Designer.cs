namespace Patientenverwaltung
{
    partial class CreatePatientCtrl
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
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxSecondName = new System.Windows.Forms.TextBox();
            this.lvlFirstName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblStreetNumber = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxPostalCode = new System.Windows.Forms.TextBox();
            this.txtBoxStreetNumber = new System.Windows.Forms.TextBox();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.datePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblHealthInsurance = new System.Windows.Forms.Label();
            this.lblInsuranceID = new System.Windows.Forms.Label();
            this.txtBoxHealthInsurance = new System.Windows.Forms.TextBox();
            this.txtBoxInsuranceID = new System.Windows.Forms.TextBox();
            this.lstBoxSpecialTraits = new System.Windows.Forms.ListBox();
            this.lblSpecialTraits = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBoxSpecialTraits = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(172, 28);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(218, 20);
            this.txtBoxFirstName.TabIndex = 0;
            // 
            // txtBoxSecondName
            // 
            this.txtBoxSecondName.Location = new System.Drawing.Point(172, 69);
            this.txtBoxSecondName.Name = "txtBoxSecondName";
            this.txtBoxSecondName.Size = new System.Drawing.Size(218, 20);
            this.txtBoxSecondName.TabIndex = 1;
            // 
            // lvlFirstName
            // 
            this.lvlFirstName.AutoSize = true;
            this.lvlFirstName.Location = new System.Drawing.Point(34, 31);
            this.lvlFirstName.Name = "lvlFirstName";
            this.lvlFirstName.Size = new System.Drawing.Size(49, 13);
            this.lvlFirstName.TabIndex = 2;
            this.lvlFirstName.Text = "Vorname";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Location = new System.Drawing.Point(34, 72);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(59, 13);
            this.lblSecondName.TabIndex = 3;
            this.lblSecondName.Text = "Nachname";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(34, 137);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(42, 13);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Strasse";
            // 
            // lblStreetNumber
            // 
            this.lblStreetNumber.AutoSize = true;
            this.lblStreetNumber.Location = new System.Drawing.Point(34, 180);
            this.lblStreetNumber.Name = "lblStreetNumber";
            this.lblStreetNumber.Size = new System.Drawing.Size(69, 13);
            this.lblStreetNumber.TabIndex = 5;
            this.lblStreetNumber.Text = "Hausnummer";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(425, 140);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(60, 13);
            this.lblPostalCode.TabIndex = 6;
            this.lblPostalCode.Text = "Postleitzahl";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(425, 180);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(21, 13);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "Ort";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(425, 31);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(73, 13);
            this.lblBirthday.TabIndex = 8;
            this.lblBirthday.Text = "Geburtsdatum";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(425, 72);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(43, 13);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Telefon";
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(542, 69);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.txtBoxPhoneNumber.TabIndex = 10;
            this.txtBoxPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxPhoneNumber_Validating);
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(542, 177);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(200, 20);
            this.txtBoxCity.TabIndex = 12;
            // 
            // txtBoxPostalCode
            // 
            this.txtBoxPostalCode.Location = new System.Drawing.Point(542, 137);
            this.txtBoxPostalCode.Name = "txtBoxPostalCode";
            this.txtBoxPostalCode.Size = new System.Drawing.Size(200, 20);
            this.txtBoxPostalCode.TabIndex = 13;
            this.txtBoxPostalCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxPostalCode_Validating);
            // 
            // txtBoxStreetNumber
            // 
            this.txtBoxStreetNumber.Location = new System.Drawing.Point(172, 180);
            this.txtBoxStreetNumber.Name = "txtBoxStreetNumber";
            this.txtBoxStreetNumber.Size = new System.Drawing.Size(218, 20);
            this.txtBoxStreetNumber.TabIndex = 14;
            this.txtBoxStreetNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxStreetNumber_Validating);
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.Location = new System.Drawing.Point(172, 137);
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(218, 20);
            this.txtBoxStreet.TabIndex = 15;
            // 
            // datePickerBirthday
            // 
            this.datePickerBirthday.Location = new System.Drawing.Point(542, 25);
            this.datePickerBirthday.Name = "datePickerBirthday";
            this.datePickerBirthday.Size = new System.Drawing.Size(200, 20);
            this.datePickerBirthday.TabIndex = 16;
            // 
            // lblHealthInsurance
            // 
            this.lblHealthInsurance.AutoSize = true;
            this.lblHealthInsurance.Location = new System.Drawing.Point(34, 247);
            this.lblHealthInsurance.Name = "lblHealthInsurance";
            this.lblHealthInsurance.Size = new System.Drawing.Size(75, 13);
            this.lblHealthInsurance.TabIndex = 17;
            this.lblHealthInsurance.Text = "Krankenkasse";
            // 
            // lblInsuranceID
            // 
            this.lblInsuranceID.AutoSize = true;
            this.lblInsuranceID.Location = new System.Drawing.Point(425, 247);
            this.lblInsuranceID.Name = "lblInsuranceID";
            this.lblInsuranceID.Size = new System.Drawing.Size(111, 13);
            this.lblInsuranceID.TabIndex = 18;
            this.lblInsuranceID.Text = "Versicherungsnummer";
            // 
            // txtBoxHealthInsurance
            // 
            this.txtBoxHealthInsurance.Location = new System.Drawing.Point(172, 244);
            this.txtBoxHealthInsurance.Name = "txtBoxHealthInsurance";
            this.txtBoxHealthInsurance.ReadOnly = true;
            this.txtBoxHealthInsurance.Size = new System.Drawing.Size(218, 20);
            this.txtBoxHealthInsurance.TabIndex = 19;
            this.txtBoxHealthInsurance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxHealthInsurance_MouseClick);
            // 
            // txtBoxInsuranceID
            // 
            this.txtBoxInsuranceID.Location = new System.Drawing.Point(542, 243);
            this.txtBoxInsuranceID.Name = "txtBoxInsuranceID";
            this.txtBoxInsuranceID.ReadOnly = true;
            this.txtBoxInsuranceID.Size = new System.Drawing.Size(200, 20);
            this.txtBoxInsuranceID.TabIndex = 20;
            // 
            // lstBoxSpecialTraits
            // 
            this.lstBoxSpecialTraits.FormattingEnabled = true;
            this.lstBoxSpecialTraits.Location = new System.Drawing.Point(37, 373);
            this.lstBoxSpecialTraits.Name = "lstBoxSpecialTraits";
            this.lstBoxSpecialTraits.Size = new System.Drawing.Size(705, 82);
            this.lstBoxSpecialTraits.TabIndex = 21;
            // 
            // lblSpecialTraits
            // 
            this.lblSpecialTraits.AutoSize = true;
            this.lblSpecialTraits.Location = new System.Drawing.Point(37, 302);
            this.lblSpecialTraits.Name = "lblSpecialTraits";
            this.lblSpecialTraits.Size = new System.Drawing.Size(81, 13);
            this.lblSpecialTraits.TabIndex = 22;
            this.lblSpecialTraits.Text = "Besonderheiten";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(478, 472);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 23);
            this.btnCreate.TabIndex = 23;
            this.btnCreate.Text = "Anlegen";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(630, 472);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBoxSpecialTraits
            // 
            this.txtBoxSpecialTraits.Location = new System.Drawing.Point(37, 328);
            this.txtBoxSpecialTraits.Name = "txtBoxSpecialTraits";
            this.txtBoxSpecialTraits.Size = new System.Drawing.Size(705, 20);
            this.txtBoxSpecialTraits.TabIndex = 25;
            this.txtBoxSpecialTraits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSpecialTraits_KeyPress);
            // 
            // CreatePatientCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBoxSpecialTraits);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblSpecialTraits);
            this.Controls.Add(this.lstBoxSpecialTraits);
            this.Controls.Add(this.txtBoxInsuranceID);
            this.Controls.Add(this.txtBoxHealthInsurance);
            this.Controls.Add(this.lblInsuranceID);
            this.Controls.Add(this.lblHealthInsurance);
            this.Controls.Add(this.datePickerBirthday);
            this.Controls.Add(this.txtBoxStreet);
            this.Controls.Add(this.txtBoxStreetNumber);
            this.Controls.Add(this.txtBoxPostalCode);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblStreetNumber);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblSecondName);
            this.Controls.Add(this.lvlFirstName);
            this.Controls.Add(this.txtBoxSecondName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Name = "CreatePatientCtrl";
            this.Size = new System.Drawing.Size(771, 513);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxSecondName;
        private System.Windows.Forms.Label lvlFirstName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblStreetNumber;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxPostalCode;
        private System.Windows.Forms.TextBox txtBoxStreetNumber;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private System.Windows.Forms.DateTimePicker datePickerBirthday;
        private System.Windows.Forms.Label lblHealthInsurance;
        private System.Windows.Forms.Label lblInsuranceID;
        private System.Windows.Forms.TextBox txtBoxHealthInsurance;
        private System.Windows.Forms.TextBox txtBoxInsuranceID;
        private System.Windows.Forms.ListBox lstBoxSpecialTraits;
        private System.Windows.Forms.Label lblSpecialTraits;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBoxSpecialTraits;
    }
}
