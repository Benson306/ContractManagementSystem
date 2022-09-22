using ContractManagementSystem.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
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
    public partial class Form_AddUsers : Form
    {
        public Form_AddUsers()
        {
            InitializeComponent();
        }

        private void btnCancelWorkDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void insertUser()
        {
            string sql = "SELECT * FROM users WHERE username = @username OR email = @email";

            MySqlConnection conn = DbContract.GetConnection();

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@username", MySqlDbType.Text).Value = txtUsername.Text;
            cmd.Parameters.Add("@email", MySqlDbType.Text).Value = txtEmail.Text;

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("A user exists with the same username or email", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql1 = "INSERT INTO users VALUES (NULL, @username, @password, @email)";

                MySqlConnection conn1 = DbContract.GetConnection();

                MySqlCommand cmd1 = new MySqlCommand(sql1, conn1);

                cmd1.CommandType = CommandType.Text;

                cmd1.Parameters.Add("@username", MySqlDbType.Text).Value = txtUsername.Text;
                cmd1.Parameters.Add("@password", MySqlDbType.Text).Value = txtPassword.Text;
                cmd1.Parameters.Add("@email", MySqlDbType.Text).Value = txtEmail.Text;

                try
                {
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("User Has been Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (MySqlException ex1)
                {
                    MessageBox.Show(ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn1.Close();

            }
            conn.Close();
        }

        private void btnSaveWorkDone_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Trim().Length < 1 || txtPassword.Text.Trim().Length < 1 || txtConfPassword.Text.Trim().Length < 1)
            {
                MessageBox.Show("Fields Cannot Be Empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text != txtConfPassword.Text )
            {
                MessageBox.Show("Password Must Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            insertUser();
            
        }

        private void Form_AddUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
