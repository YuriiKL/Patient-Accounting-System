namespace Patient_Accounting_System.DesktopUI.Forms
{
    partial class AccountingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountingForm));
            this.accountingProvidedServicesDataGridView = new System.Windows.Forms.DataGridView();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceAccountingInformationButton = new System.Windows.Forms.Button();
            this.doctorAccountingInformationButton = new System.Windows.Forms.Button();
            this.patientAccountingInformationButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.threeMonthsButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sixMonthsButton = new System.Windows.Forms.Button();
            this.yearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountingProvidedServicesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountingProvidedServicesDataGridView
            // 
            this.accountingProvidedServicesDataGridView.AllowUserToAddRows = false;
            this.accountingProvidedServicesDataGridView.AllowUserToDeleteRows = false;
            this.accountingProvidedServicesDataGridView.AllowUserToOrderColumns = true;
            this.accountingProvidedServicesDataGridView.AllowUserToResizeRows = false;
            this.accountingProvidedServicesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountingProvidedServicesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.accountingProvidedServicesDataGridView.Location = new System.Drawing.Point(12, 149);
            this.accountingProvidedServicesDataGridView.Name = "accountingProvidedServicesDataGridView";
            this.accountingProvidedServicesDataGridView.ReadOnly = true;
            this.accountingProvidedServicesDataGridView.RowHeadersVisible = false;
            this.accountingProvidedServicesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountingProvidedServicesDataGridView.Size = new System.Drawing.Size(802, 428);
            this.accountingProvidedServicesDataGridView.TabIndex = 41;
            this.accountingProvidedServicesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountingProvidedServicesDataGridView_CellContentClick);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(81, 29);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 42;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(81, 69);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.toDateTimePicker.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "From date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Before date:";
            // 
            // serviceAccountingInformationButton
            // 
            this.serviceAccountingInformationButton.Location = new System.Drawing.Point(57, 21);
            this.serviceAccountingInformationButton.Name = "serviceAccountingInformationButton";
            this.serviceAccountingInformationButton.Size = new System.Drawing.Size(87, 25);
            this.serviceAccountingInformationButton.TabIndex = 47;
            this.serviceAccountingInformationButton.Text = "Services";
            this.serviceAccountingInformationButton.UseVisualStyleBackColor = true;
            this.serviceAccountingInformationButton.Click += new System.EventHandler(this.showAccountingInformation_Click);
            // 
            // doctorAccountingInformationButton
            // 
            this.doctorAccountingInformationButton.Location = new System.Drawing.Point(57, 56);
            this.doctorAccountingInformationButton.Name = "doctorAccountingInformationButton";
            this.doctorAccountingInformationButton.Size = new System.Drawing.Size(87, 25);
            this.doctorAccountingInformationButton.TabIndex = 48;
            this.doctorAccountingInformationButton.Text = "Doctors";
            this.doctorAccountingInformationButton.UseVisualStyleBackColor = true;
            this.doctorAccountingInformationButton.Click += new System.EventHandler(this.doctorAccountingInformationButton_Click);
            // 
            // patientAccountingInformationButton
            // 
            this.patientAccountingInformationButton.Location = new System.Drawing.Point(57, 91);
            this.patientAccountingInformationButton.Name = "patientAccountingInformationButton";
            this.patientAccountingInformationButton.Size = new System.Drawing.Size(87, 25);
            this.patientAccountingInformationButton.TabIndex = 49;
            this.patientAccountingInformationButton.Text = "Patients";
            this.patientAccountingInformationButton.UseVisualStyleBackColor = true;
            this.patientAccountingInformationButton.Click += new System.EventHandler(this.patientAccountingInformationButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serviceAccountingInformationButton);
            this.groupBox1.Controls.Add(this.patientAccountingInformationButton);
            this.groupBox1.Controls.Add(this.doctorAccountingInformationButton);
            this.groupBox1.Location = new System.Drawing.Point(533, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 131);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display accounting information for...";
            // 
            // threeMonthsButton
            // 
            this.threeMonthsButton.Location = new System.Drawing.Point(22, 19);
            this.threeMonthsButton.Name = "threeMonthsButton";
            this.threeMonthsButton.Size = new System.Drawing.Size(75, 23);
            this.threeMonthsButton.TabIndex = 51;
            this.threeMonthsButton.Text = "3 months";
            this.threeMonthsButton.UseVisualStyleBackColor = true;
            this.threeMonthsButton.Click += new System.EventHandler(this.threeMonthsButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.fromDateTimePicker);
            this.groupBox2.Controls.Add(this.toDateTimePicker);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 131);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Period of accounting information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.yearButton);
            this.groupBox3.Controls.Add(this.sixMonthsButton);
            this.groupBox3.Controls.Add(this.threeMonthsButton);
            this.groupBox3.Location = new System.Drawing.Point(353, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 110);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Last...";
            // 
            // sixMonthsButton
            // 
            this.sixMonthsButton.Location = new System.Drawing.Point(22, 47);
            this.sixMonthsButton.Name = "sixMonthsButton";
            this.sixMonthsButton.Size = new System.Drawing.Size(75, 23);
            this.sixMonthsButton.TabIndex = 52;
            this.sixMonthsButton.Text = "6 months";
            this.sixMonthsButton.UseVisualStyleBackColor = true;
            this.sixMonthsButton.Click += new System.EventHandler(this.sixMonthsButton_Click);
            // 
            // yearButton
            // 
            this.yearButton.Location = new System.Drawing.Point(22, 76);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(75, 23);
            this.yearButton.TabIndex = 53;
            this.yearButton.Text = "Year";
            this.yearButton.UseVisualStyleBackColor = true;
            this.yearButton.Click += new System.EventHandler(this.yearButton_Click);
            // 
            // AccountingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.accountingProvidedServicesDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountingForm";
            this.Text = "Accounting information";
            ((System.ComponentModel.ISupportInitialize)(this.accountingProvidedServicesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView accountingProvidedServicesDataGridView;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button serviceAccountingInformationButton;
        private System.Windows.Forms.Button doctorAccountingInformationButton;
        private System.Windows.Forms.Button patientAccountingInformationButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button threeMonthsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button yearButton;
        private System.Windows.Forms.Button sixMonthsButton;
    }
}