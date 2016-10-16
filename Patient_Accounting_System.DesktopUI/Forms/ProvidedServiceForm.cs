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
using System.Globalization;
using Patient_Accounting_System.DesktopUI.Code;

namespace Patient_Accounting_System.DesktopUI.Forms
{
    public partial class ProvidedServiceForm : Form
    {
        public readonly string ConnectionString = ConfigurationManager.ConnectionStrings["PatientAccountingSystem"].ConnectionString;

        private Patient _selectedPatient;
        private Doctor _selectedDoctor;
        private Service _selectedService;
        private ProvidedService _providedService;
        private bool _needUpdate;
        private bool _isEditable;
        private bool _updateMode;

        private List<Patient> _suggestedPatients;
        private List<Doctor> _suggestedDoctors;
        private List<Service> _suggestedServices;

        public ProvidedServiceForm()
        {
            _selectedPatient = null;
            _selectedDoctor = null;
            _selectedService = null;
            _isEditable = true;
            _updateMode = false;
            InitializeComponent();
        }

        public ProvidedServiceForm(ProvidedService providedService)
        {
            _selectedDoctor = new SqlDoctorRepository(ConnectionString).GetDoctorById(providedService.DoctorId);
            _selectedPatient = new SqlPatientRepository(ConnectionString).GetPatientById(providedService.PatientId);
            _selectedService = new SqlServiceRepository(ConnectionString).GetServiceById(providedService.ServiceId);
            _providedService = providedService;
            _isEditable = false;
            _updateMode = true;
            InitializeComponent();
        }

        #region ControlsEventHandlers

        private void AddProvidedServiceForm_Load(object sender, EventArgs e)
        {
            datePortionDateTimePicker.MaxDate = DateTime.Now;
            if (_isEditable)
            {
                editProvidedServiceGroupBox.Visible = false;
                cancelButton.Text = "Close";
            }
            else
            {
                this.Text = "Provided Service";
                
                selectDetailsGroupBox.Visible = false;
                notesTextBox.ReadOnly = true;
            }
            RefreshDisplayedInformation();
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

        private void selectPatientComboBox_TextUpdate(object sender, EventArgs e)
        {
            var comboBox = (sender as ComboBox);

            if (_needUpdate && comboBox.Text.Length > 0)
            {
                var sqlPatientRepository = new SqlPatientRepository(ConnectionString);
                var suggestedPatients = sqlPatientRepository.SearchPatientsByName(comboBox.Text).ToList();

                if (suggestedPatients.Count > 0)
                {
                    _suggestedPatients = suggestedPatients;
                    List<string> searchPatients = _suggestedPatients.Select(p => p.FirstName + " " + p.LastName).ToList();
                    ControlsHandling.HandleTextChanged(searchPatients, comboBox);
                }
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
        private void selectServiceComboBox_TextUpdate(object sender, EventArgs e)
        {
            var comboBox = (sender as ComboBox);

            if (_needUpdate && comboBox.Text.Length > 0)
            {
                var sqlServiceRepository = new SqlServiceRepository(ConnectionString);
                var suggestedServices = sqlServiceRepository.SearchServiceByName(comboBox.Text).ToList();

                if (suggestedServices.Count > 0)
                {
                    _suggestedServices = suggestedServices;
                    List<string> searchServices = _suggestedServices.Select(p => p.Name).ToList();
                    ControlsHandling.HandleTextChanged(searchServices, comboBox);
                }
            }
        }

        private void selectDoctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suggestedDoctors.Count > 0)
            {
                _selectedDoctor = _suggestedDoctors[selectDoctorComboBox.SelectedIndex];
                RefreshDisplayedInformation();
            }
        }

        private void selectPatientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suggestedPatients.Count > 0)
            {
                _selectedPatient = _suggestedPatients[selectPatientComboBox.SelectedIndex];
                RefreshDisplayedInformation();
            }
        }

        private void selectServiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suggestedServices.Count > 0)
            {
                _selectedService = _suggestedServices[selectServiceComboBox.SelectedIndex];
                RefreshDisplayedInformation();
            }
        }

        #endregion ControlsEventHandlers

        #region ButtonClickEventHandlers

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            selectDetailsGroupBox.Visible = true;
            editProvidedServiceGroupBox.Visible = false;
            notesTextBox.ReadOnly = false;
            addProvidedService.Text = "Edit provided service";
            _updateMode = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Delete current provided service?", "Delete provided service", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                var sqlPreviouslyProvidedService = new SqlPreviouslyProvidedServiceRepository(ConnectionString);

                int queryResult = sqlPreviouslyProvidedService.DeleteProvidedServiceByProvidedServiceId(_providedService.ProvidedServiceId);

                if (queryResult > 0)
                {
                    MessageBox.Show("Operation completed successfully!", "Success");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addProvidedService_Click(object sender, EventArgs e)
        {
            var sqlPreviouslyProvidedService = new SqlPreviouslyProvidedServiceRepository(ConnectionString);
            var executionDateTime = datePortionDateTimePicker.Value.Date + timePortionDateTimePicker.Value.TimeOfDay;
            int queryResult = -1;

            try
            {
                var providedService = new ProvidedService()
                {
                    PatientId = _selectedPatient.PatientId,
                    DoctorId = _selectedDoctor.DoctorId,
                    ServiceId = _selectedService.ServiceId,
                    Notes = notesTextBox.Text,
                    ExecutionDateTime = executionDateTime
                };

                if (_updateMode)
                {
                    queryResult = sqlPreviouslyProvidedService.UpdateProvidedService(providedService);
                }
                else
                {
                    queryResult = sqlPreviouslyProvidedService.AddNewProvidedService(providedService);
                }

                if (queryResult > 0)
                {
                    MessageBox.Show("Operation completed successfully!", "Success");
                    this.Close();
                }
            }
            catch
            {
            }

            if (queryResult == -1)
            {
                MessageBox.Show("An error occurred \nPlease, check fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void showPatientDetails_Click(object sender, EventArgs e)
        {
            Forms.PatientForm patientForm = new PatientForm(_selectedPatient.PatientId);
            patientForm.Show();
        }

        #endregion ButtonClickEventHandlers

        private void RefreshDisplayedInformation()
        {
            if (_selectedDoctor != null)
            {
                doctorFirstNameLbl.Text = _selectedDoctor.FirstName;
                doctorLastNameLbl.Text = _selectedDoctor.LastName;
                doctorTitleLbl.Text = _selectedDoctor.Title;
                doctorPhoneNumberLbl.Text = _selectedDoctor.PhoneNumber;
            }

            if (_selectedService != null)
            {
                serviceNameLbl.Text = _selectedService.Name;
                servicePriceLbl.Text = _selectedService.Price.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            }

            if (_selectedPatient != null)
            {
                patientFirstNameLbl.Text = _selectedPatient.FirstName;
                patientLastNameLbl.Text = _selectedPatient.LastName;

                var today = DateTime.Today;
                int age = today.Year - _selectedPatient.BirthDate.Year;
                if (_selectedPatient.BirthDate > today.AddYears(-age)) age--;

                patientBirthDateLbl.Text = _selectedPatient.BirthDate.ToShortDateString() + " (" + age + " years)";
                patientSexLbl.Text = _selectedPatient.SexString;
            }
        }
    }
}

