using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagementSystem.Classes
{
    internal class DbContract
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=sql8.freemysqlhosting.net;port=3306;username=sql8521009;password=Q9gQ1Ha7Ak;database=sql8521009";
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
                Form1 frm = new Form1();
                frm.Hide();
                using (Dashboard ds = new Dashboard())
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
                MessageBox.Show("Work Has been Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student Not Added! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }

        public static void DisplayAndSearchWork(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter dp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();
            dp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();

        }

        public static void addContractor(Contractor ct)
        {
            string sql = "INSERT INTO contractors VALUES (NULL, @full_name, @address)";

            MySqlConnection conn = GetConnection();

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@full_name", MySqlDbType.Text).Value = ct.full_name;
            cmd.Parameters.Add("@address", MySqlDbType.Text).Value = ct.address;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contractor Has been Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void DisplayAndSearchContractor(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter dp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();
            dp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();
        }

        public static void DeleteContractor(string id)
        {
            string sql = "DELETE FROM contractors WHERE id = @id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contractor Deleted", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }



}
