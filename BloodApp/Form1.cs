using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Blood1 BloodConfig = new Blood1();
            BloodConfig.Loging();
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
    }
}
