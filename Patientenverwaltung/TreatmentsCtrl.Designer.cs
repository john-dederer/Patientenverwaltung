namespace Patientenverwaltung
{
    partial class TreatmentsCtrl
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
            this.txtBoxOther = new System.Windows.Forms.TextBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnCreateTreatment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtBoxTreatments = new System.Windows.Forms.TextBox();
            this.lstBoxTreatments = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBoxOther
            // 
            this.txtBoxOther.Location = new System.Drawing.Point(23, 134);
            this.txtBoxOther.Name = "txtBoxOther";
            this.txtBoxOther.Size = new System.Drawing.Size(727, 20);
            this.txtBoxOther.TabIndex = 49;
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(23, 108);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(53, 13);
            this.lblOther.TabIndex = 48;
            this.lblOther.Text = "Sonstiges";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 31);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(150, 13);
            this.lblDescription.TabIndex = 47;
            this.lblDescription.Text = "Beschreibung der Behandlung";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(462, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 13);
            this.lblDate.TabIndex = 46;
            this.lblDate.Text = "Datum";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 450);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 45;
            this.lblSearch.Text = "Suchen";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(23, 466);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(422, 20);
            this.txtBoxSearch.TabIndex = 44;
            this.txtBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSearch_KeyPress);
            // 
            // btnCreateTreatment
            // 
            this.btnCreateTreatment.Location = new System.Drawing.Point(479, 464);
            this.btnCreateTreatment.Name = "btnCreateTreatment";
            this.btnCreateTreatment.Size = new System.Drawing.Size(112, 23);
            this.btnCreateTreatment.TabIndex = 43;
            this.btnCreateTreatment.Text = "Anlegen";
            this.btnCreateTreatment.UseVisualStyleBackColor = true;
            this.btnCreateTreatment.Click += new System.EventHandler(this.btnCreateTreatment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(631, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 23);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(550, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 41;
            // 
            // txtBoxTreatments
            // 
            this.txtBoxTreatments.Location = new System.Drawing.Point(23, 63);
            this.txtBoxTreatments.Name = "txtBoxTreatments";
            this.txtBoxTreatments.Size = new System.Drawing.Size(727, 20);
            this.txtBoxTreatments.TabIndex = 40;
            // 
            // lstBoxTreatments
            // 
            this.lstBoxTreatments.FormattingEnabled = true;
            this.lstBoxTreatments.Location = new System.Drawing.Point(23, 181);
            this.lstBoxTreatments.Name = "lstBoxTreatments";
            this.lstBoxTreatments.Size = new System.Drawing.Size(727, 238);
            this.lstBoxTreatments.TabIndex = 39;
            this.lstBoxTreatments.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstBoxTreatments_MouseClick);
            // 
            // TreatmentsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBoxOther);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnCreateTreatment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txtBoxTreatments);
            this.Controls.Add(this.lstBoxTreatments);
            this.Name = "TreatmentsCtrl";
            this.Size = new System.Drawing.Size(771, 513);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxOther;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnCreateTreatment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtBoxTreatments;
        private System.Windows.Forms.ListBox lstBoxTreatments;
    }
}
