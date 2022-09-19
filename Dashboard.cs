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

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        public void addUserControls(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
            uc.BringToFront();

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Dash dash = new UC_Dash();
            addUserControls(dash);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Work work = new UC_Work();
            addUserControls(work);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Contractors contractors = new UC_Contractors();
            addUserControls(contractors);
        }
    }
}
