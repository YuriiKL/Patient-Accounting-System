namespace Patient_Accounting_System.DesktopUI.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.greatingTextLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.credentinalsPanel = new System.Windows.Forms.Panel();
            this.warningLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.credentinalsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // greatingTextLabel
            // 
            this.greatingTextLabel.AutoSize = true;
            this.greatingTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greatingTextLabel.Location = new System.Drawing.Point(75, 19);
            this.greatingTextLabel.Name = "greatingTextLabel";
            this.greatingTextLabel.Size = new System.Drawing.Size(248, 16);
            this.greatingTextLabel.TabIndex = 0;
            this.greatingTextLabel.Text = "Welcome to Patients Accounting System";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(112, 23);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(125, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(112, 58);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(125, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(27, 26);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(44, 16);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Login:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(27, 61);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(71, 16);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // credentinalsPanel
            // 
            this.credentinalsPanel.Controls.Add(this.warningLabel);
            this.credentinalsPanel.Controls.Add(this.loginTextBox);
            this.credentinalsPanel.Controls.Add(this.passwordLabel);
            this.credentinalsPanel.Controls.Add(this.passwordTextBox);
            this.credentinalsPanel.Controls.Add(this.loginLabel);
            this.credentinalsPanel.Location = new System.Drawing.Point(60, 62);
            this.credentinalsPanel.Name = "credentinalsPanel";
            this.credentinalsPanel.Size = new System.Drawing.Size(279, 121);
            this.credentinalsPanel.TabIndex = 5;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.warningLabel.Location = new System.Drawing.Point(68, 93);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(123, 13);
            this.warningLabel.TabIndex = 5;
            this.warningLabel.Text = "Invalid login or password";
            this.warningLabel.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(78, 205);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(240, 205);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 252);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.credentinalsPanel);
            this.Controls.Add(this.greatingTextLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Login";
            this.credentinalsPanel.ResumeLayout(false);
            this.credentinalsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greatingTextLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel credentinalsPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label warningLabel;
    }
}