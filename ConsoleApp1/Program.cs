using Batch37.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 for Display Full Time Employee");
            Console.WriteLine("2 for Display Part Time Employee");
            Console.WriteLine("3 for Add Full Time Employee");
            Console.WriteLine("4 for Add Part Time Employee");
            Console.WriteLine("0 for exit");

            Console.WriteLine("Enter your choice ..........");
            int ch = Convert.ToInt32(Console.ReadLine());
            
            switch(ch)
            {
                case 1:
                    EmployeeDataAccess data = new EmployeeDataAccess();
                    var empData=data.GetEmployes();
                    foreach (var item in empData)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", item.EmpID, item.FirstName, item.LastName, item.annualSalary);
                    }
                break;
            }

            Console.ReadKey();

        }
        
    }
}
