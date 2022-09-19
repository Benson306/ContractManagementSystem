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
        public Form_AddWork()
        {
            InitializeComponent();
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

            txtLocation.Text ="";
            txtWorkTitle.Text = "";
            txtTsNumber.Text = "";
            txtTsAmount.Text = "";
            cmType.Text = "";

        }

        private void btnCancelWork_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=cms";
            MySqlConnection conn = new MySqlConnection(sql);

            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }
        public int workid;

        public int findId(string name)
        {
            string sql = "SELECT id FROM work_types WHERE name = @name";

            MySqlConnection conn = GetConnection();

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@name", MySqlDbType.Text).Value = name;

            MySqlDataReader reader = cmd.ExecuteReader();

            string id="0";
            while (reader.Read())
            {
               id= reader["id"].ToString();
            }

            workid = Convert.ToInt32(id);
            conn.Close();


            return workid;
            
        }
        public void fillCombo()
        {
            try
            {
                
                string sql = "SELECT name, id FROM work_types";
                MySqlConnection conn = GetConnection();

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

        private void Form_AddWork_Load(object sender, EventArgs e)
        {
            fillCombo();

        }
    }
}
