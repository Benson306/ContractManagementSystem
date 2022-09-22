using ContractManagementSystem.Classes;
using ContractManagementSystem.Forms;
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

namespace ContractManagementSystem.UserControls
{
    public partial class UC_Users : UserControl
    {
        public UC_Users()
        {
            InitializeComponent();
        }
        public void Display()
        {
            DbContract.DisplayAndSearchWork("SELECT id, username, email, password FROM users;", dataGridView1);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form_AddUsers user = new Form_AddUsers();
            user.ShowDialog();
        }

        private void UC_Users_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        public string userId, email, username, password;

        public void deleteUser()
        {
            string sql = "DELETE FROM users WHERE id = @id";
            MySqlConnection conn = DbContract.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = userId;

            DialogResult result = MessageBox.Show("Are you sure you want to Delete User?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if(result == DialogResult.Yes)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

            if (userId != null)
            {
                deleteUser();
                userId = null;
            }
            else
            {
                MessageBox.Show("Select a row to Continue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if(userId != null)
            {
                using(Form_EditUsers frm = new Form_EditUsers())
                {
                    frm.userId = userId;
                    frm.username = username;
                    frm.email = email;
                    frm.password = password;
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Select a row to Continue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow item in dataGridView1.SelectedRows)
            {
                userId = item.Cells[0].Value.ToString();
                username = item.Cells[1].Value.ToString();
                email = item.Cells[2].Value.ToString();
                password = item.Cells[3].Value.ToString();

            }
        }
    }
}
