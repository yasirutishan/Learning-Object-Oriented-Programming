using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz02_Inheritance_
{
    class Employee
    {
        public void getValues()
        {

            Console.WriteLine("Enter the Employee ID : ");
            int empID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Employee Name : ");
            String empName = Console.ReadLine();

        }
        
    }
}
