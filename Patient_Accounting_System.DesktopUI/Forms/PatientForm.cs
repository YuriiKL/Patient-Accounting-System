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
    public partial class PatientForm : Form
    {
        // Review TK: Naming for private fields.
        private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["PatientAccountingSystem"].ConnectionString;

        // According to ISO 5218 standart
        private const short NotApplicableHumanSexCode = 9;

        private Patient _currentPatient;

        private bool _updateMode;
        private bool _needUpdate;

        private List<Patient> _suggestedPatients;
        private List<ProvidedService> _recentProvidedServices;

        public PatientForm()
        {
            InitializeComponent();
            _updateMode = false;
            editButton.Visible = false;
        }

        public PatientForm(int patientId)
        {
            InitializeComponent();
            _currentPatient = new SqlPatientRepository(ConnectionString).GetPatientById(patientId);
            notesTextBox.ReadOnly = true;
            _updateMode = true;
            // Review TK: Use const or resources for strings.
            addPatientButton.Text = "Update patient information";
            addPatientButton.Visible = false;
            selectPatientComboBox.Visible = true;
            patientLookupLbl.Visible = true;
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            if (_updateMode)
            {
                DisplayInformation();
                ShowRecentProvidedServices();
            }
            else
            {
                ShowEditControls();
            }

            birthDatePicker.MaxDate = DateTime.Now;
        }

        #region HelperMethods

        private void DisplayInformation()
        {
            patientFirstNameLbl.Text = _currentPatient.FirstName;
            patientLastNameLbl.Text = _currentPatient.LastName;
            emailLbl.Text = _currentPatient.Email;
            phoneNumberLbl.Text = _currentPatient.PhoneNumber;

            var today = DateTime.Today;
            int age = today.Year - _currentPatient.BirthDate.Year;
            //Review TK: Use {} with if.
            if (_currentPatient.BirthDate > today.AddYears(-age)) age--;
            //Review TK: Why didn't you use string interpolation.
            patientBirthDateLbl.Text = _currentPatient.BirthDate.ToShortDateString() + " (" + age + " years)";

            notesTextBox.Text = _currentPatient.Notes;
            patientSexLbl.Text = _currentPatient.SexString;
        }
        private void ShowEditControls()
        {
            emailLbl.Visible = false;
            phoneNumberLbl.Visible = false;
            patientBirthDateLbl.Visible = false;
            patientSexLbl.Visible = false;
            patientLastNameLbl.Visible = false;
            patientFirstNameLbl.Visible = false;
            editButton.Visible = false;

            birthDatePicker.Visible = true;
            sexComboBox.Visible = true;
            phoneNumberTextBox.Visible = true;
            emailTextBox.Visible = true;
            lastNameTextBox.Visible = true;
            firstNameTextBox.Visible = true;
            notesTextBox.ReadOnly = false;
        }

        private void HideEditControls()
        {
            emailLbl.Visible = true;
            phoneNumberLbl.Visible = true;
            patientBirthDateLbl.Visible = true;
            patientSexLbl.Visible = true;
            patientLastNameLbl.Visible = true;
            patientFirstNameLbl.Visible = true;

            editButton.Visible = true;
            addPatientButton.Visible = false;
            birthDatePicker.Visible = false;
            sexComboBox.Visible = false;
            phoneNumberTextBox.Visible = false;
            emailTextBox.Visible = false;
            lastNameTextBox.Visible = false;
            firstNameTextBox.Visible = false;
            notesTextBox.ReadOnly = true;

        }
        private void FillEditControlsWithCurrentValues()
        {
            firstNameTextBox.Text = _currentPatient.FirstName;
            lastNameTextBox.Text = _currentPatient.LastName;
            birthDatePicker.Value = _currentPatient.BirthDate;
            sexComboBox.SelectedIndex = _currentPatient.Sex == NotApplicableHumanSexCode ? 3 : _currentPatient.Sex;
            phoneNumberTextBox.Text = _currentPatient.PhoneNumber;
            emailTextBox.Text = _currentPatient.Email;
            notesTextBox.Text = _currentPatient.Notes;
        }

        private void SetPatientValuesFromEditContorls()
        {
            if (_currentPatient == null)
            {
                _currentPatient = new Patient();
            }
            _currentPatient.BirthDate = birthDatePicker.Value;
            _currentPatient.Sex = sexComboBox.SelectedIndex == 3 ? NotApplicableHumanSexCode : (short)sexComboBox.SelectedIndex;
            _currentPatient.PhoneNumber = phoneNumberTextBox.Text;
            _currentPatient.Email = emailTextBox.Text;
            _currentPatient.LastName = lastNameTextBox.Text;
            _currentPatient.FirstName = firstNameTextBox.Text;
            _currentPatient.Notes = notesTextBox.Text;
        }

        private void ValidatePatientFields()
        {
            if (String.IsNullOrWhiteSpace(phoneNumberTextBox.Text) || String.IsNullOrWhiteSpace(lastNameTextBox.Text) || 
                String.IsNullOrWhiteSpace(firstNameTextBox.Text) || sexComboBox.SelectedIndex == -1)
            {
                // Review TK: Why did you decide to throw exception in this case?
                // I would prefer to use bool variable or something like that.
                throw new ArgumentException();
            }
        }

        private void ShowRecentProvidedServices()
        {
            patientsProvidedServicesDataGridView.Columns.Clear();

            SqlPreviouslyProvidedServiceRepository prev = new SqlPreviouslyProvidedServiceRepository(ConnectionString);
            _recentProvidedServices = prev.GetPreviuoslyProvidedServicesByPatientId(_currentPatient.PatientId).ToList();
            patientsProvidedServicesDataGridView.DataSource = _recentProvidedServices;

            DataGridViewButtonColumn detailsButton = new DataGridViewButtonColumn();
            detailsButton.UseColumnTextForButtonValue = true;
            detailsButton.Text = "Show details";
            patientsProvidedServicesDataGridView.Columns.Insert(patientsProvidedServicesDataGridView.Columns.Count, detailsButton);

            patientsProvidedServicesDataGridView.Refresh();
        }

        #endregion HelperMethods

        #region Events

        private void comboBox_KeyUp(object sender, KeyEventArgs e)
        {
            var comboBox = (sender as ComboBox);
            // Review TK: Again a lot of if statement.
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
            // Review TK: Please try to use other constructions. I mean ternary operator.
            if (e.KeyCode == Keys.Back)
            {
                _needUpdate = false;
            }
            else
            {
                _needUpdate = true;
            }
        }


        private void selectPatientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suggestedPatients.Count > 0)
            {
                _currentPatient = _suggestedPatients[selectPatientComboBox.SelectedIndex];
                HideEditControls();
                DisplayInformation();
                ShowRecentProvidedServices();
                _updateMode = true;
                addPatientButton.Text = "Update patient information";
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
        private void editButton_Click(object sender, EventArgs e)
        {
            ShowEditControls();
            FillEditControlsWithCurrentValues();
            addPatientButton.Visible = true;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (_currentPatient != null)
            {
                HideEditControls();
            }
            else
            {
                this.Close();
            }
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            SqlPatientRepository sqlPatientRepository = new SqlPatientRepository(ConnectionString);
            int queryResult = -1;
            try
            {
                ValidatePatientFields();
                SetPatientValuesFromEditContorls();

                // Review TK: Ternary operator.
                if (_updateMode)
                {
                    queryResult = sqlPatientRepository.UpdatePatient(_currentPatient);
                }
                else
                {
                    queryResult = sqlPatientRepository.AddNewPatient(_currentPatient);
                }

                if (queryResult > 0)
                {
                    MessageBox.Show("Operation completed successfully!", "Success");
                    this.Close();
                }

            }
            // Review TK: It seems strange.
            catch
            {
            }

            if (queryResult == -1)
            {
                MessageBox.Show("An error occurred \nPlease, check fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void patientsProvidedServicesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            patientsProvidedServicesDataGridView.Columns["ProvidedServiceId"].Visible = false;
            patientsProvidedServicesDataGridView.Columns["Notes"].Visible = false;
            patientsProvidedServicesDataGridView.Columns["PatientId"].Visible = false;
            patientsProvidedServicesDataGridView.Columns["DoctorId"].Visible = false;
            patientsProvidedServicesDataGridView.Columns["ServiceId"].Visible = false;
            patientsProvidedServicesDataGridView.Columns["PatientLastName"].Visible = false;
            patientsProvidedServicesDataGridView.Columns["PatientFirstName"].Visible = false;

            patientsProvidedServicesDataGridView.Columns["ExecutionDateTime"].HeaderText = "Execution time";
            patientsProvidedServicesDataGridView.Columns["DoctorFirstName"].HeaderText = "Doctor first name";
            patientsProvidedServicesDataGridView.Columns["DoctorLastName"].HeaderText = "Doctor last name";
            patientsProvidedServicesDataGridView.Columns["DoctorTitle"].HeaderText = "Doctor title";
            patientsProvidedServicesDataGridView.Columns["ServiceName"].HeaderText = "Service name";
            patientsProvidedServicesDataGridView.Columns["ServicePrice"].HeaderText = "Price";
        }
        private void patientsProvidedServicesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var providedServiceForm = new Forms.ProvidedServiceForm(_recentProvidedServices[e.RowIndex]);
                providedServiceForm.Show();
            }
        }

        #endregion Events
    }
}
