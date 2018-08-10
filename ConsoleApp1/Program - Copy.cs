//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
    
    
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            PartTimeEmploy ObjPT = new PartTimeEmploy();
//            Fulltime ObjFT = new Fulltime();
//            while (true)
//            {

//                Console.Write("Enter Emplyee Type");
//                string type = Console.ReadLine();

//                if (type == "p")
//                {



//                    Console.WriteLine("Enter ID");
//                    String ID = Console.ReadLine();
//                    ObjPT.EmpID = Convert.ToInt32(ID);

//                    Console.WriteLine("Enter a First Name");
//                    ObjPT.FirstName = Console.ReadLine();
//                    Console.WriteLine("Enter a Last Name");
//                    ObjPT.LastName = Console.ReadLine();
//                    Console.WriteLine("Enter a HourlyWorked");
//                    String hoursWorkd = Console.ReadLine();
//                    ObjPT.hoursWorked = Convert.ToInt32(hoursWorkd);
//                    Console.WriteLine("Enter a HourlyRate");
//                    String hourlyRate = Console.ReadLine();
//                    ObjPT.hourlyRate = Convert.ToInt32(hourlyRate);
//                    ObjPT.TotalSalary = TotalSalary(ObjPT.hourlyRate, ObjPT.hoursWorked);


//                }
//                else
//                {
//                    Console.WriteLine("Enter ID");
//                    String ID = Console.ReadLine();
//                    ObjFT.EmpID = Convert.ToInt32(ID);

//                    Console.WriteLine("Enter a First Name");
//                    ObjFT.FirstName = Console.ReadLine();
//                    Console.WriteLine("Enter a Last Name");
//                    ObjFT.LastName = Console.ReadLine();
//                    Console.WriteLine("Enter a HourlyWorked");
//                    String hoursWorkd = Console.ReadLine();
//                    ObjPT.hoursWorked = Convert.ToInt32(hoursWorkd);
//                    Console.WriteLine("Enter a HourlyRate");
//                    String hourlyRate = Console.ReadLine();
//                    ObjPT.hourlyRate = Convert.ToInt32(hourlyRate);
//                }

//                PrintData(ObjFT);

//                PrintData(ObjPT);
//              //  Console.ReadKey();
//            }


//        }

//     public   static int TotalSalary(int rate, int hours)
//        {
//            return rate * hours;
//        }

//        static void PrintData(Object x)
//        {
//            if(x is Fulltime)
//            {
//                Fulltime obj = (Fulltime)x;
//                Console.WriteLine(obj.EmpID);
//                Console.WriteLine("Annual Salary={0}",obj.annualSalary);
//            }

//            if (x is PartTimeEmploy)
//            {
//                PartTimeEmploy obj = (PartTimeEmploy)x;
//                Console.WriteLine(obj.EmpID);
//                Console.WriteLine("Total Salary={0}", obj.TotalSalary);
//            }
//        }
        
//    } 
//     class ABC
//    {
//        private void method()
//        {
//            Program.TotalSalary(4, 6);
//        }
//    }
//}
