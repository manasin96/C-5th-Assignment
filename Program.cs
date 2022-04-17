using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingArrayList
{
    internal class MyArrayList
    {
        static void Main(string[] args)
        {

            /*duplicates are allowed,
             different datatypes are allowed withh non generic type,
             multiple null values are allowed,
             Index is present,
             Insertion order is preserved
             */
            int enterSize;
            Console.WriteLine("Enter total number of employees");
            enterSize = int.Parse(Console.ReadLine());
            ArrayList al = new ArrayList(enterSize);  //creating collection class arrayList
            int empId = 0;
            Console.WriteLine("Enter Admin UserID/UserName to view Total Employees' Details");
            String adminUserId = Console.ReadLine();
            String empName1 = "Pooja Sharma";
            String emp1Designation = "Analyst A4";
            //al.Add(empId);   //we can store different datatypes
            al.Add(empName1 + " : " + emp1Designation);
            //al.Add(emp1Designation);

            String empName2 = "Ravi Verma";
            String emp2Designation = "Sales Person";
            al.Add(empName2 + " : " + emp2Designation);
            //al.Add(emp2Designation);

            String empName3 = "Rudra Singh";
            String emp3Designation = "Senior Analyst";
            al.Add(empName3 + " : " + emp3Designation);
            //al.Add(emp3Designation);

            String empName4 = "Emily Gabriel";
            String emp4Designation = "Chief Head";
            al.Add(empName4 + " : " + emp4Designation);
            //al.Add(emp4Designation);

            String empName5 = "Sasha Sharma";
            String emp5Designation = "Analyst A4"; //we can store duplicates
            al.Add(empName5 + " : " + emp5Designation);
            //al.Add(emp5Designation);



            foreach (Object obj in al)
            {
                empId++;
                Console.WriteLine("Employee ID : {0} ", empId);

                Console.WriteLine(obj);

            }
            Console.ReadKey();
            ;
        }

    }
}
