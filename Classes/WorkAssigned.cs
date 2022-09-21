using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagementSystem.Classes
{
    internal class WorkAssigned
    {
        public string work_id { get; set; }
        public string contractor_id { get; set; }
        public string ca_cost { get; set; }
        public string assigned_date { get; set; }
        public string year { get; set; }

        public WorkAssigned(string work_id, string contractor_id, string ca_cost, string assigned_date, string year)
        {
            this.work_id = work_id;
            this.contractor_id = contractor_id;
            this.ca_cost = ca_cost;
            this.assigned_date = assigned_date;
            this.year = year;
        }
    }
}
