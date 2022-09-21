using ContractManagementSystem.Classes;
using ContractManagementSystem.UserControls;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace ContractManagementSystem
{
    public partial class Form_AddWork : Form
    {
        private readonly UC_Work _parent;
        public Form_AddWork(UC_Work parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public int workid;

        private void Form_AddWork_Load(object sender, EventArgs e)
        {
            fillCombo();

        }
        public void fillCombo()
        {
            try
            {

                string sql = "SELECT name, id FROM work_types";
                MySqlConnection conn = DbContract.GetConnection();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.CommandType = CommandType.Text;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmType.Items.Add(reader["name"].ToString());
                    cmType.ValueMember = reader["id"].ToString();
                    cmType.DisplayMember = reader["name"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }

        public int findId(string name)
        {
            string sql = "SELECT id FROM work_types WHERE name = @name";

            MySqlConnection conn = DbContract.GetConnection();

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@name", MySqlDbType.Text).Value = name;

            MySqlDataReader reader = cmd.ExecuteReader();

            string id = "0";
            while (reader.Read())
            {
                id = reader["id"].ToString();
            }

            workid = Convert.ToInt32(id);
            conn.Close();


            return workid;

        }
        private void btnSaveWork_Click(object sender, EventArgs e)
        {
            if(txtWorkTitle.Text.Trim().Length < 1)
            {
                MessageBox.Show("Work Title cannot be empty","Information",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtLocation.Text.Trim().Length < 1)
            {
                MessageBox.Show("Location cannot be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTsNumber.Text.Trim().Length < 1)
            {
                MessageBox.Show("Ts Number cannot be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTsAmount.Text.Trim().Length < 1)
            {
                MessageBox.Show("Ts Amount cannot be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmType.Text.Trim().Length < 1)
            {
                MessageBox.Show("Work type cannot be empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int type_id = findId(cmType.Text.Trim().ToString());


            Work work = new Work(txtWorkTitle.Text, txtLocation.Text, txtTsNumber.Text, txtTsAmount.Text, type_id);
            DbContract.addWork(work);
            _parent.Display();
            this.Close();

        }

        private void btnCancelWork_Click(object sender, EventArgs e)
        {
            this.Close();

        }
         
    }
}
