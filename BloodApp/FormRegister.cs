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
    public partial class FormRegister : Form
    {
        Blood1 BloodConfig = new Blood1();
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnGoLogin_Click(object sender, EventArgs e)
        {
            Form1 GoLoging = new Form1();
            GoLoging.Show();
            this.Hide();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if(validate_Email() && validate_Pass() && validate_Position() && validate_Position() && validate_RepeatPass() && validate_userName() )
            {
                string User = txtUserNameRegister.Text.Trim(),
                Password = txtUserPasswordRegister.Text.Trim(),
                RepeatPassword = txtRepeatPasswordRegister.Text.Trim(),
                Email = txtUserEmailRegister.Text.Trim(),
                Acess = txtUserPosition.Text.Trim();

                bool result = BloodConfig.Register(User, Password, Email);

                string message = result ? "Registration Succesful" : "Error, Please Try Again";
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Error! Please Complete All the Sections", "Could not Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUserNameRegister_Validating(object sender, CancelEventArgs e)
        {
            validate_userName();
        }
        private bool validate_userName()
        {
            if(txtUserNameRegister.Text.Trim() == "")
            {
                erpUser.SetError(txtUserNameRegister, "Use a valid user name");
            return false;
            }
            else
            {
                erpUser.SetError(txtUserNameRegister, "");
                return true;
            }
        }

        private void txtUserPasswordRegister_Validating(object sender, CancelEventArgs e)
        {
            validate_Pass();
        }
        private bool validate_Pass()
        {
            if(!Regex.IsMatch(txtUserPasswordRegister.Text.Trim(), @"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$"))
            {
                erpUser.SetError(txtUserPasswordRegister, "Invalid Password, Use at Leas One Number, and Upper Case Letter");
                return false;
            }
            else
            {
                erpUser.SetError(txtUserPasswordRegister, "");
                return true;
            }
        }

        private void txtRepeatPasswordRegister_Validating(object sender, CancelEventArgs e)
        {
            validate_RepeatPass();
        }
        private bool validate_RepeatPass()
        {
            if (txtRepeatPasswordRegister.Text.Trim() == "" || txtRepeatPasswordRegister.Text != txtUserPasswordRegister.Text)
            {
                erpUser.SetError(txtRepeatPasswordRegister, "Passwords Don't Match");
                return false;
            }
            else
            {
                erpUser.SetError(txtRepeatPasswordRegister, "");
                return true;
            }
        }

        private void txtUserEmailRegister_Validating(object sender, CancelEventArgs e)
        {
            validate_Email();
        }
        private bool validate_Email()
        {
            if(Regex.IsMatch(txtUserEmailRegister.Text.Trim(), @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$"))
            {
                erpUser.SetError(txtUserEmailRegister, "Use a Valid Email");
                return false;
            }
            else
            {
                erpUser.SetError(txtUserEmailRegister, "");
                return true;
            }
        }

        private void txtUserPosition_Validating(object sender, CancelEventArgs e)
        {
            validate_Position();
        }
        private bool validate_Position()
        {
            if (txtUserPosition.Text.Trim() == "")
            {
                erpUser.SetError(txtUserPosition, "Assing a Position to the User");
                return false;
            }
            else
            {
                erpUser.SetError(txtUserPosition, "");
                return true;
            }
        }
    }
}
