using ContractManagementSystem.Classes;
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
    }
}
