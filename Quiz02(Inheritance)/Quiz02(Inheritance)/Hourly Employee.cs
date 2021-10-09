using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz02_Inheritance_
{
    class Hourly_Employee : Employee
    {
        double hours;
        double wage;

        public Hourly_Employee(double h , double w)
        {
            hours = h;
            wage = w;
        }

        public double earning()
        {
            if (hours <= 40)
            {
                double netSal = wage * hours;
                return netSal;
            }
            else
            {
                double netSal = 40 * wage + (hours - 40) * wage * 1.5;
                return netSal;
            }
            
        }
    }
}
