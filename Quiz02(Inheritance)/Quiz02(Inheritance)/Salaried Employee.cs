using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz02_Inheritance_
{
    class Salaried_Employee : Employee
    {
        double weeklySal;

        public Salaried_Employee(double wSal)
        {
            weeklySal = wSal;
        }

        public double earning()
        {
            double netSalary = weeklySal;
            return netSalary;
        }


    }
}
