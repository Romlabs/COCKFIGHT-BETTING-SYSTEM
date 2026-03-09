using System;
using System.Windows.Forms;

namespace Cockfight_Betting_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Cockfight Betting System";
            this.Size = new System.Drawing.Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Login Button
            Button loginButton = new Button();
            loginButton.Text = "Login Bettor";
            loginButton.Location = new System.Drawing.Point(150, 50);
            loginButton.Size = new System.Drawing.Size(100, 40);
            loginButton.Click += LoginButton_Click;
            this.Controls.Add(loginButton);

            // Register Button
            Button registerButton = new Button();
            registerButton.Text = "Register Bettor";
            registerButton.Location = new System.Drawing.Point(150, 110);
            registerButton.Size = new System.Drawing.Size(100, 40);
            registerButton.Click += RegisterButton_Click;
            this.Controls.Add(registerButton);

            // Exit Button
            Button exitButton = new Button();
            exitButton.Text = "Exit";
            exitButton.Location = new System.Drawing.Point(150, 170);
            exitButton.Size = new System.Drawing.Size(100, 40);
            exitButton.Click += ExitButton_Click;
            this.Controls.Add(exitButton);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Placeholder for Login logic
            MessageBox.Show("Login functionality not implemented yet.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Placeholder for Register logic
            MessageBox.Show("Register functionality not implemented yet.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}