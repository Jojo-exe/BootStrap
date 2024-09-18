using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamProject_PCStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String userName = txtboxUserName.Text;
            String password = txtboxPassword.Text;
            String user = "Qadis";
            String pass = "4566";

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Enter UserName");
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter Password");
            }

            else if(userName.Equals(user) && password.Equals(pass))
            {
                MessageBox.Show("Login Success");
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Close();
            }
        


        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
