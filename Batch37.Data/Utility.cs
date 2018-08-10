using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch37.Data
{
    public class Utility
    {
        public static string  GetConnectionString()
        {
            string conStr = @"Data Source=DESKTOP-74JJFSU\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True";
            return conStr;

        }
    }
}
