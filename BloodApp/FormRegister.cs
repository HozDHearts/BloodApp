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
    public partial class FormRegister : Form
    {
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
    }
}
