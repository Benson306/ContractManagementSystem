using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagementSystem
{
    internal class DbContract
    {
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
                MessageBox.Show(ex.Message , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            return conn;
        }
        public static void login(Users usr)
        {
            string sql = "SELECT * FROM users WHERE username = @username AND password = @password";

            MySqlConnection conn = GetConnection();

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@username", MySqlDbType.Text).Value = usr.username;
            cmd.Parameters.Add("@password", MySqlDbType.Text).Value = usr.password;

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                using(Dashboard ds = new Dashboard())
                {
                    ds.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Access Denied. Check Credentials", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

    }
    

    
}
