namespace ContractManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Trim().Length < 1)
            {
                MessageBox.Show("Username cannot be empty");
                return;
            }
            if (txtPassword.Text.Trim().Length < 1)
            {
                MessageBox.Show("Password cannot be empty");
                return;
            }

            Users usr = new Users(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            DbContract.login(usr);
            clear();
        }
    }
}