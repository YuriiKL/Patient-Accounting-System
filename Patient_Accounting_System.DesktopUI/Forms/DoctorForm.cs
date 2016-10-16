using Patient_Accounting_System.DesktopUI.Code;
using Patient_Accounting_System.Entities;
using Patient_Accounting_System.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Accounting_System.DesktopUI.Forms
{
    public partial class DoctorForm : Form
    {
        private List<Doctor> _suggestedDoctors;
        private Doctor _currentDoctor;
        public readonly string ConnectionString = ConfigurationManager.ConnectionStrings["PatientAccountingSystem"].ConnectionString;
        private List<ProvidedService> _recentProvidedServices;
        private bool _needUpdate;

        public DoctorForm()
        {
            InitializeComponent();
        }
        public DoctorForm(int DoctorId)
        {
            InitializeComponent();

            _currentDoctor = new SqlDoctorRepository(ConnectionString).GetDoctorById(DoctorId);
            RefreshDisplayedInformation();
            ShowRecentProvidedServices();
        }

        private void RefreshDisplayedInformation()
        {
            doctorFirstNameLbl.Text = _currentDoctor.FirstName;
            doctorLastNameLbl.Text = _currentDoctor.LastName;
            doctorTitleLbl.Text = _currentDoctor.Title;
            doctorPhoneNumberLbl.Text = _currentDoctor.PhoneNumber;
        }

        private void ShowRecentProvidedServices()
        {
            previousProvidedServicesDataGridView.Columns.Clear();

            SqlPreviouslyProvidedServiceRepository prev = new SqlPreviouslyProvidedServiceRepository(ConnectionString);
            _recentProvidedServices = prev.GetPreviuoslyProvidedServicesByDoctorId(_currentDoctor.DoctorId).ToList();
            previousProvidedServicesDataGridView.DataSource = _recentProvidedServices;

            DataGridViewButtonColumn detailsButton = new DataGridViewButtonColumn();
            detailsButton.UseColumnTextForButtonValue = true;
            detailsButton.Text = "Show details";
            previousProvidedServicesDataGridView.Columns.Insert(previousProvidedServicesDataGridView.Columns.Count, detailsButton);

            previousProvidedServicesDataGridView.Refresh();
        }

        #region Events

        private void previousProvidedServicesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            previousProvidedServicesDataGridView.Columns["ProvidedServiceId"].Visible = false;
            previousProvidedServicesDataGridView.Columns["Notes"].Visible = false;
            previousProvidedServicesDataGridView.Columns["PatientId"].Visible = false;
            previousProvidedServicesDataGridView.Columns["DoctorId"].Visible = false;
            previousProvidedServicesDataGridView.Columns["ServiceId"].Visible = false;
            previousProvidedServicesDataGridView.Columns["DoctorLastName"].Visible = false;
            previousProvidedServicesDataGridView.Columns["DoctorFirstName"].Visible = false;
            previousProvidedServicesDataGridView.Columns["DoctorTitle"].Visible = false;

            previousProvidedServicesDataGridView.Columns["PatientFirstName"].HeaderText = "Patient first name";
            previousProvidedServicesDataGridView.Columns["PatientLastName"].HeaderText = "Patient last name";
            previousProvidedServicesDataGridView.Columns["ExecutionDateTime"].HeaderText = "Execution time";
            previousProvidedServicesDataGridView.Columns["ServiceName"].HeaderText = "Service name";
            previousProvidedServicesDataGridView.Columns["ServicePrice"].HeaderText = "Price";
        }

        private void previousProvidedServicesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var providedServiceForm = new ProvidedServiceForm(_recentProvidedServices[e.RowIndex]);
                providedServiceForm.Show();
            }
        }

        private void comboBox_KeyUp(object sender, KeyEventArgs e)
        {
            var comboBox = (sender as ComboBox);
            if (e.KeyCode == Keys.Back)
            {
                int stringStart = comboBox.SelectionStart;
                if (stringStart > 0)
                {
                    if (stringStart == 0)
                    {
                        comboBox.Text = "";
                    }
                    else
                    {
                        comboBox.Text = comboBox.Text.Substring(0, stringStart);
                    }
                    comboBox.SelectionStart = comboBox.Text.Length;
                }
                e.Handled = true;
            }
        }

        private void comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                _needUpdate = false;
            }
            else
            {
                _needUpdate = true;
            }
        }

        private void selectDoctorComboBox_TextUpdate(object sender, EventArgs e)
        {
            var comboBox = (sender as ComboBox);

            if (_needUpdate && comboBox.Text.Length > 0)
            {
                var sqlDoctorRepository = new SqlDoctorRepository(ConnectionString);
                var suggestedDoctors = sqlDoctorRepository.SearchDoctorsByName(comboBox.Text).ToList();

                if (suggestedDoctors.Count > 0)
                {
                    _suggestedDoctors = suggestedDoctors;
                    List<string> searchDoctors = _suggestedDoctors.Select(p => p.FirstName + " " + p.LastName).ToList();

                    ControlsHandling.HandleTextChanged(searchDoctors, comboBox);
                }
            }
        }

        private void selectDoctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suggestedDoctors.Count > 0)
            {
                _currentDoctor = _suggestedDoctors[selectDoctorComboBox.SelectedIndex];
                RefreshDisplayedInformation();
                ShowRecentProvidedServices();
            }
        }

#endregion Events
    }
}
