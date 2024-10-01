using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLoginCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string storedUserName = "admin";
            string storedPassword = "password123";

            string inputUserName; 
            string inputPassword; 

            inputUserName = txtUsername.Text;
            inputPassword = txtPassword.Text;

            if (inputUserName.Equals(storedUserName) && inputPassword.Equals(storedPassword))
            {
                MessageBox.Show("You are logged in!");
                lblOutput.Text = "";
            }
            else
            {
                lblOutput.Text = "Credentials invalid";
            }
        }
    }
}
