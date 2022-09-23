using ContractManagementSystem.Classes;
using ContractManagementSystem.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractManagementSystem.UserControls
{
    public partial class UC_Dash : UserControl
    {
        public UC_Dash()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        string figure;


        public string getFigures(string sql)
        {

            MySqlConnection conn = DbContract.GetConnection();

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               figure = reader[0].ToString();
            }

            conn.Close();

            if (Convert.ToInt32(figure) < 10)
            {
                figure = "0" + figure;
            }

            return figure;
            
        }

        string userId, username, email, password;

        public void login(string usr)
        {
            string sql = "SELECT id, username, email, password FROM users WHERE username = @username";

            MySqlConnection conn = DbContract.GetConnection();

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@username", MySqlDbType.Text).Value = usr;

            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                userId = reader[0].ToString();
                username = reader[1].ToString();
                email = reader[2].ToString();
               password = reader[3].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form_EditUsers frm = new Form_EditUsers())
            {
                frm.userId = userId;
                frm.username = username;
                frm.email = email;
                frm.password = password;
                frm.ShowDialog();
            }
        }

        private void UC_Dash_Load(object sender, EventArgs e)
        {
            username = LoginInfo.userName;

            login(username);

            lblEmail.Text = email;
            lblUsername.Text = username;
            string new_password = "";
            if (password != null)
            {
                new_password = new string('*', password.ToString().Length);
            }

            lblPassword.Text = new_password;

            lblContracts.Text = getFigures("SELECT COUNT(*) FROM works;");
            lblCategories.Text = getFigures("SELECT COUNT(*) FROM work_types;");
            lblContractors.Text = getFigures("SELECT COUNT(*) FROM contractors");
            lblUnassignedContracts.Text = getFigures("SELECT COUNT(*) FROM works where work_assigned = 'NO';");
            findCategoriesFigures("SELECT wt.name as 'Work Category',COUNT(w.type_id) as 'Number of Contracts' FROM work_types as wt INNER JOIN works as w ON wt.id = w.type_id GROUP BY wt.name", dataGridView1);


        }
        public static void findCategoriesFigures(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = DbContract.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter dp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();
            dp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();

        }

    }
}
