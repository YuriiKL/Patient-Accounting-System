namespace Patient_Accounting_System.DesktopUI.Forms
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.patientGroupBox = new System.Windows.Forms.GroupBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.patientBirthDateLbl = new System.Windows.Forms.Label();
            this.patientSexLbl = new System.Windows.Forms.Label();
            this.patientLastNameLbl = new System.Windows.Forms.Label();
            this.patientFirstNameLbl = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.patientLookupLbl = new System.Windows.Forms.Label();
            this.selectPatientComboBox = new System.Windows.Forms.ComboBox();
            this.patientsProvidedServicesDataGridView = new System.Windows.Forms.DataGridView();
            this.patientGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsProvidedServicesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patientGroupBox
            // 
            this.patientGroupBox.Controls.Add(this.emailLbl);
            this.patientGroupBox.Controls.Add(this.phoneNumberLbl);
            this.patientGroupBox.Controls.Add(this.notesTextBox);
            this.patientGroupBox.Controls.Add(this.label2);
            this.patientGroupBox.Controls.Add(this.label4);
            this.patientGroupBox.Controls.Add(this.label1);
            this.patientGroupBox.Controls.Add(this.label10);
            this.patientGroupBox.Controls.Add(this.label7);
            this.patientGroupBox.Controls.Add(this.label5);
            this.patientGroupBox.Controls.Add(this.label3);
            this.patientGroupBox.Controls.Add(this.patientBirthDateLbl);
            this.patientGroupBox.Controls.Add(this.patientSexLbl);
            this.patientGroupBox.Controls.Add(this.patientLastNameLbl);
            this.patientGroupBox.Controls.Add(this.patientFirstNameLbl);
            this.patientGroupBox.Controls.Add(this.birthDatePicker);
            this.patientGroupBox.Controls.Add(this.sexComboBox);
            this.patientGroupBox.Controls.Add(this.phoneNumberTextBox);
            this.patientGroupBox.Controls.Add(this.emailTextBox);
            this.patientGroupBox.Controls.Add(this.lastNameTextBox);
            this.patientGroupBox.Controls.Add(this.firstNameTextBox);
            this.patientGroupBox.Location = new System.Drawing.Point(12, 12);
            this.patientGroupBox.Name = "patientGroupBox";
            this.patientGroupBox.Size = new System.Drawing.Size(402, 471);
            this.patientGroupBox.TabIndex = 16;
            this.patientGroupBox.TabStop = false;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLbl.Location = new System.Drawing.Point(105, 221);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(0, 16);
            this.emailLbl.TabIndex = 16;
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumberLbl.Location = new System.Drawing.Point(105, 182);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(0, 16);
            this.phoneNumberLbl.TabIndex = 15;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(9, 282);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(374, 183);
            this.notesTextBox.TabIndex = 14;
            this.notesTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Phone number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email (optional):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Notes (optional):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Sex:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "BirthDate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "First name:";
            // 
            // patientBirthDateLbl
            // 
            this.patientBirthDateLbl.AutoSize = true;
            this.patientBirthDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientBirthDateLbl.Location = new System.Drawing.Point(105, 140);
            this.patientBirthDateLbl.Name = "patientBirthDateLbl";
            this.patientBirthDateLbl.Size = new System.Drawing.Size(0, 16);
            this.patientBirthDateLbl.TabIndex = 3;
            // 
            // patientSexLbl
            // 
            this.patientSexLbl.AutoSize = true;
            this.patientSexLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientSexLbl.Location = new System.Drawing.Point(105, 101);
            this.patientSexLbl.Name = "patientSexLbl";
            this.patientSexLbl.Size = new System.Drawing.Size(0, 16);
            this.patientSexLbl.TabIndex = 2;
            // 
            // patientLastNameLbl
            // 
            this.patientLastNameLbl.AutoSize = true;
            this.patientLastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientLastNameLbl.Location = new System.Drawing.Point(105, 54);
            this.patientLastNameLbl.Name = "patientLastNameLbl";
            this.patientLastNameLbl.Size = new System.Drawing.Size(0, 16);
            this.patientLastNameLbl.TabIndex = 1;
            // 
            // patientFirstNameLbl
            // 
            this.patientFirstNameLbl.AutoSize = true;
            this.patientFirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientFirstNameLbl.Location = new System.Drawing.Point(105, 15);
            this.patientFirstNameLbl.Name = "patientFirstNameLbl";
            this.patientFirstNameLbl.Size = new System.Drawing.Size(0, 16);
            this.patientFirstNameLbl.TabIndex = 0;
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(108, 140);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(180, 20);
            this.birthDatePicker.TabIndex = 25;
            this.birthDatePicker.Visible = false;
            // 
            // sexComboBox
            // 
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Not Known",
            "Male",
            "Female",
            "Not Specified"});
            this.sexComboBox.Location = new System.Drawing.Point(108, 98);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(97, 21);
            this.sexComboBox.TabIndex = 24;
            this.sexComboBox.Visible = false;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(108, 181);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(217, 20);
            this.phoneNumberTextBox.TabIndex = 22;
            this.phoneNumberTextBox.Visible = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(108, 220);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(217, 20);
            this.emailTextBox.TabIndex = 21;
            this.emailTextBox.Visible = false;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(108, 52);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(217, 20);
            this.lastNameTextBox.TabIndex = 20;
            this.lastNameTextBox.Visible = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(108, 13);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(217, 20);
            this.firstNameTextBox.TabIndex = 19;
            this.firstNameTextBox.Visible = false;
            // 
            // addPatientButton
            // 
            this.addPatientButton.Location = new System.Drawing.Point(436, 449);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(96, 34);
            this.addPatientButton.TabIndex = 17;
            this.addPatientButton.Text = "Add patient";
            this.addPatientButton.UseVisualStyleBackColor = true;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(612, 449);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(84, 34);
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(755, 449);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(84, 34);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // patientLookupLbl
            // 
            this.patientLookupLbl.AutoSize = true;
            this.patientLookupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientLookupLbl.Location = new System.Drawing.Point(457, 369);
            this.patientLookupLbl.Name = "patientLookupLbl";
            this.patientLookupLbl.Size = new System.Drawing.Size(88, 15);
            this.patientLookupLbl.TabIndex = 20;
            this.patientLookupLbl.Text = "Patient lookup:";
            // 
            // selectPatientComboBox
            // 
            this.selectPatientComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.selectPatientComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectPatientComboBox.FormattingEnabled = true;
            this.selectPatientComboBox.Location = new System.Drawing.Point(458, 390);
            this.selectPatientComboBox.Name = "selectPatientComboBox";
            this.selectPatientComboBox.Size = new System.Drawing.Size(201, 24);
            this.selectPatientComboBox.TabIndex = 21;
            this.selectPatientComboBox.SelectedIndexChanged += new System.EventHandler(this.selectPatientComboBox_SelectedIndexChanged);
            this.selectPatientComboBox.TextUpdate += new System.EventHandler(this.selectPatientComboBox_TextUpdate);
            this.selectPatientComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.selectPatientComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyUp);
            // 
            // patientsProvidedServicesDataGridView
            // 
            this.patientsProvidedServicesDataGridView.AllowUserToAddRows = false;
            this.patientsProvidedServicesDataGridView.AllowUserToDeleteRows = false;
            this.patientsProvidedServicesDataGridView.AllowUserToResizeRows = false;
            this.patientsProvidedServicesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.patientsProvidedServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsProvidedServicesDataGridView.Location = new System.Drawing.Point(420, 12);
            this.patientsProvidedServicesDataGridView.Name = "patientsProvidedServicesDataGridView";
            this.patientsProvidedServicesDataGridView.ReadOnly = true;
            this.patientsProvidedServicesDataGridView.RowHeadersVisible = false;
            this.patientsProvidedServicesDataGridView.Size = new System.Drawing.Size(681, 330);
            this.patientsProvidedServicesDataGridView.TabIndex = 22;
            this.patientsProvidedServicesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsProvidedServicesDataGridView_CellContentClick);
            this.patientsProvidedServicesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.patientsProvidedServicesDataGridView_DataBindingComplete);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 507);
            this.Controls.Add(this.patientsProvidedServicesDataGridView);
            this.Controls.Add(this.patientLookupLbl);
            this.Controls.Add(this.selectPatientComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.patientGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientForm";
            this.Text = "Patient details";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.patientGroupBox.ResumeLayout(false);
            this.patientGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsProvidedServicesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.GroupBox patientGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label patientBirthDateLbl;
        private System.Windows.Forms.Label patientSexLbl;
        private System.Windows.Forms.Label patientLastNameLbl;
        private System.Windows.Forms.Label patientFirstNameLbl;
        private System.Windows.Forms.RichTextBox notesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label patientLookupLbl;
        private System.Windows.Forms.ComboBox selectPatientComboBox;
        private System.Windows.Forms.DataGridView patientsProvidedServicesDataGridView;
    }
}