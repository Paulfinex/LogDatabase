using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDatabase
{
    public class Log
    {

        public int Number { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string User { get; set; }
        public string Source_IP { get; set; }
        public string Computer_name { get; set; }
        public string Connection_type { get; set; }
        public string Accessed_resources { get; set; }
        public string Action { get; set; }


        
    }
}
