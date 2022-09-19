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
                LoginInfo.userName = usr.username;
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
        public static void addWork(Work work)
        {
            string sql = "INSERT INTO works VALUES (NULL, @title, @location, @ts_number, @ts_amount, @type_id)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@title", MySqlDbType.Text).Value = work.title;
            cmd.Parameters.Add("@location", MySqlDbType.Text).Value = work.location;
            cmd.Parameters.Add("@ts_number", MySqlDbType.Text).Value = work.ts_number;
            cmd.Parameters.Add("@ts_amount", MySqlDbType.Text).Value = work.ts_amount;
            cmd.Parameters.Add("@type_id", MySqlDbType.Text).Value = work.type_id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Work Has benn Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student Not Added! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }

    }
    

    
}
