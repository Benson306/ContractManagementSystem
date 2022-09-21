using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagementSystem.Classes
{
    internal class Contractor
    {
        public string full_name { get; set; }
        public string address { get; set; }

        public Contractor(string full_name, string address)
        {
            this.full_name = full_name;
            this.address = address;
        }
    }
}
