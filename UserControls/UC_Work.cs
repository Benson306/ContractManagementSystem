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
    public partial class UC_Work : UserControl
    {
        public UC_Work()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_AddWork wrk = new Form_AddWork();
            wrk.ShowDialog();
        }

        private void UC_Work_Load(object sender, EventArgs e)
        {
            DbContract.DisplayAndSearchWork("SELECT id, title, location, ts_number, ts_amount FROM works;", dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DbContract.DisplayAndSearchWork("SELECT id, title, location, ts_number, ts_amount FROM works WHERE title LIKE '%"+ txtSearch.Text + "%' OR location LIKE '%"+ txtSearch.Text + "%' OR ts_number LIKE '%"+ txtSearch.Text + "%' OR ts_amount LIKE '%"+ txtSearch.Text +"%';", dataGridView1);
        }
    }
}
