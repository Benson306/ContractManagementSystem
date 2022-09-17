using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagementSystem
{
    internal class Users
    {
        public string username { get; set; }
        public string password { get; set; }

        public Users(string Username, string Password)
        {
            username = Username;
            password = Password;
        }
    }

}
