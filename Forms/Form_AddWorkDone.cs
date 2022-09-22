using ContractManagementSystem.Classes;
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
    public partial class Form_AddWorkDone : Form
    {
        public string worktitle { get; set; }
        public string workAssignId { get; set; } 
        public string contractorName { get; set; }
        public string CAcost { get; set; }

        public Form_AddWorkDone()
        {
            InitializeComponent();
        }

        public string getWorkToBeDone(string sql)
        {

            MySqlConnection conn = DbContract.GetConnection();

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;

            MySqlDataReader reader = cmd.ExecuteReader();
            string id = "";
            try
            {
                while (reader.Read())
                {
                    id = reader[0].ToString();
                }

            }
            catch (MySqlException ex)
            {
                id = "";
                MessageBox.Show(ex.Message);
            }
            return id;
            conn.Close();
        }

        private void Form_AddWorkDone_Load(object sender, EventArgs e)
        {
            lblContractorName.Text = contractorName;
            lblTitle.Text = worktitle;
            llblWorkToBeDone.Text = getWorkToBeDone("SELECT work_to_be_done FROM calculations WHERE work_assign_id = '" + workAssignId + "'");
        }

        public void updateCalculations(double newWorkDone, double newPayableAmount, double workToBeDone)
        {
            string sql = "UPDATE calculations SET work_done_amount = @newWorkDone, payable_amount = @newPayableAmount, work_to_be_done = @workToBeDone  WHERE work_assign_id = '" + workAssignId + "'";
            MySqlConnection conn = DbContract.GetConnection();

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@newWorkDone", MySqlDbType.Text).Value =newWorkDone;
            cmd.Parameters.Add("@newPayableAmount", MySqlDbType.Text).Value = newPayableAmount;
            cmd.Parameters.Add("@workToBeDone", MySqlDbType.Text).Value = workToBeDone;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Work Done Has Been Updated","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        public void insertCalculationsData(string work_assign_id, double newWorkDone, double newPayableAmount, double workToBeDone, string  paid_amount)
        {
            string sql = "INSERT INTO calculations_data VALUES( NULL, @workAssignId, @newWorkDone,  @newPayableAmount, @workToBeDone, @paid_amount  )";
            MySqlConnection conn = DbContract.GetConnection();

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@workAssignId", MySqlDbType.Text).Value = work_assign_id;
            cmd.Parameters.Add("@newWorkDone", MySqlDbType.Text).Value = newWorkDone;
            cmd.Parameters.Add("@newPayableAmount", MySqlDbType.Text).Value = newPayableAmount;
            cmd.Parameters.Add("@workToBeDone", MySqlDbType.Text).Value = workToBeDone;
            cmd.Parameters.Add("@paid_amount", MySqlDbType.Text).Value = paid_amount;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnSaveWorkDone_Click(object sender, EventArgs e)
        {
            if(txtWorkDone.Text.Trim().Length < 1 || double.Parse(txtWorkDone.Text) ==0)
            {
                MessageBox.Show("Amount of Work Done cannot be empty","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(double.Parse(txtWorkDone.Text) > double.Parse(llblWorkToBeDone.Text))
            {
                MessageBox.Show("Work Done cannot be greater than the Work to be Done", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string workDone = getWorkToBeDone("SELECT work_done_amount FROM calculations WHERE work_assign_id = '" + workAssignId + "'");

            double newWorkDone = double.Parse(txtWorkDone.Text) + double.Parse(workDone);

            string toBePAid = getWorkToBeDone("SELECT payable_amount FROM calculations WHERE work_assign_id = '" + workAssignId + "'");

            double newPayableAmount = double.Parse(txtWorkDone.Text) + double.Parse(toBePAid);

            double WorkToBeDone = double.Parse(llblWorkToBeDone.Text) - double.Parse(txtWorkDone.Text);

            insertCalculationsData(workAssignId, newWorkDone, newPayableAmount, WorkToBeDone, txtWorkDone.Text);

            updateCalculations(newWorkDone,newPayableAmount, WorkToBeDone);


        }

        private void btnCancelWorkDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
