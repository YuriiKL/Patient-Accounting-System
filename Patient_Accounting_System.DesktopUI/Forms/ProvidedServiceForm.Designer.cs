namespace Patient_Accounting_System.DesktopUI.Forms
{
    partial class ProvidedServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvidedServiceForm));
            this.label1 = new System.Windows.Forms.Label();
            this.datePortionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timePortionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addProvidedService = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectPatientComboBox = new System.Windows.Forms.ComboBox();
            this.selectDoctorComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectServiceComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.patientGroupBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showPatientDetails = new System.Windows.Forms.Button();
            this.patientBirthDateLbl = new System.Windows.Forms.Label();
            this.patientSexLbl = new System.Windows.Forms.Label();
            this.patientLastNameLbl = new System.Windows.Forms.Label();
            this.patientFirstNameLbl = new System.Windows.Forms.Label();
            this.doctorGroupBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.doctorPhoneNumberLbl = new System.Windows.Forms.Label();
            this.doctorLastNameLbl = new System.Windows.Forms.Label();
            this.doctorTitleLbl = new System.Windows.Forms.Label();
            this.doctorFirstNameLbl = new System.Windows.Forms.Label();
            this.serviceGroupBox = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.RichTextBox();
            this.servicePriceLbl = new System.Windows.Forms.Label();
            this.serviceNameLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.selectDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.editProvidedServiceGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.patientGroupBox.SuspendLayout();
            this.doctorGroupBox.SuspendLayout();
            this.serviceGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.selectDetailsGroupBox.SuspendLayout();
            this.editProvidedServiceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type patient name:";
            // 
            // datePortionDateTimePicker
            // 
            this.datePortionDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePortionDateTimePicker.Location = new System.Drawing.Point(16, 179);
            this.datePortionDateTimePicker.Name = "datePortionDateTimePicker";
            this.datePortionDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.datePortionDateTimePicker.TabIndex = 2;
            // 
            // timePortionDateTimePicker
            // 
            this.timePortionDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timePortionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePortionDateTimePicker.Location = new System.Drawing.Point(152, 179);
            this.timePortionDateTimePicker.Name = "timePortionDateTimePicker";
            this.timePortionDateTimePicker.ShowUpDown = true;
            this.timePortionDateTimePicker.Size = new System.Drawing.Size(75, 20);
            this.timePortionDateTimePicker.TabIndex = 3;
            // 
            // addProvidedService
            // 
            this.addProvidedService.Location = new System.Drawing.Point(16, 215);
            this.addProvidedService.Name = "addProvidedService";
            this.addProvidedService.Size = new System.Drawing.Size(101, 37);
            this.addProvidedService.TabIndex = 4;
            this.addProvidedService.Text = "Add providing service";
            this.addProvidedService.UseVisualStyleBackColor = true;
            this.addProvidedService.Click += new System.EventHandler(this.addProvidedService_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(152, 220);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(79, 26);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // selectPatientComboBox
            // 
            this.selectPatientComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.selectPatientComboBox.FormattingEnabled = true;
            this.selectPatientComboBox.Location = new System.Drawing.Point(16, 31);
            this.selectPatientComboBox.Name = "selectPatientComboBox";
            this.selectPatientComboBox.Size = new System.Drawing.Size(201, 21);
            this.selectPatientComboBox.TabIndex = 6;
            this.selectPatientComboBox.SelectedIndexChanged += new System.EventHandler(this.selectPatientComboBox_SelectedIndexChanged);
            this.selectPatientComboBox.TextUpdate += new System.EventHandler(this.selectPatientComboBox_TextUpdate);
            this.selectPatientComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.selectPatientComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyUp);
            // 
            // selectDoctorComboBox
            // 
            this.selectDoctorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.selectDoctorComboBox.FormattingEnabled = true;
            this.selectDoctorComboBox.Location = new System.Drawing.Point(16, 76);
            this.selectDoctorComboBox.Name = "selectDoctorComboBox";
            this.selectDoctorComboBox.Size = new System.Drawing.Size(201, 21);
            this.selectDoctorComboBox.TabIndex = 9;
            this.selectDoctorComboBox.SelectedIndexChanged += new System.EventHandler(this.selectDoctorComboBox_SelectedIndexChanged);
            this.selectDoctorComboBox.TextUpdate += new System.EventHandler(this.selectDoctorComboBox_TextUpdate);
            this.selectDoctorComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.selectDoctorComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type doctor name:";
            // 
            // selectServiceComboBox
            // 
            this.selectServiceComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.selectServiceComboBox.FormattingEnabled = true;
            this.selectServiceComboBox.Location = new System.Drawing.Point(16, 122);
            this.selectServiceComboBox.Name = "selectServiceComboBox";
            this.selectServiceComboBox.Size = new System.Drawing.Size(201, 21);
            this.selectServiceComboBox.TabIndex = 11;
            this.selectServiceComboBox.SelectedIndexChanged += new System.EventHandler(this.selectServiceComboBox_SelectedIndexChanged);
            this.selectServiceComboBox.TextUpdate += new System.EventHandler(this.selectServiceComboBox_TextUpdate);
            this.selectServiceComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.selectServiceComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type service name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Specify date and time of service providing:";
            // 
            // patientGroupBox
            // 
            this.patientGroupBox.Controls.Add(this.label10);
            this.patientGroupBox.Controls.Add(this.label7);
            this.patientGroupBox.Controls.Add(this.label5);
            this.patientGroupBox.Controls.Add(this.label3);
            this.patientGroupBox.Controls.Add(this.showPatientDetails);
            this.patientGroupBox.Controls.Add(this.patientBirthDateLbl);
            this.patientGroupBox.Controls.Add(this.patientSexLbl);
            this.patientGroupBox.Controls.Add(this.patientLastNameLbl);
            this.patientGroupBox.Controls.Add(this.patientFirstNameLbl);
            this.patientGroupBox.Location = new System.Drawing.Point(3, 3);
            this.patientGroupBox.Name = "patientGroupBox";
            this.patientGroupBox.Size = new System.Drawing.Size(292, 258);
            this.patientGroupBox.TabIndex = 15;
            this.patientGroupBox.TabStop = false;
            this.patientGroupBox.Text = "Patient";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(17, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Sex:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Birth date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "First name:";
            // 
            // showPatientDetails
            // 
            this.showPatientDetails.Location = new System.Drawing.Point(16, 209);
            this.showPatientDetails.Name = "showPatientDetails";
            this.showPatientDetails.Size = new System.Drawing.Size(85, 37);
            this.showPatientDetails.TabIndex = 4;
            this.showPatientDetails.Text = "Show patient";
            this.showPatientDetails.UseVisualStyleBackColor = true;
            this.showPatientDetails.Click += new System.EventHandler(this.showPatientDetails_Click);
            // 
            // patientBirthDateLbl
            // 
            this.patientBirthDateLbl.AutoSize = true;
            this.patientBirthDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientBirthDateLbl.Location = new System.Drawing.Point(116, 154);
            this.patientBirthDateLbl.Name = "patientBirthDateLbl";
            this.patientBirthDateLbl.Size = new System.Drawing.Size(0, 16);
            this.patientBirthDateLbl.TabIndex = 3;
            // 
            // patientSexLbl
            // 
            this.patientSexLbl.AutoSize = true;
            this.patientSexLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientSexLbl.Location = new System.Drawing.Point(116, 115);
            this.patientSexLbl.Name = "patientSexLbl";
            this.patientSexLbl.Size = new System.Drawing.Size(0, 16);
            this.patientSexLbl.TabIndex = 2;
            // 
            // patientLastNameLbl
            // 
            this.patientLastNameLbl.AutoSize = true;
            this.patientLastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientLastNameLbl.Location = new System.Drawing.Point(116, 76);
            this.patientLastNameLbl.Name = "patientLastNameLbl";
            this.patientLastNameLbl.Size = new System.Drawing.Size(0, 16);
            this.patientLastNameLbl.TabIndex = 1;
            // 
            // patientFirstNameLbl
            // 
            this.patientFirstNameLbl.AutoSize = true;
            this.patientFirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientFirstNameLbl.Location = new System.Drawing.Point(116, 37);
            this.patientFirstNameLbl.Name = "patientFirstNameLbl";
            this.patientFirstNameLbl.Size = new System.Drawing.Size(0, 16);
            this.patientFirstNameLbl.TabIndex = 0;
            // 
            // doctorGroupBox
            // 
            this.doctorGroupBox.Controls.Add(this.label14);
            this.doctorGroupBox.Controls.Add(this.label12);
            this.doctorGroupBox.Controls.Add(this.label11);
            this.doctorGroupBox.Controls.Add(this.label9);
            this.doctorGroupBox.Controls.Add(this.doctorPhoneNumberLbl);
            this.doctorGroupBox.Controls.Add(this.doctorLastNameLbl);
            this.doctorGroupBox.Controls.Add(this.doctorTitleLbl);
            this.doctorGroupBox.Controls.Add(this.doctorFirstNameLbl);
            this.doctorGroupBox.Location = new System.Drawing.Point(301, 3);
            this.doctorGroupBox.Name = "doctorGroupBox";
            this.doctorGroupBox.Size = new System.Drawing.Size(252, 258);
            this.doctorGroupBox.TabIndex = 16;
            this.doctorGroupBox.TabStop = false;
            this.doctorGroupBox.Text = "Doctor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(15, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 15);
            this.label14.TabIndex = 14;
            this.label14.Text = "Phone number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(15, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Title:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(15, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Last name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(15, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "First name:";
            // 
            // doctorPhoneNumberLbl
            // 
            this.doctorPhoneNumberLbl.AutoSize = true;
            this.doctorPhoneNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorPhoneNumberLbl.Location = new System.Drawing.Point(108, 169);
            this.doctorPhoneNumberLbl.Name = "doctorPhoneNumberLbl";
            this.doctorPhoneNumberLbl.Size = new System.Drawing.Size(0, 16);
            this.doctorPhoneNumberLbl.TabIndex = 7;
            // 
            // doctorLastNameLbl
            // 
            this.doctorLastNameLbl.AutoSize = true;
            this.doctorLastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorLastNameLbl.Location = new System.Drawing.Point(108, 75);
            this.doctorLastNameLbl.Name = "doctorLastNameLbl";
            this.doctorLastNameLbl.Size = new System.Drawing.Size(0, 16);
            this.doctorLastNameLbl.TabIndex = 6;
            // 
            // doctorTitleLbl
            // 
            this.doctorTitleLbl.AutoSize = true;
            this.doctorTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorTitleLbl.Location = new System.Drawing.Point(108, 122);
            this.doctorTitleLbl.Name = "doctorTitleLbl";
            this.doctorTitleLbl.Size = new System.Drawing.Size(0, 16);
            this.doctorTitleLbl.TabIndex = 5;
            // 
            // doctorFirstNameLbl
            // 
            this.doctorFirstNameLbl.AutoSize = true;
            this.doctorFirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorFirstNameLbl.Location = new System.Drawing.Point(108, 28);
            this.doctorFirstNameLbl.Name = "doctorFirstNameLbl";
            this.doctorFirstNameLbl.Size = new System.Drawing.Size(0, 16);
            this.doctorFirstNameLbl.TabIndex = 4;
            // 
            // serviceGroupBox
            // 
            this.serviceGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.serviceGroupBox.Controls.Add(this.label15);
            this.serviceGroupBox.Controls.Add(this.label13);
            this.serviceGroupBox.Controls.Add(this.label8);
            this.serviceGroupBox.Controls.Add(this.notesTextBox);
            this.serviceGroupBox.Controls.Add(this.servicePriceLbl);
            this.serviceGroupBox.Controls.Add(this.serviceNameLbl);
            this.serviceGroupBox.Location = new System.Drawing.Point(299, 267);
            this.serviceGroupBox.Name = "serviceGroupBox";
            this.serviceGroupBox.Size = new System.Drawing.Size(550, 292);
            this.serviceGroupBox.TabIndex = 17;
            this.serviceGroupBox.TabStop = false;
            this.serviceGroupBox.Text = "Service";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(17, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 15);
            this.label15.TabIndex = 12;
            this.label15.Text = "Price:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(17, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(17, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Providing service notes (optional):  ";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(20, 117);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(515, 164);
            this.notesTextBox.TabIndex = 10;
            this.notesTextBox.Text = "";
            // 
            // servicePriceLbl
            // 
            this.servicePriceLbl.AutoSize = true;
            this.servicePriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servicePriceLbl.Location = new System.Drawing.Point(101, 60);
            this.servicePriceLbl.Name = "servicePriceLbl";
            this.servicePriceLbl.Size = new System.Drawing.Size(0, 16);
            this.servicePriceLbl.TabIndex = 9;
            // 
            // serviceNameLbl
            // 
            this.serviceNameLbl.AutoSize = true;
            this.serviceNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceNameLbl.Location = new System.Drawing.Point(101, 26);
            this.serviceNameLbl.Name = "serviceNameLbl";
            this.serviceNameLbl.Size = new System.Drawing.Size(0, 16);
            this.serviceNameLbl.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.patientGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.doctorGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.selectDetailsGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.editProvidedServiceGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.serviceGroupBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(858, 566);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // selectDetailsGroupBox
            // 
            this.selectDetailsGroupBox.Controls.Add(this.label1);
            this.selectDetailsGroupBox.Controls.Add(this.datePortionDateTimePicker);
            this.selectDetailsGroupBox.Controls.Add(this.label6);
            this.selectDetailsGroupBox.Controls.Add(this.timePortionDateTimePicker);
            this.selectDetailsGroupBox.Controls.Add(this.cancelButton);
            this.selectDetailsGroupBox.Controls.Add(this.addProvidedService);
            this.selectDetailsGroupBox.Controls.Add(this.selectServiceComboBox);
            this.selectDetailsGroupBox.Controls.Add(this.label4);
            this.selectDetailsGroupBox.Controls.Add(this.selectDoctorComboBox);
            this.selectDetailsGroupBox.Controls.Add(this.selectPatientComboBox);
            this.selectDetailsGroupBox.Controls.Add(this.label2);
            this.selectDetailsGroupBox.Location = new System.Drawing.Point(559, 3);
            this.selectDetailsGroupBox.Name = "selectDetailsGroupBox";
            this.selectDetailsGroupBox.Size = new System.Drawing.Size(290, 258);
            this.selectDetailsGroupBox.TabIndex = 19;
            this.selectDetailsGroupBox.TabStop = false;
            // 
            // editProvidedServiceGroupBox
            // 
            this.editProvidedServiceGroupBox.Controls.Add(this.deleteButton);
            this.editProvidedServiceGroupBox.Controls.Add(this.editButton);
            this.editProvidedServiceGroupBox.Location = new System.Drawing.Point(3, 267);
            this.editProvidedServiceGroupBox.Name = "editProvidedServiceGroupBox";
            this.editProvidedServiceGroupBox.Size = new System.Drawing.Size(290, 123);
            this.editProvidedServiceGroupBox.TabIndex = 20;
            this.editProvidedServiceGroupBox.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(152, 26);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(101, 37);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete provided service";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(16, 26);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(101, 37);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "Edit provided service";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ProvidedServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(881, 585);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProvidedServiceForm";
            this.Text = "Providing service ";
            this.Load += new System.EventHandler(this.AddProvidedServiceForm_Load);
            this.patientGroupBox.ResumeLayout(false);
            this.patientGroupBox.PerformLayout();
            this.doctorGroupBox.ResumeLayout(false);
            this.doctorGroupBox.PerformLayout();
            this.serviceGroupBox.ResumeLayout(false);
            this.serviceGroupBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.selectDetailsGroupBox.ResumeLayout(false);
            this.selectDetailsGroupBox.PerformLayout();
            this.editProvidedServiceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePortionDateTimePicker;
        private System.Windows.Forms.DateTimePicker timePortionDateTimePicker;
        private System.Windows.Forms.Button addProvidedService;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox selectPatientComboBox;
        private System.Windows.Forms.ComboBox selectDoctorComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectServiceComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button showPatientDetails;
        private System.Windows.Forms.Label patientBirthDateLbl;
        private System.Windows.Forms.Label patientSexLbl;
        private System.Windows.Forms.Label patientLastNameLbl;
        private System.Windows.Forms.Label patientFirstNameLbl;
        private System.Windows.Forms.Label doctorPhoneNumberLbl;
        private System.Windows.Forms.Label doctorLastNameLbl;
        private System.Windows.Forms.Label doctorTitleLbl;
        private System.Windows.Forms.Label doctorFirstNameLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox notesTextBox;
        private System.Windows.Forms.Label servicePriceLbl;
        private System.Windows.Forms.Label serviceNameLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        protected System.Windows.Forms.GroupBox patientGroupBox;
        protected System.Windows.Forms.GroupBox doctorGroupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        protected System.Windows.Forms.GroupBox selectDetailsGroupBox;
        protected System.Windows.Forms.GroupBox serviceGroupBox;
        private System.Windows.Forms.GroupBox editProvidedServiceGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
    }
}