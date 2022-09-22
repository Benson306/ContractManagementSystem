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

namespace ContractManagementSystem.Forms
{
    public partial class Form_EditUsers : Form
    {
        public string userId { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Form_EditUsers()
        {
            InitializeComponent();
        }

        private void Form_EditUsers_Load(object sender, EventArgs e)
        {
            txtEmail.Text = email;
            txtUsername.Text = username;
            txtPassword.Text = password;
            
        }

        private void btnCancelWorkDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void updateUser()
        {
            string sql1 = "SELECT * FROM users WHERE id != '"+ userId +"' AND username = @username";

            MySqlConnection conn1 = DbContract.GetConnection();

            MySqlCommand cmd1 = new MySqlCommand(sql1, conn1);

            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("@username", MySqlDbType.Text).Value = txtUsername.Text;

            MySqlDataReader reader = cmd1.ExecuteReader();



            string sql2 = "SELECT * FROM users WHERE id != '" + userId + "' AND email = @email";

            MySqlConnection conn2 = DbContract.GetConnection();

            MySqlCommand cmd2 = new MySqlCommand(sql2, conn2);

            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("@email", MySqlDbType.Text).Value = txtEmail.Text;

            MySqlDataReader reader2 = cmd2.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("A user already exists with the same username. Check Credentials", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(reader2.HasRows)
            {
                    MessageBox.Show("A user already exists with the same Email. Check Credentials", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                        string sql = "UPDATE users SET username = @username , email = @email, password = @password WHERE id = @id";

                        MySqlConnection conn = DbContract.GetConnection();

                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@username", MySqlDbType.Text).Value = txtUsername.Text;
                        cmd.Parameters.Add("@email", MySqlDbType.Text).Value = txtEmail.Text;
                        cmd.Parameters.Add("@password", MySqlDbType.Text).Value = txtPassword.Text;
                        cmd.Parameters.Add("@id", MySqlDbType.Text).Value = userId;

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("User Credential Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        conn.Close();
             }
            conn2.Close(); 
            conn1.Close();
        }
        
        private void btnSaveWorkDone_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.Trim().Length < 1 || txtPassword.Text.Trim().Length < 1 || txtUsername.Text.Trim().Length < 1)
            {
                MessageBox.Show("All fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            updateUser();
            userId = null;
        }
    }
}
