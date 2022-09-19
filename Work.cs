using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractManagementSystem
{
    internal class Work
    {
        public string title { get; set; }
        public string location { get; set; }
        public string ts_number { get; set; }
        public string ts_amount { get; set; }

        public int type_id { get; set; }

        public Work(string title, string location, string ts_number, string ts_amount, int type_id)
        {
            this.title = title;
            this.location = location;
            this.ts_number = ts_number;
            this.ts_amount = ts_amount;
            this.type_id = type_id;
        }
    }
}
