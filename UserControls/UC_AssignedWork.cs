using ContractManagementSystem.Classes;
using ContractManagementSystem.Forms;
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
    public partial class UC_AssignedWork : UserControl
    {
        public UC_AssignedWork()
        {
            InitializeComponent();
        }

        public void UC_AssignedWork_Load(object sender, EventArgs e)
        {
            DbContract.DisplayAndSearchWork("SELECT wa.id, w.title as 'Work Title', c.full_name as 'Contractor Name', wa.ca_cost as 'CA Cost', wa.assigned_date as 'Assigned Date', wa.year FROM work_assigned as wa INNER JOIN works as w ON wa.work_id = w.id INNER JOIN contractors as c ON wa.contractor_id = c.id WHERE w.work_assigned = 'Yes' AND wa.is_completed = 'NO'", dataGridView1);
        }
        string workAssignId,worktitle, contractorName, CACost;

        private void button1_Click(object sender, EventArgs e)
        {
            if(workAssignId != null)
            {
                using(Form_AddWorkDone wrk = new Form_AddWorkDone())
                {
                    wrk.workAssignId = workAssignId;
                    wrk.worktitle = worktitle;
                    wrk.contractorName = contractorName;
                    wrk.CAcost = CACost;
                    wrk.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow drv in dataGridView1.SelectedRows)
            {
                workAssignId = drv.Cells[0].Value.ToString();
                worktitle = drv.Cells[1].Value.ToString();
                contractorName = drv.Cells[2].Value.ToString();
                CACost = drv.Cells[3].Value.ToString();
            }
        }
    }
}
