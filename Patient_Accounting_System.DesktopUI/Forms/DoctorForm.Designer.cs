namespace Patient_Accounting_System.DesktopUI.Forms
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.doctorInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.doctorPhoneNumberLbl = new System.Windows.Forms.Label();
            this.doctorLastNameLbl = new System.Windows.Forms.Label();
            this.doctorTitleLbl = new System.Windows.Forms.Label();
            this.doctorFirstNameLbl = new System.Windows.Forms.Label();
            this.previousProvidedServicesDataGridView = new System.Windows.Forms.DataGridView();
            this.selectDoctorComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doctorInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previousProvidedServicesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorInformationGroupBox
            // 
            this.doctorInformationGroupBox.Controls.Add(this.label14);
            this.doctorInformationGroupBox.Controls.Add(this.label12);
            this.doctorInformationGroupBox.Controls.Add(this.label11);
            this.doctorInformationGroupBox.Controls.Add(this.label9);
            this.doctorInformationGroupBox.Controls.Add(this.doctorPhoneNumberLbl);
            this.doctorInformationGroupBox.Controls.Add(this.doctorLastNameLbl);
            this.doctorInformationGroupBox.Controls.Add(this.doctorTitleLbl);
            this.doctorInformationGroupBox.Controls.Add(this.doctorFirstNameLbl);
            this.doctorInformationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.doctorInformationGroupBox.Name = "doctorInformationGroupBox";
            this.doctorInformationGroupBox.Size = new System.Drawing.Size(325, 183);
            this.doctorInformationGroupBox.TabIndex = 39;
            this.doctorInformationGroupBox.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(28, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "Phone number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(28, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Title:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(28, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Last name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(28, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "First name:";
            // 
            // doctorPhoneNumberLbl
            // 
            this.doctorPhoneNumberLbl.AutoSize = true;
            this.doctorPhoneNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorPhoneNumberLbl.Location = new System.Drawing.Point(120, 144);
            this.doctorPhoneNumberLbl.Name = "doctorPhoneNumberLbl";
            this.doctorPhoneNumberLbl.Size = new System.Drawing.Size(0, 16);
            this.doctorPhoneNumberLbl.TabIndex = 18;
            // 
            // doctorLastNameLbl
            // 
            this.doctorLastNameLbl.AutoSize = true;
            this.doctorLastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorLastNameLbl.Location = new System.Drawing.Point(121, 68);
            this.doctorLastNameLbl.Name = "doctorLastNameLbl";
            this.doctorLastNameLbl.Size = new System.Drawing.Size(0, 16);
            this.doctorLastNameLbl.TabIndex = 17;
            // 
            // doctorTitleLbl
            // 
            this.doctorTitleLbl.AutoSize = true;
            this.doctorTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorTitleLbl.Location = new System.Drawing.Point(121, 107);
            this.doctorTitleLbl.Name = "doctorTitleLbl";
            this.doctorTitleLbl.Size = new System.Drawing.Size(0, 16);
            this.doctorTitleLbl.TabIndex = 16;
            // 
            // doctorFirstNameLbl
            // 
            this.doctorFirstNameLbl.AutoSize = true;
            this.doctorFirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorFirstNameLbl.Location = new System.Drawing.Point(121, 31);
            this.doctorFirstNameLbl.Name = "doctorFirstNameLbl";
            this.doctorFirstNameLbl.Size = new System.Drawing.Size(0, 16);
            this.doctorFirstNameLbl.TabIndex = 15;
            // 
            // previousProvidedServicesDataGridView
            // 
            this.previousProvidedServicesDataGridView.AllowUserToAddRows = false;
            this.previousProvidedServicesDataGridView.AllowUserToDeleteRows = false;
            this.previousProvidedServicesDataGridView.AllowUserToOrderColumns = true;
            this.previousProvidedServicesDataGridView.AllowUserToResizeRows = false;
            this.previousProvidedServicesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.previousProvidedServicesDataGridView.Location = new System.Drawing.Point(355, 12);
            this.previousProvidedServicesDataGridView.Name = "previousProvidedServicesDataGridView";
            this.previousProvidedServicesDataGridView.ReadOnly = true;
            this.previousProvidedServicesDataGridView.RowHeadersVisible = false;
            this.previousProvidedServicesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.previousProvidedServicesDataGridView.Size = new System.Drawing.Size(680, 388);
            this.previousProvidedServicesDataGridView.TabIndex = 40;
            this.previousProvidedServicesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousProvidedServicesDataGridView_CellContentClick);
            this.previousProvidedServicesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.previousProvidedServicesDataGridView_DataBindingComplete);
            // 
            // selectDoctorComboBox
            // 
            this.selectDoctorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.selectDoctorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectDoctorComboBox.FormattingEnabled = true;
            this.selectDoctorComboBox.Location = new System.Drawing.Point(41, 57);
            this.selectDoctorComboBox.Name = "selectDoctorComboBox";
            this.selectDoctorComboBox.Size = new System.Drawing.Size(201, 24);
            this.selectDoctorComboBox.TabIndex = 42;
            this.selectDoctorComboBox.SelectedIndexChanged += new System.EventHandler(this.selectDoctorComboBox_SelectedIndexChanged);
            this.selectDoctorComboBox.TextUpdate += new System.EventHandler(this.selectDoctorComboBox_TextUpdate);
            this.selectDoctorComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.selectDoctorComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Type doctor name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectDoctorComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 116);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor lookup";
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 420);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.previousProvidedServicesDataGridView);
            this.Controls.Add(this.doctorInformationGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorForm";
            this.Text = "Doctor Information";
            this.doctorInformationGroupBox.ResumeLayout(false);
            this.doctorInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previousProvidedServicesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox doctorInformationGroupBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label doctorPhoneNumberLbl;
        private System.Windows.Forms.Label doctorLastNameLbl;
        private System.Windows.Forms.Label doctorTitleLbl;
        private System.Windows.Forms.Label doctorFirstNameLbl;
        private System.Windows.Forms.DataGridView previousProvidedServicesDataGridView;
        private System.Windows.Forms.ComboBox selectDoctorComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}