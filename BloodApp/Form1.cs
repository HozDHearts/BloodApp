using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodApp
{
    public partial class Form1 : Form
    {
        Blood1 BloodConfig = new Blood1();
        public Form1()
        {
            InitializeComponent();
           
           
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExitApp2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnGoRegister_Click(object sender, EventArgs e)
        {
            FormRegister Registration = new FormRegister();
            Registration.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if( Validate_Password() && Validate_UserName())
            {
                string User = txtUserNameLogin.Text.Trim(), Password = txtPasswordLogin.Text.Trim();
                bool result = BloodConfig.Loging(User, Password);

                if (result)
                {
                    frmDashboard form = new frmDashboard();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or P Please Try Again", "Could not Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtUserNameLogin_Validating(object sender, CancelEventArgs e)
        {
            Validate_UserName();
        }
        private bool Validate_UserName()
        {
            if (txtUserNameLogin.Text.Trim() == "")
            {
                erpUser.SetError(txtUserNameLogin, "The Username Textbox Must not be Empty");
                return false;
            }
            else
            {
                erpUser.SetError(txtUserNameLogin, "");
                return true;
            }
        }

        private void txtPasswordLogin_Validating(object sender, CancelEventArgs e)
        {
            Validate_Password();
        }
        private bool Validate_Password()
        {
            if (!Regex.IsMatch(txtPasswordLogin.Text.Trim(), @"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$"))
            {
                erpUser.SetError(txtPasswordLogin, "Invalid Password");
                return false;
            }
            else
            {
                erpUser.SetError(txtPasswordLogin, "");
                return true;
            }
        }

    }
}
