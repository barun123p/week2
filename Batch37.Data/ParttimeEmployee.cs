using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch37.Data
{
     public class PartTimeEmploy: Employee
    {
        public int hoursWorked { get; set;}
        public int hourlyRate { get; set; }
        public int TotalSalary { get; set; }
    }

}


