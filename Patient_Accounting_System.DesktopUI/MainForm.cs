using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patient_Accounting_System.Repositories;
using Patient_Accounting_System.Entities;
using System.Configuration;
using System.Threading;

namespace Patient_Accounting_System.DesktopUI
{
    public partial class MainForm : Form
    {
        public readonly string ConnectionString = ConfigurationManager.ConnectionStrings["PatientAccountingSystem"].ConnectionString;
        private List <ProvidedService> _recentProvidedServices;

        public MainForm()
        {
            InitializeComponent();
        }

        #region EventHandlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            BindRecentProvidedServices();
        }
        private void mainDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            mainDataGridView.Columns["ProvidedServiceId"].Visible = false;
            mainDataGridView.Columns["Notes"].Visible = false;
            mainDataGridView.Columns["PatientId"].Visible = false;
            mainDataGridView.Columns["DoctorId"].Visible = false;
            mainDataGridView.Columns["ServiceId"].Visible = false;

            mainDataGridView.Columns["ExecutionDateTime"].HeaderText = "Execution time";
            mainDataGridView.Columns["PatientFirstName"].HeaderText = "Patient first name";
            mainDataGridView.Columns["PatientLastName"].HeaderText = "Patient last name";
            mainDataGridView.Columns["DoctorFirstName"].HeaderText = "Doctor first name";
            mainDataGridView.Columns["DoctorLastName"].HeaderText = "Doctor last name";
            mainDataGridView.Columns["DoctorTitle"].HeaderText = "Doctor title";
            mainDataGridView.Columns["ServiceName"].HeaderText = "Service name";
            mainDataGridView.Columns["ServicePrice"].HeaderText = "Service price";
        }

        private void addProvidedServiceButton_Click(object sender, EventArgs e)
        {
            var addProvidedServiceForm = new Forms.ProvidedServiceForm();
            addProvidedServiceForm.Show();
        }

        private void mainDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var providedServiceForm = new Forms.ProvidedServiceForm(_recentProvidedServices[e.RowIndex]);
                providedServiceForm.Show();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            BindRecentProvidedServices();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            Forms.PatientForm patientForm = new Forms.PatientForm();
            patientForm.Show();
        }

        private void patientsLookupButton_Click(object sender, EventArgs e)
        {
            Forms.PatientForm patientForm = new Forms.PatientForm(3);
            patientForm.Show();
        }

        private void doctorLookupButton_Click(object sender, EventArgs e)
        {
            Forms.DoctorForm doctorForm = new Forms.DoctorForm(2);
            doctorForm.Show();
        }

        private void accountingButton_Click(object sender, EventArgs e)
        {
            Forms.AccountingForm accountingForm = new Forms.AccountingForm();
            accountingForm.Show();
        }

        #endregion EventHandlers

        #region HelperMethods

        private void BindRecentProvidedServices()
        {
            mainDataGridView.Columns.Clear();

            SqlPreviouslyProvidedServiceRepository prev = new SqlPreviouslyProvidedServiceRepository(ConnectionString);
            _recentProvidedServices = prev.GetPreviuoslyProvidedServices().ToList();
            mainDataGridView.DataSource = _recentProvidedServices;

            DataGridViewButtonColumn detailsButton = new DataGridViewButtonColumn();
            detailsButton.UseColumnTextForButtonValue = true;
            detailsButton.Text = "Show details";
            mainDataGridView.Columns.Insert(mainDataGridView.Columns.Count, detailsButton);

            mainDataGridView.Refresh();
        }



        public static void UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            DialogResult result = DialogResult.Cancel;
            try
            {
                result = ShowThreadExceptionDialog("Windows Forms Error", t.Exception);
            }
            catch
            {
                try
                {
                    MessageBox.Show("Fatal Error",
                        "Fatal Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }

            if (result == DialogResult.Abort)
                Application.Exit();
        }

        private static DialogResult ShowThreadExceptionDialog(string title, Exception e)
        {
            string errorMsg = "An application error occurred\n" +
                "Error information:\n\n";
            errorMsg = errorMsg + e.Message + "\n\nStack Trace:\n" + e.StackTrace;
            return MessageBox.Show(errorMsg, title, MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Stop);
        }

        #endregion HelperMethods
    }
}
