using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContractManagementSystem.Classes;
using ContractManagementSystem.Forms;

namespace ContractManagementSystem.UserControls
{
    public partial class UC_Work : UserControl
    {
        Form_AddWork form;
        public UC_Work()
        {
            InitializeComponent();
            form = new Form_AddWork(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.ShowDialog();
        }

        public void Display()
        {
            DbContract.DisplayAndSearchWork("SELECT id, title, location, ts_number, ts_amount, work_assigned FROM works;", dataGridView1);
        }

        private void UC_Work_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DbContract.DisplayAndSearchWork("SELECT id, title, location, ts_number, ts_amount FROM works WHERE title LIKE '%"+ txtSearch.Text + "%' OR location LIKE '%"+ txtSearch.Text + "%' OR ts_number LIKE '%"+ txtSearch.Text + "%' OR ts_amount LIKE '%"+ txtSearch.Text +"%';", dataGridView1);
        }

        private string workId, title, ts_number, ts_amount;

        private void button2_Click(object sender, EventArgs e)
        {
            if(workId != null)
            {
                using(Assign_Work wrk = new Assign_Work())
                {
                    wrk.workId = workId;
                    wrk.title = title;
                    wrk.ts_amount = ts_amount;
                    wrk.ts_number = ts_number;
                    wrk.ShowDialog();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                workId = item.Cells[0].Value.ToString();
                title = item.Cells[1].Value.ToString();
                ts_amount = item.Cells[4].Value.ToString();
                ts_number = item.Cells[3].Value.ToString();
            }
        }
    }
}
