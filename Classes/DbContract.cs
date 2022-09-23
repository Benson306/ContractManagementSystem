using Microsoft.VisualBasic.ApplicationServices;
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
                Form_Login frm = new Form_Login();
                frm.Hide();
                using (Form_Dashboard ds = new Form_Dashboard())
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
            string sql = "INSERT INTO works VALUES (NULL, @title, @location, @ts_number, @ts_amount, @work_assigned, @type_id)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@title", MySqlDbType.Text).Value = work.title;
            cmd.Parameters.Add("@location", MySqlDbType.Text).Value = work.location;
            cmd.Parameters.Add("@ts_number", MySqlDbType.Text).Value = work.ts_number;
            cmd.Parameters.Add("@ts_amount", MySqlDbType.Text).Value = work.ts_amount;
            cmd.Parameters.Add("@work_assigned", MySqlDbType.Text).Value = "No";
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
            conn.Close();
        }

        public static void AddWorkAssigned(WorkAssigned wrk)
        {
            string sql = "INSERT INTO work_assigned VALUES(NULL, @work_id, @contractor_id, @ca_cost, @assigned_date, @year, @is_completed)";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@work_id", MySqlDbType.VarChar).Value = wrk.work_id;
            cmd.Parameters.Add("@contractor_id", MySqlDbType.VarChar).Value = wrk.contractor_id;
            cmd.Parameters.Add("@ca_cost", MySqlDbType.VarChar).Value = wrk.ca_cost;
            cmd.Parameters.Add("@assigned_date", MySqlDbType.VarChar).Value = wrk.assigned_date;
            cmd.Parameters.Add("@year", MySqlDbType.VarChar).Value = wrk.year;
            cmd.Parameters.Add("@is_completed", MySqlDbType.VarChar).Value = "No";

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Work Has been assigned","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void editWork(string work_id)
        {
            string sql = "UPDATE works SET work_assigned = @work_assigned WHERE id = @work_id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@work_assigned", MySqlDbType.Text).Value = "Yes";
            cmd.Parameters.Add("@work_id", MySqlDbType.Text).Value = work_id;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        } 

        public static string GetWorkAssignedId()
        {
            string sql = "SELECT MAX(id) FROM work_assigned";

            MySqlConnection conn = GetConnection();

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
            catch(MySqlException ex)
            {
                id = "";
                MessageBox.Show(ex.Message);
            }
            return id;
            conn.Close();
        }
        public static void addCalculation(string work_assigned_id, string ca_cost)
        {
            string sql = "INSERT INTO calculations VALUES (NULL, @work_assigned_id, 0, 0, @ca_cost, 0)";
            MySqlConnection conn = GetConnection();

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@work_assigned_id", MySqlDbType.Text).Value = work_assigned_id;
            cmd.Parameters.Add("@ca_cost", MySqlDbType.Text).Value = ca_cost;

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

    }



}
