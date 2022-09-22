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
    public partial class UC_Users : UserControl
    {
        public UC_Users()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form_AddUsers user = new Form_AddUsers();
            user.ShowDialog();
        }

        private void UC_Users_Load(object sender, EventArgs e)
        {
            DbContract.DisplayAndSearchWork("SELECT id, username, email, password FROM users;",dataGridView1);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }
    }
}
