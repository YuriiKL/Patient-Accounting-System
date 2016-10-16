namespace Patient_Accounting_System.DesktopUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.recentPSlabel = new System.Windows.Forms.Label();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.addProvidedServiceButton = new System.Windows.Forms.Button();
            this.refreshRecentProvidedServicesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doctorLookupButton = new System.Windows.Forms.Button();
            this.patientsLookupButton = new System.Windows.Forms.Button();
            this.accountingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.addGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToDeleteRows = false;
            this.mainDataGridView.AllowUserToOrderColumns = true;
            this.mainDataGridView.AllowUserToResizeRows = false;
            this.mainDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mainDataGridView.Location = new System.Drawing.Point(12, 225);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.ReadOnly = true;
            this.mainDataGridView.RowHeadersVisible = false;
            this.mainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDataGridView.Size = new System.Drawing.Size(1037, 359);
            this.mainDataGridView.TabIndex = 0;
            this.mainDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataGridView_CellContentClick);
            this.mainDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.mainDataGridView_DataBindingComplete);
            // 
            // recentPSlabel
            // 
            this.recentPSlabel.AutoSize = true;
            this.recentPSlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recentPSlabel.Location = new System.Drawing.Point(12, 198);
            this.recentPSlabel.Name = "recentPSlabel";
            this.recentPSlabel.Size = new System.Drawing.Size(165, 16);
            this.recentPSlabel.TabIndex = 3;
            this.recentPSlabel.Text = "Recent provided services:";
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.addPatientButton);
            this.addGroupBox.Controls.Add(this.addProvidedServiceButton);
            this.addGroupBox.Location = new System.Drawing.Point(127, 28);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(150, 138);
            this.addGroupBox.TabIndex = 5;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add information";
            // 
            // addPatientButton
            // 
            this.addPatientButton.Location = new System.Drawing.Point(22, 85);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(100, 34);
            this.addPatientButton.TabIndex = 1;
            this.addPatientButton.Text = "Add new patient";
            this.addPatientButton.UseVisualStyleBackColor = true;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // addProvidedServiceButton
            // 
            this.addProvidedServiceButton.Location = new System.Drawing.Point(22, 31);
            this.addProvidedServiceButton.Name = "addProvidedServiceButton";
            this.addProvidedServiceButton.Size = new System.Drawing.Size(100, 34);
            this.addProvidedServiceButton.TabIndex = 0;
            this.addProvidedServiceButton.Text = "Add provided service";
            this.addProvidedServiceButton.UseVisualStyleBackColor = true;
            this.addProvidedServiceButton.Click += new System.EventHandler(this.addProvidedServiceButton_Click);
            // 
            // refreshRecentProvidedServicesButton
            // 
            this.refreshRecentProvidedServicesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshRecentProvidedServicesButton.Location = new System.Drawing.Point(974, 198);
            this.refreshRecentProvidedServicesButton.Name = "refreshRecentProvidedServicesButton";
            this.refreshRecentProvidedServicesButton.Size = new System.Drawing.Size(75, 23);
            this.refreshRecentProvidedServicesButton.TabIndex = 6;
            this.refreshRecentProvidedServicesButton.Text = "Refresh";
            this.refreshRecentProvidedServicesButton.UseVisualStyleBackColor = true;
            this.refreshRecentProvidedServicesButton.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.doctorLookupButton);
            this.groupBox1.Controls.Add(this.patientsLookupButton);
            this.groupBox1.Location = new System.Drawing.Point(323, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 138);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information lookup";
            // 
            // doctorLookupButton
            // 
            this.doctorLookupButton.Location = new System.Drawing.Point(27, 85);
            this.doctorLookupButton.Name = "doctorLookupButton";
            this.doctorLookupButton.Size = new System.Drawing.Size(100, 34);
            this.doctorLookupButton.TabIndex = 3;
            this.doctorLookupButton.Text = "Doctor lookup";
            this.doctorLookupButton.UseVisualStyleBackColor = true;
            this.doctorLookupButton.Click += new System.EventHandler(this.doctorLookupButton_Click);
            // 
            // patientsLookupButton
            // 
            this.patientsLookupButton.Location = new System.Drawing.Point(27, 31);
            this.patientsLookupButton.Name = "patientsLookupButton";
            this.patientsLookupButton.Size = new System.Drawing.Size(100, 34);
            this.patientsLookupButton.TabIndex = 2;
            this.patientsLookupButton.Text = "Patient lookup";
            this.patientsLookupButton.UseVisualStyleBackColor = true;
            this.patientsLookupButton.Click += new System.EventHandler(this.patientsLookupButton_Click);
            // 
            // accountingButton
            // 
            this.accountingButton.Location = new System.Drawing.Point(542, 59);
            this.accountingButton.Name = "accountingButton";
            this.accountingButton.Size = new System.Drawing.Size(100, 39);
            this.accountingButton.TabIndex = 4;
            this.accountingButton.Text = "Accounting information";
            this.accountingButton.UseVisualStyleBackColor = true;
            this.accountingButton.Click += new System.EventHandler(this.accountingButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 596);
            this.Controls.Add(this.accountingButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.refreshRecentProvidedServicesButton);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.recentPSlabel);
            this.Controls.Add(this.mainDataGridView);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Patient Accounting System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.addGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.Label recentPSlabel;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.Button addProvidedServiceButton;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button patientsLookupButton;
        private System.Windows.Forms.Button doctorLookupButton;
        private System.Windows.Forms.Button accountingButton;
        protected System.Windows.Forms.Button refreshRecentProvidedServicesButton;
    }
}

