using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractManagementSystem.UserControls
{
    public partial class UC_Contractors : UserControl
    {
        public UC_Contractors()
        {
            InitializeComponent();
        }

        private void btnSaveContractor_Click(object sender, EventArgs e)
        {
            if(txtContractorName.Text.Trim().Length < 1)
            {
                MessageBox.Show("Full Names cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtContractorAddress.Text.Trim().Length < 1)
            {
                MessageBox.Show("Address cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Contractor ct = new Contractor(txtContractorName.Text, txtContractorAddress.Text);
            DbContract.addContractor(ct);
            txtContractorAddress.Text = txtContractorName.Text = "";
        }

        private void UC_Contractors_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM contractors;";
            DbContract.DisplayAndSearchContractor(query, dgvContractor);
        }

        private void txtSearchContractor_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM contractors WHERE full_name LIKE '%"+ txtSearchContractor.Text +"%' OR address LIKE '%" +txtSearchContractor.Text+ "%' ;";
            DbContract.DisplayAndSearchContractor(query, dgvContractor);
        }
    }
}
