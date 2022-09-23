using ContractManagementSystem.Classes;
using ContractManagementSystem.UserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractManagementSystem.Forms
{
    public partial class Form_Assign_Work : Form
    {
        public string workId { get; set; }
        public string title { get; set; }
        public string ts_number { get; set; }
        public string ts_amount { get; set; }
        public Form_Assign_Work()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string sql = "SELECT address FROM contractors WHERE full_name = '" + cmbContractors.SelectedItem.ToString() + "'";
                MySqlConnection conn = DbContract.GetConnection();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.CommandType = CommandType.Text;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lblAddress.Text = reader["address"].ToString();
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Assign_Work_Load(object sender, EventArgs e)
        {
            fillCombo();
            lblTsNumber.Text = ts_number;
            lblTsAmount.Text = ts_amount;
            lblTitle.Text = title;
        }
        public void fillCombo()
        {
            try
            {

                string sql = "SELECT full_name,id FROM contractors";
                MySqlConnection conn = DbContract.GetConnection();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.CommandType = CommandType.Text;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbContractors.Items.Add(reader["full_name"].ToString());
                    cmbContractors.ValueMember = reader["id"].ToString();
                    cmbContractors.DisplayMember = reader["full_name"].ToString();
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelAssign_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string contractorId;
        private void cmbContractors_Leave(object sender, EventArgs e)
        {
            try
            {

                string sql = "SELECT id FROM contractors WHERE full_name = '" + cmbContractors.SelectedItem.ToString() + "'";
                MySqlConnection conn = DbContract.GetConnection();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.CommandType = CommandType.Text;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    contractorId = reader["id"].ToString();
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSaveAssignedWork_Click(object sender, EventArgs e)
        {
            if(cmbContractors.Text.Trim().Length < 1 || txtCaCost.Text.Trim().Length < 1 || cmbYear.Text.Trim().Length < 1 || dateTimeAssignDate.Text.Trim().Length < 1)
            {
                MessageBox.Show("Field Cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WorkAssigned wa = new WorkAssigned(workId, contractorId, txtCaCost.Text, dateTimeAssignDate.Text, cmbYear.Text);
            DbContract.AddWorkAssigned(wa);
            string work_assigned_id = DbContract.GetWorkAssignedId();

            DbContract.editWork(workId);
            this.Close();


        }
    }
}
