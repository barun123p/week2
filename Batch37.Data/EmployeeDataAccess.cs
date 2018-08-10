using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Batch37.Data
{
   public class EmployeeDataAccess
    {
        public List<Fulltime> GetEmployes()
        {
            List<Fulltime> employees = new List<Fulltime>();

            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand("GetEmployee", conn);

            conn.Open();

            SqlDataReader rd = sqlCommand.ExecuteReader();

            while(rd.Read())
            {
                employees.Add(new Fulltime
                {
                   EmpID=rd.GetInt32(0),
                   FirstName=rd.GetString(1),
                   LastName=rd.GetString(2),
                   annualSalary=rd.GetInt32(3)
                });
            }
            

            return employees;

        }
    }
}
