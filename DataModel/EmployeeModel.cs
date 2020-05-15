using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
   public class EmployeeModel
    {
        public int Uid { get; set; }
        public int EmployeeId { get; set; }
        public int Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Role { get; set; }
    }
}
