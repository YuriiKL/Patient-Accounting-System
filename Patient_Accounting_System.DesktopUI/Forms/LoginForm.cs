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
using Patient_Accounting_System.DesktopUI.Code;
using System.Configuration;

namespace Patient_Accounting_System.DesktopUI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            
            SqlUserRepository userRepository = new SqlUserRepository(ConfigurationManager.ConnectionStrings["PatientAccountingSystem"].ConnectionString);

            User user = userRepository.GetUserByLogin(login, Hashes.GetMD5Hash(password));

            if (user != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                warningLabel.Visible = true;
                passwordTextBox.Text = String.Empty;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
