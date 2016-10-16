using Patient_Accounting_System.Repositories;
using Patient_Accounting_System.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Patient_Accounting_System.DesktopUI.Forms
{
    public partial class AccountingForm : Form
    {
        private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["PatientAccountingSystem"].ConnectionString;

        public AccountingForm()
        {
            InitializeComponent();

            toDateTimePicker.MaxDate = DateTime.Now;
            fromDateTimePicker.MaxDate = DateTime.Now;
            fromDateTimePicker.Value = DateTime.Today.AddMonths(-3);
        }

        #region DataGridViewHandling

        private void HidePatientColumns()
        {
            accountingProvidedServicesDataGridView.Columns["PatientFirstName"].Visible = false;
            accountingProvidedServicesDataGridView.Columns["PatientLastName"].Visible = false;
        }
        private void HideServiceColumns()
        {
            accountingProvidedServicesDataGridView.Columns["ServiceName"].Visible = false;
            accountingProvidedServicesDataGridView.Columns["ServicePrice"].Visible = false;
            accountingProvidedServicesDataGridView.Columns["ServicePrice"].Visible = false;
        }
        private void HideDoctorColumns()
        {
            accountingProvidedServicesDataGridView.Columns["DoctorFirstName"].Visible = false;
            accountingProvidedServicesDataGridView.Columns["DoctorLastName"] .Visible = false;
            accountingProvidedServicesDataGridView.Columns["DoctorTitle"].Visible = false;
        }
        
        private void SetDataGridViewColumns()
        {
            accountingProvidedServicesDataGridView.Columns["ProvidedServiceId"].Visible = false;
            accountingProvidedServicesDataGridView.Columns["Notes"].Visible = false;
            accountingProvidedServicesDataGridView.Columns["PatientId"].Visible = false;
            accountingProvidedServicesDataGridView.Columns["DoctorId"].Visible = false;
            accountingProvidedServicesDataGridView.Columns["ServiceId"].Visible = false;
            accountingProvidedServicesDataGridView.Columns["ExecutionDateTime"].Visible = false;
            accountingProvidedServicesDataGridView.Columns["ExecutionDateTime"].Visible = false;

            accountingProvidedServicesDataGridView.Columns["TotalCost"].DisplayIndex = accountingProvidedServicesDataGridView.ColumnCount - 1;
            accountingProvidedServicesDataGridView.Columns["AverageCostPerService"].DisplayIndex = accountingProvidedServicesDataGridView.ColumnCount - 2;
            accountingProvidedServicesDataGridView.Columns["ServicesProvided"].DisplayIndex = accountingProvidedServicesDataGridView.ColumnCount - 3;

            accountingProvidedServicesDataGridView.Columns["TotalCost"].HeaderText = "Total cost";
            accountingProvidedServicesDataGridView.Columns["PatientFirstName"].HeaderText = "Patient first name";
            accountingProvidedServicesDataGridView.Columns["PatientLastName"].HeaderText = "Patient last name";
            accountingProvidedServicesDataGridView.Columns["DoctorFirstName"].HeaderText = "Doctor first name";
            accountingProvidedServicesDataGridView.Columns["DoctorLastName"].HeaderText = "Doctor last name";
            accountingProvidedServicesDataGridView.Columns["DoctorTitle"].HeaderText = "Doctor title";
            accountingProvidedServicesDataGridView.Columns["ServiceName"].HeaderText = "Service name";
            accountingProvidedServicesDataGridView.Columns["ServicePrice"].HeaderText = "Service price";
            accountingProvidedServicesDataGridView.Columns["AverageCostPerService"].HeaderText = "Average cost per service";
            accountingProvidedServicesDataGridView.Columns["ServicesProvided"].HeaderText = "Count of services provided";
        }

        #endregion DataGridViewHandling

        #region Buttons

        private void showAccountingInformation_Click(object sender, EventArgs e)
        {
            accountingProvidedServicesDataGridView.Columns.Clear();

            var sqlAccountingProvidedServiceRepository = new SqlAccountingProvidedServiceRepository(ConnectionString);
            List<AccountingProvidedService> accountingProvidedServices = sqlAccountingProvidedServiceRepository
                .GetServiceAccountingInformation(fromDateTimePicker.Value, toDateTimePicker.Value).ToList();

            accountingProvidedServicesDataGridView.DataSource = accountingProvidedServices;
            accountingProvidedServicesDataGridView.Columns["AverageCostPerService"].Visible = false;

            SetDataGridViewColumns();
            HideDoctorColumns();
            HidePatientColumns();

            accountingProvidedServicesDataGridView.Refresh();
        }

        private void doctorAccountingInformationButton_Click(object sender, EventArgs e)
        {
            accountingProvidedServicesDataGridView.Columns.Clear();

            var sqlAccountingProvidedServiceRepository = new SqlAccountingProvidedServiceRepository(ConnectionString);
            List<AccountingProvidedService> accountingProvidedServices = sqlAccountingProvidedServiceRepository
                .GetDoctorAccountingInformation(fromDateTimePicker.Value, toDateTimePicker.Value).ToList();

            DataGridViewButtonColumn detailsButton = new DataGridViewButtonColumn();
            detailsButton.UseColumnTextForButtonValue = true;
            detailsButton.Text = "Show details";
            accountingProvidedServicesDataGridView.DataSource = accountingProvidedServices;

            SetDataGridViewColumns();
            HideServiceColumns();
            HidePatientColumns();
            accountingProvidedServicesDataGridView.Columns.Insert(accountingProvidedServicesDataGridView.Columns.Count, detailsButton);

            accountingProvidedServicesDataGridView.Refresh();
        }

        private void patientAccountingInformationButton_Click(object sender, EventArgs e)
        {
            accountingProvidedServicesDataGridView.Columns.Clear();

            var sqlAccountingProvidedServiceRepository = new SqlAccountingProvidedServiceRepository(ConnectionString);
            List<AccountingProvidedService> accountingProvidedServices = sqlAccountingProvidedServiceRepository
                .GetPatientAccountingInformation(fromDateTimePicker.Value, toDateTimePicker.Value).ToList();

            DataGridViewButtonColumn detailsButton = new DataGridViewButtonColumn();
            detailsButton.UseColumnTextForButtonValue = true;
            detailsButton.Text = "Show details";

            accountingProvidedServicesDataGridView.DataSource = accountingProvidedServices;

            SetDataGridViewColumns();
            HideServiceColumns();
            HideDoctorColumns();
            accountingProvidedServicesDataGridView.Columns.Insert(accountingProvidedServicesDataGridView.Columns.Count, detailsButton);

            accountingProvidedServicesDataGridView.Refresh();
        }

        private void threeMonthsButton_Click(object sender, EventArgs e)
        {
            fromDateTimePicker.Value = DateTime.Today.AddMonths(-3);
        }

        private void sixMonthsButton_Click(object sender, EventArgs e)
        {
            fromDateTimePicker.Value = DateTime.Today.AddMonths(-6);
        }

        private void yearButton_Click(object sender, EventArgs e)
        {
            fromDateTimePicker.Value = DateTime.Today.AddYears(-1);
        }

        #endregion Buttons

        private void accountingProvidedServicesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int doctorId = Convert.ToInt32(senderGrid[senderGrid.Columns["DoctorId"].Index, e.RowIndex].Value);
                int patientId = Convert.ToInt32(senderGrid[senderGrid.Columns["PatientId"].Index, e.RowIndex].Value);
                if (doctorId > 0)
                {
                    var doctorForm = new DoctorForm(doctorId);
                    doctorForm.Show();
                }

                if (patientId > 0)
                {
                    var patientForm = new PatientForm(patientId);
                    patientForm.Show();
                }
            }
        }
    }
}
