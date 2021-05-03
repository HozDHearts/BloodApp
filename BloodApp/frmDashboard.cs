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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

       private void frmDashboard_Load(object sender, EventArgs e)
        {
            changeForms(new frminicio());
        }

        private void btnExitDashboard_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExitDashboard2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       

        private void btnStart_Click(object sender, EventArgs e)
        {
            changeForms(new frminicio());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
                if (pnlMenu.Width == 200)
                {
                    pnlMenu.Visible = false;
                    pnlMenu.Width = 60;
                    LineL.Width = 60;
                    pnlSidebarMenu.Width = 70;
                    MinimizeTransition.Show(pnlMenu);
                }
                else
                {
                    pnlMenu.Visible = false;
                    pnlMenu.Width = 200;
                    LineL.Width = 200;
                    pnlSidebarMenu.Width = 250;
                    MaximizeTransition.Show(pnlMenu);
                }
            
        }

        private void changeForms( Object fh)
        {
            if (pnlForms.Controls.Count > 0)
            {
                pnlForms.Controls.Clear();
            }
            pnlForms.Visible = false;
            Form nfh = fh as Form;
            nfh.TopLevel = false;
            nfh.Dock = DockStyle.Fill;
            pnlForms.Controls.Add(nfh);
            pnlForms.Tag = nfh;
            nfh.Show();
            FormsAnimation.Show(pnlForms);

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProfiles_Click(object sender, EventArgs e)
        {
            changeForms(new FormRegister());
        }
    }
}
