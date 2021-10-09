using System;

namespace Quiz02_Inheritance_
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Enter your Weekly Salary : ");
                double weekSal = Double.Parse(Console.ReadLine());

            Salaried_Employee salE = new Salaried_Employee(weekSal);        //Salaried Employee
            salE.getValues();
            Console.WriteLine("Salaried Employee - Net Salary : " + salE.earning());


                Console.WriteLine("Enter the working hours : ");
                double hour = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Wage per day  : ");
                double wage = Double.Parse(Console.ReadLine());

            Hourly_Employee hourE = new Hourly_Employee(hour, wage);        //Hourly Employee
            hourE.getValues();
            Console.WriteLine("Hourly Employee - Net Salary : " + hourE.earning());


                Console.WriteLine("Enter the Commission Rate : ");
                double comRate = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Gross Sales : ");
                double grossSal = Double.Parse(Console.ReadLine());

            Commision_Employee comE = new Commision_Employee(comRate, grossSal);           //Commission Employee
            comE.getValues();
            Console.WriteLine("Commission Employee - Net Salary : " + comE.earning());

                
                Console.WriteLine("Enter the Basic Salary : ");
                double basSal = Double.Parse(Console.ReadLine());

                BasePlusComission_Employee baseCE = new BasePlusComission_Employee(basSal,comRate,grossSal);       //BasePlus Commission Employee
                baseCE.getValues();
                Console.WriteLine("BasePlus Commission Employee - Net Salary : " + baseCE.earning());

            Console.ReadKey();
        }
          

        }
    
}
