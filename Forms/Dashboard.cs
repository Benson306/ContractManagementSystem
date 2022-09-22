using ContractManagementSystem.Classes;
using ContractManagementSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            UC_Dash dash = new UC_Dash();
            addUserControls(dash);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {
            lblUser.Text = LoginInfo.userName;
            timer1.Start();
        }

        public void addUserControls(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
            uc.BringToFront();

        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UC_Dash dash = new UC_Dash();
            addUserControls(dash);
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            UC_AssignedWork work = new UC_AssignedWork();
            addUserControls(work);
        }

        private void btnContractors_Click(object sender, EventArgs e)
        {
            UC_Contractors contractors = new UC_Contractors();
            addUserControls(contractors);
        }

        

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void btnWorks_Click(object sender, EventArgs e)
        {
            UC_Work work = new UC_Work();
            addUserControls(work);
        }
    }
}
